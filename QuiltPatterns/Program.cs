using System;

namespace QuiltPatterns
{
    class Program
    {
        // Track when user wants to exit program.
        public static bool exit = false;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your Quilt Pattern Storage!\n\n");

            // Allows process to repeat until the user chooses to exit the program.
            while (exit == false)
            {
                // Display a list of shape choices for the user to choose from.
                IOProcessor.DisplayShapeChoices();

                // Send to get user input and convert to lowercase.
                var choice = IOProcessor.GetLowercaseString();

                // Only passes the first letter in case the whole word was entered.
                IOProcessor.ShapeChoice(choice.Substring(0,1));
            }

            


        }
    }
}
