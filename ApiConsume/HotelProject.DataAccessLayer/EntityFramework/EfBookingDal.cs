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
    public class EfBookingDal : GenericRepostory<Booking>, IBookingDal
    {
        public EfBookingDal(Context context) : base(context)
        {

        }

        public void BookingStatusChangeApproverd(Booking booking)
        {
            var context = new Context();
            var values = context.Bookings.Where(x => x.BookingID == booking.BookingID).FirstOrDefault();
            values.Status = true;
            context.SaveChanges();

        }

        public void BookingStatusChangeApproverd2(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status = true;
            context.SaveChanges();
        }

        public int GetBookingCount()
        {
            using var context = new Context();
            var values = context.Bookings.Count();
            return values;
        }

        public List<Booking> GetListBookingdata()
        {
            using var context = new Context();
            var values = context.Bookings.OrderByDescending(x => x.BookingID).Take(5).ToList();
            return values;
        }

        public void StatusBookingChangeApproverd(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status2 = "Onaylandı";
            context.SaveChanges();
        }

        public void StatusBookingChangeCancel(int id)
        {
            var  context = new Context();
            var values = context.Bookings.Find(id);
            values.Status2 = "İptal Edildi";
            context.SaveChanges();
        }

        public void StatusBookingChangeStop(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status2 = "Müşteri Aranacak";
            context.SaveChanges();
        }
    }
}
