using System;
using System.Collections.Generic;
using System.Linq;

namespace Metro
{
    [Serializable]
    public class Station
    {
        protected string stationLine;
        protected string stationName;

        protected int maximum;
        protected int minimum;

        // Таблица часов пика
        protected List<(string, int)> rushHourTable = new List<(string, int)>();
        
        // Временная переменная используемая для валидации таблицы часов пика
        protected TimeSpan tempTimeSpan = new TimeSpan();

        protected long numberOfPeople;
        protected Random random = new Random();

        public string StationName
        {
            set
            {
                if (value is string)
                {
                    stationName = value;
                }
                else
                {
                    throw new Exception("Станции было передано некорректное имя");
                }
            }
            get { return stationName; }
        }

        public string StationLine
        {
            set
            {
                if (value is string)
                {
                    stationLine = value;
                }
                else
                {
                    throw new Exception("Станции было передано некорректное название линии");
                }
            }
            get { return stationLine; }
        }

        public int Maximum
        {
            set
            {
                if (value >= 0 && value >= minimum)
                {
                    maximum = value;
                }
                else 
                {
                    throw new Exception("Станции было передано некорректное значение максимума");
                }
            }
            get { return maximum; }
        }

        public int Minimum
        {
            set
            {
                if (value >= 0 && value <= maximum)
                {
                    minimum = value;
                }
                else
                {
                    throw new Exception("Станции было передано некорректное значение максимума");
                }
            }
            get { return minimum; }
        }

        public List<(string, int)> RushHourTable
        {
            set
            {
                if (value.All(hour => TimeSpan.TryParse("00:" + hour.Item1, out tempTimeSpan) || tempTimeSpan.TotalSeconds == 0))
                {
                    rushHourTable = value;
                }
                else 
                {
                    throw new Exception("Станции была передана некорреткная таблица часов пика");
                }
            }
            get { return rushHourTable; }
        }

        public long NumberOfPeople
        {
            get { return numberOfPeople; }
        }

        // Конструктор станции-шаблона
        public Station()
        {
            stationLine = "Линия";
            stationName = "Название";
        }

        // Конструктор, использующийся при замене SubwaySttaion на Station
        public Station(SubwayStation station)
        {
            StationName = station.StationName;
            StationLine = station.StationLine;
            Maximum = station.Maximum;
            Minimum = station.Minimum;
            RushHourTable.Clear();
            RushHourTable.AddRange(station.RushHourTable);
        }

        // Возвращает разницу в часах до ближайшего часа-пик
        public virtual int Offset(int currentHour)
        {
            List<int> diff = new List<int>();
            foreach (var hour in rushHourTable)
            {
                diff.Add(DateTime.Parse(hour.Item1).Hour - currentHour);
            }
            if (diff.Count == 0)
            {
                return 0;
            }
            else
            {
                diff = diff.OrderBy(d => Math.Abs(d)).ToList();
                return diff.First();
            }
        }

        // Возвращает нагрузку в % в ближайший час-пик
        public virtual int CurrentStress(int currentHour)
        {
            if (rushHourTable.Any(hour => DateTime.Parse(hour.Item1).Hour == currentHour))
            {
                return rushHourTable.FirstOrDefault(hour => DateTime.Parse(hour.Item1).Hour == currentHour).Item2 - 100;
            }
            else
            {
                return 0;
            }
        }

        // Возвращает количество людей, зашедших в поезд
        public virtual long GetNumberOfPeople(int currentHour)
        {
            numberOfPeople = random.Next(minimum, maximum + 1) * (CurrentStress(currentHour + Offset(currentHour)) / (long)Math.Pow(2, Math.Abs(Offset(currentHour))) + 100) / 100; // + 1 так как верхняя граница не включается

            if (numberOfPeople > maximum)
            {
                return maximum;
            }
            else
            {
                return numberOfPeople;
            }
        }
    }
}
