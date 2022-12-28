using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MaxNumber
    {
        
        internal static int FindMaxNumber(int firstValue, int secondValue, int ThirdValue)
        {
            if (firstValue.CompareTo(secondValue)> 0 && firstValue.CompareTo(ThirdValue)>0)
            {
                return firstValue;
            }
            if(secondValue.CompareTo(firstValue)>0 && secondValue.CompareTo(ThirdValue)>0)
            {
                return secondValue;
            }
            if(ThirdValue.CompareTo(firstValue)>0 && ThirdValue.CompareTo(secondValue)>0)
            {
                return ThirdValue;
            }
            throw new Exception("all tha values are same");
        }
    }
}
