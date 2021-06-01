using System;
using System.Linq;

namespace Metro
{
    [Serializable]
    public class SubwayStation : Station
    {
        // Имя станции, на которую осуществляется переход
        protected string mateStationName;

        // Конструктор, используемый, для замены Station на SubwayStation
        public SubwayStation(Station station)
        {
            StationName = station.StationName;
            StationLine = station.StationLine;
            Maximum = station.Maximum;
            Minimum = station.Minimum;
            RushHourTable.Clear();
            RushHourTable.AddRange(station.RushHourTable);
        }

        public string MateStationName
        {
            set
            {
                if (value is string)
                {
                    mateStationName = value;
                }
                else 
                {
                    throw new Exception("Станции было передано некорректное имя переходной станции");
                }
            }
            get { return mateStationName; }
        }

        // Возвращает станцию, на которую осуществляется переход
        public SubwayStation GetMate(string mateStationName)
        {
            if (MetroData.StationList.FirstOrDefault(subwayStation => subwayStation.StationName == mateStationName) is SubwayStation)
            {
                return (SubwayStation)MetroData.StationList.First(s => s.StationName == mateStationName);
            }
            else
            {
                throw new Exception("Станции было передано некорректное имя переходной станции");
            }
        }

        // Возвращает число людей, зашедших в поезд, с учётом числа людей, сгенерированного на переходной станции
        public override long GetNumberOfPeople(int currentHour)
        {
            if (MetroData.StationList.FirstOrDefault(subwayStation => subwayStation.StationName == mateStationName) is SubwayStation)
            {
                numberOfPeople = random.Next(minimum, maximum + 1) * (CurrentStress(currentHour + Offset(currentHour)) / (long)Math.Pow(2, Math.Abs(Offset(currentHour))) + 100) / 100 // + 1 так как верхняя граница не включается
                + GetMate(mateStationName).numberOfPeople / 2;
                return numberOfPeople;
            }
            else
            {
                throw new Exception("Станции было передано некорректное имя переходной станции");
            }
        }
    }
}
