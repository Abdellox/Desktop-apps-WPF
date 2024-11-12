using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMangementSystem.Model
{
    internal class Reservation:Guess
    {
        public DateTime ReservationDate { get; set; }
        public string ReservationType { get; set; }
        
        string BigRoom, SmallRom, MeduiRoom;
        public void Reserve(DateTime date,int numberofGuess)
        {
            if (numberofGuess > 1)
            {
                SmallRom = ReservationType;
            }
        }
    }
}
