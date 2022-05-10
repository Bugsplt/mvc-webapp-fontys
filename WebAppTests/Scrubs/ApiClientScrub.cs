using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using InterfaceLayer.DTO;
using InterfaceLayer.Interface;
using LogicLayer.Classes;
using Newtonsoft.Json.Linq;
using WebAppProftS2Tests.Stubs;

namespace WebAppProftS2Tests.Scrubs
{
    public class ApiClientScrub : IApiClient
    {
        private ProspectStub _prospectStub;
        private CustomerStub _customerStub;
        
        public string Get(string getUrl)
        {
            throw new NotImplementedException();
        }

        public string Post(string body, string postUrl)
        {
            if (postUrl == "invalid")
            {
                throw new Exception("Invalid Post Url");
            }
            if (body == "invalid")
            {
                throw new Exception("Invalid Post Body");
            }
            var json = "";
            JToken jToken = new JObject();
            switch (postUrl)
            {
                //Gets multiple customers and prospects
                case "https://server.kattenradar.nl/get-dashboard-overview":
                    jToken["Prospects"] = new JObject();
                    var prospectArr = new List<JObject>();
                    foreach (var prospectDto in _prospectStub.Prospects)
                    {
                        var prospectToken = new JObject();
                        prospectToken["catName"] = prospectDto.CatName ;
                        prospectToken["email"] = prospectDto.Email;
                        prospectToken["phoneNr"] = prospectDto.PhoneNr;
                        prospectToken["prospectNr"] = prospectDto.ProspectNr;
                        prospectArr.Add(prospectToken);
                    }
                    jToken["Prospects"] = JToken.FromObject(prospectArr);
                    
                    jToken["Customers"] = new JObject();
                    var customerArr = new List<JObject>();
                    foreach (var customerDto in _customerStub.Customers)
                    {
                        var customerToken = new JObject();
                        customerToken["firstName"] = customerDto.FirstName;
                        customerToken["email"] = customerDto.Email;
                        customerToken["phoneNr"] = customerDto.PhoneNr;
                        customerToken["id"] = customerDto.Id;
                        customerArr.Add(customerToken);
                    }
                    jToken["Customers"] = JToken.FromObject(customerArr);
                    
                    json = jToken.ToString();
                    return json;
                //gets in depth details of a customer
                case "https://server.kattenradar.nl/get-customer-detail-view":
                    CustomerDTO customerDetails = null;
                    foreach (var customerStubCustomer in _customerStub.Customers)
                    {
                        if (customerStubCustomer.Id == JToken.Parse(body)["id"]?.ToString())
                        {
                            customerDetails = customerStubCustomer;
                        }
                    }
                    if (customerDetails == null)
                    {
                        throw new Exception("Customer not found");
                    }

                    var activities = new JArray();
                    foreach (var activity in customerDetails._activities)
                    {
                        activities.Add(activity.Type);
                    }
                    jToken["activity"] = activities;

                    var tips = new JArray();
                    foreach (var tip in customerDetails._searches[0]._tips)
                    {
                        tips.Add(tip.Content);
                    }
                    jToken["tips"] = tips;
                    
                    jToken["FbAdId"] = customerDetails._searches[0]._areas[0].FbAdId;
                    jToken["instaAdId"] = customerDetails._searches[0]._areas[0].IgAdId;
                    
                    jToken["FbPostId"] = customerDetails._searches[0].FbPostId;
                    jToken["instaPostId"] = customerDetails._searches[0].IgPostId;
                    jToken["catName"] = customerDetails._searches[0].CatName;

                    jToken["name"] = customerDetails.FirstName;
                    jToken["email"] = customerDetails.Email;
                    jToken["status"] = customerDetails.Status;
                    jToken["customerId"] = customerDetails.Id;
                    jToken["language"] = customerDetails.Language;
                    jToken["country"] = customerDetails.Country;
                    jToken["phone"] = customerDetails.PhoneNr;
                    json = jToken.ToString();
                    return json;
                //updates a customers details
                case "https://server.kattenradar.nl/edit-customer-details":
                    _customerStub.Customers[int.Parse(JToken.Parse(body)["id"]?.ToString() ?? throw new InvalidOperationException("Id was null"))] = 
                        JsonSerializer.Deserialize<CustomerDTO>(JToken.Parse(body)["content"]?.ToString() ?? throw new InvalidOperationException("Content was null"));
                    return "success";
                case "https://server.kattenradar.nl/remove-customer":
                    CustomerDTO customerDetails2 = null;
                    foreach (var customerStubCustomer in _customerStub.Customers)
                    {
                        if (customerStubCustomer.Id == JToken.Parse(body)["id"]?.ToString())
                        {
                            customerDetails2 = customerStubCustomer;
                        }
                    }
                    _customerStub.Customers.Remove(customerDetails2);
                    return "success";
                default:
                    throw new Exception("Url not recognized (should be valid?)");
            }
        }

        public ApiClientScrub(ProspectStub prospectStub, CustomerStub customerStub)
        {
            _prospectStub = prospectStub;
            _customerStub = customerStub;
        }
    }
}