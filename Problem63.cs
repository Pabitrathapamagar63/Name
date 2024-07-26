using System;
namespace ConsoleApp
{
    public class Problem63
    {
        public bool sasa(int a)
        {
            if (a % 2 == 0)
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
            Problem63 obj = new Problem63();
            bool Ans = obj.sasa(70);
            Console.WriteLine(Ans);

        }
    }
}