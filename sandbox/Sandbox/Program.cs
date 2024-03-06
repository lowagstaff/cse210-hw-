using System;
using System.Drawing;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Circle c = new Circle("Blue", 4);
        Square s = new Square("Black", 3);
        Rectangle r = new Rectangle("Red", 5, 6);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(c);
        shapes.Add(s);
        shapes.Add(r);

        foreach (Shape sh in shapes)
        {
            string color = sh.GetColor();
            double area = sh.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }


}