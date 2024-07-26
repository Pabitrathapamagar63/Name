using System;
namespace ConsoleApp
{
    public class Problem27
    {
         
  public static void solution()
        {
         int []arr =[10,2,30,4,5];
         int Smallest=arr[0];
         //int arr.length=length(arr)
         int length= arr.Length;
         {
            for(int i=1; i<arr.Length; i++)
            {
              if(arr[i]<Smallest)
                {
                    Smallest = arr [i];
                }
            }
            Console.WriteLine(Smallest);
         }
        }
    }
}            