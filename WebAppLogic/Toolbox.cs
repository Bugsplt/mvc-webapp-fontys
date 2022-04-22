using System.Collections.Generic;
using InterfaceLayer.DTO;
using InterfaceLayer.Interface;
using LogicLayer.Containers;
using LogicLayer.Helpers;
using WebAppDAL;

namespace LogicLayer
{
    public static class Toolbox
    {
        public static IApiClient _apiClient = new ApiClient();
        public static IRequestBuilder _requestBuilder = new RequestBuilder();
        public static CustomerContainer CustomerContainer = new();
        public static MapDataContainer MapDataContainer = new();
        public static ProspectContainer ProspectContainer = new();
        public static CustomerViewHelper CustomerViewHelper = new();
        public static CustomerDetailsHelper CustomerDetailsHelper = new(_apiClient);
        
 // public static string ApiPost(string body, string url)
        // {
        //     return _apiClient.Post(body, url);
        // }
        //
        // public static string ApiGet(string url)
        // {
        //     return _apiClient.Get(url);
        // }
        //
        // public static (string, string) GetCustomerOverView()
        // {
        //     return _requestBuilder.GetCustomerOverView();
        // }
        //
        // public static (string, string) GetCustomerDetailView(string id)
        // {
        //     return _requestBuilder.GetCustomerDetailView(id);
        // }
        //
        // public static (string, string) UpdateCustomerDetails(CustomerDTO detailDto)
        // {
        //     return _requestBuilder.UpdateCustomerDetails(detailDto);
        // }
       
    }
}