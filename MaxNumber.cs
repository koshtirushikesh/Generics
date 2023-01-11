using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MaxNumber<T> where T : IComparable
    {
        public T FirstValue,SecondValue,ThirdValue;
        public MaxNumber(T FirstValue, T SecondValue, T ThirdValue) 
        {
            this.FirstValue = FirstValue;
            this.SecondValue = SecondValue;
            this.ThirdValue = ThirdValue;
        }

        internal static T FindMaxNumber(T FirstValue, T SecondValue, T ThirdValue) 
        {
            if (FirstValue.CompareTo(SecondValue) > 0 && FirstValue.CompareTo(ThirdValue) > 0)
            {
                return FirstValue;
            }
            if(SecondValue.CompareTo(FirstValue)>0 && SecondValue.CompareTo(ThirdValue)>0)
            {
                return SecondValue;
            }
            if(ThirdValue.CompareTo(FirstValue)>0 && ThirdValue.CompareTo(SecondValue)>0)
            {
                return ThirdValue;
            }
            throw new Exception("all tha values are same");
        }

        public T PrintMaxMethod()
        {
            T Max = MaxNumber<T>.FindMaxNumber(this.FirstValue, this.SecondValue, this.ThirdValue);
            return Max;
        }
    }
}
