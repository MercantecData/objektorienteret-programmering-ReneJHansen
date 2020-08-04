using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class CustomDictionary
    {

        private Dictionary<string, int> opgave1;
        private Dictionary<float, bool> opgave2;
        private Dictionary<Person, int> personDic;

        public Dictionary<string, int> Opgave1()
        {
            return opgave1;
        }

        public Dictionary<float, bool> Opgave2() 
        {
            return opgave2;
        }

        public Dictionary<Person, int> PersonDictionary()
        {
            return personDic;
        }
    }
}
