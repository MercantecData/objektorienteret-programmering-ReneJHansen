using System;
using System.Collections.Generic;
using System.Text;

namespace School_Register
{
    public class Course
    {
        public int id;
        public string courseName;
        public int students;
        public string teacher;
        public List<Student> enrolledList = new List<Student>();

        public Course(int id, string courseName, int students, string teacher, List<Student> enrolledList)
        {
            this.id = id;
            this.courseName = courseName;
            this.students = students;
            this.teacher = teacher;
            this.enrolledList = enrolledList;
        }

        public List<Student> GetStudents()
        {
            return enrolledList;
        }
    }
}
