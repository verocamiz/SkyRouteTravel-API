using SkyRouteTravel_API.DTOs.Requests;
using SkyRouteTravel_API.Models;

namespace SkyRouteTravel_API.Providers
{
    public interface IFlightProvider
    {
        Task<IEnumerable<Flight>> SearchFlightsAsync(
            FlightSearchRequestDTO request); 

    }
       
}
