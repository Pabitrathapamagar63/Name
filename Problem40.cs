using System;
namespace ConsoleApp
{

class Problem40 {
  public static void solution() {
    // String Interpolation
    string a = "Mumbai";
    string b = "India";
    
    // Use string interpolation to concatenate strings.
    string cityOfcountry = $"{a} is a city in {b}.";
    Console.WriteLine(cityOfcountry);
  }
}
}