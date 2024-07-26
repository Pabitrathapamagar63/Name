using System;
using System.Diagnostics.Contracts;
namespace ConsoleApp
{
    class Problem81
    {
        public static void solution()
        {
            Contractemployee obj = new Contractemployee(20000);
            double o = obj.calculatesalary(11);
            Console.WriteLine(o);


        }




        abstract class Employee
        {
            public abstract double calculatesalary(int numberofhour);
            public double salary;

        }

        class Contractemployee : Employee
        {
            double hoursalary;


            public Contractemployee(double a)
            {
                this.hoursalary = a;
            }
            public override double calculatesalary(int numberofhour)
            {

                double d = (hoursalary) * (numberofhour);
                return d;
            }


        }
    }
}