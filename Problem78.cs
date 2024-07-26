using System;
namespace ConsoleApp
{
    public class Shape

    {
        public float calculateArea()
        {
            return 0;
        }
        public float calculateperimeter()
        {
            return 0;
        }

    }

    class Triangle : Shape
    {
        double Base;
        double height;


        public Triangle(double b, double h)
        {
            this.Base = b;
            this.height = h;
        }

        public new double calculateArea()
        {
            // this.Base = b;
            // this.height = height;
            double Area = (1.0 / 2) * Base * height;
            return Area;
        }
    }
    class Circle : Shape
    {
        double radius;

        public Circle(double r)
        {
            this.radius = r;
        }
        public new double calculateArea()
        {
            double Area = 3.14 * Math.Pow(radius, 2);
            return Area;
        }
        public new double calculateperimeter()
        {
            double perimeter = 2 * 3.14 * this.radius;
            return perimeter;
        }
    }

    class Popo
    {
        public void solution()
        {
            Triangle obj = new Triangle(9.45867537, 3.45);
            double ans = obj.calculateArea();
            Console.WriteLine(ans);

            Circle obj1 = new Circle(6.33);
            double ans1 = obj1.calculateArea();
            Console.WriteLine(ans1);
            double ans2 = obj1.calculateperimeter();
            Console.WriteLine(ans2);
        }
    }
}