using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gridnine.FlightCodingTest.Filter.Interfaces
{
    public interface IFilterRule
    {
        bool Allowed(Flight flight);
    }
}
