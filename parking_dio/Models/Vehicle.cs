using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parking_dio.Models
{
    public class Vehicle
    {
        public string LicensePlate { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime DepartureTime { get; set; }

        public Vehicle(string licensePlate)
        {
            LicensePlate = licensePlate;
            EntryTime = DateTime.Now;
        }


       
    }
}
