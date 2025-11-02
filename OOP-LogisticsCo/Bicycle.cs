namespace LogisticsCo
{
    public class Bicycle : Vehicle
    {
        // Bicycle own property
        public int NumberOfGears {get;set;} = 21;
        // Count for the gear
        public int CurrentGear {get;set;} = 11;

        // Bicycle constructor
        public Bicycle(int numberOfWheels, int weightKg, int passengerCapacity, string brand, string model, int fabYear, string color, int numberOfGears, int currentGear) : base(numberOfWheels, weightKg, passengerCapacity, brand, model, fabYear, color, "Human Power")
        {
            // Assigning Bicycle's own properties
            NumberOfGears = numberOfGears;
            CurrentGear = currentGear;
        }

        // Heritated method from Vehicle
        public override void StartEngine()
        {
            System.Console.WriteLine($"🔔 Ring ring! {Brand} {Model} ready to pedal!");
        }

        // Bicycle's own methods
        public void ShiftUp()
        {
            CurrentGear += 1;
            System.Console.WriteLine("⬆️ Shifting up a gear! You are riding on {CurrentGear} gear");
        }
        public void ShiftDown()
        {
            CurrentGear -= 1;
            System.Console.WriteLine("⬇️ Shifting down a gear! You are riding on {CurrentGear} gear");
        }
    }
}