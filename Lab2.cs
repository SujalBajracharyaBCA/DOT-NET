
using System;
namespace Lab2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Declare appropriate Data type for variables");
                Console.WriteLine("2. Use string to print string with quotations");
                Console.WriteLine("3. Swap the value of two variables");
                Console.WriteLine("4. Calculate area of trapezoid");
                Console.WriteLine("5. Calculate perimeter and area of rectangle");
                Console.WriteLine("6. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Datatype();
                        break;
                    case 2:
                       Quotestring();
                        break;
                    case 3:
                        Swapvalue();
                        break;
                    case 4:
                        Areaoftrapezoid();
                        break;
                    case 5:
                        periarearectangle();
                        break;
                    case 6:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
        public static void Datatype()
        {
            sbyte sb1 = -115, sb2 = -44;
            byte b1 = 97, b2 = 112;
            short sh1 = -10000, sh2 = 224;
            ushort ush1 = 20000, ush2 = 1990;
            int i1 = -1000000, i2 = 4825932;
            uint ui1 = 52130, ui2 = 970700000;
            long l1 = 123456789123456789;
            ulong ul1 = 0;
            Console.WriteLine("The sbyte type are " + sb1 + " " + sb2);
            Console.WriteLine("The byte type are " + b1 + " " + b2);
            Console.WriteLine("The short type are " + sh1 + " " + sh2);
            Console.WriteLine("The ushort type are " + ush1 + " " + ush2);
            Console.WriteLine("The int type are " + i1 + " " + i2);
            Console.WriteLine("The uint type are " + ui1 + " " + ui2);
            Console.WriteLine("The long type are " + l1);
            Console.WriteLine("The ulong type are " + ul1);
        }
        public static void Quotestring() 
        {
            string s1, s2;
            s1 = "The \"use\" of quotations causes difficulties.";
            s2 = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
        public static void Swapvalue()
        {
            int j1 = 5, j2 = 10,temp;
            Console.WriteLine("The value of j1 and j2 are " + j1 + " " + j2);
            temp = j1;
            j1 = j2;
            j2 = temp;
            Console.WriteLine("After swap, the value of j1 and j2 are " + j1 + " " + j2);
        }
        public static void Areaoftrapezoid()
        {
            double a, b, h,areaoft;
            Console.Write("Enter side a of trapezoid: ");
            a= Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter side b of trapeoid: ");
            b= Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height h of trapezoid: ");
            h= Convert.ToDouble(Console.ReadLine());
            areaoft = ((a + b) * h) / 2;
            Console.WriteLine("The area of trapeoid is: " + areaoft);

        }
        public static void periarearectangle()
        {
            double l,bh,periofr,areaofr;
            Console.Write("Enter length of rectangle: ");
            l = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter heigth(breadth) of rectangle: ");
            bh = Convert.ToDouble(Console.ReadLine());
            periofr = 2 * (l + bh);
            areaofr = l * bh;
            Console.WriteLine("The perimeter of rectangle is: " + periofr);
            Console.WriteLine("The area of rectangle is: " + areaofr);
        }
    }
}

