using System;
namespace ConsoleApp
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
        public string ClassName;
        public Student[] Students;


        public Class(string classname, Student[] students)
        {
            ClassName = classname;
            Students = students;
        }
    }

    public class Problem84
    {
        public static void solution()
        {
            Student obj1 = new Student("smarika", 12);
            Student obj2 = new Student("Aakush", 18);

            Student[] students1 = new Student[] { obj1, obj2 };
            Student[] students2 = new Student[] {
                new Student("smarika", 12),
                new Student("Aakush", 18),
            };

            Student[] students3 = new Student[3];
        }
    }
}