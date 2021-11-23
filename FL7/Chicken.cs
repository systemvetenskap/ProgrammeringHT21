using System;
using System.Collections.Generic;
using System.Text;

namespace FL7
{
    public class Chicken : Animal
    {
        /// <summary>
        /// Konstruktor
        /// Parameterlös
        /// </summary>
        public Chicken()
        {
            InitalizeChicken();
        }

        /// <summary>
        /// Skapar ett nytt objekt av typen Chicken
        /// </summary>
        /// <param name="name">Namnet på kycklingen</param>
        public Chicken(string name)
        {
            InitalizeChicken();
            Name = name;
        }

        private void InitalizeChicken()
        {
            NumberOfLegs = 2;
            Type = "Kyckling";
        }

        public override string ToString()
        {
            return "Kyckling";
        }

    }
}
