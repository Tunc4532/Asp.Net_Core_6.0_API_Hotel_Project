﻿namespace HotelProject.WebUI.DTOs.ContactDto
{
    public class ResultContactDto
    {
        public int ContactID { get; set; }
        public string? Name { get; set; }
        public string? Mail { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
        public DateTime Date { get; set; }
    }
}
