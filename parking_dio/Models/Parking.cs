namespace parking_dio.Models
{
    public class Parking
    {
        public decimal PriceStart { get; set; }
        public decimal PricePerHour { get; set; }
        public int NumberOfVacancies { get; private set; }
        public Dictionary<string, Vehicle> Vehicles { get; set; }
        public List<Vehicle> VehiclesRemoved { get; set; }

        public Parking(decimal priceStart, decimal pricePerHour, int numberOfVacancies)
        {
            PriceStart = priceStart;
            PricePerHour = pricePerHour;
            NumberOfVacancies = numberOfVacancies;
            Vehicles = new Dictionary<string, Vehicle>();
            VehiclesRemoved = new List<Vehicle>();
        }

        public bool IsNotFull => NumberOfVacancies > Vehicles.Count;
        public decimal TotalToPay(Vehicle vehicle)
        {
            decimal pricePerMinute = (PricePerHour / 60);
            int timeStart = (vehicle.EntryTime.Hour * 60) + vehicle.EntryTime.Minute;
            int timeEnd = (DateTime.Now.Hour * 60) + DateTime.Now.Minute;
            int totalTime = timeEnd - timeStart;
            return PriceStart + (pricePerMinute * totalTime);
        }
    }
}
