using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 2.a)
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;
            int num5 = 5;
            Console.WriteLine($"Num1: {num1}, Num2: {num2}, Num3: {num3} | Sum: {Addition(num1, num2, num3)}");
            Console.WriteLine($"Num1: {num1}, Num2: {num2}, Num3: {num3}, Num4: {num4} | Sum: {Addition(num1, num2, num3, num4)}");
            Console.WriteLine($"Num1: {num1}, Num2: {num2}, Num3: {num3}, Num4: {num4}, Num5: {num5} | Sum: {Addition(num1, num2, num3, num4, num5)}");
            // Exercise 2.b)
            string name1 = "Dillon";
            string name2 = "Bob";
            string name3 = "Gary";
            string name4 = "Chara";
            DisplayNames(name1);
            DisplayNames(name1, name2);
            DisplayNames(name1, name2, name3);
            DisplayNames(name1, name2, name3, name4);

            Console.ReadLine(); // Prevent immediate exit.
        }

        // Exercise 2.a)
        private static int Addition(params int[] numbers)
        {
            int result = 0;
            foreach (int currNum in numbers)
            {
                result += currNum;
            }
            return result;
        }

        // Exercise 2.b)
        private static void DisplayNames(params string[] names)
        {
            foreach (string currName in names)
            {
                Console.Write($"{currName} ");
            }
            Console.WriteLine();
        }
    }
}
