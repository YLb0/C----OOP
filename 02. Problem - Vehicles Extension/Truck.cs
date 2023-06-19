using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    public class Truck : Vehicle
    {
        public Truck(double tankCapacity, double fuelQuantity, double fuelConsumptionPerKM) : base(tankCapacity, fuelQuantity, fuelConsumptionPerKM)
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
