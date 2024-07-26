using System;
namespace ConsoleApp
{
    public class Problem69
    {
        public double momo(int m1, int m2, float r)
        {
            double F = 6.67 * Math.Pow(10, -11) * ((m1 - m2) / Math.Pow(r, 2));
            return F;
        }

        public static void solution()
        {
            Problem69 obj = new Problem69();
            double ans = obj.momo(87, 70, 5.5f);
            Console.WriteLine(ans);
        }
    }
}