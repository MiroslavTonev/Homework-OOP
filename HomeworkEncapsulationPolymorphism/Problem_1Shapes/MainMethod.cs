using System;
using System.Collections.Generic;

namespace Problem_1Shapes
{
    public class MainMethod
    {        
        static void Main()
        {
            Circle circle = new Circle(5);
            Circle circle2 = new Circle(6);
            BasicShape rectangle = new Rectangle(4, 5);
            BasicShape rhumbos = new Rhombus(4, 5);
            List<IShape> shapes = new List<IShape>() {circle, circle2, rectangle, rhumbos };
            
          
            foreach(IShape shape in shapes)
            {
                Console.WriteLine("Shape: {0}  Perimetre: {1:F2} Area: {2:F2}",shape.GetType().Name ,shape.CalculatePerimetre() ,shape.CalculateArea());
            }
                

            

            

        }
    }
}
