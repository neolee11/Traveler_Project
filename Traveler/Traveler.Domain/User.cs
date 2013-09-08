using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveler.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GenderTypes Gender { get; set; }
        public DateTime Birthday { get; set; }
        public Address HomeAddress { get; set; }
    }
}
