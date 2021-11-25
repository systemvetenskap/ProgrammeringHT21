using System;
using System.Collections.Generic;
using System.Text;

namespace FL7
{
    public abstract class Animal
    {
        protected string _test = "Erik";

        public int NumberOfLegs { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Id { get;  set; }

        public string MakeSound()
        {
            return _test;
        }
    }
}
