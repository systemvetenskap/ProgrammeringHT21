using System;
using System.Collections.Generic;
using System.Text;

namespace FL7
{
    public class Animal
    {
        protected string _test = "Erik";

        public int NumberOfLegs { get; protected set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Id { get;  set; }

        public string MakeSound()
        {
            return _test;
        }
    }
}
