namespace SkyRouteTravel_API.Models
{
    public class Flight
    {
        public string FlightNumber { get; set; } = string.Empty;

        public string Provider { get; set; } = string.Empty;

        public Airport Origin { get; set; } = default!;

        public Airport Destination { get; set; } = default!;

        public DateTime DepartureTime { get; set; }

        public DateTime ArrivalTime { get; set; }

        public CabinClass CabinClass { get; set; }

        public decimal PricePerPassenger { get; set; }

        public TimeSpan Duration =>
            ArrivalTime - DepartureTime;
    }
}
