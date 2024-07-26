using System;
namespace ConsoleApp
{
    public class Problem73
    {
        public double sisi(int m, int h)
        {
            double U = (m * 9.8 * h);
            return U;

        }
        public static void solution()
        {
            Problem73 obj = new Problem73();
            double ans = obj.sisi(76, 10);
            Console.WriteLine(ans);
        }
    }
}
