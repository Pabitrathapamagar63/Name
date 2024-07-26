using System;
namespace ConsoleApp
{
    public class School
    {
        public string Name = "Shree devaki Secondary";
        public string Location = "Makwanpur";

        public School(string name, string location)
        {
            Name = name;
            Location = location;


        }

        public void details()
        {
            Console.WriteLine($"Name:{Name}, Location={Location}");
        }
    }



    public class Student
    {
        string Name;
        int Rollno;
        int Level;


        public Student(string name, int rollno, int level)
        {
            Name = name;
            Rollno = rollno;
            Level = level;
        }
        public void properties()
        {
            Console.WriteLine($"Name:{Name}, Rollno:{Rollno}, Level:{Level}");
        }
    }
}