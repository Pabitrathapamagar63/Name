using System;
namespace ConsoleApp
{
    public class Problem62
    {
        public int calculation(int i, int j)
        {
            int sub = i - j;
            return sub;
        }
        public static void solution()
        {
            Problem62 obj = new Problem62();
            int ans = obj.calculation(2024, 2000);
            Console.WriteLine(ans);

        }
    }
}