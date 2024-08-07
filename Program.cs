
using System;
namespace Lab1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Calculate Simple Interest");
                Console.WriteLine("2. Print full name");
                Console.WriteLine("3. Print natural numbers in descending order");
                Console.WriteLine("4. Print a pattern");
                Console.WriteLine("5. Calculate area of rectangle");
                Console.WriteLine("6. Compare two numbers");
                Console.WriteLine("7. Even descending numbers from 1 to 100");
                Console.WriteLine("8. Check whether number is prime or not");
                Console.WriteLine("9. Print day of week");
                Console.WriteLine("10. Print multiplication table");
                Console.WriteLine("11. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        SimpleInterestCalculator();
                        break;
                    case 2:
                        Fullname();
                        break;
                    case 3:
                        Naturalnumbers();
                        break;
                    case 4:
                        Pattern2818();
                        break;
                    case 5:
                        rectanglearea();
                        break;
                    case 6:
                        smalllargenum();
                        break;
                    case 7:
                        descendingevennum();
                        break;
                    case 8:
                        primeornot();
                        break;
                    case 9:
                        dayofweek();
                        break;
                    case 10:
                        multiplicationtable();
                        break;
                    case 11:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                Console.ReadKey();
            }
        }
       public static void SimpleInterestCalculator()
        {
            double principal, time, rate, simpleInterest, amount;


            Console.Write("Enter the principal amount: ");
            principal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the time period (in years): ");
            time = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the rate of interest (per year): ");
            rate = Convert.ToDouble(Console.ReadLine());

            simpleInterest = (principal * time * rate) / 100;

            amount = principal + simpleInterest;


            Console.WriteLine("Simple Interest: " + simpleInterest);
            Console.WriteLine("Total Amount: " + amount);

        }
        public static void Fullname()
        {
            string fname, mname, lname, name;
            Console.Write("Enter first name: ");
            fname = Console.ReadLine();
            Console.Write("Enter middle name: ");
            mname = Console.ReadLine();
            Console.Write("Enter last name: ");
            lname = Console.ReadLine();
            name=fname+" "+mname+" "+lname;
            Console.WriteLine("Full name is: "+name);
        }


        public static void Naturalnumbers()
        {
            Console.WriteLine("The first ten natural numbers in descending order are:");

            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i+" ");
            }
        }

        public static void Pattern2818()
        {
            int n = 2,a=6;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + " ");
                n = n + a;
                a = a + 4;
            }
        }

        public static void rectanglearea()
        {
            int l, b, area;
            Console.Write("Enter length:");
            l=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter breadth:");
            b = Convert.ToInt32(Console.ReadLine());
            area = l * b;
            Console.WriteLine("Area of rectangle is: " + area);

        }

            public static void smalllargenum()
        {
            int n1, n2;
            Console.Write("Enter first number:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number:");
            n2 = Convert.ToInt32(Console.ReadLine());
            if(n1>n2)
            {
                Console.WriteLine(n1 + " is greater number.");
                Console.WriteLine(n2 + " is smaller number.");
            }
           else if (n2 > n1)
            {
                Console.WriteLine(n2 + " is greater number.");
                Console.WriteLine(n1 + " is smaller number.");
            }
            else 
            { 
                Console.WriteLine(n1 + "=" + n2); 
            }
        }

            public static void descendingevennum()
        {
            Console.WriteLine("The even numbers from 1 to 100 in descending order are:");

            for (int j = 100; j >= 1; j--)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine(j + " ");
                }
            }
        }

            public static void primeornot()
        {
            int p, count=0,d;
            Console.Write("Enter the number: ");
            p= Convert.ToInt32(Console.ReadLine());
            for(d=1;d<=p;d++)
            {
                if(p%d==0)
                {
                    count++;
                }
               
            }
            if (count == 2)
            {
                Console.WriteLine(p + " is a prime number");
            }
            else
            {
                Console.WriteLine(p + " is not a prime number");
            }
        }

        public static void dayofweek()
        {
            Console.Write("Enter day number :");
            int daynum = Convert.ToInt32(Console.ReadLine());
            switch (daynum)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednusday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

            public static void multiplicationtable()
        {
            int number, m,product;
            Console.Write("Enter the number :");
           number = Convert.ToInt32(Console.ReadLine());
            for(m= 1; m <=10; m++)
            {
                product = number * m;
                Console.WriteLine(number+"*"+m+"="+product);
            }
        }

    }

}



