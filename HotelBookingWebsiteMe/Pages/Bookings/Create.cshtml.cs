﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HotelBookingWebsiteMe.Data;
using HotelBookingWebsiteMe.Models;

namespace HotelBookingWebsiteMe.Pages.Bookings
{
    public class CreateModel : PageModel
    {
        private readonly HotelBookingWebsiteMe.Data.HotelBookingWebsiteMeContext _context;

        public CreateModel(HotelBookingWebsiteMe.Data.HotelBookingWebsiteMeContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Booking Booking { get; set; }

        [BindProperty]
        public Room Room { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Booking.Add(Booking);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
