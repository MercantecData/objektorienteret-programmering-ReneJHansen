using MathLibrary;
using System;

namespace MathTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // MathLibrary.Math is to differenciate between the pre-coded Math class and my custom Math class
            MathLibrary.Math math = new MathLibrary.Math();

            Console.WriteLine("int: 2 + 2 = " + math.Plus(2, 2));
            Console.WriteLine("float: 2.2 + 2.2 = " + math.Plus(2.2f, 2.2f));
            Console.WriteLine("string: \"2\" + \"2\" = " + math.Plus("2", "2"));


            // Delegate assignment test area
            // Testing plus function with ints
            WithInts withInts;
            int number = 3;
            withInts = math.Plus;
            Console.WriteLine("Delegates assignment with ints: " + withInts(number, number));

            // Testing plus function with floats
            WithFloats withFloats;
            float fnumber = 3.3f;
            withFloats = math.Plus;
            Console.WriteLine("Delegates assignment but with floats: " + withFloats(fnumber, fnumber));

            // Testing plus function with strings
            WithStrings withStrings;
            string newString = "5";
            withStrings = math.Plus;
            Console.WriteLine("Delegates assignment but with strings: " + withStrings(newString, newString));
        }
    }
}
