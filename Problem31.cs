using System;

namespace ConsoleApp {
 public class Problem31 {
    public static void solution()
     {

      int[] numbers = { 1, 2, 3};
 	 
      for(int i=0; i < numbers.Length; i++) {
        Console.WriteLine("Element in index " + i + ": " + numbers[i]);
      }

      Console.ReadLine();
    }
  }
}