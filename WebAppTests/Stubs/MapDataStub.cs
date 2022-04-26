using System;
using System.Collections.Generic;
using InterfaceLayer.DTO;
using InterfaceLayer.Enums;

namespace WebAppProftS2Tests.Stubs
{
    public class MapDataStub
    {
        public List<MapDataDTO> MapDatas;

        public MapDataStub()
        {
            MapDatas = new List<MapDataDTO>();
            
            MapDatas.Add(new MapDataDTO()
            {
                _id = 1,
                _searchNr = "1",
                CatStatus = CatStatus.Deceased,
                Date = new DateTime(2022, 4, 26)
            });
            MapDatas.Add(new MapDataDTO()
            {
                _id = 2,
                _searchNr = "2",
                CatStatus = CatStatus.Missing,
                Date = new DateTime(2022, 4, 27)
            });
            MapDatas.Add(new MapDataDTO()
            {
                _id = 2,
                _searchNr = "2",
                CatStatus = CatStatus.Safe,
                Date = new DateTime(2022, 4, 28)
            });
        }
    }
}