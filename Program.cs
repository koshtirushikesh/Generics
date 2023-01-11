using System.Collections.Generic;
namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = {10,20,60,400,300};
            MaxNumber<int> maxNumber = new MaxNumber<int>(Arr);
            maxNumber.PrintMaxMethod();
        }
    }
}