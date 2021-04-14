using System;
using System.Linq;
using Gridnine.FlightCodingTest.Filter;

namespace Gridnine.FlightCodingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            FlightBuilder flightBuilder = new FlightBuilder();
            var flightsList = flightBuilder.GetFlights();
            var depaturedFilter = flightsList.Filter(new DepaturedFlights());
            var invertedFilter = flightsList.Filter(new InvertedArrivalFlights());
            var onGroundFilter = flightsList.Filter(new AboveTwoHoursOnGround());

            Console.WriteLine("Вылет до текущего момента времени");
            for (int i = 0; i < depaturedFilter.Count; i++)
            {

                Console.WriteLine("Время вылета");
                Console.WriteLine(depaturedFilter[i].Segments.First().DepartureDate);
                Console.WriteLine("Время прибытия");
                Console.WriteLine(depaturedFilter[i].Segments.Last().ArrivalDate);
                Console.WriteLine();
            }

            Console.WriteLine("Дата прилёта раньше даты вылета");
            for (int i = 0; i < invertedFilter.Count; i++)
            {

                Console.WriteLine("Время вылета");
                Console.WriteLine(invertedFilter[i].Segments.First().DepartureDate);
                Console.WriteLine("Время прибытия");
                Console.WriteLine(invertedFilter[i].Segments.Last().ArrivalDate);
                Console.WriteLine();
            }

            Console.WriteLine("Общее время, проведённое на земле превышает два часа");
            for (int i = 0; i < onGroundFilter.Count; i++)
            {

                Console.WriteLine("Время вылета");
                Console.WriteLine(onGroundFilter[i].Segments.First().DepartureDate);
                Console.WriteLine("Время прибытия");
                Console.WriteLine(onGroundFilter[i].Segments.Last().ArrivalDate);
            }
        }
    }
}