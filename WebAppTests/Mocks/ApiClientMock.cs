using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using InterfaceLayer.DTO;
using InterfaceLayer.Interface;
using LogicLayer.Classes;
using Newtonsoft.Json.Linq;
using WebAppProftS2Tests.Stubs;

namespace WebAppProftS2Tests.Mocks
{
    public class ApiClientMock : IApiClient
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
                throw new ArgumentException("Invalid Post Url");
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
                        prospectToken["catName"] = prospectDto.CatName;
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
                    if (_customerStub.Customers != null)
                    {
                        foreach (var customerStubCustomer in _customerStub.Customers)
                        {
                            if (customerStubCustomer.Id == JToken.Parse(body)["id"]?.ToString())
                            {
                                customerDetails = customerStubCustomer;
                            }
                        }
                    }

                    if (customerDetails == null)
                    {
                        throw new ArgumentException("Customer not found");
                    }

                    var activities = new JArray();
                    if (customerDetails._activities != null)
                    {
                        foreach (var activity in customerDetails._activities)
                        {
                            activities.Add(activity.Type);
                        }
                    }

                    jToken["activity"] = activities;

                    var tips = new JArray();
                    if (customerDetails._searches != null)
                    {
                        if (customerDetails._searches.Count != 0)
                        {
                            if (customerDetails._searches[0]._tips != null)
                            {
                                foreach (var tip in customerDetails._searches[0]._tips)
                                {
                                    tips.Add(tip.Content);
                                }

                                jToken["FbPostId"] = customerDetails._searches[0].FbPostId;
                                jToken["instaPostId"] = customerDetails._searches[0].IgPostId;
                                jToken["catName"] = customerDetails._searches[0].CatName;
                            }

                            if (customerDetails._searches[0]._areas != null)
                            {
                                jToken["FbAdId"] = customerDetails._searches[0]._areas[0].FbAdId;
                                jToken["instaAdId"] = customerDetails._searches[0]._areas[0].IgAdId;
                            }
                        }
                    }

                    jToken["tips"] = tips;


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
                    _customerStub.Customers[
                            int.Parse(JToken.Parse(body)["id"]?.ToString() ??
                                      throw new InvalidOperationException("Id was null"))] =
                        JsonSerializer.Deserialize<CustomerDTO>(JToken.Parse(body)["content"]?.ToString() ??
                                                                throw new InvalidOperationException(
                                                                    "Content was null"));
                    return "success";
                //removes a customer
                case "https://server.kattenradar.nl/remove-customer":
                    CustomerDTO customerDetails2 = null;
                    foreach (var customerStubCustomer in _customerStub.Customers)
                    {
                        if (customerStubCustomer.Id == JToken.Parse(body)["id"]?.ToString())
                        {
                            customerDetails2 = customerStubCustomer;
                        }
                    }

                    if (customerDetails2 == null)
                    {
                        throw new ArgumentException("Customer not found");
                    }

                    _customerStub.Customers.Remove(customerDetails2);
                    return "success";
                //creates a new customer
                case "https://server.kattenradar.nl/create-customer":
                    var contained = false;
                    var test = JToken.Parse(body)["content"]?.ToString();
                    var customer = JsonSerializer.Deserialize<CustomerDTO>(test);
                   foreach (var customerStubCustomer in _customerStub.Customers)
                   {
                       if (customerStubCustomer.Email == customer?.Email)
                       {
                           contained = true;
                       }
                   }
                    if (contained)
                    {
                        throw new ArgumentException("A customer with this email already exists");
                    }
                    customer.Id = (_customerStub.Customers.Count + 1).ToString();
                    foreach (var customerStubCustomer in _customerStub.Customers)
                    {
                        if (customerStubCustomer.Email == customer.Email)
                        {
                            throw new ArgumentException("Email already exists");
                        }
                    }

                    var id = _customerStub.Customers.Count + 999;
                    customer.Id = id.ToString();
                    _customerStub.Customers.Add(customer);
                    return "{\"id\":" + id + "}";
                default:
                    throw new Exception("Url not recognized (should be valid?)");
            }
        }

        public ApiClientMock(ProspectStub prospectStub, CustomerStub customerStub)
        {
            _prospectStub = prospectStub;
            _customerStub = customerStub;
        }
    }
}