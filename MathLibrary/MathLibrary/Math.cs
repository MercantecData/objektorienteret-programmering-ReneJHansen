using System;

namespace MathLibrary
{
    public delegate int WithInts(int a, int b);
    public delegate float WithFloats(float a, float b);
    public delegate string WithStrings(string a, string b);
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
            bool success1 = int.TryParse(a, out int value1);
            bool success2 = int.TryParse(b, out int value2);
            if (success1 == true && success2 == true)
            {
                var add = value1 + value2;
                return add.ToString();
            }
            else return "Unable to convert input";
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
            bool success1 = int.TryParse(a, out int value1);
            bool success2 = int.TryParse(b, out int value2);
            if (success1 == true && success2 == true)
            {
                var subtract = value1 - value2;
                return subtract.ToString();
            }
            else return "Unable to convert input";
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
            bool success1 = int.TryParse(a, out int value1);
            bool success2 = int.TryParse(b, out int value2);
            if (success1 == true && success2 == true)
            {
                var multiply = value1 * value2;
                return multiply.ToString();
            }
            else return "Unable to convert input";
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
            bool success1 = int.TryParse(a, out int value1);
            bool success2 = int.TryParse(b, out int value2);
            if (success1 == true && success2 == true)
            {
                var divide = value1 / value2;
                return divide.ToString();
            }
            else return "Unable to convert input";
        }
    }
}
