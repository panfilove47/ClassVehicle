using System;
using System.Collections.Generic;
namespace ClassVehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>()
            {
                new Car("SimleCar", 10, 50, 100, 35, 3),
                new Truck("Truck", 25, 100, 50, 70, 3000, 5000),
                new SportCar("Sport", 10, 50, 100, 35, 3)
            };
            foreach (var vehicle in vehicles)
            {
                vehicle.CurrentStatus();
            }
        }
    }
}