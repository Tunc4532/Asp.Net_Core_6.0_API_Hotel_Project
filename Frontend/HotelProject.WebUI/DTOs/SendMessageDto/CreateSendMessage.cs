namespace HotelProject.WebUI.DTOs.SendMessageDto
{
    public class CreateSendMessage
    {
        public string? ReceiverName { get; set; }
        public string? ReceiverMail { get; set; }
        public string? SenderName { get; set; }
        public string? SenderMail { get; set; }
        public string? Condent { get; set; }
        public string? Titte { get; set; }
        public DateTime Date { get; set; }
    }
}
