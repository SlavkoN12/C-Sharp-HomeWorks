using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            string stop = "STOP";
            Console.WriteLine(stop);

            Console.BackgroundColor = ConsoleColor.Yellow;
            string ready = "READY";
            Console.WriteLine(ready);

            Console.BackgroundColor = ConsoleColor.Green;
            string go = "GO";
            Console.WriteLine(go);

            Console.ReadLine();
        }
    }
}
