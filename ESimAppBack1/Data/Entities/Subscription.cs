using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Subscription
    {
        public Guid Id { get; set; }
        public string PlanName { get; set; }
        public int ValidityInDays { get; set; }
        public bool RenewalStatus { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}