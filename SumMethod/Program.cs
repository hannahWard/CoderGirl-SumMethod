using System;

namespace SumMethod
{
    public static class Program
    {
        public static void Main()
        {

            Console.WriteLine("Please, choose a number: ");
            int n = int.Parse(Console.ReadLine());
            int total = 0;

            int sum = SumMethod(total, n);
            Console.WriteLine($"Total: {sum}");
            Console.ReadLine();
        }

        public static int SumMethod(int total, int n)
        {
            total = (n * (n + 1) / 2);
            return total; 
        }
        // TODO: Create a method that returns the sum of all integer numbers up to and including given value. 
        // Use the equation (n * (n + 1)) / 2.
    }
}
