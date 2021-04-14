using System;
using Gridnine.FlightCodingTest.Filter.Interfaces;


namespace Gridnine.FlightCodingTest.Filter
{
    public abstract class TimeRuleFilter : IFilterRule
    {
        private readonly Func<Flight, bool> _timeRule;

        public TimeRuleFilter(Func<Flight, bool> timeRule)
        {
            _timeRule = timeRule;
        }

        public bool Allowed(Flight flight)
        {
            return _timeRule(flight);
        }
    }
}
