using HomeWork11.Models;

namespace HomeWork11.Services;

public interface IBookingService
{
    bool IsValidTime(string time);
    bool IsTimeTaken(string time);
    void AddBooking(Booking booking);
    List<Booking> GetBookings();
}