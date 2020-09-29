using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HotelBookingWebsiteMe.Models;

namespace HotelBookingWebsiteMe.Data
{
    public class HotelBookingWebsiteMeContext : DbContext
    {
        public HotelBookingWebsiteMeContext (DbContextOptions<HotelBookingWebsiteMeContext> options)
            : base(options)
        {
        }

        public DbSet<HotelBookingWebsiteMe.Models.Room> Room { get; set; }

        public DbSet<HotelBookingWebsiteMe.Models.Booking> Booking { get; set; }
    }
}
