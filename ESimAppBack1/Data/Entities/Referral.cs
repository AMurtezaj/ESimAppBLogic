using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Referral
    {
        public Guid Id { get; set; }
        public Guid ReferrerId { get; set; }
        public User Referrer { get; set; }
        public Guid RefereeId { get; set; }
        public User Referee { get; set; }
        public double RewardEarned { get; set; }
        public DateTime Date { get; set; }
         
    }
}