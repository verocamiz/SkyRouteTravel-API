using SkyRouteTravel_API.DTOs.Requests;
using SkyRouteTravel_API.DTOs.Responses;

namespace SkyRouteTravel_API.Services
{
    public interface IFlightService
    {
        Task<List<FlightResponseDTO>> SearchFlightsAsync(
            FlightSearchRequestDTO request);
    }
}
