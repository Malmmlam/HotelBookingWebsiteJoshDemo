using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace HotelBookingWebsiteMe.Models
{
    public enum RoomType
    {
        [Display(Name = "Studio")]
        Studio,
        [Display(Name = "Single")]
        Single,
        [Display(Name = "Double")]
        Double,
        [Display(Name = "Twin")]
        Twin,
        [Display(Name = "Suite")]
        Suite
    }

    public class Room
    {
        public int ID { get; set; }
        public string RoomNumber { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public RoomType Type { get; set; }
        public List<Booking> Bookings { get; }
        public bool IsBooked { get; set; }
        public Room()
        {
            Bookings = new List<Booking>(); 
        }
    }
}
