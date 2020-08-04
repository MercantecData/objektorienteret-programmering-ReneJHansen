using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignments have been split into different functions

            Console.WriteLine("Choose assignment:\n1: Library assignment\n2: Dictionary assignment");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.Clear();
                LibraryTest(); // Hovedsektion
            }
            else if (input == "2")
            {
                Console.Clear();
                DictionaryTest(); //Dictionaries
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }

        static void LibraryTest()
        {
            // Variables used in this program
            var register = new Register();
            var personRegister = register.GetPersons();
            var jobRegister = register.GetJobs();
            var dictionary = new CustomDictionary(); // Bonus Opgave
            var personDictionary = dictionary.PersonDictionary();
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
                Person personDic = new Person(name, age);
                personDictionary.Add(personDic, age);

                jobRegister.Add(job);
                personRegister.Add(person);

                Console.Write("Add another entry? ");
                confirm = Console.ReadLine();
                Console.WriteLine();

                if (confirm.ToLower() == "n")
                {
                    isRunning = false;
                }
            }

            // After you are done adding entries, the program write the list out for you
            for (int i = 0; i < personRegister.Count; i++)
            {
                Console.WriteLine($"{personRegister[i].name} {personRegister[i].age}");
                Console.WriteLine($"{jobRegister[i].title} {jobRegister[i].salary} \n");
                Console.WriteLine(personDictionary.Keys.ElementAt(i).name);
                Console.WriteLine(personDictionary.Keys.ElementAt(i).age);
            }

        }

        static void DictionaryTest()
        {

            var dictionary = new CustomDictionary();
            var opgave1 = dictionary.Opgave1();
            var opgave2 = dictionary.Opgave2();

            Console.WriteLine("Opgave 1: Dictionary med string KEY og int VALUE");
            for (int i = 0; i < 10; i++)
            {
                opgave1.Add($"{i}", i);
            }
            foreach (KeyValuePair<string, int> item in opgave1)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }

            Console.ReadKey();

            Console.WriteLine("\nOpgave2: Dictionary med float KEY og bool VALUE");
            for (float i = 0.0F; i < 10.0; i++)
            {
                opgave2.Add(i, true);
            }
            foreach (KeyValuePair<float, bool> item in opgave2)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
            Console.ReadKey();
            // This is just one way of adding to the dictionary
            // Another is by using dictionaryVariable.Add("KEY", VALUE); ten times
            // For the purpose of the assignment "Add ten items" using a loop simplifies it massively
        }
    }
}
