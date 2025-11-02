namespace LogisticsCo
{
    public class Car : Vehicle
{
    // Car own properties
    protected int NumberOfDoors { get; set; }
    protected string CarSound {get; set;} = "prop prop prop";


    public Car (int numberOfWheels, int weightKg, int passengerCapacity, string brand, string model, int fabYear, string color, string fuelType, int numberOfDoors, string carSound)
     : base(numberOfWheels, weightKg, passengerCapacity, brand, model, fabYear, color, fuelType)
    {
        // Assigning Car's properties
        NumberOfDoors = numberOfDoors;
        CarSound = carSound;
    }

    // Override startEngine method for car
    public override void StartEngine()
    {
        Console.WriteLine($"The car is running and sounds {CarSound}.");
    }
    
    // Own method for car - This method will be passed to Suv and Cabriolet
    public virtual void JumpIn(int passengerCapacity, int numberOfDoors)
    {
        Console.WriteLine($"The {Brand}-{Model} drives {PassengerCapacity} passengers and it has {NumberOfDoors} doors.");
    }

}
}