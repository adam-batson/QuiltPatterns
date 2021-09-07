using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltPatterns
{
    public class Triangle : Shape
    {
        // This class handles Triangles and creating them, inheriting from Shape.
        public Triangle(string color, double a, double b, double c)
        {
            Name = "triangle";
            Color = color;
            Area = getArea(a, b, c);
        }

        // Create a Triangle by getting its color and three side lengths.
        public static Shape MakeTriangle()
        {
            Console.WriteLine("Your quilt pattern is a triangle.");
            Console.WriteLine("What color is it?");
            var color = IOProcessor.GetLowercaseString();
            var a = IOProcessor.GetSide(1);
            var b = IOProcessor.GetSide(2);
            var c = IOProcessor.GetSide(3);
            Console.WriteLine("\nThanks! Your triangle has been saved.\n");

            return new Triangle(color, a, b, c);
        }
    }
}
