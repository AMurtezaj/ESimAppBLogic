using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class SupportTicket
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string IssueDescription { get; set; }
        public string Status { get; set; }
        public string AssignedSupportAgent { get; set; }
        
    }
}