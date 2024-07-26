using System;
namespace ConsoleApp
{
    public class Problem56
    {
        public void mood( int i, int j)
        {
            int result = i+j;
            Console.WriteLine(result);
        }
        public static void solution()
        {
            Problem56 obj = new Problem56();
            obj.mood(40,60);
            Console.ReadLine();
        }

    }
}