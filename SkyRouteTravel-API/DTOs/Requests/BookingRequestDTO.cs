using System.ComponentModel.DataAnnotations;

namespace SkyRouteTravel_API.DTOs.Requests
{
    public class BookingRequestDTO
    {
        [Required]
        public string FlightNumber { get; set; } = string.Empty;

        [Range(1, 9)]
        public int PassengerCount { get; set; }

        [Required]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string DocumentNumber { get; set; } = string.Empty;
    }
}
