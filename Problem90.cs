using System;
namespace ConsoleApp
{
    public class Data
    {
        public void Datainfo()
        {

            int[] arr = new int[5];

            arr[0] = arr[10];
            arr[1] = arr[20];
            arr[2] = arr[30];
            arr[3] = arr[40];
            arr[4] = arr[50];



            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(i);
            }

        }

    }
}