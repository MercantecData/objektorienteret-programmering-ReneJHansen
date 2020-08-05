using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Math
    {
        public int Plus(int a, int b)
        {
            return (a + b);
        }
        public float Plus(float a, float b)
        {
            return (a + b);
        }
        public string Plus(string a, string b)
        {
            var int1 = int.Parse(a);
            var int2 = int.Parse(b);
            var add = int1 + int2;
            return add.ToString();
        }
        public int Minus(int a, int b)
        {
            return (a - b);
        }
        public float Minus(float a, float b)
        {
            return (a - b);
        }
        public string Minus(string a, string b)
        {
            var int1 = int.Parse(a);
            var int2 = int.Parse(b);
            var add = int1 - int2;
            return add.ToString();
        }
        public int Multiply(int a, int b)
        {
            return (a * b);
        }
        public float Multiply(float a, float b)
        {
            return (a * b);
        }
        public string Multiply(string a, string b)
        {
            var int1 = int.Parse(a);
            var int2 = int.Parse(b);
            var add = int1 * int2;
            return add.ToString();
        }
        public int Divide(int a, int b)
        {
            return (a / b);
        }
        public float Divide(float a, float b)
        {
            return (a / b);
        }
        public string Divide(string a, string b)
        {
            var int1 = int.Parse(a);
            var int2 = int.Parse(b);
            var add = int1 / int2;
            return add.ToString();
        }
    }
}
