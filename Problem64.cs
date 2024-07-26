using System;
namespace ConsoleApp
{
    public class Problem64
    {
        public int sasa (int []arr)
        {
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
            return Smallest;
        }
    }
    public static void solution()
    {
        Problem64 obj = new Problem64();
        int ans = obj.sasa([3,2,9,1]);
        Console.WriteLine(ans);
    }
}}