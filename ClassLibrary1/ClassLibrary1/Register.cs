using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Register
    {
        private List<Person> personRegister = new List<Person>();
        private List<Job> jobRegister = new List<Job>();

        public List<Person> GetPersons() => personRegister;

        public List<Job> GetJobs() => jobRegister;
    }
}
