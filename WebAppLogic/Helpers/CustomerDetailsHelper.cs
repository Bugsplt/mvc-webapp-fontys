using System.Collections.Generic;
using InterfaceLayer.DTO;
using LogicLayer.Classes;
using Newtonsoft.Json.Linq;

namespace LogicLayer.Helpers
{
    public class CustomerDetailsHelper
    {
        public JToken LoadCustomerDetailView(string id)
        {
            //todo fill in logic classes as well
            var (body, url) = Toolbox.GetCustomerDetailView(id);
            var json = Toolbox.ApiPost(body,url); 
            return JToken.Parse(json);
        }

        public void UpdateCustomerDetails(CustomerDetailDTO detailDto)
        {
            //todo update logic classes as well
            var (body, url) = Toolbox.UpdateCustomerDetails(detailDto);
            Toolbox.ApiPost(body,url); 
        }
    }
}