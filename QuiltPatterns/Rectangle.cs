using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltPatterns
{
    public class Rectangle : Shape
    {
        // This class handles Rectangles and creating them, inheriting from Shape.
        public Rectangle(string color, double length, double width)
        {
            Name = "rectangle";
            Color = color;
            Area = getArea(length, width);
        }

        // Create a Rectangle by getting its color and two side lengths.
        public static Shape MakeRectangle()
        {
            Console.WriteLine("Your quilt pattern is a rectangle.");
            Console.WriteLine("What color is it?");
            var color = IOProcessor.GetLowercaseString();
            var length = IOProcessor.GetSide(1);
            var width = IOProcessor.GetSide(2);
            Console.WriteLine("\nThanks! Your rectangle has been saved.\n");

            return new Rectangle(color, length, width);
        }
    }
}
