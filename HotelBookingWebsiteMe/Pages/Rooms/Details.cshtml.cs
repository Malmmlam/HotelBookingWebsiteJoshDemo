﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly HotelBookingWebsiteMe.Data.HotelBookingWebsiteMeContext _context;

        public DetailsModel(HotelBookingWebsiteMe.Data.HotelBookingWebsiteMeContext context)
        {
            _context = context;
        }

        public Room Room { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Room = await _context.Room.FirstOrDefaultAsync(m => m.ID == id);

            if (Room == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
