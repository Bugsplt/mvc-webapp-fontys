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
        private static IApiClient _apiClient = new ApiClient();
        private static IRequestBuilder _requestBuilder = new RequestBuilder();
        public static CustomerContainer CustomerContainer = new();
        public static MapDataContainer MapDataContainer = new();
        public static ProspectContainer ProspectContainer = new();
        public static CustomerViewHelper CustomerViewHelper = new();
        public static CustomerDetailsHelper CustomerDetailsHelper = new();

        
        
        public static CustomerDetailDTO ToDto(string name, List<string> activity, List<string> searches, string catName,
            string country, string phone, string email, string status, List<string> notes, List<string> tasks,
            List<string> orders, List<string> tips, string fbAdId, string fbPostId, string id, string instaAdId,
            string instaPostId, string language)
        {
            return new ()
            {
                Name = name,
                Activity = activity,
                Searches = searches,
                CatName = catName,
                Country = country,
                Phone = phone,
                Email = email,
                Status = status,
                Notes = notes,
                Tasks = tasks,
                Orders = orders,
                Tips = tips,
                FbAdId = fbAdId,
                FbPostId = fbPostId,
                Id = id,
                InstaAdId = instaAdId,
                InstaPostId = instaPostId,
                Language = language
            };
        }

        public static string ApiPost(string body, string url)
        {
            return _apiClient.Post(body, url);
        }

        public static string ApiGet(string url)
        {
            return _apiClient.Get(url);
        }

        public static (string, string) GetCustomerOverView()
        {
            return _requestBuilder.GetCustomerOverView();
        }

        public static (string, string) GetCustomerDetailView(string id)
        {
            return _requestBuilder.GetCustomerDetailView(id);
        }

        public static (string, string) UpdateCustomerDetails(CustomerDetailDTO detailDto)
        {
            return _requestBuilder.UpdateCustomerDetails(detailDto);
        }
    }
    
}