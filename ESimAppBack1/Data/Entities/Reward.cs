using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Reward
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; } 
        public string RewardType { get; set; }
        public string Status { get; set; }
        public DateTime ExpirationDate { get; set; }
        
    }
}