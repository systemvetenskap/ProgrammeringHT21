using System;
using System.Collections.Generic;
using System.Text;

namespace TentaTrain
{
    public class Seat
    {
        public int SeatNumber { get; set; }
        public string Type { get; set; }
        public bool IsTaken { get; set; }

        public override string ToString()
        {
            string status;
            if (IsTaken)
            {
                status = "upptagen";
            }
            else
            {
                status = "ledig";
            }
            return $"Plats: {SeatNumber}({Type}) är {status}";
        }
    }
}
