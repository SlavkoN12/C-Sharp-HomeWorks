using CarModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarModels
{
    class FuelCar : Car
    {
        public int FuelCapacity { get; set; }
        public int CurentCapacity { get; set; }

        public FuelCar()
        {

        }

        public void Drive(int distance, Consumption consumption)
        {
            if (consumption == Consumption.Economic)
            {
                var economic = (distance * 1) / 10;
                Console.WriteLine($"Has can cover a distance of {economic} miles");
            }
            else if (consumption == Consumption.Medium)
            {
                var medium = (distance * 2) / 10;
                Console.WriteLine($"Has can cover a distance of {medium} miles");
            }
            else if (consumption == Consumption.High)
            {
                var high = (distance * 3) / 10;
                Console.WriteLine($"Has can cover a distance of {high} miles");
            }
            else 
            {
                Console.WriteLine("Please enter a valid consumption model for the car!");
            }
        }

        public void Refuel(int fuel)
        {
            int forRefuel = FuelCapacity - CurentCapacity;
            if (fuel > forRefuel)
            {
                Console.WriteLine($"Cant refuel more than {forRefuel} liters!");
            }
            else if (fuel < forRefuel)
            {
                Console.WriteLine($"Your car has {CurentCapacity + forRefuel} liters in the tank.");
            }
        }
    }
}
