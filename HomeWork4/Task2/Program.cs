using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your minutes: ");
            int yourMin = int.Parse(Console.ReadLine());
            string yourMinInSec = CalcAge(yourMin);

            Console.WriteLine(yourMinInSec);

        }

        public static string CalcAge(int yourMin)
        {
            int oneMin = 60;
            int minToSec = yourMin * oneMin;
            string result = $"You have {yourMin} minutes, and that is {minToSec} seconds.";
            return result;
        }
    }
}
