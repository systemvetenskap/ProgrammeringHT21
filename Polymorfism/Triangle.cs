using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfism
{
    public class Triangle : Shape
    {
        // Använd polymorfism
        // = kan anta nya former

        public override double GetArea()
        {
            return Width * Height/2;
        }
    }
}
