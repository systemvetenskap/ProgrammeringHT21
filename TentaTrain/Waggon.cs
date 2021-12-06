using System;
using System.Collections.Generic;
using System.Text;

namespace TentaTrain
{
    public class Waggon
    {

        private int _count;
        private static readonly Random _random = new Random();
        public List<Seat> Seats { get; set; } = new List<Seat>();

        public Waggon(int count)
        {
            _count = count;
            InitializeSeats();
            FillSeats();
        }

        public void ReturnTickets(int[] seatNumbers)
        {
           
            // https://www.w3schools.com/cs/cs_conditions.php
            // hämtat från labb 2

            // från föreläsning
            // från egna labba
            // Egna anteckningar

            foreach (int seatNumber in seatNumbers)
            {
                //Seat seat = GetSeatByNumber(seatNumber)
                //seat.IsTaken = false;
                // Vet att de....
            }
        }

        private Seat GetSeatByNumber(int number)
        {
            foreach (Seat seat in Seats)
            {
                if (seat.SeatNumber == number)
                {
                    return seat;
                }
            }
            return null;
        }
        public List<Seat> GetFreeSeats(int count)
        {
            List<Seat> availableSeats = new List<Seat>();
            foreach (Seat seat in Seats)
            {
                if (!seat.IsTaken)
                {
                    availableSeats.Add(seat);
                }
                if (availableSeats.Count == count)
                {
                    return availableSeats;
                }
            }
            return null;
        }

        public List<Seat> GetFreeSeatPairs()
        {
            List<Seat> availableSeats = new List<Seat>();
            for (int i = 0; i < Seats.Count; i++)
            {
                Seat seat = Seats[i];
                if (i +1 >= Seats.Count)
                {
                    break;
                }
                Seat nextSeat = Seats[i + 1];
                if (!seat.IsTaken && seat.SeatNumber % 2 != 0 && !nextSeat.IsTaken)
                {
                    // ledigt stolspar
                    availableSeats.Add(seat);
                    availableSeats.Add(nextSeat);
                }
            }
            return availableSeats;
        }

        private void FillSeats()
        {
            foreach (Seat seat in Seats)
            {
                int magicNumber = _random.Next(2);
                if (magicNumber == 1)
                {
                    seat.IsTaken = true;
                }
            }
        }

        private void InitializeSeats()
        {
            Seat seat;
            for (int i = 0; i < _count; i++)
            {
                seat = new Seat
                {
                    SeatNumber = i + 1,
                    Type=GetType(i+1)
                };
                Seats.Add(seat);
            }
        }
        private string GetType(int seatNumber)
        {
            if (seatNumber % 2 == 0) // ett jämnt sittplatsnummer
            {
                return "Gång";
            }
            else
            {
                return "Fönster";
            }
        }
    }
}
