using System;
using InterfaceLayer.DTO;

namespace LogicLayer.Classes
{
    public class SearchStat
    {
        public DateTime Date { get; private set; }
        public int Impressions { get; private set; }
        public int Interactions { get; private set; }
        public int Likes { get; private set; }

        private int _id;
        private string _searchNr;

        public void SetDate(DateTime date)
        {
            Date = date;
        }

        public void SetImpressions(int impressions)
        {
            Impressions = impressions;
        }

        public void SetInteractions(int interactions)
        {
            Interactions = interactions;
        }

        public void SetLikes(int likes)
        {
            Likes = likes;
        }
        
        public SearchStat(){}

        public SearchStat(SearchStatDTO dto)
        {
            Date = dto.Date;
            Impressions = dto.Impressions;
            Interactions = dto.Interactions;
            Likes = dto.Likes;
            _id = dto._id;
            _searchNr = dto._searchNr;
        }

        public SearchStatDTO ToDto()
        {
            return new()
            {
                Date = Date,
                Impressions = Impressions,
                Interactions = Interactions,
                Likes = Likes,
                _id = _id,
                _searchNr = _searchNr
            };
        }
    }
}