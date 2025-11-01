public class Vehicle
{
    // Physical props
    private int NumberOfWheels;
    private int WeightKg;
    // Identification props
    private string  Brand;
    private string Model;
    private int FabYear;
    private string Color;
    // State props
    private bool IsWorking = true;
    private bool IsService = false;

public Vehicle(int numberOfWheels, int weightKg, string brand, string model, int fabYear, string color)
{
    NumberOfWheels = numberOfWheels;
    WeightKg = weightKg;
    Brand = brand;
    Model = model;
    FabYear = fabYear;
    Color = color;

    // Method1 required in US7
    public virtual string startEngine()
    {
        System.Console.WriteLine($"The XXXX is doing xxxx");
    }
    // Method2 required in US7
    public virtual string runVehicle()
    {
        System.Console.WriteLine($"The XXXX is running");
    }
    // Method3 required in US7
    public virtual string stopVehicle()
    {
        System.Console.WriteLine($"The XXXX is stopped");
    }
}
}