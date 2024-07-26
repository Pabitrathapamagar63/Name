using System;
namespace ConsoleApp{
class Problem43{
  public static void solution() {
    // Using String.Join(String, String[])
    int[] inputArray = { 89, 78, 34, 76, 34, 21 };
    String sep = "; ";
    string finalresult = "Int: ";
    
    finalresult += String.Join(sep, inputArray);
    Console.WriteLine($"Result: {finalresult}");
  }
}
}