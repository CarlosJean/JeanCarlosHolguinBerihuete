using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JeanCarlosHolguinBerihueteAPI.Models
{
    public class User
    {
        public int ID { get; set; }

        public string Names { get; set; }

        public string Surnames { get; set; }

        public char Genre { get; set; }
        public string Document { get; set; }

        public DateTime Birthday { get; set; }

        public Department Department { get; set; }

        public string Position { get; set; }

        public  string Supervisor { get; set; }


    }
}
