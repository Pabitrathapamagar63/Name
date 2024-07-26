using System;
namespace ConsoleApp
{
    public class Problem57
    {
        public int mood( int i, int j)
        {
            int result = i+j;
            return result;
        }
        public String Everything(string Firstname, string Lastname)
        {
            return $"{Firstname} {Lastname}";
        }
        public static void solution()
        {
            Problem57 obj = new Problem57();
            int ans=obj.mood(900,700);
            Console.WriteLine(ans);
            obj.Everything("Pabitra","magar");
            Console.ReadLine();
        }

    }
}