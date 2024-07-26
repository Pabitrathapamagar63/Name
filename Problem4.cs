using System;
namespace ConsoleApp
{
    public class Problem4
    {
        public static void solution()
        {
            int i, sum=0;
            for( i=1; i<=10; i++)
            {
                sum = sum + i;
            }
            Console.Write(sum);
        }
    }
}