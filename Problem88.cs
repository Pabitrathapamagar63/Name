using System;
namespace ConsoleApp
{
    public class Doctor
    {
        public int Did;
        public string Dname;

        public Doctor(int did, string dname)
        {
            Did = did;
            Dname = dname;

        }
        public void doctorInfo()
        {
            Console.WriteLine($"Did:{Did}, Dname:{Dname}");
        }
    }


    public class Departmentt
    {
        public string Departmenttname;

        public Doctor[] Doctors;

        public Departmentt(string departmenttname, Doctor[] doctors)
        {
            Departmenttname = departmenttname;
            Doctors = doctors;
        }

        public void DepartmentInfo()
        {
            Console.WriteLine($"Departmentname:{Departmenttname}");
            Console.WriteLine("Doctor:");
            foreach (var Doctor in Doctors)
            {
                Doctor.doctorInfo();
            }
        }
    }

    public class Hospital
    {
        public string Hname;
        public int Hid;

        public Departmentt[] Departmentts;

        public Hospital(string hname, int hid, Departmentt[] departmentts)
        {
            Hname = hname;
            Hid = hid;
            Departmentts = departmentts;

        }

        public void HospitalInfo()
        {
            Console.WriteLine($"Hname:{Hname}, Hid:{Hid}");
            Console.WriteLine("Departments");
            foreach (var Departmentt in Departmentts)
            {
                Departmentt.DepartmentInfo();
            }

        }
    }


    public class Problem88
    {
        public static void solution()
        {
            Doctor obj = new Doctor(1, "Smarika");
            Doctor obj1 = new Doctor(2, "Aakash");

            Doctor[] doctors11 = new Doctor[] { obj };
            Doctor[] doctors12 = new Doctor[] { obj1 };


            Departmentt obj9 = new Departmentt("Cardiologist", doctors11);
            Departmentt obj7 = new Departmentt("Neurologist", doctors12);
            Departmentt[] departmentts44 = new Departmentt[] { obj9, obj7 };


            Hospital objj = new Hospital("Hetaudahospital", 96, departmentts44);
            objj.HospitalInfo();



        }
    }


}