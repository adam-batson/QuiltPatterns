using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltPatterns
{
    public abstract class Shape
    {
        // This class handles shapes and getting areas for shapes.
        public string Name { get; set; }
        public string Color { get; set; }
        public double Area { get; set; }

        // Return area for a square when given one side length.
        public virtual double getArea(double side)
        {
            return side * side;
        }

        // Return area for a rectangle when given two side lengths.
        public virtual double getArea(double l, double w)
        {
            return l * w;
        }

        // Return area for a triangle using Heron's Formula when given three side lengths.
        public virtual double getArea(double a, double b, double c)
        {
            var s = (a + b + c) / 2.0d;
            var x = s - a;
            var y = s - b;
            var z = s - c;
            return Math.Sqrt(s * x * y * z);
        }
    }
}
