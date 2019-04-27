using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1.a)
            int num1 = 4;
            int num2 = 5;
            Console.WriteLine($"Num1: {num1}, Num2: {num2} | Largest: {Maximum(num1, num2)}");
            // Exercise 1.b)
            num1 = -4;
            num2 = -4;
            int num3 = -3;
            Console.WriteLine($"Num1: {num1}, Num2: {num2}, Num3: {num3} | Largest: {Maximum(num1, num2, num3)}");
            // Exercise 1.c)
            num1 = -5;
            Console.WriteLine($"Num: {num1} | Num^2: {Square(num1)}");
            // Exercise 1.d)
            double num4 = 5.0;
            Console.WriteLine($"Num: {num4:F1} | Num^2: {Square(num4):F1}");

            Console.ReadLine(); // Prevent immediate exit.
        }

        // Exercise 1.a)
        private static int Maximum(int num1, int num2)
        {
            int result = num1;
            if (num2 > num1)
            {
                result = num2;
            }
            return result;
        }

        // Exercise 1.b)
        private static int Maximum(int num1, int num2, int num3)
        {
            int result = num1;
            if ((num2 > num1) && (num2 > num3))
            {
                result = num2;
            }
            else if ((num3 > num1) && (num3 > num2))
            {
                result = num3;
            }
            return result;
        }

        // Exercise 1.c)
        private static int Square(int num)
        {
            int result = num * num;
            return result;
        }

        // Exercise 1.d)
        private static double Square(double num)
        {
            double result = num * num;
            return result;
        }
    }
}
