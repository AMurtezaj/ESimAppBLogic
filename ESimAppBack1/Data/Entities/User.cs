using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set;}
        public string Surname {get; set;}
        public string Email {get; set;}
        public int PhoneNumber {get; set;}
        public string Password {get; set;}
        public List<Order> Orders { get; set; }
        public List<Payment> Payments { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Referral> Referrals { get; set; }
        public List<Reward> Rewards { get; set; }
        public List<SupportTicket> SupportTickets { get; set; }
        public List<Subscription> Subscriptions { get; set; }
        
    }
}