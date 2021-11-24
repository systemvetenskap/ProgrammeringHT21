using System;
using System.Collections.Generic;
using System.Text;

namespace SmoothieChallenge
{
    public class Smoothie
    {
        public string[] Ingrediens { get; set; }
        public List<Ingredient> Fruits { get; set; } = new List<Ingredient>();

        public Smoothie(string[] fruits)
        {
            Ingredient ingredient;
            foreach (string fruit in fruits)
            {
                ingredient = new Ingredient
                {
                    Fruit = fruit,
                    Price = 1
                };
                Fruits.Add(ingredient);
            }
            Ingrediens = fruits;
        }

        public double GetCost()
        {
            double sum = 0;
            foreach (Ingredient ingredient in Fruits)
            {
                sum += ingredient.Price*1.1;
            }
            return sum;
        }

        public string GetPrice()
        {
            double cost = GetCost() + GetCost() * 1.5;
            cost =  Math.Round(cost, 2);
            return $"£{cost}";
        }

        public string GetName()
        {
            return $"{Ingrediens[0]} smoothie";
        }
    }
}
