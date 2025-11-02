namespace LogisticsCo
{
    public class Vehicle
    {
        // Physical props
        protected int NumberOfWheels { get; set; } // protected remains private but it is transferable to children
        protected int WeightKg { get; set; }
        protected int PassengerCapacity { get; set; }
        // Identification props
        protected string  Brand { get; set; }
        protected string Model { get; set; }
        protected int FabYear { get; set; }
        protected string Color { get; set; }
        protected string FuelType { get; set; }
        // State props
        protected bool IsWorking { get; set; } = true;
        protected bool IsService { get; set; }= false;

        // Vehicle constructor
        public Vehicle(int numberOfWheels, int weightKg, int passengerCapacity, string brand, string model, int fabYear, string color, string fuelType)
        {
            NumberOfWheels = numberOfWheels;
            WeightKg = weightKg;
            PassengerCapacity = passengerCapacity;
            Brand = brand;
            Model = model;
            FabYear = fabYear;
            Color = color;
            FuelType = fuelType;
        }
        // Vehicle methods
        // Method1 required in US7
        public virtual void StartEngine()
        {
            Console.WriteLine($"Engine starting...");
        }
        // Method2 required in US7
        public virtual void RunVehicle()
        {
            Console.WriteLine($"The {Brand}-{Model} is running!");
        }
        // Method3 required in US7
        public virtual void StopVehicle()
        {
            Console.WriteLine($"The {Brand}-{Model} stopped!");
        }
    }
}