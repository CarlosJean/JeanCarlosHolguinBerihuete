using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JeanCarlosHolguinBerihueteAPI.Models
{
    public class UserDTO
    {

        public string Names { get; set; }

        public string Surnames { get; set; }

        public char Genre { get; set; }
        public string Document { get; set; }

        public string Birthday { get; set; }

        public int Department { get; set; }

        public string Position { get; set; }

        public string Supervisor { get; set; }
    }
}
