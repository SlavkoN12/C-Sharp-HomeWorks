using CarModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarModels
{
    public class ElectircCar : Car
    {
        public int BatteryCapacity { get; set; }
        public int BatteryUsage { get; set; }

        public ElectircCar()
        {

        }

        public static int Drive(int distance, Consumption consumption)
        {
            if (consumption == Consumption.Economic)
            {
                var result1 = (distance * 1) / 10;
                return result1;
            }
            else if (consumption == Consumption.Medium)
            {
                var result2 = (distance * 2) / 10;
                return result2;
            }
            else if (consumption == Consumption.High)
            {
                var result3 = (distance * 3) / 10;
                return result3;
            }
            else
            {
                var error = 0;
                return error;
            }
        }

        public void Recharge(int min)
        {
            int onePercent = min % 10;
            int wholeMiutes = min - onePercent;
            int timeOfCharging = (BatteryCapacity - BatteryUsage) * 10;
            if(timeOfCharging < min)
            {
                Console.WriteLine($"Can't charge longer than {timeOfCharging} minutes");
            }
            else
            {
                while (wholeMiutes > 0 && BatteryUsage < 100)
                {
                    BatteryUsage++;
                    wholeMiutes -= 10;
                }
                Console.WriteLine($"Your car is {BatteryUsage}% charged");
            }
        }
    }
}
