using System;
using System.Collections.Generic;
using System.Text;

namespace FL11
{
    public static class Calculator
    {
        /// <summary>
        /// Beräknar summan av två tal
        /// </summary>
        /// <param name="x">Decimaltal</param>
        /// <param name="y">decimaltal</param>
        /// <returns>Summa</returns>
        public static double Sum(double x, double y) =>  x + y;
        /// <summary>
        /// Beräknar summan av två tal
        /// </summary>
        /// <param name="x">heltal</param>
        /// <param name="y">heltal</param>
        /// <returns>Summa</returns>
        public static int Sum(int x, int y) =>  x + y;

        public static double Sum(double[] values)
        {
            double sum = 0;
            foreach  (double value in values)
            {
                sum += value;
            }

            return sum;
        }

    }
}
