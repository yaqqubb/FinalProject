using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.DAL.DataContext.Entities
{
    public class SpecialOffer:BaseEntity
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required decimal TotalAmount { get; set; }
        public required DateTime ValidityDate { get; set; }
        public required string ImagePath { get; set; }

    }
}
