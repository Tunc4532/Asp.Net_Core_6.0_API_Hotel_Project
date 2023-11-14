using HotelProject.WebUI.DTOs.ContactDto;
using HotelProject.WebUI.DTOs.SendMessageDto;
using HotelProject.WebUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    public class AdminContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Inbox()
        {
            var client = _httpClientFactory.CreateClient();
            var respponseMessage = await client.GetAsync("https://localhost:44309/api/Contact");

            var client2 = _httpClientFactory.CreateClient();
            var respponseMessage2 = await client2.GetAsync("https://localhost:44309/api/Contact/GetContactCount");

            var client3 = _httpClientFactory.CreateClient();
            var respponseMessage3 = await client3.GetAsync("https://localhost:44309/api/SendMessage/GetSendMessageCount");

            if (respponseMessage.IsSuccessStatusCode)
            {
                var jsonData = await respponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<InboxContactDto>>(jsonData);

                var jsonData2 = await respponseMessage2.Content.ReadAsStringAsync();
                ViewBag.contactCount = jsonData2;

                var jsonData3 = await respponseMessage3.Content.ReadAsStringAsync();
                ViewBag.SendCount = jsonData2;

                return View(values);
            }

            return View();

        }

        public async Task<IActionResult> Sendbox()
        {
            var client = _httpClientFactory.CreateClient();
            var respponseMessage = await client.GetAsync("https://localhost:44309/api/SendMessage");
            if (respponseMessage.IsSuccessStatusCode)
            {
                var jsonData = await respponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultSendBoxDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddSendMessage()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddSendMessage(CreateSendMessage model)
        {
            model.SenderName = "Admin";
            model.SenderMail = "Admin@gmail.com";
            model.Date = DateTime.Parse(DateTime.Now.ToString());
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:44309/api/SendMessage", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("SendBox");
            }
            return View();
        }

        public PartialViewResult SidebarAdminContactPartil()
        {
            return PartialView();
        }
        public PartialViewResult SidebarAdminContactCatagoryPartil()
        {
            return PartialView();
        }

        public async Task <IActionResult> MessageDetails(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var respnseMessage = await client.GetAsync($"https://localhost:44309/api/SendMessage/{id}");
            if (respnseMessage.IsSuccessStatusCode)
            {
                var jsonData = await respnseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<GetMessageByIdDto>(jsonData);
                return View(values);
            }
            return View();
        }

        public async Task<IActionResult> MessageDetailsByInbox(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var respnseMessage = await client.GetAsync($"https://localhost:44309/api/Contact/{id}");
            if (respnseMessage.IsSuccessStatusCode)
            {
                var jsonData = await respnseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<InboxContactDto>(jsonData);
                return View(values);
            }
            return View();
        }

    }
}
