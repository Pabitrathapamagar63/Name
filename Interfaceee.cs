using InterfaceExample;

namespace Interface
{
    public interface Writeable
    {
        public string write();
    }

    public interface Erasable
    {
        public String erase();
    }


    public class NatarajPencilN1 : Writeable, Erasable

    {
        public string write()
        {
            return "hello it's me nataraj N1";
        }

        public string erase()
        {
            return "erase some text";
        }


    }

    public class NatarajPencilN2 : Writeable
    {
        public string write()
        {
            return "it's me pencil";
        }
    }

    public class DOMSPencil123 : Writeable, Erasable
    {
        public string write()
        {
            return "written text";
        }

        public string erase()
        {
            return "Hello i am Doms";
        }
    }

    public class InterfaceProblemm
    {

    }
}
