namespace parking_dio.Models
{
    public class Parking
    {
        public decimal PriceStart { get; set; }
        public decimal PricePerHour { get; set; }
        public int NumberOfVacancies { get; private set; }
        public Dictionary<string, Vehicle> Vehicles { get; set; }

        public Parking(decimal priceStart, decimal pricePerHour, int numberOfVacancies)
        {
            PriceStart = priceStart;
            PricePerHour = pricePerHour;
            NumberOfVacancies = numberOfVacancies;
            Vehicles = new Dictionary<string, Vehicle>();
        }

        public bool IsNotFull => NumberOfVacancies >= Vehicles.Count;
    }
}
