using System;
namespace ConsoleApp
{
    public class Problem66
    {
        public float sasa(int[] arr)
        {

            float sum = arr.Sum();

            int count = arr.Count();

            float average = sum / count;
            return average;

        }

        public static void Solution()
        {
            Problem66 obj = new Problem66();

            float ans = obj.sasa([80, 26, 89, 91]);
            Console.WriteLine(ans);
        }
    }
}