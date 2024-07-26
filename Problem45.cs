using System;  

namespace ConsoleApp{  
  class Problem45 {
    public static void solution() {

      string name = "Rahul";
      string programmingLanguage = "Csharp";

      // Format the string
      string strFormat = String.Format("{0} likes to code in {1}", name, programmingLanguage);
      Console.WriteLine(strFormat);

      Console.ReadLine();
    }
  } 
}