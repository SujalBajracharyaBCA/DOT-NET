
using System;
namespace Lab4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. print sum of numbers in an array");
                Console.WriteLine("2. Print sum of two 3X3 matrices");
                Console.WriteLine("3. Generate prime number");
                Console.WriteLine("4. Print sum of even and odd numbers in an array");
                Console.WriteLine("5. Implement jagged array");
                Console.WriteLine("6. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        arraysum();
                        break;
                    case 2:
                        matrixsum();
                        break;
                    case 3:
                        genprime();
                        break;
                    case 4:
                        evenoddarraysum();
                        break;
                    case 5:
                        jaggedarray();
                        break;
                    case 6:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                Console.ReadKey();
            }
        }

        public static void arraysum()
        {
            int[] arr=new int[5];
            int sum = 0,i;
            Console.WriteLine("Enter 5 numbers");
            for(i=0;i<arr.Length;i++)
            {
                Console.Write($"Enter arr[{i}]:");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }
            Console.WriteLine("The sum of numbers in array is =" + sum);
        }
            public static void matrixsum()
                {
            int[,] m1 = new int[3,3], m2 = new int[3, 3], m3 = new int[3, 3];
            int i, j;
            Console.WriteLine("Enter values of matrix A");
            for( i=0;i<3;i++)
            {
                for( j=0;j<3;j++)
                {
                    Console.Write($"Enter A[{i},{j}]:");
                    m1[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter values of matrix B");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j <3; j++)
                {
                    Console.Write($"Enter A[{i},{j}]:");
                    m2[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {

                    m3[i, j] = m1[i, j] + m2[i, j];
                }
            }
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(m3[i,j]+" ");
                }
                Console.WriteLine();
            }

        }
        
        public static void genprime()
            {
            int n1, n2, count=0,i,j;
            Console.Write("Enter lower number: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter upper number: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            for (i = n1; i <= n2; i++)
            {
                count = 0;
                for (j = 1; j <= i; j++)
                {
                    if (i%j==0)
                    {
                        count++;                      
                    }
                }
                if(count==2)
                {
                    Console.WriteLine(i);
                }
            }
        }
        
            public static void  evenoddarraysum()
    {
            int[] arr = new int[10];
            int esum = 0,osum=0, i;
            Console.WriteLine("Enter 5 numbers");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter arr[{i}]:");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                if (arr[i]%2==0)
                {
                    esum += arr[i];
                }
                else
                {
                    osum += arr[i];
                }
               
            }
            Console.WriteLine("The sum of even numbers in array is =" + esum);
            Console.WriteLine("The sum of odd numbers in array is =" + osum);
        }
        
            public static void jaggedarray()
    {
            int[][] jarr = new int[][]
            {
                new int[] {4,50,6},
                new int[]{8,7,6,12,24},
                new int[]{9,10,11,14,3}
            };
            foreach (int[] array in jarr)
            {
                foreach(int i in array)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();


    }

    }
}

