using InterfaceLayer.DTO;
using InterfaceLayer.Interface;

namespace WebAppProftS2Tests.Scrubs
{
    public class InvalidRequestBodyBuilderScrub : IRequestBuilder
    {
        public (string, string) GetCustomerOverView()
        {
            var body = "invalid";
            var url = "valid";
            return (body, url);
        }

        public (string, string) GetCustomerDetails(string id)
        {
            var body = "invalid";
            var url = "valid";
            return (body, url);
        }

        public (string, string) UpdateCustomerDetails(CustomerDTO detailDto)
        {
            var reqBody = "invalid";
            var url = "valid";
            return (reqBody, url);
        }

        public (string, string) RemoveCustomer(CustomerDTO customer)
        {
            throw new System.NotImplementedException();
        }

        public (string, string) CreateCustomer(CustomerDTO customer)
        {
            throw new System.NotImplementedException();
        }
    }
}