using InterfaceLayer.DTO;

namespace InterfaceLayer.Interface
{
    public interface IRequestBuilder
    {
        public (string, string) GetCustomerOverView();
        public (string, string) GetCustomerDetails(string id);
        public (string, string) UpdateCustomerDetails(CustomerDTO detailDto);
        public (string, string) RemoveCustomer(CustomerDTO customer);
        public (string, string) CreateCustomer(CustomerDTO customer);
    }
}