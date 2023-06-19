using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    internal interface IVehicle
    {
         double FuelQuantity { get;}

         double FuelConsumptionPerKM { get;}


         bool CanDrive(double km);

         void Drive(double km);

         void Refuel(double amount);
    }
}
