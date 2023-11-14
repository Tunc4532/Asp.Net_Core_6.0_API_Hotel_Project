using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.DTOs.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="Ad alanı gerklidir")]
        public string? Name { get; set; } 

        [Required(ErrorMessage = "Soyad alanı gerklidir")]
        public string? SurName { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı alanı gerklidir")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Mail alanı gerklidir")]
        public string? Mail { get; set; }

        [Required(ErrorMessage = "Şifre alanı gerklidir")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Tekrar şifre alanı gerklidir")]
        [Compare("Password",ErrorMessage ="Şifreler uyumlu değil")]
        public string? ConfirmPassword { get; set; }
    }
}
