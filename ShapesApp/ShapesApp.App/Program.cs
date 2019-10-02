using System;

namespace ShapesApp.App
{
    class Program
    {
        static void Main(string[] args)
        {
            double length;
            string input;

            do
            {
                Console.WriteLine("Enter a Length: ");
                input = Console.ReadLine();
            } while (!double.TryParse(input, out length));
        }
    }
