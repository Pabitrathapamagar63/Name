using System;
using System.Collections.Generic;

namespace ConsoleApp1234
{
    public class Student
    {
        public string Studentname;
        public int Sid;
        public int Age;

        public Student(string studentname, int sid, int age)
        {
            Studentname = studentname;
            Sid = sid;
            Age = age;
        }

        public void StudentInfor()
        {
            Console.WriteLine($"Studentname: {Studentname}, Sid: {Sid}, Age: {Age}");
        }
    }

    public class Class<T>
    {
        public string Classname;
        public List<T> StudentMembers;

        public Class(string classname, List<T> studentmembers)
        {
            Classname = classname;
            StudentMembers = studentmembers;
        }

        public void AddStudentMember(T newStudentMember)
        {
            StudentMembers.Add(newStudentMember);
        }

        public void ClassInfor()
        {
            Console.WriteLine($"Classname: {Classname}");
            Console.WriteLine("Members:");
            foreach (var member in StudentMembers)
            {
                if (member is Student student)
                {
                    student.StudentInfor();
                }
                else
                {
                    Console.WriteLine(member.ToString());
                }
            }
        }
    }

    public class School<T>
    {
        public string Schoolname;
        public List<Class<T>> Classes;

        public School(string schoolname, List<Class<T>> classes)
        {
            Schoolname = schoolname;
            Classes = classes;
        }

        public void Sinfor()
        {
            Console.WriteLine($"Schoolname: {Schoolname}");
            Console.WriteLine("Classes:");
            foreach (var cclass in Classes)
            {
                cclass.ClassInfor();
            }
        }
    }

    public class Problem107
    {
        public static void Solution()
        {
            Student obj1 = new Student("Pabitra", 9, 17);
            Student obj2 = new Student("Ravi", 10, 16);

            List<Student> students44 = new List<Student> { obj1, obj2 };

            Class<Student> obj22 = new Class<Student>("Class6", students44);

            Student oobj = new Student("Alex", 34, 18);
            obj22.AddStudentMember(oobj);

            List<Class<Student>> classes66 = new List<Class<Student>> { obj22 };

            School<Student> obj8 = new School<Student>("Devaki", classes66);

            obj8.Sinfor();
        }
    }
}