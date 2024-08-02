using System;
namespace ConsoleApps
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


    public class Teacher
    {

        public string Teachername;
        public int Teacherid;

        public Teacher(string teachername, int teacherid)
        {
            Teachername = teachername;
            Teacherid = teacherid;

        }


        public void Tinfo()
        {
            Console.WriteLine($"Teachername:{Teachername}, Teacherid:{Teacherid}");
        }
    }

    public class Employee
    {
        public string Ename;
        public Teacher[] Teachers;

        public Employee(string ename, Teacher[] teachers)
        {
            Ename = ename;
            Teachers = teachers;
        }



        public void AddTeacher(Teacher newTeacher)
        {
            var updatedTeachers = new Teacher[Teachers.Length + 1];
            Teachers.CopyTo(updatedTeachers, 0);
            updatedTeachers[Teachers.Length] = newTeacher;
            Teachers = updatedTeachers;
        }


        public void Einfo()
        {
            Console.WriteLine($"EName:{Ename},");
            Console.WriteLine("Teacher:");
            foreach (var Teacher in Teachers)
            {
                Teacher.Tinfo();
            }
        }
    }

    public class School
    {

        public string Schoolname;
        public Class[] Classes;
        public Employee[] Employees;

        public School(string schoolname, Class[] classes, Employee[] employees)
        {
            Schoolname = schoolname;
            Classes = classes;
            Employees = employees;

        }

        public void SchoolInfo()
        {

            Console.WriteLine($"Schoolname:{Schoolname}");
            Console.WriteLine("Class:");
            foreach (var Claass in Classes)
            {
                Claass.displayInfo();
            }

            Console.WriteLine("Employee");
            foreach (var Employee in Employees)
            {
                Employee.Einfo();
            }

        }

    }



    public class Problem93
    {
        public static void solution()
        {

            Student obj = new Student("pabitra", 17);
            Student obj1 = new Student("prabisha", 16);

            Student[] studeents1 = new Student[] { obj, obj1 };


            Class obj2 = new Class("class3", studeents1);

            Class[] claasses3 = new Class[] { obj2 };


            Teacher objn = new Teacher("Sarika", 6);
            Teacher[] teachers87 = new Teacher[] { objn };

            Employee obj30 = new Employee("Teachers", teachers87);

            Employee[] employees90 = new Employee[] { obj30 };



            School obj21 = new School("Devaki", claasses3, employees90);
            obj21.SchoolInfo();












        }
    }


}