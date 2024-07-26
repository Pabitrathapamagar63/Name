using System;
namespace ConsoleApp
{
    public class Vehicle
    {
        public string model = "TATA";
        public string make = "mhgftrdre";
        public int year = 2022;
        public void showProperties()
        {
            Console.WriteLine("model: {0}", model);
            Console.WriteLine("make: {0}", make);
            Console.WriteLine("year: {0}", year);

        }
        public void startengine()
        {
            Console.WriteLine(" engine started");

        }
        public void stopengine()
        {
            Console.WriteLine("engine stoped");
        }
    }
    class Car : Vehicle
    {
        public int NumberOfDoor = 4;
        public bool IsConvertible = true;

        public new void showProperties()
        {
            base.showProperties();
            Console.WriteLine("NumberOfDoors: {0}", NumberOfDoor);
            Console.WriteLine("IsConvertible: {0}", IsConvertible);
        }


        public void OpenTrunk()
        {
            Console.WriteLine(" Trunk Opened");

        }
        public void CloseTrunk()
        {
            Console.WriteLine("Trunk closed");
        }


        public Car(string model, int NumberOfDoor)
        {
            this.model = model;
            this.NumberOfDoor = NumberOfDoor;
        }



    }


    class Program1
    {
        public static void solution()
        {
            Car obj = new Car("TATA", 4);
            Car obj1 = new Car("ALTO", 6);

            obj.showProperties();
            obj.OpenTrunk();
            obj.CloseTrunk();
            obj.startengine();
            obj.stopengine();

            Console.WriteLine();

            obj1.showProperties();
            obj1.OpenTrunk();
            obj1.CloseTrunk();
            obj1.startengine();
            obj1.stopengine();
        }


    }
}













