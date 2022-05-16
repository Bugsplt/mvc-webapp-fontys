using System.Collections.Generic;
using InterfaceLayer.DTO;
using InterfaceLayer.Interface;

namespace WebAppProftS2Tests.Scrubs
{
    public class ApiCallManagerStub : IApiCallManager
    {
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
    }
}