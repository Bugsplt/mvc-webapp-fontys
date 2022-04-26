using System.Collections.Generic;
using InterfaceLayer.DTO;
using InterfaceLayer.Interface;
using Newtonsoft.Json.Linq;

namespace WebAppDAL
{
    public class ApiCallManager : IApiCallManager
    {
        private IApiClient _apiClient;
        private IRequestBuilder _requestBuilder;

        public ApiCallManager(IApiClient api, IRequestBuilder requestBuilder)
        {
            _apiClient = api;
            _requestBuilder = requestBuilder;
        }

        public CustomerDTO LoadCustomerDetailView(string id)
        {
            var (body, url) = _requestBuilder.GetCustomerDetails(id);
            var json = _apiClient.Post(body,url); 
            var token = JToken.Parse(json);
            var activities = new List<ActivityDTO>();
            if (token["activity"] != null)
            {
                foreach (var activityName in token["activity"])
                {
                    activities.Add(new ActivityDTO(){Type = activityName.ToString()});
                }
            }

            var tips = new List<TipDTO>();
            if (token["tips"] != null)
            {
                foreach (var tip in token["tips"])
                {
                   tips.Add(new TipDTO()
                   {
                       Content = tip.ToString()
                   });
                }
            }

            var areas = new List<AreaDTO>();
           areas.Add(new AreaDTO()
           {
               FbAdId = token["FbAdId"]?.ToString(),
               IgAdId = token["instaAdId"]?.ToString(),
           });
            
            
            var searches = new List<SearchDTO>();
            searches.Add(new SearchDTO()
            {
                _tips = tips,
                _areas = areas,
                FbPostId = token["FbPostId"]?.ToString(),
                IgPostId = token["instaPostId"]?.ToString(),
                CatName = token["catName"]?.ToString()
                
            });
            
            return new CustomerDTO()
            {
                FirstName = token["name"]?.ToString(),
                Email = token["email"]?.ToString(),
                Status = token["status"]?.ToString(),
                _activities = activities,
                _searches = searches,
                Id = token["customerId"]?.ToString(),
                Language = token["language"]?.ToString(),
                Country = token["country"]?.ToString(),
                PhoneNr = token["phone"]?.ToString()
            };
        }

        public void UpdateCustomerDetails(CustomerDTO detailDto)
        {
            var (body, url) = _requestBuilder.UpdateCustomerDetails(detailDto);
            _apiClient.Post(body,url); 
        }
        
        public (List<ProspectDTO>, List<CustomerDTO>) LoadCustomerView()
        {
            var (body, url) = _requestBuilder.GetCustomerOverView();
            var json = _apiClient.Post(body, url);
            var token = JToken.Parse(json); 
            var prospects = new List<ProspectDTO>();
            if (token["Prospects"] != null)
            {
                foreach (var variable in token["Prospects"])
                {
                    prospects.Add(new ProspectDTO(){
                        CatName = variable["catName"]?.ToString(),
                        Email = variable["email"]?.ToString(),
                        PhoneNr = variable["phoneNr"]?.ToString(),
                        ProspectNr = variable["prospectNr"]?.ToString()
                    });
                }
            }  
            var customers = new List<CustomerDTO>();
            if (token["Customers"] != null)
            {
                foreach (var variable in token["Customers"])
                {
                    customers.Add(new CustomerDTO(){
                        FirstName = variable["firstName"]?.ToString(),
                        Email = variable["email"]?.ToString(),
                        PhoneNr = variable["phoneNr"]?.ToString(),
                        Id = variable["id"]?.ToString()
                    });
                }
            }
            return (prospects, customers);
        }
    }
}