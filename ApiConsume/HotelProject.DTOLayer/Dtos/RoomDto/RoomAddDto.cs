﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DTOLayer.Dtos.RoomDto
{
    public class CreateGuestDto
    {
        [Required(ErrorMessage ="Lütfen oda numarasını giriniz")]
        public string? RoomNumber { get; set; }

        public string? RoomCoverImage { get; set; }

        [Required(ErrorMessage ="Lütfen fiyat bilgisi giriniz")]
        public int Price { get; set; }

        [Required(ErrorMessage ="Lütfen oda başlık bilgisini giriniz")]
        public string? Tittle { get; set; }

        [Required(ErrorMessage = "Lütfen Yatak sayısını giriniz")]
        public string? BedCount { get; set; }

        [Required(ErrorMessage = "Lütfen banyo sayısını giriniz")]
        public string? BathCount { get; set; }

        public string? Wifi { get; set; }
        public string? Description { get; set; }
    }
}
