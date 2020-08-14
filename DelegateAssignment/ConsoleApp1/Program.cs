using DelegateAssignment;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 1
            DelegateTesting opgave = new DelegateTesting();
            Opgave1Delegate emptyDel;

            emptyDel = opgave.Opgave1Test;

            emptyDel();


            // Opgave 2
            Opgave2Delegate emptyDel2;

            emptyDel2 = opgave.Opgave2Test;

            emptyDel2();
            Console.WriteLine(emptyDel2().ToString());


            // Opgave 3
            Opgave3Delegate emptyDel3;

            emptyDel3 = opgave.Opgave3Test;

            emptyDel3("This is", "three", "strings");
        }
    }
}
