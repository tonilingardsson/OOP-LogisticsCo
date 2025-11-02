namespace LogisticsCo
{
public class Cabriolet : Car
{
    protected bool RoofOpen{get; set;}= false;
    // protected int PassengerCapacity {get; set;}= 2;
    protected int numberOfDoors {get; set;}= 2;
    // protected string CarSound {get; set;} = "freuw freuw freuw";
    

    public Cabriolet (int numberOfWheels, int weightKg, int passengerCapacity, string brand, string model, int fabYear, string color, string fuelType, int numberOfDoors, bool roofOpen, string carSound) : base(numberOfWheels, weightKg, passengerCapacity, brand, model, fabYear, color, fuelType, numberOfDoors, carSound)
    {
        // Assign properties for Cabriolet
        FuelType = "Fuel";
        PassengerCapacity = 2;
        CarSound = "freuw freuw freuw";
       
        // Cabriolet own properties
        NumberOfDoors = numberOfDoors;
        RoofOpen = roofOpen;
    }

        // Override startEngine method for cabriolet
    public override void StartEngine()
    {
        Console.WriteLine($"The cabriolet is running and sounds {CarSound}.");
    }
    // Own method for Cabriolet
    public bool OpenRoof(bool RoofOpen)
    {
        Console.WriteLine($"The cabriolet has now open roof.");
        RoofOpen = true;
        return RoofOpen;
    }
}
}