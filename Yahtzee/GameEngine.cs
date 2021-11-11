using System;
using System.Collections.Generic;
using System.Text;

namespace Yahtzee
{
    /// <summary>
    /// Spelregler för vårt yatzyspel
    /// </summary>
    public class GameEngine
    {
        // skriv av och använd alltid.
        private static readonly Random random = new Random();
        private int _ones;

        // Jag vill ha fem tärningar
        // vi skapar en array med 5 fack
        // av datatypen int

        /// <summary>
        /// Ger mig fem slumpmässiga tärningar
        /// </summary>
        /// <returns>Array med fem fack</returns>
        public int[] RollDices()
        {
            return new int[] 
            { 
                random.Next(1, 7), 
                random.Next(1, 7),
                random.Next(1, 7),
                random.Next(1, 7),
                random.Next(1, 7)
            };
        }

        /// <summary>
        /// Kontrollerar om poängsumman är korrekt för vald kategori
        /// </summary>
        /// <param name="score">Poängsumma</param>
        /// <param name="category">kategori, ettor, tvåor, treor</param>
        /// <returns>true om poängsumman är valid</returns>
        private bool IsValidScore(int score, int category)
        {
            return score % 2 == 0 && score < category * 5;
        }

        public bool SaveScore(int score, int category)
        {
            if (!IsValidScore(score, category))
            {
                return false;
            }
            _ones = score;
            return true;

        }
    }
}
