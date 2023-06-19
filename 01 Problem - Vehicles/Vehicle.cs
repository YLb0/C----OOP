using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    public class Vehicle : IVehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumptionPerKM)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumptionPerKM = fuelConsumptionPerKM;
        }
        public double FuelQuantity { get; set; }
        public virtual double FuelConsumptionPerKM { get; set; }

        public bool CanDrive(double km)
            => this.FuelQuantity - (km * this.FuelConsumptionPerKM) >= 0;
        public void Drive(double km)
        {
            if (CanDrive(km))
            {
                this.FuelQuantity -= km * this.FuelConsumptionPerKM;
            }
        }
        public virtual void Refuel(double amount)
        {
            this.FuelQuantity += amount;
        }
    }
}
