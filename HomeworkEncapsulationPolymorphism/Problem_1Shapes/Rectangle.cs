using System;

namespace Problem_1Shapes
{
    public class Rectangle : BasicShape
    {
        public Rectangle (double height, double width) : base (height, width)
        {

        }

        public override double CalculateArea()
        {
            return this.Height * this.Widht;
        }

        public override double CalculatePerimetre()
        {
            return 2 * (this.Height + this.Widht);
        }
    }
}
