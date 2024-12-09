using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public List<ESim> ESims { get; set; }
        public Guid PaymentId { get; set; }
        public Payment Payment { get; set; }
        public DateTime OrderDate { get; set;}
    }
}