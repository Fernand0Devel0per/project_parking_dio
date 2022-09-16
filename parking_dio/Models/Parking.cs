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
            return PriceStart + ((PricePerHour / 60) * (((vehicle.EntryTime.Hour * 60) + vehicle.EntryTime.Minute) - (DateTime.Now.Hour * 60) + DateTime.Now.Minute));
        }
    }
}
