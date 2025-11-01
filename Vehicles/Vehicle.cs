public class Vehicle
{
    // Physical props
    private int ManyWheels;
    private int WeightKg;
    private string Color;
    // Identification props
    private string  Brand;
    private string Model;
    private int FabYear;
    // State props
    private bool IsWorking = true;
    private bool IsService = false;

public Vehicle(int manyWheels, int weightKg, string color, string brand, string model, int fabYear)
{
    ManyWheels = manyWheels;
    WeightKg = weightKg;
    Color = color;
    Brand = brand;
    Model = model;
    FabYear = fabYear;

    // Method1 required in US7
    public string startEngine()
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