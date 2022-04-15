using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using LogicLayer.Classes;
using Newtonsoft.Json.Linq;

namespace LogicLayer.Helpers
{
    public class CustomerViewHelper
    {
        public void LoadCustomerView()
        {
            var (body, url) = Toolbox.GetCustomerOverView();
            var json = Toolbox.ApiPost(body,url);
            var token = JToken.Parse(json);
            if (token["Prospects"] != null)
            {
                var prospects = new List<Prospect>();
                foreach (var variable in token["Prospects"])
                {
                    prospects.Add(new Prospect(variable["catName"]?.ToString(),variable["email"]?.ToString(),
                        variable["phoneNr"]?.ToString(),variable["prospectNr"]?.ToString()));
                }
                Toolbox.ProspectContainer.SetProspects(prospects);
            } 
            if (token["Customers"] != null)
            { 
                var customers = new List<Customer>();
                foreach (var variable in token["Customers"])
                {
                    customers.Add(new Customer(variable["firstName"]?.ToString(),variable["email"]?.ToString(),
                        variable["phoneNr"]?.ToString(),variable["id"]?.ToString()));
                }
                Toolbox.CustomerContainer.SetCustomers(customers);
            } 
        }
    }
}