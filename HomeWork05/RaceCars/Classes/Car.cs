using System;
using System.Collections.Generic;
using System.Text;

namespace RaceCars.Classes
{
    public class Car
    {
        public string Model { get; set; }

        public int Speed { get; set; }

        public Driver Driver { get; set; }


        public Car(string model)
        {
            Model = model;
            Speed = TopSpeed();
        }
        public Car()
        {

        }

        private int TopSpeed()
        {
            int speed = new Random().Next(50, 100);
            return speed;
        }

        public int CalculateSpeed()
        {
            int result = Driver.Skill * Speed;
            return result;

        }
    }
}
