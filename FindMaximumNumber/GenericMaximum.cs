using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumNumber
{
    public class GenericMaximum<T> where T: IComparable
    {
        public T[] value;
        public GenericMaximum(T[] value)
        {
            this.value = value;
        }
       
        public void Max()
        {
            Array.Sort(this.value);
            PrintMax();
        }
        public void PrintMax()
        {
            Console.WriteLine("The maximum value is " + this.value[^1]);
        }
        
       
    }
}
