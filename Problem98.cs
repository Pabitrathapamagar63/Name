using System;
using ConsoleApp;
using ConsoleApps;
namespace ConsoleAppps
{
    public class Nurse11
    {
        public string NurseName;
        public int Age;
        public int NurseId;
        public Nurse11(string nursename, int age, int nurseid)
        {
            this.NurseName = nursename;
            this.Age = age;
            this.NurseId = nurseid;
        }
        public void ShowNurse11()
        {
            Console.WriteLine($"NurseName:{NurseName}, Age:{Age}, NurseId:{NurseId}");
        }
    }

    public class Nurse12
    {
        public string NurseName;
        public int Age;
        public int NurseId;
        public Nurse12(string nursename, int age, int nurseid)
        {
            this.NurseName = nursename;
            this.Age = age;
            this.NurseId = nurseid;
        }
        public void ShowNurse12()
        {
            Console.WriteLine($"NurseName:{NurseName}, Age:{Age}, NurseId:{NurseId}");
        }
    }


    public class Department
    {
        public string DepartmentName;

        public Department(string departmentname)
        {
            this.DepartmentName = departmentname;
        }

        public void ShowDepartment()
        {
            Console.WriteLine($"Departmentname:{DepartmentName}");
        }

    }

    public class AnimalDoctor : Department
    {
        public string DoctorName;
        public int Doctorid;
        public int Age;
        public AnimalDoctor(string departmentname, string doctorname, int doctorid, int age) : base(departmentname)
        {
            this.DoctorName = doctorname;
            this.Doctorid = doctorid;
            this.Age = age;

        }

        public void ShowAnimalDoctorInfo()
        {
            Console.WriteLine($"DoctorName:{DoctorName}, Doctorid:{Doctorid}, Age:{Age}");
        }
    }

    public class HumanDoctor : Department
    {
        public string DoctorName;
        public int Doctorid;
        public int Age;
        public HumanDoctor(string departmentname, string doctorname, int doctorid, int age) : base(departmentname)
        {
            this.DoctorName = doctorname;
            this.Doctorid = doctorid;
            this.Age = age;
        }
        public void ShowHumanINfo()
        {
            Console.WriteLine($"DoctorName:{DoctorName}, Doctorid:{Doctorid}, Age:{Age}");
        }

    }

    public class Doctor<T, P>
    {
        public int Id;
        public T[] Nurses;
        public P Names;

        public Doctor(int id, P names, T[] nurses)
        {
            this.Id = id;
            this.Names = names;
            this.Nurses = nurses;
        }

        public void showDoctorsInfo()
        {
            Console.WriteLine($"Id:{Id}");
            if (Names is Department department)
            {
                department.ShowDepartment();

                if (Names is AnimalDoctor AnimalDoctor)
                {
                    AnimalDoctor.ShowAnimalDoctorInfo();
                }
            }
            Console.WriteLine($"Nurse:");
            foreach (var nurses in Nurses)
            {
                if (nurses is Nurse11 JJ)
                {
                    JJ.ShowNurse11();
                }
                else if (nurses is Nurse12 Ss)
                {
                    Ss.ShowNurse12();
                }

            }
        }
    }

    public class Problem98
    {
        public static void solution()
        {
            Nurse11 obj = new Nurse11("Sneha Thakuri", 20, 1);
            Nurse11 obj1 = new Nurse11("Ramesh Lama", 22, 2);
            AnimalDoctor objrr = new AnimalDoctor("Animal Care", "Prabisha", 44, 32);
            Nurse11[] pp = new Nurse11[] { obj, obj1 };
            Doctor<Nurse11, AnimalDoctor> obj2 = new Doctor<Nurse11, AnimalDoctor>(12, objrr, pp);

            Nurse12 obj7 = new Nurse12("Avinash", 30, 3);
            Nurse12 obj3 = new Nurse12("Rahul", 24, 7);
            HumanDoctor objpp = new HumanDoctor("Animal Care", "NIsha", 54, 22);
            Nurse12[] hh = new Nurse12[] { obj7, obj3 };
            Doctor<Nurse12, HumanDoctor> obj27 = new Doctor<Nurse12, HumanDoctor>(12, objpp, hh);

            obj2.showDoctorsInfo();
            obj27.showDoctorsInfo();
        }
    }
}