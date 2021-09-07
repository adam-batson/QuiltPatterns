using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltPatterns
{
    // This class handle input and output operations.

    public class IOProcessor
    { 
        // List to store saved shapes.
        private static readonly List<Shape> shapes = new();

        // Display available shapes and asks user for a choice.
        public static void DisplayShapeChoices()
        {
            Console.WriteLine("Add square pattern (Enter S)");
            Console.WriteLine("Add rectangle pattern (Enter R)");
            Console.WriteLine("Add triangle pattern (Enter T)");
            Console.WriteLine("Print pattern list (Enter L)");
            Console.WriteLine("Exit the program (Enter Q)");
            Console.WriteLine("Select an option:");
        }

        // Take user choice and create a shape based on the choice.
        public static void ShapeChoice(string choice)
        {
            switch (choice)
            {
                case "s": // Create a new Square and add it to the shapes list.
                    shapes.Add(Square.MakeSquare());
                    break;
                case "t": // Create a new Triangle and add it to the shapes list.
                    shapes.Add(Triangle.MakeTriangle());
                    break;
                case "r": // Create a new Rectangle and add it to the shapes list.
                    shapes.Add(Rectangle.MakeRectangle());
                    break;
                case "l": // Print the list of shapes with color and area.
                    if (shapes.Count != 0)
                    {
                        Console.WriteLine("The patterns you have stored are: ");
                        foreach (var shape in shapes)
                        {
                            Console.WriteLine($"A {shape.Color} {shape.Name} with area {shape.Area:0.###} square feet.");
                        }
                        Console.WriteLine();
                    }
                    else // Tell user that no shapes have been stored yet in shapes list.
                    {
                        Console.WriteLine("There are no patterns stored in the list.");
                    }
                    break;
                case "q": // Exit program.
                    Console.WriteLine("\nThank you for using Quilt Pattern Storage!\nExiting program...");
                    Program.exit = true;
                    break;
                default: // Handle input that doesn't correspond to a shape.
                    Console.WriteLine("\nThat's not a valid shape for this program.\n");
                    DisplayShapeChoices();
                    choice = IOProcessor.GetLowercaseString();
                    ShapeChoice(choice.Substring(0,1));
                    break;
            }
        }

        // Get input as a lowercase string for easier processing
        public static string GetLowercaseString()
        {
            return Console.ReadLine().ToLower();
        }

        // Verify input is a number and return as a double
        public static double DoubleValidation(string num)
        {
            double output;
            while(!double.TryParse(num, out output))
            {
                Console.WriteLine("Input needs to be a number. Please enter a number: ");
                num = Console.ReadLine();
            }
            return output;
        }

        // Ask for the length of a shape's side
        public static double GetSide(int num)
        {
            Console.WriteLine($"Enter the length (in feet) of side {num}:");
            double output = DoubleValidation(Console.ReadLine());
            return output;
        }
    }
}
