namespace LogisticsCo
{
public class Truck : Vehicle
{
    protected int NumberOfDoors { get; set; } = 2;
    protected string TruckSound { get; set; }= "brum brum brum";
    protected int CargoCapacityKg { get; set; } = 5001;

    public Truck (int numberOfWheels, int weightKg, int passengerCapacity, string brand, string model, int fabYear, string color, string fuelType, int numberOfDoors, int cargoCapacityKg, string truckSound) : base(numberOfWheels, weightKg, passengerCapacity, brand, model, fabYear, color, fuelType)
    {
        // Assign properties for Truck
        NumberOfWheels = 18;
        PassengerCapacity = 2;
        FuelType = "Diesel";

        // Truck own properties
        NumberOfWheels = numberOfWheels;
        PassengerCapacity = passengerCapacity;
        FuelType = fuelType;
        NumberOfDoors = numberOfDoors;
        TruckSound = truckSound;
        CargoCapacityKg = cargoCapacityKg;
    }

    // Override startEngine method for car
    public override void StartEngine()
    {
        // TODO:
        System.Console.WriteLine($"The truck is running and sounds {TruckSound}.");
    }

    // Own method for truck
    public int TruckLoad(int CargoCapacityKg)
    {
        System.Console.WriteLine($"The truck is loaded now with {CargoCapacityKg} kg.");
        CargoCapacityKg += 5000;
        return CargoCapacityKg;
    }
    // Own method for truck
    public int TruckUnload(int CargoCapacityKg)
    {
        // TODO:
        System.Console.WriteLine($"The truck has unloaded now with {CargoCapacityKg} kg.");
        CargoCapacityKg -= 5000;
        return CargoCapacityKg;
    }
}
}