using System;
namespace ConsoleApp
{
    public class Problem10
    {
        public static void solution()
        {
            int i,j;
            for( i=1; i<=10; i++)
            {
                for( j=1; j<=10; j++)
                {
                  if(i==1||i==10||j==1||j==10)
                  {
                    Console.Write(" * ");
                  }
                  else
                  {
                    Console.Write("   ");
                  }
                }
                Console.Write("\n");
            }
        }
    }
}