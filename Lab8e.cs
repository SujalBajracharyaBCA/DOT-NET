using System;
using System.Linq;
using System.Collections.Generic;
namespace Lab8e
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 5, 57, 16, 21, 23, 46, 37, 82 };
            int sum = (from number in numbers
                       select number).Sum();
            Console.WriteLine($"The sum of the numbers is: {sum}");
        }
    }
}
