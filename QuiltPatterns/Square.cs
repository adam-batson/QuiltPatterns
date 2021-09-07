using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltPatterns
{
    public class Square : Shape
    {
        // This class handles Squares and creating them, inheriting from Shape.
        public Square(string color, double num)
        {
            Name = "square";
            Color = color;
            Area = getArea(num);
        }

        // Create a Square by getting its color and one side lengths.
        public static Shape MakeSquare()
        {
            Console.WriteLine("Your quilt pattern is square.");
            Console.WriteLine("What color is it?");
            var color = IOProcessor.GetLowercaseString();
            Console.WriteLine("What is the length of a side?");
            var side = IOProcessor.GetSide(1);
            Console.WriteLine("\nThanks! Your square has been saved.\n");

            return new Square(color, side);
        }
    }
}
