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
    }
}
