using System;
namespace ConsoleApp
{
    public class Problem70
    {
        public double nana(int m, float r)
        {
            double I = m * Math.Pow(r, 2);
            return I;

        }
        public static void solution()
        {
            Problem70 obj = new Problem70();
            double Ans = obj.nana(87, 9.9f);
            Console.WriteLine(Ans);
        }
    }
}