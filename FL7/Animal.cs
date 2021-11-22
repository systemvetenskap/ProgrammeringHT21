using System;
using System.Collections.Generic;
using System.Text;

namespace FL7
{
    public class Animal
    {
        public int NumberOfLegs { get; set; }
        public string Type { get; set; }

        public string MakeSound()
        {
            return "hoho";
        }
    }
}
