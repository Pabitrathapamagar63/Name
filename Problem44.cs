using System;  

namespace ConsoleApp
{
 public class Problem44 {
    public static void solution()
     {
      int number = 8;
      int a=3;
      int b=4;
      // Format string
      string strFormat = String.Format("{0}{1}{2}.", number,a,b);
      Console.WriteLine(strFormat);
    }
  } 
}