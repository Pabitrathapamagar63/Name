using System;
namespace ConsoleApp
{
    public class Problem53
{
    public static void solution()
    {
        int[] inputarrary={ 10,20,30,40,50};
        string a="*";
        string finalresult="int:";
        finalresult += string.Join(a,inputarrary);
        Console.WriteLine($"result:{finalresult}");
    }
}

}