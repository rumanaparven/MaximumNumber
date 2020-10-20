using System;

namespace FindMaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to maximum number problem");
            try
            {
                Console.WriteLine(Maximum.FindMax(5, 7, 2) + " is the biggest number");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            try
            {
                Console.WriteLine(Maximum.FindMax(5.7, 2.8, 5.9) + " is the biggest number");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
