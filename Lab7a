
using System;

namespace Lab7

{
    public delegate int Operation(int a, int b);

    class Program
    {
   
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        static void Main(string[] args)
        {
     
            Operation addOperation = new Operation(Add);
   
            int addResult = addOperation(10, 5);
            Console.WriteLine($"Addition Result: {addResult}");

            Operation subtractOperation = new Operation(Subtract);
       
            int subtractResult = subtractOperation(10, 5);
            Console.WriteLine($"Subtraction Result: {subtractResult}");
        }
    }
}
