using System;
namespace ConsoleApp
{
    public class Problem26
    {
         
  public static void solution()
        {
         int []arr =[12,92,43,44,52];
         int i=1;
         int Largest=arr[0];
         //int arr.length=length(arr)
         int length= arr.Length;
         {
            for(i=1; i<arr.Length; i++)
            {
              if(arr[i]>Largest)
                {
                    Largest = arr [i];
                }
            }
            Console.WriteLine(Largest);
         }
        }
    }
}            