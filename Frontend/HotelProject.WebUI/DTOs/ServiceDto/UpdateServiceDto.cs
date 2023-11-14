using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.DTOs.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }

        [Required(ErrorMessage = "Lütfen hizmet ikon lini giriniz")]
        public string? ServiceIcon { get; set; }

        [Required(ErrorMessage = "Lütfen hizmet Başlığını giriniz")]
        [StringLength(100, ErrorMessage = "Hizmet başlığı en fazla 100 karakter olabilir")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Lütfen hizmet Açıklamasını giriniz")]
        [StringLength(500, ErrorMessage = "Hizmet Açıklaması en fazla 500 karakter olabilir")]
        public string? Description { get; set; }
    }
}
