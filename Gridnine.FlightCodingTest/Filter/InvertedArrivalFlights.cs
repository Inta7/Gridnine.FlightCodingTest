using System;
using System.Linq;


namespace Gridnine.FlightCodingTest.Filter
{
    public class InvertedArrivalFlights : TimeRuleFilter
    {
        public InvertedArrivalFlights()
                         : base(flight => flight.Segments.Last().ArrivalDate < flight.Segments.First().DepartureDate)
        {

        }
    }
}
