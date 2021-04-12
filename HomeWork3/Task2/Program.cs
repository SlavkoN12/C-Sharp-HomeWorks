using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentG1 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentG2 = new string[] { "Slavko", "Ivo", "Ivan", "Brankica", "Anja" };

            Console.WriteLine("Please choose one of the two student groups: ");
            int index = int.Parse(Console.ReadLine());

            if (index == 1)
            {
                Console.WriteLine("The students in G1 are: ");
                for (int i = 0; i < studentG1.Length; i++)
                {
                    Console.WriteLine(studentG1[i]);
                }
            } else if (index == 2){
                Console.WriteLine("The students in G2 are: ");
                for (int i = 0; i < studentG2.Length; i++)
                {
                    Console.WriteLine(studentG2[i]);
                }
            }
            else
            {
                Console.WriteLine("Please enter the number of the group!");
            }
        }
    }
}
