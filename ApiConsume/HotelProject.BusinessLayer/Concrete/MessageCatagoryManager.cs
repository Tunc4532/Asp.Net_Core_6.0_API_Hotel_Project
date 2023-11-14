using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class MessageCatagoryManager : IMessageCatagoryService
    {
        private readonly IMessageCatagoryDal _messageCatagoryDal;

        public MessageCatagoryManager(IMessageCatagoryDal messageCatagoryDal)
        {
            _messageCatagoryDal = messageCatagoryDal;
        }

        public void TDelete(MessageCatagory t)
        {
            throw new NotImplementedException();
        }

        public MessageCatagory TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<MessageCatagory> TGetList()
        {
            return _messageCatagoryDal.GetList();
        }

        public void TInsert(MessageCatagory t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(MessageCatagory t)
        {
            throw new NotImplementedException();
        }
    }
}
