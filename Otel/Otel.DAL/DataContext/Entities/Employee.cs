using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.DAL.DataContext.Entities
{
    public class Employee:BaseEntity
    {
        public required string Name { get; set; }
        public int WorkId { get; set; }
        public required string ImagePath { get; set; }
    }
}
