using CarFactory.Models;

namespace CarFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            Console.WriteLine("Hello! How many vehicles would you like to add?");
            int numVehicle = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numVehicle; i++)
            {
                {
                    Console.WriteLine("=============================");
                    Console.WriteLine("Are you manufacturing a CAR or a TRUCK?");
                    string vehicleChoice = Console.ReadLine().ToLower();
                    Console.WriteLine("=============================");

                    if (vehicleChoice == "car")
                    {
                        Console.WriteLine("What color would you like your car to have?");
                        string color = Console.ReadLine();
                        Console.WriteLine("=============================");
                        Console.WriteLine("What brand would you like your car to have?");
                        string brand = Console.ReadLine();
                        Console.WriteLine("=============================");
                        Console.WriteLine("What model would you like your car to have?");
                        string model = Console.ReadLine();


                        Car c = new Car(color, brand, model);

                        vehicles.Add(c);
                    }
                    else if (vehicleChoice == "truck")
                    {
                        Console.WriteLine("What color would you like your truck to have?");
                        string color = Console.ReadLine();
                        Console.WriteLine("=============================");
                        Console.WriteLine("What brand would you like your truck to have?");
                        string brand = Console.ReadLine();
                        Console.WriteLine("=============================");
                        Console.WriteLine("What model would you like your truck to have?");
                        string model = Console.ReadLine();
                        Console.WriteLine("=============================");
                        Console.WriteLine("What capacity would you like your truck to have?");
                        float capacity = float.Parse(Console.ReadLine());

                        Truck t = new Truck(color, brand, model, capacity);

                        vehicles.Add(t);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Vehicle type. Please try again");
                        i--;
                    }





                }
            }
            Console.WriteLine("Thank you for creating your vehicle/s, here is a rundown of what you have created today:");
            Console.WriteLine("=============================");
            foreach (Vehicle v in vehicles)
            {
                // Console.WriteLine(v);
                if (v.GetType() == typeof(Car))
                {
                    Car temp = (Car)v;
                    Console.WriteLine("Vehicle is a car");
                    Console.WriteLine(temp.DisplayVehicle());
                    Console.WriteLine("=============================");
                }
                else if (v.GetType() == typeof(Truck))
                {
                    Truck temp = (Truck)v;
                    Console.WriteLine("Vehicle is a truck");
                    Console.WriteLine(temp.DisplayVehicle());
                    Console.WriteLine("=============================");
                }
            }
        }
    }
}