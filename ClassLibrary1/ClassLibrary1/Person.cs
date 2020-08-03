using System;

namespace ClassLibrary1
{
    public class Person
    {
        public string name;
        public int age;
        public Job job;

        public Person(string name, int age, Job job)
        {
            this.name = name;
            this.age = age;
            this.job = job;
        }
    }
}
