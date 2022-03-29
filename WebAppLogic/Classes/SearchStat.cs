using System;

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
    }
}