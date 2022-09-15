using System.Globalization;

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

        public override string ToString()
        {
            return $"Placa:{LicensePlate}, Entrada: {EntryTime.ToString("h:mm",CultureInfo.InvariantCulture)}";
        }



    }
}
