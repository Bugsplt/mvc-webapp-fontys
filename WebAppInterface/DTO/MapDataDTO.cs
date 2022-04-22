using System;
using InterfaceLayer.Enums;

namespace InterfaceLayer.DTO
{
    public class MapDataDTO
    {
        public CatStatus CatStatus { get; set; }
        public DateTime Date { get; set; }
        public int _id { get; set; }
        public string _searchNr { get; set; }
    }
}