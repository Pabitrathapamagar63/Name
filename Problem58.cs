using System;

namespace ConsoleApp
{
    public class Problem58
    {
        public static void PrintFullName(String firstName, String lastName)
        {
            String fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
        }

        public static String GetFullName(String firstName, String lastName)
        {
            String fullName = firstName + " " + lastName;
            return fullName;
        }

        public static String GetFullName(String firstName)
        {
            return firstName;
        }
    }
}