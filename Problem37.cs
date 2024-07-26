using System;
namespace ConsoleApp
{
    public class Problem37
    {
     public static void solution()
    {
         int []arr1 ={30, 63, 53, 60};
         int i;
         int []arr2 = new int [4];
         //int arr.length=length(arr)
         int length= arr1.Length;
         for(i=arr1.Length; i>=0; i--)
         {
          arr2 [0]= arr1 [3];
          arr2 [1]= arr1 [2];
          arr2 [2]= arr1 [1];
          arr2 [3]= arr1 [0];

         }

         {
            Console.WriteLine(arr2[0]);
            Console.WriteLine(arr2[1]);
            Console.WriteLine(arr2[2]);
            Console.WriteLine(arr2[3]);
         }
         Console.ReadLine();
    }
    }
}      