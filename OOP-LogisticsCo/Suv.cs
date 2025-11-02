namespace LogisticsCo
{
    public class Suv : Car
{
    bool HasKidsChair {get; set;} = true;
    private string NurseryRhyme {get; set;} = "The wheels in the car go round round round...";

        public Suv (int numberOfWheels, int weightKg, int passengerCapacity, string brand, string model, int fabYear, string color, string fuelType, int numberOfDoors, string carSound, string nurseryRhyme, bool hasKidsChair) : base(numberOfWheels, weightKg, passengerCapacity, brand, model, fabYear, color, fuelType, numberOfDoors, carSound)
    {
        // Assign properties for SUV
        FuelType = "Electric";
        PassengerCapacity = 7;
        HasKidsChair = hasKidsChair;
        CarSound = "prop prop prop";

        // SUV own properties
        NumberOfDoors = numberOfDoors;
        NurseryRhyme = nurseryRhyme;
    }

        // Override startEngine method for SUV
    public override void StartEngine()
    {
        Console.WriteLine($"The SUV is running and sounds {CarSound}.");
    }
    // Own method for SUV
    public virtual void PlayNurseryRhymes(string NurseryRhyme)
    {
        Console.WriteLine($"The SUV plays inside a nursery rhyme that says: {NurseryRhyme}, and the driver \"loves\" it...");
    }
}
}