using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageCatagoryController : ControllerBase
    {
        private readonly IMessageCatagoryService _messageCatagoryService;

        public MessageCatagoryController(IMessageCatagoryService messageCatagoryService)
        {
            _messageCatagoryService = messageCatagoryService;
        }

        [HttpGet]
        public IActionResult MessageCatagoryList()
        {
            var values = _messageCatagoryService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddMessageCatagory(MessageCatagory messageCatagory)
        {
            _messageCatagoryService.TInsert(messageCatagory);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteMessageCatagory(int id)
        {
            var values = _messageCatagoryService.TGetByID(id);
            _messageCatagoryService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateMessageCatagory(MessageCatagory messageCatagory)
        {
            _messageCatagoryService.TUpdate(messageCatagory);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetMessageCatagory(int id)
        {
            var values = _messageCatagoryService.TGetByID(id);
            return Ok(values);
        }
    }
}
