using System;
using InterfaceLayer.Enums;

namespace InterfaceLayer.DTO
{
    public class TipDTO
    {
        public SightingDTO Sighting { get; set; }
        public Platform Platform { get; set; }
        public DateTime SightingDate { get; set; }
        public DateTime Date { get; set; }
        public string Contact { get; set; }
        public string Content { get; set; }
        public int _id { get; set; }
    }
}