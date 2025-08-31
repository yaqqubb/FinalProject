namespace Otel.DAL.DataContext.Entities
{
    public class Room:BaseEntity
    {
        public required int RoomNumber { get; set; }
        public required int RoomTypeId {get; set; }
        public required  RoomType RoomType { get; set; }
        public RoomStatus Status { get; set; }
        public required string ImagePath { get; set; }



    }
}
