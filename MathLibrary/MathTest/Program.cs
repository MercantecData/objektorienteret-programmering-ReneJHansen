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


            // Lambda assignments
            // Lambda assignment 1 (int => int*2)
            Lambda1 lambda1;
            lambda1 = math.Lambda1;
            Console.WriteLine("Lambda assignment: " + lambda1(number));

            // Lambda assignment 2 (float,float,float => sum)
            Lambda2 lambda2;
            lambda2 = math.Lambda2;
            Console.WriteLine("Lambda assignment 2: " + lambda2(fnumber, fnumber, fnumber));

            // Lambda assignment 3 (nothing => "Hello world")
            Lambda3 lambda3;
            lambda3 = math.Lambda3;
            Console.WriteLine("Lambda assignment 3: " + lambda3());

            // Bonus assignment - Lambda expressions applied in Math.cs
        }
    }
}
