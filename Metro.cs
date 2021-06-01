using System;
using System.Collections.Generic;
using System.Linq;

namespace Metro
{
    class Metro
    {
        private DateTime currentTime = new DateTime();
        private int currentHour;

        // Список станциий метро
        private List<Station> stationList = new List<Station>();

        public DateTime CurrentTime
        {
            get { return currentTime; }
        }

        public Metro(List<Station> stationList)
        {
            if (stationList.Count == 0)
            {
                throw new Exception("Список станций пуст");
            }
            else
            {
                this.stationList = stationList;
            }
        }

        // Осуществляет одну транспортировку на всех станциях, сдвиг по времени и заполнение базы данных
        public void Run(DateTime currentTime)
        {
            currentHour = currentTime.Hour;

            // Если есть расписание движения для текущего времени
            if (MetroData.TimeTable.Any(time => DateTime.Parse(time.Item1).Hour == currentHour))
            {
                foreach (Station station in stationList)
                {
                    // Если в статистике уже есть текущее время (час)
                    if (MetroData.PeopleStats.Any(time => time.Key.Date.AddHours(time.Key.Hour) == currentTime.Date.AddHours(currentHour)))
                    {
                        MetroData.PeopleStats[currentTime.Date.AddHours(currentHour)] += station.GetNumberOfPeople(currentHour);
                    }
                    else 
                    {
                        MetroData.PeopleStats.Add(currentTime.Date.AddHours(currentHour), station.GetNumberOfPeople(currentHour));
                    }
                    MetroData.TransportationCount++;
                    MetroData.TotalNumberOfPeople += station.NumberOfPeople;
                }
                // Сдвиг времени по рапсисанию
                currentTime += MetroData.TimeTable.DefaultIfEmpty().First(time => DateTime.Parse(time.Item1).Hour == currentHour).Item2;
            }
            else
            {
                // Иначе пропуск текущего часа
                currentTime += currentTime.Date.AddHours(currentHour + 1).Subtract(currentTime);
            }
            this.currentTime = currentTime;
        }
    }
}
