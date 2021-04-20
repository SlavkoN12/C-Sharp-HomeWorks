using CarModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarModels
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Doors { get; set; }
        public int TopSpeed { get; set; }

        public Consumption Consumption { get; set; }
        public EngineType EngineType { get; set; }


        public Car()
        {
            

        }
        public string PrintInfo()
        {
            var info = $"{Brand} with the model {Model} has {Doors} doors, can generate speed up to {TopSpeed} km/h." +
                $"\n It has {Consumption} petrol consumption and has a {EngineType} type engine.";
            return info;
        }




    }
}
