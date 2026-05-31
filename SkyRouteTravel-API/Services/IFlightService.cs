using SkyRouteTravel_API.DTOs.Requests;
using SkyRouteTravel_API.DTOs.Responses;

namespace SkyRouteTravel_API.Services
{
    public interface IFlightService
    {
        Task<IEnumerable<FlightResponseDTO>> SearchFlightsAsync(
            FlightSearchRequestDTO request);
    }
}
