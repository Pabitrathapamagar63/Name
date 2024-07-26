using System;

namespace ConsoleApp 
{
public class Problem36
 {
     public static void solution()
      {
       // create an array
      int[] numbers = {30, 31, 94, 86, 55};

      Console.WriteLine("Old Value at index 0: " + numbers[0]);

      // change the value at index 0
      numbers[0] = 55;

      //print new value
      Console.WriteLine("New Value at index 4: " + numbers[4]);




      Console.WriteLine("Old Value at index 1: " + numbers[1]);

      // change the value at index 1
      numbers[1] = 86;

      //print new value
      Console.WriteLine("New Value at index 3: " + numbers[3]);




      Console.WriteLine("Old Value at index 2: " + numbers[2]);

      // change the value at index 2
      numbers[2] = 94;

      //print new value
      Console.WriteLine("New Value at index 2: " + numbers[2]);



      Console.WriteLine("Old Value at index 3: " + numbers[3]);

      // change the value at index 3
      numbers[3] = 31;

      //print new value
      Console.WriteLine("New Value at index 1: " + numbers[1]);


      Console.WriteLine("Old Value at index 4: " + numbers[4]);

      // change the value at index 4
      numbers[4] = 30;

      //print new value
      Console.WriteLine("New Value at index 0: " + numbers[0]);


       Console.ReadLine();
    }
  }
}