using System.Text.Json;
using InterfaceLayer.DTO;
using InterfaceLayer.Interface;

namespace WebAppProftS2Tests.Mocks
{
    public class ValidRequestBuilderMock : IRequestBuilder
    {
        public (string, string) GetCustomerOverView()
        {
            var body = "valid";
            var url = "https://server.kattenradar.nl/get-dashboard-overview";
            return (body, url);
        }
        
        public (string, string) GetCustomerDetails(string id)
        {
            var body = "{\"id\":\"" + id +"\"}";
            var url = "https://server.kattenradar.nl/get-customer-detail-view";
            return (body, url);
        }

        public (string, string) UpdateCustomerDetails(CustomerDTO detailDto)
        {
            var jsonString = JsonSerializer.Serialize(detailDto);
            var reqBody = "{\"id\":\"" + detailDto.Id +
                          "\",\"content\":" + jsonString + "}";
            return (reqBody, "https://server.kattenradar.nl/edit-customer-details");
        }

        public (string, string) RemoveCustomer(CustomerDTO customer)
        {
            var jsonString = JsonSerializer.Serialize(customer);
            var reqBody = "{\"id\":\"" + customer.Id +
                          "\",\"content\":" + jsonString + "}";
            return (reqBody, "https://server.kattenradar.nl/remove-customer");
        }

        public (string, string) CreateCustomer(CustomerDTO customer)
        {
            var jsonString = JsonSerializer.Serialize(customer);
            var reqBody = "{\"id\":\"" + customer.Id +
                          "\",\"content\":" + jsonString + "}";
            return (reqBody, "https://server.kattenradar.nl/create-customer");
        }
    }
}