using InterfaceLayer.DTO;
using InterfaceLayer.Interface;

namespace WebAppProftS2Tests.Scrubs
{
    public class InvalidRequestUrlBuilderScrub : IRequestBuilder
    {
        public (string, string) GetCustomerOverView()
        {
            var body = "valid";
            var url = "invalid";
            return (body, url);
        }

        public (string, string) GetCustomerDetails(string id)
        {
            var body = "valid";
            var url = "invalid";
            return (body, url);
        }

        public (string, string) UpdateCustomerDetails(CustomerDTO detailDto)
        {
            var reqBody = "valid";
            var url = "invalid";
            return (reqBody, url);
        }

        public (string, string) RemoveCustomer(CustomerDTO customer)
        {
            var body = "valid";
            var url = "invalid";
            return (body, url);
        }

        public (string, string) CreateCustomer(CustomerDTO customer)
        {
            var body = "valid";
            var url = "invalid";
            return (body, url);
        }
    }
}