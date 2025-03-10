using System;
namespace ConsoleApplication
{
    public class Student
    {
        public string Name;
        public int Age;

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Student Name: {Name}, Age: {Age}");
        }
    }

    public class Class
    {
        public string Cname;
        public Student[] Students;

        public Class(string cname, Student[] students)
        {
            Cname = cname;
            Students = students;

        }

        public void displayInfo()
        {
            Console.WriteLine($"Cname: {Cname}");
            Console.WriteLine("Studeents:");

            foreach (var student in Students)
            {
                student.DisplayStudentInfo();

            }
        }
    }


    public class Employee
    {
        public string Name;
        public int Id;
        public int Age;

        public Employee(string name, int id, int age)
        {
            Name = name;
            Id = id;
            Age = age;

        }

        public void Einfo()
        {
            Console.WriteLine($"Name:{Name}, Id:{Id}Age:{Age}");

        }

    }


    public class Teacher : Employee
    {



        public int Teacherid;
        public Teacher(string name, int id, int age, int teacherid) : base(name, id, age)
        {
            Teacherid = teacherid;
        }

        public void Teacherinfo()
        {
            Console.WriteLine($" Name:{Name}, Id:{Id}, Age:{Age},Teacherid:{Teacherid}");
        }
    }


    public class Admin : Employee
    {
        public int Adminid;

        public Admin(string name, int id, int age, int adminid) : base(name, id, age)
        {
            Adminid = adminid;
        }

        public void Admininfo()
        {
            Console.WriteLine($" Name:{Name}, Id:{Id}, Age:{Age},Admminid:{Adminid},");
        }
    }

    public class School
    {
        public string Name;
        public Class[] Classes;
        public Employee[] Employees;


        public School(string name, Class[] classes, Employee[] employees)
        {
            Name = name;
            Classes = classes;
            Employees = employees;

        }

        public void DisplaySchoolInfo()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine("Claasses");
            foreach (var classes in Classes)
            {
                classes.displayInfo();
            }
        }
    }

    public class Problem92
    {
        public static void solution()
        {


            Student obj = new Student("pabitra", 17);
            Student obj1 = new Student("prabisha", 16);

            Student[] studeents1 = new Student[] { obj, obj1 };


            Class obj2 = new Class("class3", studeents1);

            Class[] claasses3 = new Class[] { obj2 };



            Employee[] employees50 = new Employee[] { };
            School obj22 = new School("devaki", claasses3, employees50);
            obj22.DisplaySchoolInfo();


            Teacher objn = new Teacher("Sarika", 6, 20, 11);
            Admin objb = new Admin("Puja", 7, 24, 9);
            objn.Teacherinfo();
            objb.Admininfo();



            Employee[] employees90 = new Employee[] { objn, objb };
            School obj25 = new School("devaki", claasses3, employees90);



        }
    }
}





