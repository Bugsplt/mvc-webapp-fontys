using System;
using InterfaceLayer.DTO;
using LogicLayer.Enums;

namespace LogicLayer.Classes
{
    public class MapData
    {
        public CatStatus CatStatus { get; private set; }
        public DateTime Date { get; private set; }

        public int _id;
        public string _searchNr;
        
        public void SetCatStatus(CatStatus catStatus)
        {
            CatStatus = catStatus;
        }

        public void SetDate(DateTime date)
        {
            Date = date;
        }

        public MapData(){}

        public MapData(MapDataDTO dto)
        {
            CatStatus = (CatStatus) dto.CatStatus;
            Date = dto.Date;
            _id = dto._id;
            _searchNr = dto._searchNr;
        }
        
        public MapDataDTO ToDto()
        {
            return new()
            {
                CatStatus = (InterfaceLayer.Enums.CatStatus) CatStatus,
                Date = Date,
                _id = _id,
                _searchNr = _searchNr
            };
        }
    }
}