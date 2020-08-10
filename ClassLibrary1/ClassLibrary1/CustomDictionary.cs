using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class CustomDictionary
    {

        private Dictionary<string, int> opgave1 = new Dictionary<string, int>();
        private Dictionary<float, bool> opgave2 = new Dictionary<float, bool>();
        private Dictionary<Person, int> personDic = new Dictionary<Person, int>();

        public CustomDictionary()
        {
        }

        public Dictionary<string, int> Opgave1() => opgave1;

        public Dictionary<float, bool> Opgave2() => opgave2;

        public Dictionary<Person, int> PersonDictionary() => personDic;
    }
}
