using System;
namespace ConsoleApp
{
 public class Problem48
 {
    public static void solution()
    {
        Console.WriteLine("Enter the value of p");
        string p= Console.ReadLine();

        Console.WriteLine("Enter the value of q");
        string q= Console.ReadLine();


        String h=  String.Format("{0} likes to code in {1}",p,q);
        Console.WriteLine(h);
    }
 }   
}