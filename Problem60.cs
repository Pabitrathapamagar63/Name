using System;
namespace ConsoleApp
{
    public class Problem60
    {
        public int birth(int i)
        {
            int age = 2024 - i;
            return age;

        }
        public static void solution()
        {
            Problem60 obj = new Problem60();
            int ans = obj.birth(2000);
            Console.WriteLine(ans);
        }

    }
}