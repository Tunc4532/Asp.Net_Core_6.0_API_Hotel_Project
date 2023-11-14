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
    public class EfStaffDal : GenericRepostory<Staff>, IStaffDal
    {
        public EfStaffDal(Context context) : base(context) 
        {
            
        }

        public int GetStaffCount()
        {
            using var context = new Context();
            var values = context.Staff.Count();
            return values;
            
        }

        public List<Staff> Last4Staff()
        {
            using var contex = new Context();
            var vales = contex.Staff.OrderByDescending(x => x.StaffID).Take(4).ToList();
            return vales;
        }
    }
}
