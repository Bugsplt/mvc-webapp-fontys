using System.Collections.Generic;
using InterfaceLayer.Enums;

namespace InterfaceLayer.DTO
{
    public class SearchDTO
    {
        public FeedbackDTO Feedback { get; set; }
        public CatStatus CatStatus { get; set; }
        public AdStatus AdStatus { get; set; }
        public string CatName { get; set; }
        public string PostMssg { get; set; }
        public string AdCampId { get; set; }
        public string Tag { get; set; }
        public string FbPostId { get; set; }
        public string IgPostId { get; set; }
        public string IgPostUrl { get; set; }
        public string CatImg { get; set; }
        public string MockupImg { get; set; }
        public string PostImg { get; set; }
        public double AdSpent { get; set; }
        public string _searchNr { get; set; }
        public List<TipDTO> _tips { get; set; }
        public List<AreaDTO> _areas { get; set; }
        public List<SearchStatDTO> _searchStats { get; set; }
    }
}