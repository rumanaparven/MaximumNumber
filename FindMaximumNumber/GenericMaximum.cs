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
       
        public T Max()
        {
            Array.Sort(this.value);
            return this.value[^1];
        }
        
       
    }
}
