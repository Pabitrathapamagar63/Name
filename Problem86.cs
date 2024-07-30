using System;
namespace ConsoleApp
{
    public class Studeent
    {
        public string Name;
        public int Age;

        public Studeent(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Student Name: {Name}, Age: {Age}");
        }
    }


    public class Claass
    {
        public string Cname;
        public Studeent[] Studeents;

        public Claass(string cname, Studeent[] studeents)
        {
            Cname = cname;
            Studeents = studeents;
        }

        public void displayInfo()
        {
            Console.WriteLine($"Cname: {Cname}");
            Console.WriteLine("Studeents:");

            foreach (var studeent in Studeents)
            {
                studeent.DisplayStudentInfo();

            }
        }
    }



    public class Scchool
    {
        public string Sname;
        public Claass[] Claasses;


        public Scchool(string sname, Claass[] claasses)
        {
            Sname = sname;
            Claasses = claasses;
        }

        public void DisplaySchoolInfo()
        {
            Console.WriteLine($"Sname : {Sname}");
            Console.WriteLine("Claasses");
            foreach (var claasses in Claasses)
            {
                claasses.displayInfo();
            }
        }
    }


    public class Problem86
    {
        public static void solution()
        {
            Studeent obj = new Studeent("pabitra", 17);
            Studeent obj1 = new Studeent("prabisha", 16);




            Studeent[] studeents1 = new Studeent[] { obj, obj1 };


            Claass obj2 = new Claass("class3", studeents1);

            Claass[] claasses3 = new Claass[] { obj2 };


            Scchool obj22 = new Scchool("devaki", claasses3);
            obj22.DisplaySchoolInfo();



        }
    }
}

