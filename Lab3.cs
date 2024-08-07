

using System;
namespace Lab3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Print all numbers between two numbers completely divisible by 5");
                Console.WriteLine("2. Print greatest among three numbers");
                Console.WriteLine("3. Print roots of quadratic equation");
                Console.WriteLine("4. Print according to data type");
                Console.WriteLine("5. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Numbetdivby5();
                        break;
                    case 2:
                        Greatestthree();
                        break;
                    case 3:
                        Quadraticequation();
                        break;
                    case 4:
                        Switchdatatype();
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                Console.ReadKey();
            }
        }
        public static void Numbetdivby5()
        {
            int n1, n2, div=0,i;
            Console.Write("Enter lower number: ");
            n1= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter upper number: ");
            n2= Convert.ToInt32(Console.ReadLine());
            for(i=n1; i<=n2; i++) 
            {
            if(i%5==0)
                {
                    Console.WriteLine(i);
                    div++;
                }
            }
            Console.WriteLine($"There are {div} numbers between {n1} and {n2} divisible by 5");
        }

        public static void Greatestthree()
        {
            int num1, num2,num3;
            Console.Write("Enter first number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number:");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1>num3)
            {
                Console.WriteLine(num1 + " is greatest number.");
            }
            else if (num2 > num1 && num2>num3)
            {
                Console.WriteLine(num2 + " is greatest number.");
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine(num3 + " is greatest number.");
            }
            else
            {
                Console.WriteLine("There is no greatest number");
            }
        }

        public static void Quadraticequation()
        {
            double a, b, c, r1, r2;
            Console.WriteLine("Enter coefficients a,b and c of quadratic equation ax2+bx+c=0");
            Console.Write("Enter a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter c:");
            c = Convert.ToDouble(Console.ReadLine());
            r1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            r2= (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            if (r1 == double.NaN && r2 == double.NaN)
            {
                Console.WriteLine("There are no real roots");
            }
            else if (r1 != double.NaN && r2 == double.NaN)
            {
                Console.WriteLine("The real root of equation is " + r1);
            }
            else if (r1 == double.NaN && r2 != double.NaN)
            {
                Console.WriteLine("The real root of equation is " + r2);
            }
            else if(r1==r2)
            {
                Console.WriteLine("The real root of equation is " + r1);
            }
            else
            {
                Console.WriteLine("The real roots of equation are " + r1 + " and " + r2);
            }
        }
        public static void Switchdatatype()
        {

            Console.WriteLine("Choose the type of variable you want to input:");
            Console.WriteLine("1. Integer");
            Console.WriteLine("2. Double");
            Console.WriteLine("3. String");

            int choices = Convert.ToInt32(Console.ReadLine());

            switch (choices)
            {
                case 1:
                    Console.Write("Enter an integer: ");
                    int intValue = Convert.ToInt32(Console.ReadLine());
                    intValue += 1;
                    Console.WriteLine("Result: " + intValue);
                    break;

                case 2:
                    Console.Write("Enter a double: ");
                    double doubleValue = Convert.ToDouble(Console.ReadLine());
                    doubleValue += 1;
                    Console.WriteLine("Result: " + doubleValue);
                    break;

                case 3:
                    Console.Write("Enter a string: ");
                    string stringValue = Console.ReadLine();
                    stringValue += "*";
                    Console.WriteLine("Result: " + stringValue);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please run the program again and select a valid option.");
                    break;
            }

          
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
