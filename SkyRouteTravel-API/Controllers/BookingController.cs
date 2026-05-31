using Microsoft.AspNetCore.Mvc;
using SkyRouteTravel_API.DTOs.Requests;
using SkyRouteTravel_API.DTOs.Responses;
using SkyRouteTravel_API.Services;

namespace SkyRouteTravel_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingsController(
            IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpPost]
        public async Task<ActionResult<BookingResponseDTO>> CreateBooking([FromBody]BookingRequestDTO request)
        {
            var booking =
                await _bookingService.CreateBookingAsync(
                    request);

            return Ok(booking);
        }
    }
}
