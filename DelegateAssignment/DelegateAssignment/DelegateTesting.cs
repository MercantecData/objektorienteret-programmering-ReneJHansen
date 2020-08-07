using System;

namespace DelegateAssignment
{
    public delegate void Opgave1Delegate();
    public delegate float Opgave2Delegate();
    public delegate void Opgave3Delegate(string a, string b, string c);
    public class DelegateTesting
    {
        public void Opgave1Test()
        {
            Console.WriteLine("Hello, World!");
        }

        public float Opgave2Test()
        {
            return 4.2f;
        }

        public void Opgave3Test(string a, string b, string c)
        {
            Console.WriteLine($"{a} {b} {c}");
        }
    }
}
