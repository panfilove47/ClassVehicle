using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVehicle
{
    abstract internal class Vehicle
    {
        public string vehicleType { get; set; }
        public float fuelAVG { get; set; }
        public float fuelTankVolume { get; set; }
        public float speed { get; set; }
        public  float currentFuel{ get; set; }
    public Vehicle(string vehicleType, float fuelAVG, float fuelTankVolume, float speed, float currentFuel)
        {
            this.vehicleType = vehicleType;
            this.fuelAVG = fuelAVG;
            this.fuelTankVolume = fuelTankVolume;
            this.speed = speed;
            this.currentFuel = currentFuel;
        }
        
        protected virtual float Range(float fuel)
        {
            return fuel / fuelAVG;
        }
        public float RangeOnFullfuel()
        {
            return Range(fuelTankVolume);
        }
        public float RangeOnCurrentFuel()
        {
            return Range(currentFuel);
        }
        public float MaxDistance(float distance)
        {
            return distance / speed;
        }
        public void CurrentStatus()
        {
            Console.WriteLine($"Машина {vehicleType} \n Средний расход топлива {fuelAVG} \n" +
                $" Объем бака {fuelTankVolume} \n Скорость {speed}\n Текущее топливо {currentFuel}\n Проедет на полном топливе {RangeOnFullfuel()} км \n _________________________");
        }
    }
}
