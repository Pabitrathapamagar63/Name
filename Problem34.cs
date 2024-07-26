using System;

namespace ConsoleApp 
{
public class Problem34
 {
     public static void solution()
      {
       // create an array
      int[] numbers = {1, 2, 3};

      Console.WriteLine("Old Value at index 0: " + numbers[0]);

      // change the value at index 0
      numbers[0] = 11;

      //print new value
      Console.WriteLine("New Value at index 0: " + numbers[0]);

      Console.ReadLine();
    }
  }
}