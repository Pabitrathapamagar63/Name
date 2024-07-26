using System;
namespace ConsoleApp
{
   public class Problem9
   {
    public static void solution()
    {
        int i,j;
        for(i=1; i<=6; i++)
        {
            for(j=6; j>=i; j--)
            {
                Console.Write(" * ");
            }
            Console.Write("\n");
        }
    }
   } 
}