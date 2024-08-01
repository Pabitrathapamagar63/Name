using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
namespace ConsoleApp
{
    public class Sttudent
    {

        public string Sttudentname;
        public int Sid;
        public int Age;
        public Sttudent(string sttudentname, int sid, int age)
        {
            Sttudentname = sttudentname;
            Sid = sid;
            Age = age;

        }

        public void SttudentInfor()
        {
            Console.WriteLine($"Sttudentname:{Sttudentname},Sid:{Sid},Age:{Age}");
        }

    }


    public class Cclass
    {
        public string Cclassname;
        public Sttudent[] Sttudents;

        public Cclass(string cclassname, Sttudent[] sttudents)
        {
            Cclassname = cclassname;
            Sttudents = sttudents;
        }

        public void AddStudent(Sttudent newStudent)
        {
            var updatedSttudents = new Sttudent[Sttudents.Length + 1];

            Sttudents.CopyTo(updatedSttudents, 0);

            updatedSttudents[Sttudents.Length] = newStudent;

            Sttudents = updatedSttudents;
        }
        public void CclassInfor()
        {
            Console.WriteLine($"Cclassname:{Cclassname}");
            Console.WriteLine("Sttudents:");
            foreach (var Sttudent in Sttudents)
            {
                Sttudent.SttudentInfor();
            }
        }
    }

    public class Schooll
    {
        public string Schoollname;

        public Cclass[] Cclasses;

        public Schooll(string schoollname, Cclass[] cclasses)
        {
            Schoollname = schoollname;
            Cclasses = cclasses;
        }

        public void Sinfor()
        {
            Console.WriteLine($"Schoollname:{Schoollname}");
            Console.WriteLine("Cclass:");
            foreach (var Cclass in Cclasses)
            {
                Cclass.CclassInfor();
            }
        }
    }


    public class Problem89
    {
        public static void solution()
        {
            Sttudent obj1 = new Sttudent("Pabitra", 9, 17);
            Sttudent obj2 = new Sttudent("Ravi", 10, 16);


            Sttudent[] sttudents44 = new Sttudent[] { obj1 };


            Cclass obj22 = new Cclass("Cclass6", sttudents44);





            obj22.AddStudent(obj2);




            Cclass[] cclasses66 = new Cclass[] { obj22 };



            Schooll obj8 = new Schooll("Devaki", cclasses66);

            obj8.Sinfor();
        }
    }
}