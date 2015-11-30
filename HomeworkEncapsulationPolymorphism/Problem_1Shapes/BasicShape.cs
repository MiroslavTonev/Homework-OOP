using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1Shapes
{
    public abstract class BasicShape : IShape
    {
        public BasicShape(double height, double width)
        {
            this.Height = height;
            this.Widht = width;
        }
        public double Height { get; set; }
        public double Widht { get; set; }
        public abstract double CalculateArea();

        public abstract double CalculatePerimetre();  
    }
}
