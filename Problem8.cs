using System;
namespace ConsoleApp
{
   public class Problem8
   {
    public static void solution()
    {
        int i,j;
        for(i=1; i<=5; i++)
        {
            for(j=1; j<=i; j++)
            {
                Console.Write(" * ");
            }
            Console.Write("\n");
        }
    }
   } 
}