using System.Collections.Generic;
using InterfaceLayer.DTO;

namespace InterfaceLayer.Interface
{
    public interface IApiCallManager
    {
        public CustomerDTO LoadCustomerDetailView(string id);
        public void UpdateCustomerDetails(CustomerDTO detailDto);
        public (List<ProspectDTO>, List<CustomerDTO>) LoadCustomerView();
        public void RemoveCustomer(CustomerDTO customerDto);
        public int CreateCustomer(CustomerDTO customerDto);
        
        public List<MapDataDTO> LoadMapData();
    }
}