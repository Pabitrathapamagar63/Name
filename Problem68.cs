using System;
namespace ConsoleApp
{
    public class Problem68
    {
        public float momo(int f)
        {
            float c = (f - 32) / 1.8f;
            return c;

        }

        public static void solution()
        {
            Problem68 obj = new Problem68();
            float ans = obj.momo(90);
            Console.WriteLine(ans);
        }
    }
}