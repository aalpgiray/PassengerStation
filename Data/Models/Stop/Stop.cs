using System;
using System.Data.Entity.Spatial;

namespace PassengerStation.Data
{
    public class Stop : Base
    {
        public Route Route { get; set; }
        public StopType StopType { get; set; }
        public DbGeography Geography { get; set; }
    }
}
