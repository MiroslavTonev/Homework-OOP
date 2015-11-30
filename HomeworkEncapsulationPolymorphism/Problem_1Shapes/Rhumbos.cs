using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_1Shapes
{
    public class Rhombus : BasicShape
    {
        public Rhombus (double height, double width) : base (height, width)
        {

        }
        public override double CalculateArea()
        {
            return this.Widht * this.Height;
        }

        public override double CalculatePerimetre()
        {
            return this.Widht * 4;
        }
    }
}
