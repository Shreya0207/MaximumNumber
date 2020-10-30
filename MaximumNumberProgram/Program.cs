using System;

namespace MaximumNumberProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Maximum Number Program using Generics");
            Console.WriteLine("Find max Number");
            MaximumNumberCheck MaxInt = new MaximumNumberCheck();
            int output = MaxInt.MaximumIntegerNumber(11, 22, 33);
            Console.WriteLine(output);
        }
    }
}
