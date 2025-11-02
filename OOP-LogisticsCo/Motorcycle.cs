namespace LogisticsCo
{
    public class Motorcycle : Vehicle
    {
        public bool HasPassenger { get; set;}

        // Motorcycle constructor
        public Motorcycle(int numberOfWheels, int weightKg, int passengerCapacity, string brand, string model, int fabYear, string color, string fuelType, bool hasPassenger) : base(numberOfWheels, weightKg, passengerCapacity, brand, model, fabYear, color, fuelType)
        {
            HasPassenger = hasPassenger;
        }

        // Method from Vehicle
        public override void StartEngine()
        {
            Console.WriteLine($"MC {Brand}-{Model}: Vrooom vrooom!");
        }

        // MC own method
        public void ParkHere()
        {
            Console.WriteLine($"Motorcycle parked and secured!");
        }
    }
}