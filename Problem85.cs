using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using ConsoleApp;
namespace ConsoleApp
{
    public class Sstudent
    {
        public string Name;
        public int Age;

        public Sstudent(string name, int age)
        {
            Name = name;
            Age = age;
        }

    }

    public class Classs
    {
        public string ClasssName;
        public Sstudent[] Sstudents;

        public Classs(string classsname, Sstudent[] sstudents)
        {
            ClasssName = classsname;
            Sstudents = sstudents;
        }
    }

    public class Schoool
    {
        public string SchooolName;
        public Classs[] Classses;


        public Schoool(string schoolname, Classs[] classses)
        {
            SchooolName = schoolname;
            Classses = classses;
        }
    }







    public class Problem85
    {
        public static void solution()
        {
            Sstudent obj = new Sstudent("prabisha", 18);
            Sstudent obj2 = new Sstudent("priya", 16);


            Sstudent[] Sstudents5 = new Sstudent[] { obj, obj2 };







            Classs obj66 = new Classs("Class8", Sstudents5);



            Classs[] schooolClassses12 = new Classs[] { obj66 };



            Schoool obj54 = new Schoool("Devaki School", schooolClassses12);

        }
    }

}



