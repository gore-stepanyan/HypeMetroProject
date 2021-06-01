using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Metro
{
    [DataContract]
    public class MetroDataSerializable
    {
        // Накапливаемая статистика
        [DataMember] public long totalNumberOfPeople = MetroData.TotalNumberOfPeople;
        [DataMember] public int transportationCount = MetroData.TransportationCount;

        [DataMember] public DateTime startTime = MetroData.StartTime;
        [DataMember] public DateTime finishTime = MetroData.FinishTime;
        [DataMember] public List<Station> stationList = MetroData.StationList;
        [DataMember] public List<(string, TimeSpan)> timeTable = MetroData.TimeTable;

    }
}
