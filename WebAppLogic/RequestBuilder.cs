using System.Collections.Generic;
using LogicLayer.Classes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LogicLayer
{
    public class RequestBuilder
    {
        public string KrUpdateCustomer(Customer customer, List<string> variableArr)
        {
            var jsonObj = new JObject();
            jsonObj["editVariables"] = JToken.FromObject(variableArr);
            jsonObj["customer"] = JToken.FromObject(customer); 
            return JsonConvert.SerializeObject(jsonObj);
        }
        
        
    }
}