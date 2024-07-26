using System;
namespace ConsoleApp
{
    public class Problem13
    {   
        public static void solution()
        {
            int i,j,k;
             for(i=1; i<=15; i++)
               {
                 for(j=15; j>=i; j--)
                  {
                     Console.Write("   ");
                  }
                    for(k=1; k<=i; k++)
                    {
                       Console.Write(" * ");
                    }
                    for(int l=i-1; l>=1; l--)
                     {
                        Console.Write(" * ");
                     }
                      Console.Write("\n");
               }
        }
    }
}