using System;
using System.Linq;


namespace Gridnine.FlightCodingTest.Filter
{
    public class DepaturedFlights : TimeRuleFilter
    {
        public DepaturedFlights()
                   : base(flight => flight.Segments.First().DepartureDate < DateTime.Now)
        {

        }
    }
}
