using School_Register;
using System.Collections.Generic;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

namespace SchoolRegisterTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Register register = new Register(new List<Student>(), new List<Employee>(), new List<Course>());

            // Add student
            register.Add("Hans");
            register.Add("Haaaaans");
            List<Student> studentsList = register.GetStudents();

            for (int i = 0; i < studentsList.Count; i++)
            {
                Console.WriteLine("ID: " + studentsList[i].id + " - Name: " + studentsList[i].name);
            }

            Console.ReadKey();

            // Edit Student
            Console.WriteLine("Enter ID of student you want to change");
            var id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the new name of the student");
            var newName = Console.ReadLine();

            register.Edit(id, newName);

            Console.WriteLine();
            for (int i = 0; i < studentsList.Count; i++)
            {
                Console.WriteLine("ID: " + studentsList[i].id + " - Name: " + studentsList[i].name);
            }


            Console.ReadKey();

            // Add employee (name, is Teacher?, salary, was paid, courses
            register.Add("Teacher1", true, 20000, false);
            register.Add("Teacher2", true, 25000, false);

            List<Employee> employeeList = register.GetEmployees();

            for (int i = 0; i < employeeList.Count; i++)
            {
                Console.WriteLine("ID: " + employeeList[i].id + " - Name: " + employeeList[i].name + " " + employeeList[i].salary);
            }

            Console.ReadKey();

            // Edit employee
            Console.WriteLine("Enter ID of employee you want to change");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the new name of the employee");
            newName = Console.ReadLine();

            Console.WriteLine("Enter the new salary");
            var salary = int.Parse(Console.ReadLine());

            register.Edit(id, newName, true, salary, true);

            Console.WriteLine();
            for (int i = 0; i < employeeList.Count; i++)
            {
                Console.WriteLine("ID: " + employeeList[i].id + " - Name: " + employeeList[i].name + " " + employeeList[i].salary);
            }


            Console.ReadKey();

            // Add course/class
            register.Add("Math", 0, null);
            register.Add("English", 0, null);
            register.Add("English adv", 0, null);

            List<Course> coursesList = register.GetCourses();

            Console.WriteLine();
            for (int i = 0; i < coursesList.Count; i++)
            {
                Console.WriteLine("ID: " + coursesList[i].id + " - Name: " + coursesList[i].courseName);
            }

            // Edit course/class
            Console.WriteLine("Enter ID of course you want to change");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the new name of the course");
            newName = Console.ReadLine();

            Console.WriteLine("Enter the new student count");
            var studentCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the name of the teacher");
            var newTeacher = Console.ReadLine();

            register.Edit(id, newName, studentCount, newTeacher);

            Console.WriteLine();
            for (int i = 0; i < coursesList.Count; i++)
            {
                Console.WriteLine("ID: " + coursesList[i].id + " - Name: " + coursesList[i].courseName);
            }

            // Remove course/class based on ID
            Console.WriteLine("Enter ID of class to be removed");
            var removeCourseInput = Console.ReadLine();
            register.Remove(coursesList[int.Parse(removeCourseInput)]);

            for (int i = 0; i < coursesList.Count; i++)
            {
                Console.WriteLine("ID: " + coursesList[i].id + " - Name: " + coursesList[i].courseName);
            }
        }
    }
}