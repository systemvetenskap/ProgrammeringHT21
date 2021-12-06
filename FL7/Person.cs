using System;
using System.Collections.Generic;
using System.Text;

namespace FL7
{
    public class Person
    {
        // Property
        public string Name { get; set; }
        public int BirthYear { get; set; }
        public int Age => GetAge();
        public Person()
        {

        }
        // private fields
        private bool isHungry = true;
        private int _numberOfChildren = 2;

        public string Address { get; set; }

        // Metoder

        private int GetAge()
        {
            int year = DateTime.Now.Year;
            return year - BirthYear;
        }


        public bool IsVowel(char letter)
        {
            bool lower= IsLowerVowel(letter);
            bool upper = IsUpperVowel(letter);
            return lower || upper;
        }

        private bool IsUpperVowel(char letter)
        {
            return true;
        }
        private bool IsLowerVowel(char letter)
        {
            return false;
        }

        public string SayHello()
        {
            return $"Hej, jag heter {Name}";
        }

        // Vi vill snygga till ToString
        public override string ToString()
        {
            return $"{Name}: {GetAge()} år gammal";
        }
    }
}
