using System;
using System.Collections.Generic;
using System.Text;

namespace FL7
{
   public class Cow : Animal
    {
        public override string ToString()
        {
            return "Kossa";
        }
        public Cow(int id)
        {
            Id = id;
        }
        public Cow()
        {

        }
    }
}
