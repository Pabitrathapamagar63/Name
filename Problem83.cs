using System;
namespace Application
{
    class Problem83
    {
        public static void solution()
        {
            Student[] studentsClass1 = { }
                new Student("anya", 10),
                new Student("anu", 11)
            };
        Student[] studentsClass2 = {
            new Student("covid", 12),
            new Student("corona", 13)
        };
        Class[] schoolClasses = {
            new Class("Class 1", studentsClass1),
            new Class("Class 2", studentsClass2)
        };
        School school = new School("Greenwood High", schoolClasses);
        school.DisplaySchoolInfo();
        }
    public class Student
    {
        public string Name;
`     public int Age;
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
        public string ClassName { get; set; }
        public Student[] Students { get; set; }
        public Class(string className, Student[] students)
        {
            ClassName = className;
            Students = students;
        }
        public void DisplayClassInfo()
        {
            Console.WriteLine($"Class Name: {ClassName}");
            Console.WriteLine("Students:");
            foreach (var student in Students)
            {
                student.DisplayStudentInfo();
            }
        }
    }
    public class School
    {
        public string SchoolName { get; set; }
        public Class[] Classes { get; set; }
        public School(string schoolName, Class[] classes)
        {
            SchoolName = schoolName;
            Classes = classes;
        }
        public void DisplaySchoolInfo()
        {
            Console.WriteLine($"School Name: {SchoolName}");
            Console.WriteLine("Classes:");
            foreach (var cls in Classes)
            {
                cls.DisplayClassInfo();
            }
        }
    }
}