using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parking_dio.Models
{
    public class Parking
    {
        public decimal PriceStart { get; set; }
        public decimal PricePerHour { get; set; }
        public int NumberOfVacancies { get; private set; }
        public Dictionary<string, Vehicle> Vehicle { get; set; }

        public Parking(decimal priceStart, decimal pricePerHour, int numberOfVacancies)
        {
            PriceStart = priceStart;
            PricePerHour = pricePerHour;
            NumberOfVacancies = numberOfVacancies;
        }
    }
}
