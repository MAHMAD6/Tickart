using System;
using System.Collections.Generic;
using System.Text;

namespace Tickart.BL
{
    
    public class User
    {
        public int UserId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Image { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<Cart> Carts { get; set; } = new List<Cart>();
    }

    public class Ticket
    {
        public int TicketId { get; set; }
        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public DateTime EventDate { get; set; }
        public string Venue { get; set; }
        public decimal Price { get; set; }
        public int TotalSeats { get; set; }
        public int AvailableSeats { get; set; }
        public string EventImage { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<Cart> Carts { get; set; } = new List<Cart>();
    }

    public class Cart
    {
        public int CartId { get; set; }
        public int UserId { get; set; }
        public int TicketId { get; set; }
        public int Quantity { get; set; }
        public DateTime AddedAt { get; set; }
        public User User { get; set; }
        public Ticket Ticket { get; set; }
    }

}
