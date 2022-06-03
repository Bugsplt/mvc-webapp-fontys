using System.Collections.Generic;
using InterfaceLayer.DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebAppDAL;
using WebAppProftS2.Models;

namespace WebAppProftS2Tests.DAL
{ 
    [TestClass]
    public class RequestBuilderTest
    {
        [TestMethod]
        public void TestGetCustomerDetails()
        {
            //Arrange
            var requestBuilder = new RequestBuilder();
            var id = "3";
            //Act
            var (body, url) = requestBuilder.GetCustomerDetails(id);
            //Assert
            var token = JToken.Parse(body);
            Assert.AreEqual(token["id"],id,"id could not be parsed from json");
        }

        [TestMethod]
        public void TestUpdateCustomerDetails()
        {
            //Arrange
            var requestBuilder = new RequestBuilder();
            var customerDto = new CustomerDTO();
            customerDto.Id = "15";
            customerDto.Email = "someMail";
            customerDto.FirstName = "someName";
            //Act
            var (body, url) = requestBuilder.UpdateCustomerDetails(customerDto);
            //Assert
            var token = JToken.Parse(body);
            Assert.AreEqual(token["content"]?["Id"],"15","id could not be parsed from json");
            Assert.AreEqual(token["content"]?["Email"],"someMail","email could not be parsed from json");
            Assert.AreEqual(token["content"]?["FirstName"],"someName","first name could not be parsed from json");
        }
        
        [TestMethod]
        public void TestRemoveCustomer()
        {
            //Arrange
            var requestBuilder = new RequestBuilder();
            var id = "15";
            //Act
            var (body, url) = requestBuilder.RemoveCustomer(new CustomerDTO() {Id = id});
            //Assert
            var token = JToken.Parse(body);
            Assert.AreEqual(id, token["id"],"id could not be parsed from json");
        }
        
        [TestMethod]
        public void TestCreateCustomer()
        {
            //Arrange
            var requestBuilder = new RequestBuilder();
            var customerDto = new CustomerDTO();
            customerDto.Id = "15";
            customerDto.Email = "someMail";
            customerDto.FirstName = "someName";
            customerDto.Country = "someCountry";
            customerDto.Language = "someLanguage";
            customerDto.PhoneNr = "somePhoneNr";
            customerDto._searches = new List<SearchDTO>();
            customerDto._searches.Add(new SearchDTO()
            {
                CatName = "someCatName",
                FbPostId = "someFbPostId",
                IgPostId = "someIgPostId",
                _areas = new List<AreaDTO>(new[]
                {
                    new AreaDTO()
                    {
                       _id = 8,
                       Lat = 1,
                       Lng = 2,
                       IgAdId = "someIgAdId",
                       FbAdId = "someFbAdId"
                    }
                })
            });
            //Act
            var (body, url) = requestBuilder.CreateCustomer(customerDto);
            //Assert
            var token = JToken.Parse(body);
            Assert.AreEqual(token["content"]?["Id"],"15","id could not be parsed from json");
            Assert.AreEqual(token["content"]?["Email"],"someMail","email could not be parsed from json");
            Assert.AreEqual(token["content"]?["FirstName"],"someName","first name could not be parsed from json");
            Assert.AreEqual(token["content"]?["Country"],"someCountry","country could not be parsed from json");
            Assert.AreEqual(token["content"]?["Language"],"someLanguage","language could not be parsed from json");
            Assert.AreEqual(token["content"]?["PhoneNr"],"somePhoneNr","phone nr could not be parsed from json");
            Assert.AreEqual(token["content"]?["_searches"]?[0]?["CatName"],"someCatName","cat name could not be parsed from json");
            Assert.AreEqual(token["content"]?["_searches"]?[0]?["FbPostId"],"someFbPostId","fb post id could not be parsed from json");
            Assert.AreEqual(token["content"]?["_searches"]?[0]?["IgPostId"],"someIgPostId","ig post id could not be parsed from json");
            Assert.AreEqual(token["content"]?["_searches"]?[0]?["_areas"]?[0]?["_id"],8,"id could not be parsed from json");
            Assert.AreEqual(token["content"]?["_searches"]?[0]?["_areas"]?[0]?["Lat"],1,"lat could not be parsed from json");
            Assert.AreEqual(token["content"]?["_searches"]?[0]?["_areas"]?[0]?["Lng"],2,"lng could not be parsed from json");
            Assert.AreEqual(token["content"]?["_searches"]?[0]?["_areas"]?[0]?["IgAdId"],"someIgAdId","ig ad id could not be parsed from json");
            Assert.AreEqual(token["content"]?["_searches"]?[0]?["_areas"]?[0]?["FbAdId"],"someFbAdId","fb ad id could not be parsed from json");
        }

        [TestMethod]
        public void TestGetCustomerOverview()
        {
            //Arrange
            var requestBuilder = new RequestBuilder();
            //Act
            var (body, url) = requestBuilder.GetCustomerOverView();
            //Assert
            Assert.AreEqual("https://server.kattenradar.nl/get-dashboard-overview", url);
            Assert.AreEqual("{\"key\":\"5fbdfe2ff544aade4708dd58fa6962a\"}", body);      }
    }
}