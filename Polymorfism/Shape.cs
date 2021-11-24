using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfism
{
    public class Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }


        // erbjud en grundmetod
        // MEN: tillåt gärna metode att ändras längs vägen
        // visa med ordet  virtual
        public virtual double GetArea()
        {
            return Width * Height;
        }
    }
}
