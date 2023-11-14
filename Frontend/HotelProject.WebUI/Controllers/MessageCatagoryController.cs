using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class MessageCatagoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
