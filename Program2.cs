using System;

namespace CSharpFundamentals
{
    public class Person
    {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            Console.WriteLine(number);
            //ouput is 1, it's not affected by the Increment method

            var person = new Person(){Age = 20};
            MakeOld(person);
            Console.WriteLine(person.Age);
            //ouput is 30
        }
        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }

    }
}