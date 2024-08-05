using System;
using System.Net.Http.Headers;
namespace ConsoleAppsss
{

    public class StudentA
    {
        public string Name;
        public int Age;
        public StudentA(string name, int age)
        {
            this.Name = name;
            this.Age = age;

        }

        public void ShowStudent()
        {
            Console.WriteLine($"Name:{Name}, Age:{Age}");
        }
    }

    public class StudentB
    {
        public string Name;
        public int RollNumber;
        public StudentB(string name, int rollNumber)
        {
            this.Name = name;
            this.RollNumber = rollNumber;
        }

        public void ShowStudentB()
        {
            Console.WriteLine($"Name:{Name}, RollNumber:{RollNumber}");
        }
    }


    public class Employee
    {

        public string Name;
        public Employee(string name)
        {
            Name = name;
        }

        public void ShowEmployee()
        {
        }
    }


    public class Teacher : Employee
    {
        public string Subject;
        public Teacher(string name, string subject) : base(name)
        {
            this.Subject = subject;
        }

        public void ShowTeacher()
        {
            Console.WriteLine($"Name:{Name}, Subject:{Subject}");
        }
    }

    public class Admin : Employee
    {
        public Admin(string name) : base(name)
        {

        }

        public void ShowAdmin()
        {
            Console.WriteLine($"Name:{Name}");
        }
    }

    public class Class<T, P>
    {
        public int Level;
        public T[] Students;
        public P ClassTeacher;

        public Class(int level, P classTeacher, T[] students)
        {
            this.Level = level;
            this.ClassTeacher = classTeacher;
            this.Students = students;
        }

        public void ShowClass()
        {
            Console.WriteLine($"Level:{Level}");


            if (ClassTeacher is Employee employee)
            {
                employee.ShowEmployee();

                if (ClassTeacher is Teacher teacher)
                {
                    teacher.ShowTeacher();
                }

            }
            Console.WriteLine("Students:");
            foreach (var student in Students)
            {
                if (student is StudentA JJ)
                {
                    JJ.ShowStudent();
                }
                else if (student is StudentB Ss)
                {
                    Ss.ShowStudentB();
                }

            }
        }


    }


    public class Problem96
    {
        public static void solution()
        {
            StudentA obj = new StudentA("Abishek", 20);
            StudentA obje = new StudentA("Sajana", 3);
            Employee obj0 = new Teacher("Taprej", "Chemistry");
            StudentA[] obj2 = new StudentA[] { obj, obje };
            Class<StudentA, Employee> obj1 = new Class<StudentA, Employee>(12, obj0, obj2);

            StudentB obj3 = new StudentB("Sneha", 24);
            StudentB obj4 = new StudentB("Deepa", 1);
            Employee obj8 = new Admin("Rajanyadav");
            StudentB[] oo = new StudentB[] { obj3, obj4 };
            Class<StudentB, Employee> pp = new Class<StudentB, Employee>(10, obj8, oo);

            obj1.ShowClass();
            pp.ShowClass();
        }
    }
}
