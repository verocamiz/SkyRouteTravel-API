using SkyRouteTravel_API.Models;
using System.ComponentModel.DataAnnotations;

namespace SkyRouteTravel_API.DTOs.Requests
{
    public class FlightSearchRequestDTO
    {
        [Required]
        [StringLength(3, MinimumLength = 3)]
        public string OriginAirportCode { get; set; } = string.Empty;

        [Required]
        [StringLength(3, MinimumLength = 3)]
        public string DestinationAirportCode { get; set; } = string.Empty;

        [Required]
        public DateTime DepartureDate { get; set; }

        [Range(1, 9)]
        public int Passengers { get; set; }

        [Required]
        public CabinClass CabinClass { get; set; }
    }
}
