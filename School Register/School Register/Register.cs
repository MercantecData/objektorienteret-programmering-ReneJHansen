using System;
using System.Collections.Generic;
using System.Text;

namespace School_Register
{
    public class Register
    {
        private List<Student> students = new List<Student>();
        private List<Employee> employees = new List<Employee>();
        private List<Course> courses = new List<Course>();
        int studentID;
        int employeeID;
        int courseID;

        public Register(List<Student> students, List<Employee> employees, List<Course> courses)
        {
            this.students = students;
            this.employees = employees;
            this.courses = courses;
        }

        public List<Student> GetStudents()
        {
            return students;
        }
        public List<Employee> GetEmployees()
        {
            return employees;
        }
        public List<Course> GetCourses()
        {
            return courses;
        }

        // Students
        public void Add(string name)
        {
            Student student = new Student(studentID, name, new List<Course>());
            students.Add(student);
            studentID++;
        }
        public void Edit(int id, string newName)
        {
            var list = GetStudents();
            int index = list.FindIndex(x => x.id.Equals(id));
            list[index].name = newName;
        }

        public void Remove(Student student)
        {
            students.Remove(student);
        }

        // Teachers
        public void Add(string name, bool isTeacher, float salary, bool paidThisMonth)
        {
            Employee employee = new Employee(employeeID, name, isTeacher, salary, paidThisMonth);
            employees.Add(employee);
            employeeID++;
        }
        public void Edit(int id, string newName, bool isTeacher, float salary, bool paidThisMonth)
        {
            var list = GetEmployees();
            int index = list.FindIndex(x => x.id.Equals(id));
            list[index].name = newName;
            list[index].isTeacher = isTeacher;
            list[index].salary = salary;
            list[index].paidThisMonth = paidThisMonth;
        }
        public void Remove(Employee employee)
        {
            employees.Remove(employee);
        }
        
        // Courses
        public void Add(string courseName, int studentsEnrolled = 0, string teacher = null)
        {
            Course course = new Course(courseID, courseName, studentsEnrolled, teacher, new List<Student>());
            courses.Add(course);
            courseID++;
        }
        public void Edit(int id, string newName, int studentsEnrolled, string teacher)
        {
            var list = GetCourses();
            int index = list.FindIndex(x => x.id.Equals(id));
            list[index].courseName = newName;
            list[index].students = studentsEnrolled;
            list[index].teacher = teacher;
        }
        public void Remove(Course course)
        {
            courses.Remove(course);
        }
    }
}
