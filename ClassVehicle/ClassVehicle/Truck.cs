using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVehicle
{
    internal class Truck:Vehicle
    {
        private int loadCapacity { get; }
        private int maxLoadCapacity { get; }
        const double fuelDecrease = 0.04;
        const double kg = 200; 
        public Truck(string vehicleType, float fuelAVG, float fuelTankVolume, float speed, float currentFuel, int loadCapacity, int maxLoadCapacity) : base(vehicleType, fuelAVG, fuelTankVolume, speed, currentFuel)
        {
            this.loadCapacity = loadCapacity;
            this.maxLoadCapacity = maxLoadCapacity;
            if (loadCapacity > maxLoadCapacity)
            {
                throw new ArgumentException($"Грузоподъемность не может быть больше {maxLoadCapacity} кг");
            }
        }
        protected override float Range(float fuel)
        {
            return (float)(base.Range(fuel) * (1 - fuelDecrease * (loadCapacity / kg)));
        }
    }
}
