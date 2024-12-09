using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class ESim
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DataAllowance { get; set; } //MB/GB
        public int ValidityPeriod { get; set; }
        public double Price { get; set; }
        public Guid ProviderId { get; set; }
        public Provider Provider { get; set; }
        public List <Order> Orders { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Promotion> Promotions { get; set; }
        public List <Region> Regions { get; set; }
    }
}