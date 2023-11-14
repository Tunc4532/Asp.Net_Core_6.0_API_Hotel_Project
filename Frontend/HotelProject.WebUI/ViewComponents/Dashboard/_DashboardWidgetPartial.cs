using HotelProject.WebUI.DTOs.GuestDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardWidgetPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardWidgetPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var client1 = _httpClientFactory.CreateClient();
            var client2 = _httpClientFactory.CreateClient();
            var client3 = _httpClientFactory.CreateClient();

            var respponseMessage = await client.GetAsync("https://localhost:44309/api/DashboardWidgets/GetStaffCount");
            var respponseMessage1 = await client1.GetAsync("https://localhost:44309/api/DashboardWidgets/GetBookingCount");
            var respponseMessage2 = await client2.GetAsync("https://localhost:44309/api/DashboardWidgets/GetUserCount");
            var respponseMessage3 = await client2.GetAsync("https://localhost:44309/api/DashboardWidgets/GetRoomCount");

            var jsonData = await respponseMessage.Content.ReadAsStringAsync();
            var jsonData1 = await respponseMessage1.Content.ReadAsStringAsync();
            var jsonData2 = await respponseMessage2.Content.ReadAsStringAsync();
            var jsonData3 = await respponseMessage3.Content.ReadAsStringAsync();

            ViewBag.StaffCount = jsonData;
            ViewBag.BookingCount = jsonData1;
            ViewBag.UserCount = jsonData2;
            ViewBag.RommCount = jsonData3;

            return View();
        }

    }
}
