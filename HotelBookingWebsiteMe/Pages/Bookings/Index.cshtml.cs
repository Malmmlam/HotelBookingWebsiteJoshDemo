using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HotelBookingWebsiteMe.Data;
using HotelBookingWebsiteMe.Models;

namespace HotelBookingWebsiteMe.Pages.Bookings
{
    public class IndexModel : PageModel
    {
        private readonly HotelBookingWebsiteMe.Data.HotelBookingWebsiteMeContext _context;

        public IndexModel(HotelBookingWebsiteMe.Data.HotelBookingWebsiteMeContext context)
        {
            _context = context;
        }

        public IList<Booking> Booking { get;set; }

        public async Task OnGetAsync()
        {
            Booking = await _context.Booking.ToListAsync();
        }
    }
}
