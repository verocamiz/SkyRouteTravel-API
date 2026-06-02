# SkyRoute Travel

## Overview

SkyRoute Travel is a flight search and booking application built with ASP.NET Core and Angular.

The application allows users to:

* Search flights by origin, destination, departure date, cabin class.
* Compare results from multiple flight providers.
* View flight pricing and trip details.
* Create a booking and receive a booking reference code. 
   
## Architecture

### Backend

The backend follows a layered architecture:

* Controllers: Handle HTTP requests and responses.
* Services: Contain application and business logic.
* Providers: Simulate external airline providers.
* DTOs: Define API contracts.
* Models: Represent domain entities.

### Flight Providers

The application uses the Strategy Pattern through the `IFlightProvider` interface.

Current implementations:

* GlobalAirProvider
* BudgetWingsProvider

This design allows adding new providers without modifying existing business logic.

### Flight Search

The `FlightService` retrieves flight data from all registered providers.

Results are aggregated and filtered according to the search criteria.

### Booking Flow

The booking process is separated from flight search responsibilities.

The booking endpoint receives passenger information and returns a generated booking reference code.

---

## Technical Decisions

* I Decided to use Dependency Injection in order to loose coupling between components for services and providers.

* For the design of the flight providers I decided to use strategy pattern since additional providers may need to be integrated in the future.

* Providers use asynchronous methods to simulate external API integrations and demonstrate loading states in the Angular application.

* Flight providers currently return hardcoded flight data.

* A global exception middleware is used to centralize error handling and logging.
 
---

## Trade-offs and Known Limitations
 
* The application does not persist flights or bookings. Data is generated in-memory to keep the implementation focused on the challenge requirements.
 
*  Authentication and authorization are not implemented.

---

## Running the Application

### Backend

Requirements:

* .NET 8 SDK

Run:

```bash
dotnet restore
dotnet run
```  
