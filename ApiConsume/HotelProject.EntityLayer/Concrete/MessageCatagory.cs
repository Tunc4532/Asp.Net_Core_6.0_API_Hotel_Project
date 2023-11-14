using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class MessageCatagory
    {
        public int MessageCatagoryId { get; set; }
        public string? MessageCatagoryName { get; set; }

        public List<Contact>? Contacts { get; set; }
    }
}
