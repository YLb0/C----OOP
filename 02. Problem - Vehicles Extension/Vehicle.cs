using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    public class Vehicle : IVehicle
    {
        private double fuelQuantity;
        
        public Vehicle(double tankCapacity, double fuelQuantity, double fuelConsumptionPerKM)
        {
            this.TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            FuelConsumptionPerKM = fuelConsumptionPerKM;
        }
        public double FuelQuantity 
        {
            get => fuelQuantity;
            private set
            {
                if (value > this.TankCapacity)
                {
                    value = 0;
                }
                else
                {
                    this.fuelQuantity = value;
                }
            }
        }
        public virtual double FuelConsumptionPerKM { get; protected set; }

        public double TankCapacity { get; }

        public bool IsEmpty { get; set; }

        public bool CanDrive(double km)
            => this.FuelQuantity - (km * this.FuelConsumptionPerKM) >= 0;

        public bool CanRefuel(double amount) =>
            this.FuelQuantity + amount <= this.TankCapacity;


        public void Drive(double km)
        {
            if (CanDrive(km))
            {
                this.FuelQuantity -= km * this.FuelConsumptionPerKM;
            }
        }
        public virtual void Refuel(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (CanRefuel(amount)) 
            {
                this.FuelQuantity += amount;
            }
        }
    }
}
