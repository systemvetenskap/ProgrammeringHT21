using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfism
{
    public class Assignment
    {
        public string Id { get; set; } = "22 a";
        public List<Shape> Shapes { get; set; } = new List<Shape>();

        public double CalculateTotalArea()
        {
            double area = 0;
            foreach (Shape shape in Shapes)
            {
                area += shape.GetArea();
            }
            return area;
        }
    }
}
