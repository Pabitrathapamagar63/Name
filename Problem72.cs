using System;
namespace ConsoleApp
{
    public class Problem72
    {
        public double sisi(int m, int v)
        {
            double Kinetic = (1 / 2) * m * Math.Pow(v, 2);
            return Kinetic;

        }
        public static void solution()
        {
            Problem72 obj = new Problem72();
            double ans = obj.sisi(76, 10);
            Console.WriteLine(ans);
        }
    }
}
