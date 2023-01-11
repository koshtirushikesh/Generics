using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MaxNumber<T>
    {
        public T[] values;

        public MaxNumber(T[] values) 
        {
            this.values = values;
        }

        public static T[]  sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        internal static T FindMaxNumber(params T[] values ) 
        {
            T[] sortedArray = sort(values);
            return sortedArray[^1];
        }

        public void PrintMaxMethod()
        {
            var Max= FindMaxNumber(this.values);
            Console.WriteLine("this is the max value: " + Max);
        }
    }
}
