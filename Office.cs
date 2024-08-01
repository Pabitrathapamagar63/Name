using System;
using System.Diagnostics.SymbolStore;
namespace ConsoleApp
{
    public class Emmployee
    {
        public string Ename;
        public int Eid;

        public Emmployee(string ename, int eid)
        {
            Ename = ename;
            Eid = eid;
        }

        public void EmmployeeInfo()
        {
            Console.WriteLine($"Ename:{Ename}, Eid:{Eid}");
        }
    }



    public class Department
    {
        public string Dname;
        public Emmployee[] Emmployees;

        public Department(string dname, Emmployee[] emmployees)
        {

            Dname = dname;
            Emmployees = emmployees;
        }

        public void DepartmentInfo()
        {
            Console.WriteLine($"Dname:{Dname}");
            Console.WriteLine("Emmployee");
            foreach (var emmployee in Emmployees)
            {
                emmployee.EmmployeeInfo();
            }

        }
    }


    public class Company
    {
        public string Cname;

        public Department[] Departments;

        public Company(string cname, Department[] departments)
        {
            Cname = cname;
            Departments = departments;
        }

        public void CompanyInfo()
        {
            Console.WriteLine($"Cname:{Cname}");
            Console.WriteLine("Departments:");
            foreach (var department in Departments)
            {

                department.DepartmentInfo();

            }
        }
    }



    public class Nono
    {
        public static void solution()
        {
            Emmployee obj = new Emmployee("Alexxa", 1);


            Emmployee[] emmployees22 = new Emmployee[] { obj };
            obj.EmmployeeInfo();



            Department obj1 = new Department("HR", emmployees22);
            obj1.DepartmentInfo();

            Department[] departments77 = new Department[] { obj1 };


            Company obj44 = new Company("Google", departments77);

            obj44.CompanyInfo();


        }
    }
}
