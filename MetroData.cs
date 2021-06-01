using System;
using System.Linq;
using System.Collections.Generic;


namespace Metro
{
    public static class MetroData
    {
        // Накапливаемая статистика
        private static long totalNumberOfPeople;
        private static int transportationCount;

        // Данные для построения графиков
        private static Dictionary<DateTime, long> peopleStats = new Dictionary<DateTime, long>();
        
        // Входные данные
        private static DateTime startTime = new DateTime();
        private static DateTime finishTime = new DateTime();
        private static List<Station> stationList = new List<Station>();
        private static List<(string, TimeSpan)> timeTable = new List<(string, TimeSpan)>();

        private static TimeSpan tempTimeSpan = new TimeSpan();

        public static long TotalNumberOfPeople
        {
            set 
            {
                if (value >= 0)
                {
                    totalNumberOfPeople = value;
                }
                else
                {
                    throw new Exception("Базе данных было передано некорректное\nзначение колличества людей");
                }
            }
            get { return totalNumberOfPeople; }
        }

        public static int TransportationCount
        {
            set
            {
                if (value >= 0)
                {
                    transportationCount = value;
                }
                else
                {
                    throw new Exception("Базе данных было передано некорректное\nзначение колличества поездок");
                }
            }
            get { return transportationCount; }
        }

        public static Dictionary<DateTime, long> PeopleStats
        {
            set
            {
                if (value.Count >= 0)
                {
                    peopleStats = value;
                }
                else
                {
                    throw new Exception("Базе данных была передана некорректная\nстатистика перевозки людей");
                }
            }
            get { return peopleStats; }
        }

        public static DateTime StartTime
        {
            set { startTime = value; }
            get { return startTime; }
        }

        public static DateTime FinishTime
        {
            set
            {
                if (value > startTime)
                {
                    finishTime = value;
                }
                else
                {
                    throw new Exception("Некорректно указан интервал моделирования");
                }
            }
            get { return finishTime; }
        }

        public static List<Station> StationList
        {
            set
            {
                if (value.Count > 0)
                {
                    stationList = value;
                }
                else
                {
                    throw new Exception("Базе данных был передан пустой список станций");
                }
            }
            get { return stationList; }
        }

        public static List<(string, TimeSpan)> TimeTable
        {
            set
            {
                if (value.Count != 0 && value.All(hour => TimeSpan.TryParse("00:" + hour.Item1, out tempTimeSpan) || tempTimeSpan.TotalSeconds == 0))
                {
                    timeTable = value;
                }
                else
                {
                    throw new Exception("Базе данных было передано некорректное расписание");
                }
            }
            get { return timeTable; }
        }

        // Обновление данных после десериализации
        public static void Update(MetroDataSerializable data)
        {
            totalNumberOfPeople = data.totalNumberOfPeople;
            transportationCount = data.transportationCount;
            startTime = data.startTime;
            finishTime = data.finishTime;
            stationList = data.stationList;
            timeTable = data.timeTable;
        }
    }
}
