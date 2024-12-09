using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Review
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid ESIMId { get; set; }
        public ESim ESim { get; set; } 
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; } 
    }
}