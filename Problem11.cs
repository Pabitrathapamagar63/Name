using System;
namespace ConsoleApp
{
    public class Problem11
    {
        public static void solution()
        {
            int i,j,k;
            for( i=1; i<=8; i++)
            {
                for( j=7; j>=i; j--)
                {
                  Console.Write("   "); 
                }
                for( k=1; k<=i; k++)
                {
                    Console.Write(" * ");
                }
                Console.Write("\n");
            }
        }
    }
}