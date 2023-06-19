using System;
using System.Linq;

namespace Vehicle
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var carInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            var truckInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            var carfuel = double.Parse(carInput[1]);
            var carLiters = double.Parse(carInput[2]);

            var truckfuel = double.Parse(truckInput[1]);
            var truckLiters = double.Parse(truckInput[2]);

            Car car = new Car(carfuel, carLiters);
            Truck truck = new Truck(truckfuel, truckLiters);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string com = input[0];
                string type = input[1];
                double value = double.Parse(input[2]);

                if (com == "Drive")
                {
                    if (type == "Car")
                    {
                        if (car.CanDrive(value))
                        {
                            car.Drive(value);
                            Console.WriteLine($"Car travelled {value} km");
                        }
                        else
                        {
                            Console.WriteLine("Car needs refueling");
                        }
                    }
                    else
                    {
                        if (truck.CanDrive(value))
                        {
                            truck.Drive(value);
                            Console.WriteLine($"Truck travelled {value} km");
                        }
                        else
                        {
                            Console.WriteLine("Truck needs refueling");
                        }
                    }
                }
                else
                {
                    if (type == "Car")
                    {
                        car.Refuel(value);
                    }
                    else
                    {
                        truck.Refuel(value);
                    }
                }
            }
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        }
    }
}
