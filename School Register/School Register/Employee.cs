using System;
using System.Collections.Generic;

namespace School_Register
{
    public class Employee
    {
        public int id;
        public string name;
        public bool isTeacher;
        public float salary;
        public bool paidThisMonth;
        public List<Course> courses = new List<Course>();

        public Employee(int id, string name, bool isTeacher, float salary, bool paidThisMonth)
        {
            this.id = id;
            this.name = name;
            this.isTeacher = isTeacher;
            this.salary = salary;
            this.paidThisMonth = paidThisMonth;
        }

        public List<Course> GetCourses()
        {
            return courses;
        }

        public bool ReceivedPay()
        {
            return paidThisMonth;
        }
    }
}
