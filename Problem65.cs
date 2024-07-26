using System;
namespace ConsoleApp
{
    public class Problem65
    {
        public int sasa (int []arr)
        {
        int Largest=arr[0];
         //int arr.length=length(arr)
         int length= arr.Length;
         {
            for( int i=1; i<arr.Length; i++)
            {
              if(arr[i]>Largest)
                {
                    Largest = arr [i];
                }
            }
            return Largest;
         }
    }
    public static void solution()
    {
        Problem65 obj = new Problem65();
        int ans = obj.sasa([3,2,9,1]);
        Console.WriteLine(ans);
    }
}}