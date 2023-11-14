using HotelProject.WebUI.DTOs.BookingDto;
using HotelProject.WebUI.DTOs.StaffDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardLast6Bokkings : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardLast6Bokkings(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var respponseMessage = await client.GetAsync("https://localhost:44309/api/Booking/ListBookingdata");
            if (respponseMessage.IsSuccessStatusCode)
            {
                var jsonData = await respponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLast6BokingDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
