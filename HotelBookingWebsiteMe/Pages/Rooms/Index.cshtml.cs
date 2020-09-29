using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HotelBookingWebsiteMe.Data;
using HotelBookingWebsiteMe.Models;

namespace HotelBookingWebsiteMe.Pages.Rooms
{
    public class IndexModel : PageModel
    {
        private readonly HotelBookingWebsiteMe.Data.HotelBookingWebsiteMeContext _context;

        public IndexModel(HotelBookingWebsiteMe.Data.HotelBookingWebsiteMeContext context)
        {
            _context = context;
        }

        public IList<Room> Room { get;set; }

        public async Task OnGetAsync()
        {
            Room = await _context.Room.ToListAsync();
        }
    }
}
