using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi there! Welcome to my calculator app. If you want to use it go step by step.");

            Console.Write("Enter the First Number: ");
            string number1 = Console.ReadLine();

            Console.Write("Enter the Second Number: ");
            string number2 = Console.ReadLine();

            Console.Write("Enter the Operation: ");
            string operation = Console.ReadLine();

            if (operation == "+")
            {
                var result = int.Parse(number1) + int.Parse(number2);
                Console.WriteLine(result);
            }
            else if (operation == "-")
            {
                var result = int.Parse(number1) - int.Parse(number2);
                Console.WriteLine(result);
            }
            else if (operation == "*")
            {
                var result = int.Parse(number1) * int.Parse(number2);
                Console.WriteLine(result);
            }
            else if (operation == "/")
            {
                var result = int.Parse(number1) / int.Parse(number2);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Please enter the corect operation!")
            }
        }
    }
}
