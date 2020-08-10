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
        }
    }
}
