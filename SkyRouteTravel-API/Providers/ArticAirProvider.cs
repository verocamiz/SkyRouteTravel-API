using SkyRouteTravel_API.DTOs.Requests;
using SkyRouteTravel_API.Models;

namespace SkyRouteTravel_API.Providers
{
    public class ArcticAirProvider : IFlightProvider
    {

        public async Task<IEnumerable<Flight>> SearchFlightsAsync(
            FlightSearchRequestDTO request)
        {
            // Simulate external provider API latency 
            await Task.Delay(1000);

             
                 return new List<Flight>
                { 
                new Flight
                {
                    Provider = "ArticAir",
                    FlightNumber = "BW201",

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
                    DepartureTime = new DateTime(2026, 07, 06, 08, 00, 00),
                    ArrivalTime   = new DateTime(2026, 07, 06, 09, 30, 00),

                    CabinClass = CabinClass.Economy,

                    PricePerPassenger = CalculatePrice(160m)
                }, 
                new Flight
                {
                    Provider = "ArticAir",
                    FlightNumber = "BW202",

                    Origin = new Airport
                    {
                        Code = "AEP",
                        Name = "Aeroparque Jorge Newbery",
                        City = "Buenos Aires",
                        Country = "AR"
                    },

                    Destination = new Airport
                    {
                        Code = "MDZ",
                        Name = "El Plumerillo International Airport",
                        City = "Mendoza",
                        Country = "AR"
                    },
                     
                    DepartureTime = new DateTime(2026, 07, 08, 14, 15, 00),
                    ArrivalTime   = new DateTime(2026, 07, 08, 16, 15, 00),

                    CabinClass = CabinClass.Business,

                    PricePerPassenger = CalculatePrice(190m)
                },
                 
                new Flight
                {
                    Provider = "ArticAir",
                    FlightNumber = "BW301",

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
                     
                    DepartureTime = new DateTime(2026, 07, 13, 23, 00, 00),
                    ArrivalTime   = new DateTime(2026, 07, 14, 09, 00, 00),

                    CabinClass = CabinClass.FirstClass,

                    PricePerPassenger = CalculatePrice(480m)
                },
                 
                new Flight
                {
                    Provider = "ArticAir",
                    FlightNumber = "BW302",

                    Origin = new Airport
                    {
                        Code = "AEP",
                        Name = "Aeroparque Jorge Newbery",
                        City = "Buenos Aires",
                        Country = "AR"
                    },

                    Destination = new Airport
                    {
                        Code = "GRU",
                        Name = "São Paulo/Guarulhos International Airport",
                        City = "São Paulo",
                        Country = "BR"
                    },
                     
                    DepartureTime = new DateTime(2026, 07, 12, 18, 30, 00),
                    ArrivalTime   = new DateTime(2026, 07, 12, 21, 30, 00),

                    CabinClass = CabinClass.Economy,

                    PricePerPassenger = CalculatePrice(260m)
                }
            };
        }

        private decimal CalculatePrice(decimal baseFare)
        {
            //Pricing rule: Base fare × 1.20, then subtract $10 loyalty discount. Minimum final price: $49.99.
            var fareWithMarkup = baseFare * 1.20m;
              
            return Math.Max(fareWithMarkup - 10, 49.99m);
        }
    }
}