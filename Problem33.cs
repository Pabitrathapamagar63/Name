using System;
namespace ConsoleApp {
  class Problem33  {
    public static void solution() {

      int[] numbers = {30, 31, 94, 86, 55};
 	 
      // get the sum of all array elements
      float sum = numbers.Sum();
 	 
      // get the total number of elements present in the array
      int count = numbers.Count();
 	 
      float average = sum/count;

      Console.WriteLine("Average : " + average);
 	
      // compute the average
      Console.WriteLine("Average using Average() : " + numbers.Average());
 	 
      Console.ReadLine();
    }
  }
}