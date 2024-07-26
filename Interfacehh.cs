using InterfaceExample;

namespace Interfacehh
{
    public interface Writeable
    {
        public string write();
    }

    public interface Erasable
    {
        public string erase();

    }



    public class NatarajPencilp1 : Writeable, Erasable
    {
        public string write()
        {
            return "hello it's me natraj p1 ";
        }

        public string erase()
        {
            return "some erase by p1";
        }
    }

    public class NatarajPencilp2 : Writeable
    {
        public string write()
        {
            return "some write bye Natraj p2";
        }
    }


    public class DOMSPencil66 : Writeable, Erasable
    {
        public string write()
        {
            
            return "Hello i am Doms";
        }

        public string erase()
        {
            return "some erase";
        }
    }

    public class Interfaceproblem
    {
        public static void solution()
        {
            Writeable p1;
            string userOption = Console.ReadLine();

            if (userOption == "1")
            {
                p1 = new NatarajPencilp1();
            }
            else if (userOption == "2")
            {
                p1 = new NatarajPencilp2();
            }
            else
            {
                p1 = new DOMSPencil66();
            }
            p1.write();

            Erasable e1;
            string eraserOption = Console.ReadLine();

            if (userOption == "1")
            {
                e1 = new NatarajPencilp1();
            }

            else
            {
                e1 = new DOMSPencil66();
            }

            e1.erase();

            DOMSPencil66 ppt = new DOMSPencil66();
            ppt.write();
            ppt.erase();
        }


    }
}