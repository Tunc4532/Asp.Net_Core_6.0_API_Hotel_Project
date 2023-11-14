using HotelProject.WebUI.DTOs.FollowersDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribeCountPartial : ViewComponent
    {
        public async Task <IViewComponentResult> InvokeAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofileinfo/cindastunc"),
                Headers =
    {
        { "X-RapidAPI-Key", "5ea89e0241mshb044f3efcc81911p1d851fjsn37fa5d9887e8" },
        { "X-RapidAPI-Host", "instagram-profile1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                ResultInstagramDto resultInstagramDto = JsonConvert.DeserializeObject<ResultInstagramDto>(body);
                ViewBag.v1 = resultInstagramDto.followers;
                ViewBag.v2 = resultInstagramDto.following;
                return View(resultInstagramDto);
            }
        }
    }
}
