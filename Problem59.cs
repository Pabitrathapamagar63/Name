using System;
namespace ConsoleApp
{
    public class Problem59
    {
        public int birth ( int i, int j)
        {
            int age = i-j;
            return age;
        }
        public static void solution()
        {
            Problem59 obj = new Problem59();
           int ans= obj.birth(2024, 2000);
            Console.WriteLine(ans);

        }
    }
}