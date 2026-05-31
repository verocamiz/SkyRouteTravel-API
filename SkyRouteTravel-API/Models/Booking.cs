namespace SkyRouteTravel_API.Models
{
    public class Booking
    {
        public Guid Id { get; set; }

        public string BookingReference { get; set; } = string.Empty;

        public string FlightNumber { get; set; } = string.Empty;

        public int PassengerCount { get; set; }

        public Passenger Passenger { get; set; } = default!;

        public DateTime CreatedAt { get; set; }
    }
}
