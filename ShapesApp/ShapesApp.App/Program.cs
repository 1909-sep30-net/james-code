using System;

namespace ShapesApp.App
{
    static class Program
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

            double width;
            do
            {
                Console.WriteLine("Enter a Width: ");
                input = Console.ReadLine();
            } while (!double.TryParse(input, out width));

            var rectangle = new Rectangle
            {
                Length = length,
                Width = width
            };

            rectangle.PrintRectangle();

            double radius;
            do
            {
                Console.WriteLine("Enter a radius: ");
                input = Console.ReadLine();
            } while (!double.TryParse(input, out radius));

            ColorCircle colorCircle = new ColorCircle(radius: radius, colorCircle: "black");

            Console.WriteLine(colorCircle.GetPerimeter());

            Console.WriteLine(ShapeDetails(colorCircle));
        }

        public static void PrintRectangle(this Rectangle r)
        {
            Console.WriteLine($"{r.Length}x{r.Width} rectangle ({ShapeDetails(r)})");
            10.ToString();
            int thirtythree = 10.Triple(3);
        }

        public static string ShapeDetails(IShape shape)
        {
            return $"area {shape.Area}, perimeter {shape.GetPerimeter()}, {shape.Sides}";
        }
    }
}
