using System;
namespace ConsoleApp
{
    public class Problem14
    {
        public static void solution()
        {
            int i,j,k;
            for(i=1; i<=9; i++)
            {
                for(j=1; j<=i; j++)
                {
                    Console.Write("   ");
                }
                for(k=9; k>=i; k--)
                {
                    Console.Write(" * ");
                }
                Console.Write("\n");
            }
        }
    }
}