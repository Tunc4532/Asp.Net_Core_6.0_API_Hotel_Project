﻿namespace HotelProject.WebUI.DTOs.RoomDto
{
    public class ResultRoomDto
    {
        public int RoomID { get; set; }
        public string? RoomNumber { get; set; }
        public string? RoomCoverImage { get; set; }
        public int Price { get; set; }
        public string? Tittle { get; set; }
        public string? BedCount { get; set; }
        public string? BathCount { get; set; }
        public string? Wifi { get; set; }
        public string? Description { get; set; }
    }
}