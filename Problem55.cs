using System;
namespace ConsoleApp
{
    public class Problem55
    {
        public static void solution()
        {
            int []a= {4,1,9,0};
            int i;
            for(i=0; i<=a.Length; i++)
            {
             string strFormat = String.Format("the value of item at{0}is{1}.",i,a[i]);
             Console.WriteLine(strFormat);
            }
        }
    }
}