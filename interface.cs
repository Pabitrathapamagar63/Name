namespace InterfaceExample
{
    public interface Writeable
    {
        public String write();
    }

    public interface Erasable
    {
        public void erase();
    }

    public abstract class DigitalPen
    {
        public int batteryLifeInHours;
        public abstract string write();
    }

    public interface WaterDispenser
    {
        public double dispenseWater();
    }

    public class ApplePen : DigitalPen
    {
        public ApplePen()
        {
            this.batteryLifeInHours = 48;
        }

        public override string write()
        {
            return "Hello, I am an Apple Pen";
        }
    }

    public class AndroidPen : DigitalPen
    {
        public AndroidPen()
        {
            this.batteryLifeInHours = 40;
        }

        public override string write()
        {
            return "Hello, I am an Android Pen";
        }
    }

    public class NatarajPencilM1 : Writeable, Erasable
    {
        public string write()
        {
            return "Hello, I am a M1 Nataraj pencil";
        }

        public void erase()
        {
            Console.WriteLine("Erased some text by M1 Nataraj pencil");
        }
    }

    public class NatarajPencilM2 : Writeable
    {
        public string write()
        {
            return "Hello, I am a M2 Nataraj Pencil";
        }
    }

    public class DOMSPencil : Writeable, Erasable
    {
        public string write()
        {
            return "Hello, I am DOMS pencil";
        }

        public void erase()
        {
            Console.WriteLine("Erased some text by DOMS pencil");
        }
    }

    public class InterfaceProblem
    {
        public static void solution()
        {
            Writeable p1;
            String userOption = Console.ReadLine();

            if (userOption == "1")
            {
                p1 = new NatarajPencilM1();
            }
            else if (userOption == "2")
            {
                p1 = new NatarajPencilM2();
            }
            else
            {
                p1 = new DOMSPencil();
            }

            p1.write();

            Erasable e1;

            String eraserOption = Console.ReadLine();

            if (userOption == "1")
            {
                e1 = new NatarajPencilM1();
            }
            else
            {
                e1 = new DOMSPencil();
            }

            e1.erase();


            // NatarajPencil np1 = new NatarajPencil();
            // np1.write();

            DOMSPencil dp2 = new DOMSPencil();
            dp2.write();
            dp2.erase();
        }
    }
}