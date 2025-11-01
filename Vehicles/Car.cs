public class Car : Vehicle
{
    private int Passengers;
    private string Origin;
    private string Destination;

    public Car (int NumberOfWheels, int weightKg, string color, string brand, string model, int fabYear, int passengers) : base(numberOfWheels, weightKg, color, brand, model, fabYear)
    {
        NumberOfWheels = 4;
        WeightKg = weightKg;
        Color = color;
        Brand = brand;
        Model = model;
        FabYear = fabYear;
        Passengers = passengers;
        Origin = origin;
        Destination = destination
    }

    // Own method for car
    public virtual void JumpIn(int passengers, string origin, string destination)
    {
        // TODO:
        System.Console.WriteLine($"The car drives {passengers} passengers from {origin} to {destination}.");
        return 0;
    }
}