using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumptionPerKM) 
            : base(fuelQuantity, fuelConsumptionPerKM)
        {
        }

        public override double FuelConsumptionPerKM =>
            base.FuelConsumptionPerKM + 0.9;
    }
}
