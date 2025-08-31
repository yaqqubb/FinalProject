using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.DAL.DataContext.Entities
{
    public class Appointment:BaseEntity
    {
        public required int  RoomId {get; set;}
        public required Room Room { get; set;}
        public  DateTime AppointmentDate { get; set;}
        public required decimal TotalAmount { get; set;}
        public required string TotalGuestCount {  get; set;}
        public required int CustomerId { get; set;} 
        public required Customer Customer { get; set;}
    }
}
