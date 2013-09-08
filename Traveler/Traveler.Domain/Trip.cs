using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveler.Domain
{
    public class Trip
    {
        public int Id { get; set; }
        public List<Place> VisitingPlaces { get; set; }
    }
}
