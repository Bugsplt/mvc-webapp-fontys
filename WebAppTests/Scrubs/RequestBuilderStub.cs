using InterfaceLayer.DTO;
using InterfaceLayer.Interface;

namespace WebAppProftS2Tests.Stubs
{
    public class RequestBuilderStub : IRequestBuilder
    {
        public (string, string) GetCustomerOverView()
        {
            throw new System.NotImplementedException();
        }

        public (string, string) GetCustomerDetails(string id)
        {
            throw new System.NotImplementedException();
        }

        public (string, string) UpdateCustomerDetails(CustomerDTO detailDto)
        {
            throw new System.NotImplementedException();
        }
    }
}