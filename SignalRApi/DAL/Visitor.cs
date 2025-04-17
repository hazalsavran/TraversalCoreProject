using System;

namespace SignalRApi.DAL
{
    public enum ECity {         
        NewYork = 1,
        LosAngeles =2,
        Chicago = 3,
        Houston = 4,
        Phoenix = 5
    }
    public class Visitor
    {
        public int VisitorID { get; set; }
        public ECity City { get; set; }
        public int CityVisitCount { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
