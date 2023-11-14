using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Models.Setting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class SettingsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public SettingsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task <IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity?.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.Name = values.Name;
            userEditViewModel.SurName = values.Surname;
            userEditViewModel.UserName = values.UserName;
            userEditViewModel.Name = values.Email;
            return View(userEditViewModel);
        }
        [HttpPost]
        public async Task <IActionResult> Index(UserEditViewModel model)
        {
            if (model.Password == model.CnfirmPassword)
            {
                var user = await _userManager.FindByNameAsync(User.Identity?.Name);
                user.Name = model.Name;
                user.Surname = model.SurName;
                user.Email = model.Email;
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.Password);
                await _userManager.UpdateAsync(user);

                return RedirectToAction("Login", "Login");
            }

            return View();
        }
    }
}
