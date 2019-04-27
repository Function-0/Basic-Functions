using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 3.a)
            int var1 = 5;
            int var2 = 4;
            Console.WriteLine($"Normal  | Var1: {var1}, Var2: {var2}");
            Swap(ref var1, ref var2);
            Console.WriteLine($"Swapped | Var1: {var1}, Var2: {var2}");
            // Exercise 3.b)
            int num1;
            int num2; 
            Initialize(out num1, out num2);
            double average = (num1 + num2) / 2;
            Console.WriteLine($"Num1: {num1}, Num2: {num2} | Average: {average}");

            Console.ReadLine(); // Prevent immediate exit.
        }

        // Exercise 3.a)
        private static void Swap(ref int var1, ref int var2)
        {
            int temp = var1;
            var1 = var2;
            var2 = temp;
        }

        // Exercise 3.b)
        private static void Initialize(out int num1, out int num2)
        {
            num1 = 5;
            num2 = 15;
        }
    }
}
