using System;
namespace ConsoleApp
{
    public class Animals
    {
        public void MakeSound()
        {
            Console.WriteLine("some animal sound ");

        }
    }

    class Dog : Animals
    {
        public new void MakeSound()
        {
            Console.WriteLine("bark");
        }
    }

    class Cat : Animals
    {
        public new void MakeSound()
        {
            Console.WriteLine("Meow");
        }

    }

    class Koko
    {
        public static void solution()
        {
            Cat obj = new Cat();
            obj.MakeSound();
            Dog obj2 = new Dog();
            obj2.MakeSound();

        }
    }
}