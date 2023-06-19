using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumptionPerKM) : base(fuelQuantity, fuelConsumptionPerKM)
        {
        }

        public override double FuelConsumptionPerKM =>
            base.FuelConsumptionPerKM + 1.6;

        public override void Refuel(double amount)
        {
            amount *= 0.95;
            base.Refuel(amount);
        }
    }
}
