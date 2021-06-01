using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro
{
    public class MetroTest
    {
        public const int testNumber = 7;
        public int testCounter = 0;

        public void Run()
        {
            // Подготовка к тестированию
            MetroData.StationList.Clear();
            MetroData.TimeTable.Clear();

            // Инициализация
            List<(string, int)> rushHourTable = new List<(string, int)>() 
            {
                ("07:00", 160), 
                ("17:00", 160)
            };

            const int max = 100;
            const int min = 50;

            Station station1 = new Station();
            station1.StationName = "station1";
            station1.StationLine = "line1";
            station1.Maximum = max;
            station1.Minimum = min;
            station1.RushHourTable.AddRange(rushHourTable);

            SubwayStation subwayStation1 = new SubwayStation(station1);
            subwayStation1.StationName = "subwayStation1";
            subwayStation1.StationLine = "line1";
            subwayStation1.MateStationName = "subwayStation2";
            subwayStation1.RushHourTable.Clear();

            SubwayStation subwayStation2 = new SubwayStation(station1);
            subwayStation2.StationName = "subwayStation2";
            subwayStation2.StationLine = "line2";
            subwayStation2.MateStationName = "subwayStation1";
            subwayStation2.RushHourTable.Clear();

            List<Station> stationList = new List<Station>() { subwayStation1, subwayStation2 };
            MetroData.StationList.AddRange(stationList);

            List<(string, TimeSpan)> timeTable = new List<(string, TimeSpan)>()
            {
                ("06:00", new TimeSpan(0, 10, 00)),
                ("07:00", new TimeSpan(0, 10, 00)),
                ("08:00", new TimeSpan(0, 10, 00)),
                ("09:00", new TimeSpan(0, 10, 00)),
                ("10:00", new TimeSpan(0, 10, 00))
            };
            MetroData.TimeTable.AddRange(timeTable);

            DateTime startTime = new DateTime(2020, 11, 10, 0, 0, 0);
            DateTime finishTime = new DateTime(2020, 11, 11, 0, 0, 0);
            DateTime currentTime = new DateTime(2020, 11, 11, 9, 0, 0);
            int currentHour = currentTime.Hour;

            Metro metro = new Metro(stationList);
            Simulation simulation = new Simulation(startTime, finishTime, metro);

            // Тест методов Station

            // №1 Ближайший час пик (07:00) в 09:00 был 2 часа назад
            if (station1.Offset(currentHour) == DateTime.Parse(rushHourTable[0].Item1).Hour - currentHour)
            {
                testCounter++;
            }
            else 
            {
                throw new Exception("Тестирование провалено: Offset error");
            }

            // №2 Нагрузка в ближайший час пик составляла 160% - 100% = 60%
            if (station1.CurrentStress(currentHour + station1.Offset(currentHour)) == rushHourTable[0].Item2 - 100)
            {
                testCounter++;
            }
            else
            {
                throw new Exception("Тестирование провалено: CurrentStress error");
            }

            // №3 Число людей в 09:00 от min = 50 * (100 + 60 / 2^2) = 57 до max = 100 
            if (station1.GetNumberOfPeople(currentHour) < (min * (rushHourTable[0].Item2 / Math.Pow(2, Math.Abs(station1.Offset(currentHour))))) && station1.GetNumberOfPeople(currentHour) > max)
            {
                throw new Exception("Тестирование провалено: GetNumberOfPeople error");
            }
            else
            {
                testCounter++;
            }

            // Тест методов SubwayStation

            // №4 Число людей в 09:00 на переходной станции от min = 50 до max * 2 = 200 
            if (subwayStation1.GetNumberOfPeople(currentHour) < min && subwayStation1.GetNumberOfPeople(currentHour) > max * 2)
            {
                throw new Exception("Тестирование провалено: GetNumberOfPeople error");
            }
            else
            {
                testCounter++;
            }

            // №5 Название переходной станции subwayStation1 есть subwayStation2
            if (subwayStation1.GetMate(subwayStation2.StationName).StationName == subwayStation2.StationName)
            {
                testCounter++;
            }
            else
            {
                throw new Exception("Тестирование провалено: GetMate error");
            }

            // Тест методов Metro

            // №6 Должно осуществится 2 поездки (число станций 2)
            // Текущее время должно сдвинуться по расписанию (на 10 минут)
            // Метрики количества людей аналогичные (с учётом что станций 2)
            MetroData.StartTime = startTime;
            MetroData.FinishTime = finishTime;
            MetroData.TransportationCount = 0;
            MetroData.TotalNumberOfPeople = 0;
            MetroData.PeopleStats.Clear();

            metro.Run(currentTime);
            if (metro.CurrentTime == currentTime + timeTable[3].Item2 &&
                MetroData.TotalNumberOfPeople >= min * 2 && MetroData.TotalNumberOfPeople <= max * 4 &&
                MetroData.TransportationCount == stationList.Count &&
                MetroData.PeopleStats[currentTime.Date.AddHours(currentHour)] >= min * 2 && MetroData.PeopleStats[currentTime.Date.AddHours(currentHour)] <= max * 4)
            {
                testCounter++;
            }
            else
            {
                throw new Exception("Тестирование провалено: Metro.Run error");
            }

            // Тест методов Simulation

            // №7 Все метрики вычисляются аналогично, но с условием, что интервал моделирования = 5 часов, поездок в час = 6
            simulation.Run();
            if(simulation.CurrentTime == finishTime &&
               MetroData.TotalNumberOfPeople >= min * 60 && MetroData.TotalNumberOfPeople <= max * 120 &&
               MetroData.TransportationCount == stationList.Count * 30)
            {
                testCounter++;
            }
            else
            {
                throw new Exception("Тестирование провалено: Simulation.Run error");
            }

            // Очистка результатов работы
            MetroData.StationList.Clear();
            MetroData.TimeTable.Clear();
        }
    }
}
