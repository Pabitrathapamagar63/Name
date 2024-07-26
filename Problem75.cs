using System;
namespace ConsoleApp
{
    public class Person()
    {
        public string fname = " Pabitra";
        public string fnamea = " Nisha";
        public string fnameb = " Namrata";
        public string fnamec = " Prabisha";
        public string lname = "Magar";
        public string lnamea = "Shreshtha";
        public string lnameb = "Rana";
        public string lnamec = "Pakhrin";

        public void fullname()
        {
            Console.WriteLine(fname + " " + lname);
            Console.WriteLine(fnamea + " " + lnamea);
            Console.WriteLine(fnameb + " " + lnameb);
            Console.WriteLine(fnamec + " " + lnamec);

        }
    }

}
