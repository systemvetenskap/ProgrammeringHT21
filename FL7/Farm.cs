using System;
using System.Collections.Generic;
using System.Text;

namespace FL7
{
    public class Farm 
    {
        // skapa private fields
        // instansvariabel
        //private List<Animal> _animals = new List<Animal>();
        public List<Cow> Cows { get; set; } = 
        new List<Cow>();


        #region Properties
        /// <summary>
        /// Maximala antalet djur på bondgården
        /// </summary>
        public int MaximalAnimals { get; }
        public string Address { get; set; }
        public string Name { get; set; }
       // public List<Animal> Animals { get; set; } 
        #endregion
        public Farm(int numberOfCows)
        {
            // MaximalAnimals = maxCountAnimals;
            CreateCows(numberOfCows);
        }

        private void CreateCows(int numberOfCows)
        {
            Cow cow; 
            for (int i = 1; i <= numberOfCows; i++)
            {
                cow = new Cow();
                cow.Id = i;
                Cows.Add(cow);
            }
        }

        // Läxa
        // Gör en metod som skapar ett godtyckligt
        // antal kor och lägger dem i listan av djur
        // ex: 350 stycken! 45 st, 11, 34345
        // se till att metoden anropas via konstruktorn
        // ni behöver inte ta hänsyn till maxCountAnimals

        // publika metoder
        /// <summary>
        /// Lägger till djur i vår bondgård
        /// </summary>
        /// <param name="animal">Objekt av typen <see cref="Animal"/></param>
        public bool AddAnimal(Cow animal)
        {
            // Vi vill kontrollera om det finns plats
            if (Cows.Count < MaximalAnimals)
            {
                Cows.Add(animal);
                return true;
            }
            return false;
        }

        public List<Cow> GetAllAnimals()
        {
            return Cows;
        }

        public List<Animal> GetAnimalsWithTwoLegs()
        {
            List<Animal> animals = new List<Animal>();
            // lista --- tänk loop
            foreach (Cow animal in Cows)
            {
                if (animal.NumberOfLegs == 2)
                {
                    animals.Add(animal);
                }
            }

            return animals;
        }

        public Cow GetCowById(int id)
        {
            foreach (Cow cow in Cows)
            {
                if (cow.Id == id)
                {
                    return cow;
                }
            }
            return null;
        }
    }
}
