using System.Collections.Generic;
using InterfaceLayer.DTO;
using InterfaceLayer.Interface;
using LogicLayer.Classes;
using Newtonsoft.Json.Linq;

namespace LogicLayer.Helpers
{
    public class CustomerDetailsHelper
    {
        private IApiClient _apiClient;

        public CustomerDetailsHelper(IApiClient api)
        {
            _apiClient = api;
        }

        public JToken LoadCustomerDetailView(string id)
        {
            //todo fill in logic classes as well
            var (body, url) = Toolbox.GetCustomerDetailView(id);
            var json = _apiClient.Post(body,url); 
            return JToken.Parse(json);
        }

        public void UpdateCustomerDetails(CustomerDetailDTO detailDto)
        {
            //todo update logic classes as well
            var (body, url) = Toolbox.UpdateCustomerDetails(detailDto);
            _apiClient.Post(body,url); 
        }
    }
}