using System;
using LogicLayer.Enums;

namespace LogicLayer.Classes
{
    public class MapData
    {
        public CatStatus CatStatus { get; private set; }
        public DateTime Date { get; private set; }

        private int _id;
        private string _searchNr;
        
        public void SetCatStatus(CatStatus catStatus)
        {
            CatStatus = catStatus;
        }

        public void SetDate(DateTime date)
        {
            Date = date;
        }
    }
}