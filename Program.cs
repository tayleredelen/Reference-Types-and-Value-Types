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
            //returns a: 10, b: 11

            var array1 = new int[3]{1, 2, 3};
            var array2 = array1;
            array2[0] = 0;
            //array1 1st element value at this point? I think it's 0
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));
        }

    }

}