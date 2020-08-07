using DelegateAssignment;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 1
            DelegateTesting opgave1 = new DelegateTesting();
            Opgave1Delegate emptyDel;

            emptyDel = opgave1.Opgave1Test;

            emptyDel();


            // Opgave 2
            DelegateTesting opgave2 = new DelegateTesting();
            Opgave2Delegate emptyDel2;

            emptyDel2 = opgave2.Opgave2Test;

            emptyDel2();
            Console.WriteLine(emptyDel2().ToString());


            // Opgave 3
            DelegateTesting opgave3 = new DelegateTesting();
            Opgave3Delegate emptyDel3;

            emptyDel3 = opgave3.Opgave3Test;

            emptyDel3("This is", "three", "strings");
        }
    }
}
