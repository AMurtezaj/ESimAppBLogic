using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Payment
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public string Method { get; set; }
        public string TransactionStatus { get; set; }
        
    }
}