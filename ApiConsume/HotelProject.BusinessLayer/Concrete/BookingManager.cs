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
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public void BookingStatusChangeApproverd(Booking booking)
        {
            _bookingDal.BookingStatusChangeApproverd(booking);
        }

        public void BookingStatusChangeApproverd2(int id)
        {
            _bookingDal.BookingStatusChangeApproverd2(id);
        }

        public void TDelete(Booking t)
        {
            _bookingDal.Delete(t);
        }

        public int TGetBookingCount()
        {
           return _bookingDal.GetBookingCount();
        }

        public Booking TGetByID(int id)
        {
            return _bookingDal.GetByID(id);
        }

        public List<Booking> TGetList()
        {
           return _bookingDal.GetList();
        }

        public List<Booking> TGetListBookingdata()
        {
           return _bookingDal.GetListBookingdata();
        }

        public void TInsert(Booking t)
        {
            _bookingDal.Insert(t);
        }

        public void TStatusBookingChangeApproverd(int id)
        {
             _bookingDal.StatusBookingChangeApproverd(id);
        }

        public void TStatusBookingChangeCancel(int id)
        {
            _bookingDal.StatusBookingChangeCancel(id);
        }

        public void TStatusBookingChangeStop(int id)
        {
            _bookingDal.StatusBookingChangeStop(id);
        }

        public void TUpdate(Booking t)
        {
            _bookingDal.Update(t);
        }
    }
}
