using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age: ");
            int yourAge = int.Parse(Console.ReadLine());
            string yourAgeInDays = CalcAge(yourAge);

            Console.WriteLine(yourAgeInDays);

        }

        public static string CalcAge(int yourAge)
        {
            int oneYear = 365;
            int ageInDays = yourAge * oneYear;
            string result = $"Your age is {yourAge}, and its {ageInDays} days long.";
            return result;
        }
    }
}
