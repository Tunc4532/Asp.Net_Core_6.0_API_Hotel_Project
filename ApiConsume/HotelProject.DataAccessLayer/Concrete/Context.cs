﻿using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server= monster2684tunc\\SQLEXPRESS; initial catalog=ApiDb; integrated security=true");
        }

        public DbSet<Room>? Rooms { get; set; }
        public DbSet<Service>? Services { get; set; }
        public DbSet<Staff>? Staff { get; set; }
        public DbSet<Subscribe>? Subscribes { get; set; }
        public DbSet<Testimonial>? Testimonials { get; set; }
        public DbSet<About>? Abouts { get; set; }
        public DbSet<Booking>? Bookings { get; set; }
        public DbSet<Guest>? Guests { get; set; }
        public DbSet<Contact>? Contacts { get; set; }
        public DbSet<SendMessage>? SendMessages { get; set; }
        public DbSet<MessageCatagory>? MessageCatagories { get; set; }
        public DbSet<WorkLocation>? WorkLocations { get; set; }


    }
}
