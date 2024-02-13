using HomeWork11.Models;
using HomeWork11.Services;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork11.Controllers;

public class BookingController : Controller
{
    private readonly IBookingService _bookingService;

    public BookingController(IBookingService bookingService)
    {
        _bookingService = bookingService;
    }

    public IActionResult Book()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Book(Booking booking)
    {
        if (!_bookingService.IsValidTime(booking.Time))
        {
            ViewBag.Message = "Booking time must be between 10:00 and 19:00.";
            return View("BookingNotAllowed");
        }

        if (_bookingService.IsTimeTaken(booking.Time))
        {
            ViewBag.Message = "This time is already taken.";
            return View("BookingNotAllowed");
        }
        
        _bookingService.AddBooking(booking);

        return RedirectToAction("Index");
    }
    
    [Route("Booking/BookingNotAllowed")]
    public IActionResult BookingNotAllowed()
    {
        ViewBag.Message = "Sorry, but booking is currently not allowed. Please try again later.";
        return View();
    }

    public IActionResult Index()
    {
        var bookings = _bookingService.GetBookings();
        return View(bookings);
    }
}