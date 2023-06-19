using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    public class Bus : Vehicle
    {
        public Bus(double tankCapacity, double fuelQuantity, double fuelConsumptionPerKM) 
            : base(tankCapacity, fuelQuantity, fuelConsumptionPerKM)
        {
        }

        public override double FuelConsumptionPerKM =>
           this.IsEmpty
           ? base.FuelConsumptionPerKM
            : base.FuelConsumptionPerKM + 1.4;
    }
}
