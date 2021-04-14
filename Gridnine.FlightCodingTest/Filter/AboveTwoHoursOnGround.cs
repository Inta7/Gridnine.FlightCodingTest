using System;

namespace Gridnine.FlightCodingTest.Filter
{
    public class AboveTwoHoursOnGround : TimeRuleFilter
    {
        public AboveTwoHoursOnGround()
                      : base(flight => GroundFilterRule(flight))
        {

        }


        static private bool GroundFilterRule(Flight flight)
        {
            if (flight.Segments.Count > 1)
            {
                TimeSpan timeOnearth = TimeSpan.Zero;
                for (int i = 1; i < flight.Segments.Count; ++i)
                {
                    timeOnearth += flight.Segments[i].DepartureDate - flight.Segments[i - 1].ArrivalDate;
                }
                return timeOnearth > TimeSpan.FromHours(2);
            }
            return false;
        }
    }
}
