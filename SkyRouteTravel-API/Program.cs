using SkyRouteTravel_API.Middlewares;
using SkyRouteTravel_API.Providers;
using SkyRouteTravel_API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IFlightProvider, GlobalAirProvider>();

builder.Services.AddScoped<IFlightProvider, BudgetWingsProvider>();

builder.Services.AddScoped<IFlightService, FlightService>(); 

builder.Services.AddScoped<IBookingService, BookingService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AngularApp", policy =>
    {
        var allowedOrigins = builder.Configuration
            .GetSection("Cors:AllowedOrigins")
            .Get<string[]>() ?? [];

        policy.WithOrigins(allowedOrigins)
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AngularApp");

app.UseAuthorization();

app.UseMiddleware<ExceptionMiddleware>();

app.MapControllers();

app.Run();
