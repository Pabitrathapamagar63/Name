using System;
using System.Drawing;
namespace ConsoleApp
{
    public class Problem49
    {
        public static void solution()
        {
            
            Console.WriteLine("Enter the value of a");
            int a= Int32.Parse(Console.ReadLine());

             Console.WriteLine("Enter the value of b");
            int b= Int32.Parse(Console.ReadLine());

            string A= String.Format("the value of a is {0} and b is {1}.",a,b);
            Console.WriteLine(A);
             
             int sum = a + b;
             Console.WriteLine(sum);


            
        }
    }
}