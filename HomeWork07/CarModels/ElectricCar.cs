using CarModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Task1.Classes;

namespace CarModels.Classes
{
    public class ElectricCar : Car
    {
        public int BatteryCapacity { get; set; }
        public int BatteryUsage { get; set; }

        public ElectricCar()
        {

        }

        public static int Drive(int distance, Consumption consumption)
        {
            if (consumption == Consumption.Economic)
            {
                var result1 = (distance * 1) / 10;
                return result1;
            } else if(consumption == Consumption.Medium)
            {
                var result2 = (distance * 2) / 10;
                return result2;
            }
            else if (consumption == Consumption.High)
            {
                var result3 = (distance * 3) / 10;
                return result3;
            } else
            {
                var error = 0;
                return error;
            }
        }

        public static int Recharge(int min)
        {
            int onePercent = 10;
            var result = 0;
            return result;
        }


    }
}
