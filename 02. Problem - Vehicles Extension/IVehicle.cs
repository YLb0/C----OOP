using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    internal interface IVehicle
    {
         double FuelQuantity { get;}

         double FuelConsumptionPerKM { get;}
         
        double TankCapacity { get;}


         bool CanDrive(double km);
         
        bool CanRefuel(double amount);
        bool IsEmpty { get;}

         void Drive(double km);

         void Refuel(double amount);
    }
}
