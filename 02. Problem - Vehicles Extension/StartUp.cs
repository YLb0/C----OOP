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
            var busInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            var carfuel = double.Parse(carInput[1]);
            var carLiters = double.Parse(carInput[2]);
            var carTankCapaciry = double.Parse(carInput[3]);

            var truckfuel = double.Parse(truckInput[1]);
            var truckLiters = double.Parse(truckInput[2]);
            var truckTankCapaciry = double.Parse(truckInput[3]);

            var buskfuel = double.Parse(busInput[1]);
            var busLiters = double.Parse(busInput[2]);
            var busTankCapaciry = double.Parse(busInput[3]);

            Car car = new Car(carTankCapaciry, carfuel, carLiters);
            Truck truck = new Truck(truckTankCapaciry, truckfuel, truckLiters);
            Bus bus = new Bus(busTankCapaciry, buskfuel, busLiters);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                try
                {
                    var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                    string action = input[0];
                    string vehicle = input[1];
                    double value = double.Parse(input[2]);

                    IVehicle currentvehicle = GetVehicleType(car, truck, bus, vehicle);

                    if (action == "Drive")
                    {

                        if (currentvehicle.CanDrive(value))
                        {
                            currentvehicle.Drive(value);
                            Console.WriteLine($"{vehicle} travelled {value} km");
                        }
                        else
                        {
                            Console.WriteLine($"{vehicle} needs refueling");
                        }
                    }
                    else if (action == "DriveEmpty")
                    {
                        bus.IsEmpty = true;
                        if (currentvehicle.CanDrive(value))
                        {
                            bus.Drive(value);
                            bus.IsEmpty = false;
                            Console.WriteLine($"{vehicle} travelled {value} km");
                        }
                        else
                        {
                            Console.WriteLine($"{vehicle} needs refueling");
                        }
                    }
                    else
                    {
                        if (currentvehicle.CanRefuel(value))
                        {
                            currentvehicle.Refuel(value);
                        }
                        else
                        {
                            Console.WriteLine($"Cannot fit {value} fuel in the tank");
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }
        private static IVehicle GetVehicleType(Car car, Truck truck, Bus bus, string type)
        {
            if (type == "Car")
            {
                return car;
            }
            else if (type == "Truck")
            {
                return truck;
            }
            return bus;
        }
    }
}
