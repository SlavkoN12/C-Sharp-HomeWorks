using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the First Number: ");
            string number1 = Console.ReadLine();

            Console.Write("Enter the Second Number: ");
            string number2 = Console.ReadLine();

            string helpNr;

            Console.WriteLine("Before the Switch..");
            Console.WriteLine($"The first number is: {number1}.");
            Console.WriteLine($"The second number is: {number2}.");

            helpNr = number1;
            number1 = number2;
            number2 = helpNr;

            Console.WriteLine("After the Switch..");
            Console.WriteLine($"The first number is: {number1}.");
            Console.WriteLine($"The second number is: {number2}.");
        }
    }
}
