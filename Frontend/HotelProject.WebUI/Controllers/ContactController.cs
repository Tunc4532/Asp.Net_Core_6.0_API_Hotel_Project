using HotelProject.WebUI.DTOs.BookingDto;
using HotelProject.WebUI.DTOs.ContactDto;
using HotelProject.WebUI.DTOs.GuestDto;
using HotelProject.WebUI.DTOs.MessageCatagoryDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var respponseMessage = await client.GetAsync("https://localhost:44309/api/MessageCatagory");

            var jsonData = await respponseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultMessageCatagoryDto>>(jsonData);

            List<SelectListItem> values2 = (from x in values 
                                            select new SelectListItem
                                            {
                                                Text = x.MessageCatagoryName,
                                                Value = x.MessageCatagoryId.ToString()

                                            }).ToList();
            ViewBag.data = values2;

            return View();

        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> SendMessage(CreateContactDto createContactDto)
        {
            createContactDto.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createContactDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            await client.PostAsync("https://localhost:44309/api/Contact", stringContent);
            return RedirectToAction("Index", "Default");

        }
    }
}
