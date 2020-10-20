using System;

namespace FindMaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to maximum number problem");

            int[] intArray = { 2, 45, 67, 89, 23 };
            GenericMaximum<int> genericInt = new GenericMaximum<int>(intArray);
            Console.WriteLine("The maximum number is "+genericInt.Max());

            double[] doubleArray = { 2.9, 45.25, 67.77, 90.07, 23.54 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            Console.WriteLine("The maximum number is "+genericDouble.Max());

            string[] stringArray = { "25", "45", "67", "11", "92" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            Console.WriteLine("The maximum number is "+genericString.Max());
        }
    }
}
