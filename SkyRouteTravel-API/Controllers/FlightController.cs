using Microsoft.AspNetCore.Mvc;
using SkyRouteTravel_API.DTOs.Requests;
using SkyRouteTravel_API.DTOs.Responses;
using SkyRouteTravel_API.Services;

namespace SkyRouteTravel_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FlightsController : ControllerBase
    {
        private readonly IFlightService _flightService;

        public FlightsController(
            IFlightService flightService)
        {
            _flightService = flightService;
        }

        [HttpPost("search")] 
        public async Task<ActionResult<IEnumerable<FlightResponseDTO>>> SearchFlights(
            [FromBody] FlightSearchRequestDTO request)
        {
            var flights =
                await _flightService.SearchFlightsAsync(request);

            if (flights == null || !flights.Any())
                return NoContent();

            return Ok(flights); 

        }
    }
}