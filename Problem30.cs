using System;
namespace ConsoleApp
{
    public class Problem30
    {
         
  public static void solution()
        {
         int []arr =[4,6,7,5,2,9];
         int Largest=arr[0];
         int i;
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