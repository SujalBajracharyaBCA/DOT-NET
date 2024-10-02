using System;

namespace Lab7c
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

        public static int Calculate(int a, int b, Operation operation)
        {
            return operation(a, b);
        }

        static void Main(string[] args)
        {
            Operation addOperation = new Operation(Add);
            int addResult = Calculate(10, 5, addOperation);
            Console.WriteLine($"Addition Result: {addResult}");

            Operation subtractOperation = new Operation(Subtract);
            int subtractResult = Calculate(10, 5, subtractOperation);
            Console.WriteLine($"Subtraction Result: {subtractResult}");
        }
    }
}

