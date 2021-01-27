using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JeanCarlosHolguinBerihueteAPI.Models
{
    public class Department
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public IEnumerable<User> User { get; set; }
    }
}
