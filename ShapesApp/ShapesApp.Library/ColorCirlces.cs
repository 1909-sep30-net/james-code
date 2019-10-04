using System;

namespace ShapesApp.Library
{
    public class ColorCircle : Circle
    {
        public ColorCircle(double radius, string color) : base(radius)
        {
            Color = color;
        }
        public ColorCircle(double radius) : this(radius, "clear")
        {
            
        }
        public string Color { get; set; }
        public override double GetPerimeter()
        {
            Console.WriteLine("calculating perimeter");
            //return 2 * Math.PI * Radius;
            return base.GetPerimeter();
        }
    }
}