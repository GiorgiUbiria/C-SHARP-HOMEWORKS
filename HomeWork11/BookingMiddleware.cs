namespace HomeWork11;

using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

public class BookingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly IConfiguration _configuration;

    public BookingMiddleware(RequestDelegate next, IConfiguration configuration)
    {
        _next = next;
        _configuration = configuration;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        if (context.Request.Path.StartsWithSegments("/Booking/Book"))
        {
            bool isBookingAllowed = !_configuration.GetValue<bool>("BookingNotAllowed");

            if (!isBookingAllowed)
            {
                context.Response.StatusCode = StatusCodes.Status403Forbidden;
                context.Response.Redirect("/Booking/BookingNotAllowed");
                return;
            }
        }

        await _next(context);
    }
}