using SkyRouteTravel_API.DTOs.Requests;
using SkyRouteTravel_API.Models;

namespace SkyRouteTravel_API.Providers
{
    public class GlobalAirProvider : IFlightProvider
    {
        public async Task<IEnumerable<Flight>> SearchFlightsAsync(
            FlightSearchRequestDTO request)
        {
            // Simulate external provider API latency
            // Used only to demonstrate Angular loading states.
            await Task.Delay(1000);

            return new List<Flight>
            { 
            new Flight
            {
                Provider = "GlobalAir",
                FlightNumber = "GA101",

                Origin = new Airport
                {
                    Code = "EZE",
                    Name = "Ministro Pistarini International Airport",
                    City = "Buenos Aires",
                    Country = "AR"
                },

                Destination = new Airport
                {
                    Code = "COR",
                    Name = "Ingeniero Taravella International Airport",
                    City = "Cordoba",
                    Country = "AR"
                },

                DepartureTime = new DateTime(2026, 07, 06, 18, 00, 00),
                ArrivalTime   = new DateTime(2026, 07, 06, 19, 20, 00),

                CabinClass = CabinClass.Economy,

                PricePerPassenger = CalculatePrice(250m)
            }, 
            new Flight
            {
                Provider = "GlobalAir",
                FlightNumber = "GA102",

                Origin = new Airport
                {
                    Code = "AEP",
                    Name = "Aeroparque Jorge Newbery",
                    City = "Buenos Aires",
                    Country = "AR"
                },

                Destination = new Airport
                {
                    Code = "COR",
                    Name = "Ingeniero Taravella International Airport",
                    City = "Cordoba",
                    Country = "AR"
                },

                DepartureTime = new DateTime(2026, 07, 08, 14, 15, 00),
                ArrivalTime   = new DateTime(2026, 07, 08, 16, 15, 00),

                CabinClass = CabinClass.Economy,

                PricePerPassenger = CalculatePrice(220m)
            },
             
            new Flight
            {
                Provider = "GlobalAir",
                FlightNumber = "GA201",

                Origin = new Airport
                {
                    Code = "EZE",
                    Name = "Ministro Pistarini International Airport",
                    City = "Buenos Aires",
                    Country = "AR"
                },

                Destination = new Airport
                {
                    Code = "MIA",
                    Name = "Miami International Airport",
                    City = "Miami",
                    Country = "US"
                },

                DepartureTime = new DateTime(2026, 07, 10, 22, 00, 00),
                ArrivalTime   = new DateTime(2026, 07, 11, 07, 00, 00),

                CabinClass = CabinClass.FirstClass,

                PricePerPassenger = CalculatePrice(550m)
            },
             
            new Flight
            {
                Provider = "GlobalAir",
                FlightNumber = "GA202",

                Origin = new Airport
                {
                    Code = "AEP",
                    Name = "Aeroparque Jorge Newbery",
                    City = "Buenos Aires",
                    Country = "AR"
                },

                Destination = new Airport
                {
                    Code = "JFK",
                    Name = "John F. Kennedy International Airport",
                    City = "New York",
                    Country = "US"
                },
                 
                DepartureTime = new DateTime(2026, 07, 25, 20, 30, 00),
                ArrivalTime   = new DateTime(2026, 07, 26, 08, 30, 00),

                CabinClass = CabinClass.Business,

                PricePerPassenger = CalculatePrice(620m)
            }
        };
        }

        private decimal CalculatePrice(decimal baseFare)
        {
            return Math.Round(baseFare * 1.15m, 2);
        }
    }
}