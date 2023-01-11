using System.Collections.Generic;
namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaxNumber<int> maxNumber = new MaxNumber<int>(20,30,40);
            Console.WriteLine(maxNumber.PrintMaxMethod());
        }
    }
}