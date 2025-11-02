namespace LogisticsCo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== 🚗 LOGISTICS CO - VEHICLE TESTING 🚗 ===\n");

            // Test Car
            Console.WriteLine("--- CAR ---");
            Car myCar = new Car(4, 1600, 2, "Alfa Romeo", "GT", 2005, "Rosso Corsa", "Gasoline", 4, "Vroom vroom");
            myCar.StartEngine();
      //      myCar.JumpIn(4, 5);
            
            // Test SUV
            Console.WriteLine("\n--- SUV (ELECTRIC) ---");
            Suv mySuv = new Suv(4, 1500, 5, "Toyota", "Verso", 2015, "Pearl White", "Electric", 4, "Whiiiiir", "Wheel on the bus...", true);
            mySuv.StartEngine();
    //        mySuv.PlayNurseryRhymes(NurseryRhyme);

            // Test Cabriolet
            Console.WriteLine("\n--- CABRIOLET ---");
            Cabriolet myCabrio = new Cabriolet(4,1400,2,"Mazda", "MX-5", 2013, "Bronze", "Gasoline", 2, false, "freuw freuw freuw");
            myCabrio.StartEngine();
  //          myCabrio.OpenRoof(RoofOpen);

            // Test Truck
            Console.WriteLine("\n--- TRUCK ---");
            Truck myTruck = new Truck(18, 5000, 3, "Volvo", "FH16", 2021, "White", "Diesel", 2, 10000, "RRRUMBLE");
            myTruck.StartEngine();
//            myTruck.TruckLoad(CargoCapacityKg);

            // Test Motorcycle
            Console.WriteLine("\n--- MOTORCYCLE ---");
            Motorcycle myMC = new Motorcycle(2,170, 2, "Suzuki", "GSF 1200", 2010, "Burgundy", "Gasoline", false);
            myMC.StartEngine();
            // myMC.ParkHere();

            // Test Bicycle
            Console.WriteLine("\n--- BICYCLE ---");
            //  int numberOfGears, int currentGear) 
            Bicycle myBike = new Bicycle(2, 10,1, "Specialized", "Sequoia", 2010, "Black", 21, 11);
            myBike.StartEngine();
            // myBike.ShiftUp();

            Console.WriteLine("\n=== ✅ ALL VEHICLES TESTED! ===");

        }   
    }
}