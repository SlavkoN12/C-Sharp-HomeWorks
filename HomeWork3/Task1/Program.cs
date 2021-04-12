using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] newArray = new int[6];
            int result = 0;
            Console.WriteLine("Enter integer no.1: ");
            newArray[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer no.2: ");
            newArray[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer no.3: ");
            newArray[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer no.4: ");
            newArray[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer no.5: ");
            newArray[4] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer no.6: ");
            newArray[5] = int.Parse(Console.ReadLine());

            foreach (int num in newArray)
            {
                if (num % 2 == 0)
                {
                   result += num;
                }
               
            }
            Console.WriteLine("The result is: " + result);


        }


    }
}
