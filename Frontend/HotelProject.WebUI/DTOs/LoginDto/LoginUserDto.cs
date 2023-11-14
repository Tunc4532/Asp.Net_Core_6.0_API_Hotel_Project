using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.DTOs.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage ="Kullanıcı adını giriniz")]
        public string? UserName { get; set; }

        [Required(ErrorMessage ="Şifrenizi giriniz")]
        public string? Password { get; set; }
    }
}
