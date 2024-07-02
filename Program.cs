using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        { 
            var a = 10;
            var b = a;
            b++;
            //value of a at this point? 10 cuz int are value types
            //when value is copied to other variable, the copy is stored in target location in memory
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));
        }

    }

}