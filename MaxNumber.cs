using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MaxNumber
    {
        internal static T FindMaxNumber<T>(T FirstValue, T secondValue, T ThirdValue) where T : IComparable
        {

            if (FirstValue.CompareTo(secondValue) > 0 && FirstValue.CompareTo(ThirdValue) > 0)
            {
                return FirstValue;
            }
            if(secondValue.CompareTo(FirstValue)>0 && secondValue.CompareTo(ThirdValue)>0)
            {
                return secondValue;
            }
            if(ThirdValue.CompareTo(FirstValue)>0 && ThirdValue.CompareTo(secondValue)>0)
            {
                return ThirdValue;
            }
            throw new Exception("all tha values are same");
        }
    }
}
