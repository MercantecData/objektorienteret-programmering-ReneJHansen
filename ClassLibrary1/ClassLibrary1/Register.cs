using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Register
    {
        List<Person> personRegister = new List<Person>();
        List<Job> jobRegister = new List<Job>();

        public List<Person> GetPersons()
        {
            return personRegister;
        }
        public List<Job> GetJobs()
        {
            return jobRegister;
        }
    }
}
