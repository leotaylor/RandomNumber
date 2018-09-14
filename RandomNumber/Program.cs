using System;
using System.Collections.Generic;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            var Numbers = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                Numbers.Add(rand.Next(1, 51));
            }

            Console.WriteLine("20 Random Numbers");
            foreach(int randomNumber in Numbers)
            {
                Console.WriteLine(randomNumber);
            }
            Console.ReadLine();

            // Squared Root

            Console.WriteLine("Sqaured Root of Numbers");
            var squared = new List<int>();
            foreach(int number in Numbers)
            {
                var squareRoot = number * number;
                squared.Add(squareRoot);
                Console.WriteLine($"{number} : {squareRoot}");
            }
            Console.ReadLine();

            // even numbers

            var even = new List<int>();

            foreach(int squareNumber in squared)
            {
                if (squareNumber % 2 == 0)
                {
                    even.Add(squareNumber);
                }
            }
            Console.WriteLine("Only Even:");
            foreach(int squareNumber in even)
            {
                Console.WriteLine(squareNumber);
            }

            Console.ReadLine();
        }
    }
}
