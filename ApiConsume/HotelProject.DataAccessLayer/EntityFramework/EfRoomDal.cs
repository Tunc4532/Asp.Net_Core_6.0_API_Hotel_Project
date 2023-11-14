using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repostories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfRoomDal : GenericRepostory<Room>, IRoomDal
    {
        public EfRoomDal(Context context) : base(context)
        {
            
        }

        public int RoomCount()
        {
            Context context = new Context();
            var values = context.Rooms.Count();
            return values;
        }
    }
}
