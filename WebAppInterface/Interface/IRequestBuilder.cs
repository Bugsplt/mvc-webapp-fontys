using InterfaceLayer.DTO;

namespace InterfaceLayer.Interface
{
    public interface IRequestBuilder
    {
        public (string, string) GetCustomerOverView();
        public (string, string) GetCustomerDetailView(string id);
        public (string, string) UpdateCustomerDetails(CustomerDetailDTO detailDto);

    }
}