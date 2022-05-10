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
    }
}