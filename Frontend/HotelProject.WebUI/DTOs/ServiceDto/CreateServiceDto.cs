using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.DTOs.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage = "Lütfen hizmet ikon lini giriniz")]
        public string? ServiceIcon { get; set; }

        [Required(ErrorMessage = "Lütfen hizmet Başlığını giriniz")]
        [StringLength(100, ErrorMessage = "Hizmet başlığı en fazla 100 karakter olabilir")]
        public string? Title { get; set; }

        public string? Description { get; set; }
    }
}
