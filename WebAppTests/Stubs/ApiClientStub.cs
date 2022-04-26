using System.Runtime.InteropServices;
using InterfaceLayer.DTO;
using InterfaceLayer.Interface;

namespace WebAppProftS2Tests.Stubs
{
    public class ApiClientStub : IApiClient
    {
        private CustomerDTO customer1 = new CustomerDTO()
        {
            
        };
        
        
        
        public string Get(string getUrl)
        {
            throw new System.NotImplementedException();
        }

        public string Post(string body, string postUrl)
        {
            throw new System.NotImplementedException();
        }
    }
}