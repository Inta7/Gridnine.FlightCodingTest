using System;
using System.Collections.Generic;
using Gridnine.FlightCodingTest.Filter.Interfaces;

namespace Gridnine.FlightCodingTest.Filter
{
    public static class Extensions
    {
        public static IList<Flight> Filter(this IList<Flight> flights, params IFilterRule[] filterRules)
        {
            var result = new List<Flight>();
            foreach (var flight in flights)
            {
                foreach (var rule in filterRules)
                {
                    if (rule.Allowed(flight))
                    {
                        result.Add(flight);
                        break;
                    }
                }

            }
            return result;
        }
    }
}
