using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVehicle
{
    internal class SportCar:Vehicle
    {
        public SportCar(string vehicleType, float fuelAVG, float fuelTankVolume, float speed, float currentFuel, int countOfPassangers) : base(vehicleType, fuelAVG, fuelTankVolume, speed, currentFuel)
        {

        }
    }
}
