using System;

namespace InterfaceLayer.DTO
{
    public class SearchStatDTO
    {
        public DateTime Date { get; set; }
        public int Impressions { get; set; }
        public int Interactions { get; set; }
        public int Likes { get; set; }
        public int _id { get; set; }
        public string _searchNr { get; set; }
    }
}