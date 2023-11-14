using HotelProject.WebUI.DTOs.StaffDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardStaffList4 : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardStaffList4(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var respponseMessage = await client.GetAsync("https://localhost:44309/api/Staff/Get4StafLast");
            if (respponseMessage.IsSuccessStatusCode)
            {
                var jsonData = await respponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<Last4StafListDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
