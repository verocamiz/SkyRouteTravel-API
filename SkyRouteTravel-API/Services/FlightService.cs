using SkyRouteTravel_API.DTOs.Requests;
using SkyRouteTravel_API.DTOs.Responses;
using SkyRouteTravel_API.Models;
using SkyRouteTravel_API.Providers;

namespace SkyRouteTravel_API.Services
{
    public class FlightService : IFlightService
    {
        private readonly IEnumerable<IFlightProvider> _providers;

        public FlightService(
            IEnumerable<IFlightProvider> providers)
        {
            _providers = providers;
        }

        public async Task<List<FlightResponseDTO>> SearchFlightsAsync(
            FlightSearchRequestDTO request)
        {
            var searchTasks = _providers
                .Select(provider => provider.SearchFlightsAsync());

            var providerResults = await Task.WhenAll(searchTasks);

            var flights = providerResults
                .SelectMany(result => result)
                .Where(f =>
                f.Origin.Code == request.OriginAirportCode &&
                f.Destination.Code == request.DestinationAirportCode &&
                f.CabinClass == request.CabinClass &&
                f.DepartureTime.Date == request.DepartureDate.Date);

            return flights.Select(f => new FlightResponseDTO
            {
                Provider = f.Provider,

                FlightNumber = f.FlightNumber,

                OriginAirportCode = f.Origin.Code,

                DestinationAirportCode = f.Destination.Code,

                DepartureTime = f.DepartureTime,

                ArrivalTime = f.ArrivalTime,

                Duration = f.Duration,

                CabinClass = f.CabinClass,

                PricePerPassenger = f.PricePerPassenger,

                TotalPrice = f.PricePerPassenger * request.Passengers
            }).ToList();
        }
    }
}