using System;
using System.Linq;

namespace Lab8a
{
    class Program
    {
        static void Main()
        {         
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };       
            var evenNumbers = from number in numbers
                              where number % 2 == 0
                              select number;

            var oddNumbers = from number in numbers
                             where number % 2 != 0
                             select number;
            Console.WriteLine("Even Numbers:");
            foreach (var num in evenNumbers)
            {
                Console.Write(num+" ");
            }
            Console.WriteLine("\nOdd Numbers:");
            foreach (var num in oddNumbers)
            {
                Console.Write(num+" ");
            }
        }
    }
}
