using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolidayAPI.Models
{
    public class Flight
    {
        public Guid UID { get; set; }

        public string FlightNr { get; set; }

        public string Departure { get; set; }

        public string Destination { get; set; }

        public DateTime DepartureDate { get; set; }

        public DateTime ArrivalDate { get; set; }
    }
}
