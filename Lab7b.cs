using System;

namespace Lab7b
{
    public delegate int Operation(int a, int b);

    class Program
    {
      
        public static int Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"Add Result: {result}");
            return result;
        }

      
        public static int Subtract(int a, int b)
        {
            int result = a - b;
            Console.WriteLine($"Subtract Result: {result}");
            return result;
        }

        public static int Multiply(int a, int b) 
        {

            int result = a * b;
            Console.WriteLine($"Multiplication Result: {result}");
            return result;
        }
        static void Main(string[] args)
        {
          
            Operation operation = new Operation(Add);
            operation += Subtract; 
            operation += Multiply;

      
            int finalResult = operation(10, 5); 
            Console.WriteLine($"Final Result: {finalResult}");
        }
    }
}
