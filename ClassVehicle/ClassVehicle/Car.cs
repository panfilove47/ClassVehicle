using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVehicle
{
    internal class Car : Vehicle
    {
        private int countOfPassangers { get; }
        const double fuelDecrease = 0.06;
        public Car(string vehicleType, float fuelAVG, float fuelTankVolume, float speed, float currentFuel, int countOfPassangers):base(vehicleType, fuelAVG, fuelTankVolume, speed, currentFuel)
        {
            if (countOfPassangers > 0 && countOfPassangers <= 5)
            {
                this.countOfPassangers = countOfPassangers;
            }
            else
            {
                throw new ArgumentException("Число пассажиров не может быть больше 5");
            }
        }
        protected override float Range(float fuel)
        {
            return (float)(base.Range(fuel) * (1 - fuelDecrease * countOfPassangers));
        }
    }
}
