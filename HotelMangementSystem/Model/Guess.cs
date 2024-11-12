using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMangementSystem.Model
{
    internal class Guess
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Gender{ get; set; }
        public string Email{ get; set; }
        public string Country{ get; set; }
        public string PhoneNumber{ get; set; }
    }
}
