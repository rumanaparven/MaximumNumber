using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumNumber
{
    public class Maximum
    {
        public static int FindMax(int number1, int number2, int number3)
        {
            if (number1 > number2 && number1 > number3)
            {
                return number1;
            }
            else if (number2 > number1 && number2 > number3)
            {
                return number2;
            }
            else if (number3 > number1 && number3 > number2)
            {
                return number3;
            }
            else
            {
                throw new Exception("Numbers are equal");
            }
        }

        public static double FindMax(double number1, double number2, double number3)
        {
            if (number1 > number2 && number1 > number3)
            {
                return number1;
            }
            else if (number2 > number1 && number2 > number3)
            {
                return number2;
            }
            else if (number3 > number1 && number3 > number2)
            {
                return number3;
            }
            else
            {
                throw new Exception("Numbers are equal");
            }
        }

        public static string FindMax(string number1, string number2, string number3)
        {
           
            if (number1.CompareTo(number2)>0 && number1.CompareTo(number3)>0)
            {
                return number1;
            }
            else if (number2.CompareTo(number1) > 0 && number2.CompareTo(number3) > 0)
            {
                return number2;
            }
            else if (number3.CompareTo(number1) > 0 && number3.CompareTo(number2) > 0)
            {
                return number3;
            }
            else
            {
                throw new Exception("Numbers are equal");
            }
        }
    }
}
