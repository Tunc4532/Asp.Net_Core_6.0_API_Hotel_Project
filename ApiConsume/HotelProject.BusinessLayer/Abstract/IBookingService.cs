using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IBookingService : IGenericService<Booking>
    {
        void BookingStatusChangeApproverd(Booking booking);
        void BookingStatusChangeApproverd2(int id);

        int TGetBookingCount();
        List<Booking> TGetListBookingdata();
        void TStatusBookingChangeApproverd(int id);
        void TStatusBookingChangeCancel(int id);
        void TStatusBookingChangeStop(int id);
    }
}
