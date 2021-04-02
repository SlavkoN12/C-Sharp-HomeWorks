using System;

namespace AverageCal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the First Number: ");
            string number1 = Console.ReadLine();

            Console.Write("Enter the Second Number: ");
            string number2 = Console.ReadLine();

            Console.Write("Enter the Third Number: ");
            string number3 = Console.ReadLine();

            Console.Write("Enter the Forth Number: ");
            string number4 = Console.ReadLine();

            double avg = (double.Parse(number1) + double.Parse(number2) + double.Parse(number3) + double.Parse(number4)) / 4;
            Console.WriteLine($"The avarege of {number1}, {number2}, {number3} & {number4} is: {avg}");
        }
    }
}
