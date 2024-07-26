using System;
namespace ConsoleApp
{

    public class Problem67
    {
        public bool momo(int i)
        {

            if (i % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void solution()
        {
            Problem67 obj = new Problem67();
            bool ans = obj.momo(2000);
            Console.WriteLine(ans);
        }

    }
}