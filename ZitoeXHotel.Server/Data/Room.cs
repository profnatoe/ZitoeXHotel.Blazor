using System.Collections.Generic;

namespace ZitoeXHotel.Server.Data
{
      public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public ICollection<RoomProperty> RoomProperties { get; set; }
        public bool IsActive { get; set; }

    }

    public class RoomProperty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
