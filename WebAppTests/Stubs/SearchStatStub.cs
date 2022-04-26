using System;
using System.Collections.Generic;
using InterfaceLayer.DTO;
using LogicLayer.Classes;

namespace WebAppProftS2Tests.Stubs
{
    public class SearchStatStub
    {
        public List<SearchStatDTO> SearchStats;

        public SearchStatStub()
        {
            SearchStats = new List<SearchStatDTO>();
            
            SearchStats.Add(new SearchStatDTO()
            {
                _id = 1,
                _searchNr = "1",
                Date = new DateTime(2022, 4, 26),
                Impressions = 1,
                Interactions = 1,
                Likes = 1
            });
            SearchStats.Add(new SearchStatDTO()
            {
                _id = 2,
                _searchNr = "2",
                Date = new DateTime(2022, 4, 27),
                Impressions = 2,
                Interactions = 2,
                Likes = 2
            });
            SearchStats.Add(new SearchStatDTO()
            {
                _id = 3,
                _searchNr = "3",
                Date = new DateTime(2022, 4, 28),
                Impressions = 3,
                Interactions = 3,
                Likes = 3
            });
        }
    }
}