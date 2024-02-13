using HomeWork11.Models;
using Newtonsoft.Json;

namespace HomeWork11.Services;

public class BookingService : IBookingService
{
    private readonly string _filePath = "bookings.json";
    private readonly IConfiguration _configuration;

    public BookingService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public bool IsValidTime(string time)
    {
        TimeSpan bookingTime = TimeSpan.Parse(time);
        return bookingTime >= new TimeSpan(10, 0, 0) && bookingTime <= new TimeSpan(19, 0, 0);
    }

    public bool IsTimeTaken(string time)
    {
        var bookings = GetBookings();
        return bookings.Any(b => b.Time == time);
    }

    public void AddBooking(Booking booking)
    {
        var bookings = GetBookings();
        bookings.Add(booking);
        File.WriteAllText(_filePath, JsonConvert.SerializeObject(bookings));
    }

    public List<Booking> GetBookings()
    {
        if (!File.Exists(_filePath))
        {
            return new List<Booking>();
        }

        var json = File.ReadAllText(_filePath);
        if (string.IsNullOrEmpty(json))
        {
            return new List<Booking>();
        }
        return JsonConvert.DeserializeObject<List<Booking>>(json);
    }
}