using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }


        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            _bookingService.TInsert(booking);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var values = _bookingService.TGetByID(id);
            _bookingService.TDelete(values);
            return Ok();
        }
        [HttpPut("UpdateBooking")]
        public IActionResult UpdateBooking(Booking booking)
        {
            _bookingService.TUpdate(booking);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var values = _bookingService.TGetByID(id);
            return Ok(values);
        }

        [HttpPut("UpdateChangeBooking")]
        public IActionResult UpdateChangeBooking(Booking booking)
        {
            _bookingService.BookingStatusChangeApproverd(booking);
            return Ok();
        }

        [HttpPut("UpdateChangeBooking2")]
        public IActionResult UpdateChangeBooking2(int id)
        {
            _bookingService.BookingStatusChangeApproverd2(id);
            return Ok();
        }

        [HttpGet("ListBookingdata")]
        public IActionResult ListBookingdata()
        {
            var values = _bookingService.TGetListBookingdata();
            return Ok(values);
        }

        [HttpGet("BookingApproverd")]
        public IActionResult BookingApproverd(int id)
        {
            _bookingService.TStatusBookingChangeApproverd(id);
            return Ok();
        }

        [HttpGet("BookingCancel")]
        public IActionResult BookingCancel(int id)
        {
            _bookingService.TStatusBookingChangeCancel(id);
            return Ok();
        }

        [HttpGet("BookingStop")]
        public IActionResult BookingStop(int id)
        {
            _bookingService.TStatusBookingChangeStop(id);
            return Ok();
        }

    }
}
