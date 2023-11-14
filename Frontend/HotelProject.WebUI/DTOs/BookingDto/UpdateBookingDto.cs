namespace HotelProject.WebUI.DTOs.BookingDto
{
    public class UpdateBookingDto
    {
        public int BookingID { get; set; }
        public string? Name { get; set; }
        public string? Mail { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime CheckOut { get; set; }
        public string? AdultCount { get; set; }
        public string? ChiledCount { get; set; }
        public string? RoomCount { get; set; }
        public string? SpecialRequest { get; set; }
        public string? Description { get; set; }
        public bool Status { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? Status2 { get; set; }
    }
}
