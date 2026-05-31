using SkyRouteTravel_API.DTOs.Requests;
using SkyRouteTravel_API.DTOs.Responses;
using SkyRouteTravel_API.Models;

namespace SkyRouteTravel_API.Services
{
    public class BookingService : IBookingService
    {
        public async Task<BookingResponseDTO> CreateBookingAsync(
           BookingRequestDTO request)
        { 
            await Task.Delay(500);

            var booking = new Booking
            {
                Id = Guid.NewGuid(),

                BookingReference = GenerateBookingReference(),

                FlightNumber = request.FlightNumber,

                PassengerCount = request.PassengerCount,

                Passenger = new Passenger
                {
                    FullName = request.FullName,
                    Email = request.Email,
                    DocumentNumber = request.DocumentNumber
                },

                CreatedAt = DateTime.UtcNow
            };

            return new BookingResponseDTO
            {
                BookingReference = booking.BookingReference
            };
        }

        private static string GenerateBookingReference()
        {
            return $"SKY-{Guid.NewGuid():N}"
                .Substring(0, 8)
                .ToUpper();
        }
    }
}
