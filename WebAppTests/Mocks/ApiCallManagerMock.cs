using System;
using System.Collections.Generic;
using InterfaceLayer.DTO;
using InterfaceLayer.Enums;
using InterfaceLayer.Interface;

namespace WebAppProftS2Tests.Scrubs
{
    public class ApiCallManagerMock : IApiCallManager
    {
        public List<MapDataDTO> MapDataDtos { get; set; }

        public ApiCallManagerMock()
        {
            MapDataDtos = new List<MapDataDTO>();
            MapDataDtos.Add(new MapDataDTO(){CatStatus = CatStatus.Missing, Date = new DateTime(2018, 1, 1), _id = 1, _searchNr = "1"});
            MapDataDtos.Add(new MapDataDTO(){CatStatus = CatStatus.Safe, Date = new DateTime(2018, 1, 3), _id = 2, _searchNr = "2"});
        }
        
        public CustomerDTO LoadCustomerDetailView(string id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCustomerDetails(CustomerDTO detailDto)
        {
            throw new System.NotImplementedException();
        }

        public (List<ProspectDTO>, List<CustomerDTO>) LoadCustomerView()
        {
            throw new System.NotImplementedException();
        }

        public void RemoveCustomer(CustomerDTO customerDto)
        {
            throw new System.NotImplementedException();
        }

        public int CreateCustomer(CustomerDTO customerDto)
        {
            throw new System.NotImplementedException();
        }

        public List<MapDataDTO> LoadMapData()
        {
            return MapDataDtos;
        }
    }
}