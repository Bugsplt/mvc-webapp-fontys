using System.Text.Json;
using InterfaceLayer.DTO;
using InterfaceLayer.Interface;

namespace WebAppDAL
{
    public class RequestBuilder : IRequestBuilder
    {
        public (string, string) GetCustomerOverView()
        {
            return ("{\"key\":\"5fbdfe2ff544aade4708dd58fa6962a\"}",
                "https://server.kattenradar.nl/get-dashboard-overview");
        }

        public (string, string) GetCustomerDetails(string id)
        {
            return ("{\"key\":\"2365fn348q6qm239781fhn873ub238u\",\"id\":\"" + id + "\"}",
                "https://server.kattenradar.nl/get-customer-detail-view");
        }
        
        public (string, string) UpdateCustomerDetails(CustomerDTO detailDto)
        {
            var jsonString = JsonSerializer.Serialize(detailDto);
            var reqBody = "{\"key\":\"2yq3yf7iq2v78qhwfn6gqw3i7rfhnwef6q7ihf3kyqe\",\"id\":\"" + detailDto.Id +
                          "\",\"content\":" + jsonString + "}";
            return (reqBody, "https://server.kattenradar.nl/edit-customer-details");
        }
    }
}