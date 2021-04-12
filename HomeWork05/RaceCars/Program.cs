using System;
using RaceCars.Classes;
using System.Collections.Generic;

namespace RaceCars
{
    class Program
    {
        static void Main(string[] args)
        {
            Race();
            Console.WriteLine("Do you want to race again? Y/N");
            string confirm = Console.ReadLine().ToLower();
            while (confirm == "Y" || confirm == "y")
            {
                Race();
                Console.WriteLine("Do you want to race again? Y/N");
                confirm = Console.ReadLine();
                if (confirm == "N" || confirm == "n")
                {
                    break;
                }
                while (confirm != "Y" && confirm != "y" && confirm != "N" && confirm != "n")
                {
                    Console.WriteLine("Please enter the right choice!");
                    confirm = Console.ReadLine();

                }

            }
            
            
            

        }

        public static void Race()
        {
            Driver Bob = new Driver("Bob", 3);
            Driver Greg = new Driver("Greg", 2);
            Driver Jill = new Driver("Jill", 1);
            Driver Anne = new Driver("Anne", 3);

            Car hyundai = new Car("Hyundai");
            Car mazda = new Car("Mazda");
            Car ferrari = new Car("Ferrari");
            Car porsche = new Car("Porsche");

            Car selectedCar1 = new Car();
            Car selectedCar2 = new Car();

            Console.WriteLine("Write the name of the first car:");
            Console.WriteLine("1. Hyundai");
            Console.WriteLine("2. Mazda");
            Console.WriteLine("3. Ferrari");
            Console.WriteLine("4. Porsche");

            string carName1 = Console.ReadLine().ToLower();

            if (carName1 == hyundai.Model)
            {
                selectedCar1 = hyundai;
            }
            else if (carName1 == mazda.Model)
            {
                selectedCar1 = mazda;
            }
            else if (carName1 == ferrari.Model)
            {
                selectedCar1 = ferrari;
            }
            else if (carName1 == porsche.Model)
            {
                selectedCar1 = porsche;
            }

            while (carName1 != hyundai.Model.ToLower() && carName1 != mazda.Model.ToLower() && carName1 != ferrari.Model.ToLower() && carName1 != porsche.Model.ToLower())
            {
                Console.WriteLine("Write the correct name of the car please!");
                carName1 = Console.ReadLine().ToLower();
            }


            Console.WriteLine("");

            Console.WriteLine("Write the name of the first driver:");
            Console.WriteLine($"1. {Bob.Name}");
            Console.WriteLine($"2. {Greg.Name}");
            Console.WriteLine($"3. {Jill.Name}");
            Console.WriteLine($"4. {Anne.Name}");


            string driverName1 = Console.ReadLine().ToLower();

            while (driverName1 != Bob.Name.ToLower() && driverName1 != Greg.Name.ToLower() && driverName1 != Jill.Name.ToLower() && driverName1 != Anne.Name.ToLower())
            {
                Console.WriteLine("Write the correct name of the driver please!");
                driverName1 = Console.ReadLine().ToLower();
            }

            if (driverName1 == "Bob".ToLower())
            {
                Driver selectedDriver1 = new Driver("Bob", 5);
                selectedCar1.Driver = selectedDriver1;
            }
            else if (driverName1 == "Greg".ToLower())
            {
                Driver selectedDriver1 = new Driver("Greg", 2);
                selectedCar1.Driver = selectedDriver1;
            }
            else if (driverName1 == "Jill".ToLower())
            {
                Driver selectedDriver1 = new Driver("Jill", 1);
                selectedCar1.Driver = selectedDriver1;
            }
            else if (driverName1 == "Anne".ToLower())
            {
                Driver selectedDriver1 = new Driver("Anne", 3);
                selectedCar1.Driver = selectedDriver1;
            }

            Console.WriteLine("Write the name of the second car:");






            if (carName1 == "Hyundai".ToLower())
            {
                Console.WriteLine("1. Mazda");
                Console.WriteLine("2. Ferrari");
                Console.WriteLine("3. Porsche");

            }
            else if (carName1 == "Mazda".ToLower())
            {
                Console.WriteLine("1. Hyundai");
                Console.WriteLine("2. Ferrari");
                Console.WriteLine("3. Porsche");

            }
            else if (carName1 == "Ferrari".ToLower())
            {
                Console.WriteLine("1. Hyundai");
                Console.WriteLine("2. Mazda"); ;
                Console.WriteLine("3. Porsche");

            }
            else if (carName1 == "Porsche".ToLower())
            {
                Console.WriteLine("1. Hyundai");
                Console.WriteLine("2. Mazda"); ;
                Console.WriteLine("3. Ferrari");

            }

            string carName2 = Console.ReadLine().ToLower();

            if (carName2 == hyundai.Model.ToLower())
            {
                selectedCar2 = hyundai;
            }
            else if (carName2 == mazda.Model.ToLower())
            {
                selectedCar2 = mazda;
            }
            else if (carName2 == ferrari.Model.ToLower())
            {
                selectedCar2 = ferrari;
            }
            else if (carName2 == porsche.Model.ToLower())
            {
                selectedCar2 = porsche;
            }

            while (carName2 != hyundai.Model.ToLower() && carName2 != mazda.Model.ToLower() && carName2 != ferrari.Model.ToLower() && carName2 != porsche.Model.ToLower())
            {
                Console.WriteLine("Write the correct name of the car please!");
                carName2 = Console.ReadLine().ToLower();
            }


            Console.WriteLine("");

            Console.WriteLine("Write the name of the second driver:");

            if (driverName1 == "Bob".ToLower())
            {
                Console.WriteLine("1. Greg");
                Console.WriteLine("2. Jill");
                Console.WriteLine("3. Anne");
            }
            else if (driverName1 == "Greg".ToLower())
            {
                Console.WriteLine("1. Bob");
                Console.WriteLine("2. Jill");
                Console.WriteLine("3. Anne");
            }
            else if (driverName1 == "Jill".ToLower())
            {
                Console.WriteLine("1. Bob");
                Console.WriteLine("2. Greg");
                Console.WriteLine("3. Anne");
            }
            else if (driverName1 == "Anne".ToLower())
            {
                Console.WriteLine("1. Bob");
                Console.WriteLine("2. Greg");
                Console.WriteLine("3. Jill");
            }





            string driverName2 = Console.ReadLine().ToLower();

            if (driverName2 == "Bob".ToLower())
            {
                Driver selectedDriver2 = new Driver("Bob", 5);
                selectedCar2.Driver = selectedDriver2;
            }
            else if (driverName2 == "Greg".ToLower())
            {
                Driver selectedDriver2 = new Driver("Greg", 2);
                selectedCar2.Driver = selectedDriver2;
            }
            else if (driverName2 == "Jill".ToLower())
            {
                Driver selectedDriver2 = new Driver("Jill", 1);
                selectedCar2.Driver = selectedDriver2;
            }
            else if (driverName2 == "Anne".ToLower())
            {
                Driver selectedDriver2 = new Driver("Anne", 3);
                selectedCar2.Driver = selectedDriver2;
            }

            while (driverName2 != Bob.Name.ToLower() && driverName2 != Greg.Name.ToLower() && driverName2 != Jill.Name.ToLower() && driverName2 != Anne.Name.ToLower())
            {
                Console.WriteLine("Write the correct name of the driver please!");
                driverName2 = Console.ReadLine().ToLower();
            }

            RaceCars(selectedCar1, selectedCar2);
        }

        

        public static void  RaceCars(Car car1, Car car2)
        {
            
            if (car1.CalculateSpeed() > car2.CalculateSpeed())
            {
                Console.WriteLine( $"{car1.Model} won with the max speed of {car1.CalculateSpeed()} and {car1.Driver.Name} was driving!");
            }
            else
            {
                Console.WriteLine( $"{car2.Model} won with the max speed of {car2.CalculateSpeed()} and {car2.Driver.Name} was driving!");
            }
        }

        
            



            
    }
}
