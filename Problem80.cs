using System;
namespace ConsoleApp
{
    abstract class Employee
    {
        public abstract double calculatesalary(int numberofmonths);
    }
    class Permanentemployee : Employee
    {
        double Bonus;
        double Monthlysalary;




        public Permanentemployee(double m, double n)
        {
            this.Bonus = m;
            this.Monthlysalary = n;
        }
        // public new double calculatesalary(double numberofmonths)
        // {
        //     Console.WriteLine(numberofmonths);
        // }

        public override double calculatesalary(int numberofmonths)
        {

            if (numberofmonths < 12)
            {
                double k = (Monthlysalary) * (numberofmonths);
                return k;

            }
            else
            {
                double u = (Monthlysalary * 12) + Bonus;
                return u;
            }


        }
    }
    class Rara
    {
        public static void solution()
        {
            Permanentemployee obj = new Permanentemployee(1000, 60000);
            // Console.WriteLine(numberofmonths);
            double p = obj.calculatesalary(11);
            obj.calculatesalary(5);
            obj.calculatesalary(12);
            Console.Write("Prabisha:");
            Console.WriteLine(p);

        }
    }
}