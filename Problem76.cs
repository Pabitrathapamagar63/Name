using System;
namespace ConsoleApp
{
    class Problem76
    {
        public string firstname;
        public string lastname;

        public Problem76(string firstname, string lastnames)
        {
            this.firstname = firstname;
            this.lastname = lastnames;
        }
        public void showfullname()
        {
            Console.WriteLine("firstname:" + firstname + "lastname:" + lastname);
        }


        public static void solution()
        {
            Problem76 p = new Problem76("Pabitra", "thapa");
            Problem76 q = new Problem76("Nisha", "shreshtha");
            Problem76 r = new Problem76("Namrata", "rana");
            Problem76 s = new Problem76("Prabisha", "pakhrin");

            p.showfullname();
            q.showfullname();
            r.showfullname();
            s.showfullname();


        }
    }

}