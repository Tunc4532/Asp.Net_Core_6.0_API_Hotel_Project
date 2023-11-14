using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebUI.DTOs.ContactDto
{
    public class CreateContactDto
    {
       // public int ContactID { get; set; }
        public string? Name { get; set; }
        public string? Mail { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
        public DateTime Date { get; set; }

        public int MessageCatagoryId { get; set; }
    }
}
