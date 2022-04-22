using InterfaceLayer.DTO;

namespace InterfaceLayer.Interface
{
    public interface IRequestBuilder
    {
        public (string, string) GetCustomerOverView();
        public (string, string) GetCustomerDetails(string id);
        public (string, string) UpdateCustomerDetails(CustomerDTO detailDto);

    }
}