using System.Collections.Generic;
namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxNumber.FindMaxNumber<int>(12,19,14));
        }
    }
}