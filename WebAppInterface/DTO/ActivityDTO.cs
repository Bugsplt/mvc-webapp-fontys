using System;

namespace InterfaceLayer.DTO
{
    public class ActivityDTO
    {
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int _id { get; set; }
    }
}