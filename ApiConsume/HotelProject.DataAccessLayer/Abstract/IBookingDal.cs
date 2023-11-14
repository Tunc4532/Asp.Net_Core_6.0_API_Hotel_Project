using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IBookingDal : IGenericDal<Booking>
    {
        void BookingStatusChangeApproverd(Booking booking);
        void BookingStatusChangeApproverd2(int id);

        int GetBookingCount();

        List<Booking> GetListBookingdata();

        void StatusBookingChangeApproverd(int id);
        void StatusBookingChangeCancel(int id);
        void StatusBookingChangeStop(int id);

    }
}
