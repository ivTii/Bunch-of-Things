using System;

namespace Recursion_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number;");
            int n = Convert.ToInt32(Console.ReadLine());
            int answer = Factorial(n);
            Console.WriteLine($"The factorial of your number is {answer}."); // Courtesy of Sofia
        }
        static int Factorial(int n)
        {
            if (n == 0) { return 1; }
            else
            {
                return n * Factorial(n - 1);
            }
        }

    }
}
