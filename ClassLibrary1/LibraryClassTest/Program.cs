using ClassLibrary1;
using System;
using System.Collections.Generic;

namespace LibraryClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personRegister = new List<Person>();
            List<Job> jobRegister = new List<Job>();
            string confirm;
            bool isRunning = true;


            // Console form for testing the list builder
            Console.WriteLine("Form builder test \n");
            while (isRunning == true)
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();

                Console.Write("Enter age: ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Enter Job title: ");
                string title = Console.ReadLine();

                Console.Write("Enter Job salary: ");
                double payment = double.Parse(Console.ReadLine());

                Job job = new Job(title, payment);
                Person person = new Person(name, age, job);
                jobRegister.Add(job);
                personRegister.Add(person);

                Console.Write("Add another entry? ");
                confirm = Console.ReadLine();
                Console.WriteLine();

                if(confirm.ToLower() == "n")
                {
                    isRunning = false;
                }

            }
            for (int i = 0; i < personRegister.Count; i++)
            {
                Console.WriteLine($"{personRegister[i].name} {personRegister[i].age}");
                Console.WriteLine($"{jobRegister[i].title} {jobRegister[i].salary} \n");
            }

        }
    }
}
