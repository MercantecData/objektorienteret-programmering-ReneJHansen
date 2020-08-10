using System;
using System.Collections.Generic;
using System.Text;

namespace School_Register
{
    public class Student
    {
        public int id;
        public string name;
        public List<Course> courses = new List<Course>();

        public Student(int id, string name, List<Course> courses)
        {
            this.id = id;
            this.name = name;
            this.courses = courses;
        }

        public List<Course> GetCourses() => courses;
    }
}
