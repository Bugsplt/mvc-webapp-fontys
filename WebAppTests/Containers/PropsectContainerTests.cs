using System.Collections.Generic;
using LogicLayer.Classes;
using LogicLayer.Containers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAppDAL;
using WebAppProftS2Tests.Mocks;
using WebAppProftS2Tests.Stubs;

namespace WebAppProftS2Tests.Containers
{
    [TestClass]
    public class PropsectContainerTests
    {
        [TestMethod]
        public void TestGetProspects()
        {
            // Arrange
            var prospectStub = new ProspectStub();
            var customerStub = new CustomerStub();
            var apiClient = new ApiClientMock(prospectStub, customerStub);
            var requestBuilder = new ValidRequestBuilderMock();
            var manager = new ApiCallManager(apiClient, requestBuilder);
            var container = new ProspectContainer(manager);
            container.Load();
            // Act
            var prospects = container.GetProspects();
            // Assert
            Assert.AreEqual(prospectStub.Prospects[0].CatName, prospects[0].CatName);
            Assert.AreEqual(prospectStub.Prospects[0].Email, prospects[0].Email);
            Assert.AreEqual(prospectStub.Prospects[0].PhoneNr, prospects[0].PhoneNr);
            Assert.AreEqual(prospectStub.Prospects[0].ProspectNr, prospects[0].ProspectNr);
        }

        [TestMethod]
        public void TestAdd()
        {
            // Arrange
            var prospectStub = new ProspectStub();
            var customerStub = new CustomerStub();
            var apiClient = new ApiClientMock(prospectStub, customerStub);
            var requestBuilder = new ValidRequestBuilderMock();
            var manager = new ApiCallManager(apiClient, requestBuilder);
            var container = new ProspectContainer(manager);
            var prospect = new Prospect("CatName", "Email", "PhoneNr", "ProspectNr");
            container.Load();
            // Act
            container.Add(prospect);
            // Assert
            Assert.AreEqual(prospect.CatName, container.GetProspects()[^1].CatName);
            Assert.AreEqual(prospect.Email, container.GetProspects()[^1].Email);
            Assert.AreEqual(prospect.PhoneNr, container.GetProspects()[^1].PhoneNr);
            Assert.AreEqual(prospect.ProspectNr, container.GetProspects()[^1].ProspectNr);
        }
        
        [TestMethod]
        public void TestRemove()
        {
            // Arrange
            var prospectStub = new ProspectStub();
            var customerStub = new CustomerStub();
            var apiClient = new ApiClientMock(prospectStub, customerStub);
            var requestBuilder = new ValidRequestBuilderMock();
            var manager = new ApiCallManager(apiClient, requestBuilder);
            var container = new ProspectContainer(manager);
            container.Load();
            var cycles = container.GetProspects().Count;
            // Act
            for (var i = 0; i < cycles; i++)
            {
                container.Remove(container.GetProspects()[0]);
            }
            // Assert
            Assert.AreEqual(0, container.GetProspects().Count);
        }
        
        [TestMethod]
        public void TestClear(){
            // Arrange
            var prospectStub = new ProspectStub();
            var customerStub = new CustomerStub();
            var apiClient = new ApiClientMock(prospectStub, customerStub);
            var requestBuilder = new ValidRequestBuilderMock();
            var manager = new ApiCallManager(apiClient, requestBuilder);
            var container = new ProspectContainer(manager);
            container.Load();
            //act
            container.Clear();
            //assert
            Assert.AreEqual(0, container.GetProspects().Count);
        }

        [TestMethod]
        public void TestSetProspects()
        {
            // Arrange
            var prospectStub = new ProspectStub();
            var customerStub = new CustomerStub();
            var apiClient = new ApiClientMock(prospectStub, customerStub);
            var requestBuilder = new ValidRequestBuilderMock();
            var manager = new ApiCallManager(apiClient, requestBuilder);
            var container = new ProspectContainer(manager);
            container.Load();
            var prospects = new List<Prospect>();
            prospects.Add(new Prospect("CatName", "Email", "PhoneNr", "ProspectNr"));
            // Act
            container.SetProspects(prospects);
            // Assert
            Assert.AreEqual( 1, container.GetProspects().Count);
            Assert.AreEqual(prospects[0].CatName, container.GetProspects()[0].CatName);
            Assert.AreEqual(prospects[0].Email, container.GetProspects()[0].Email);
            Assert.AreEqual(prospects[0].PhoneNr, container.GetProspects()[0].PhoneNr);
            Assert.AreEqual(prospects[0].ProspectNr, container.GetProspects()[0].ProspectNr);
        }

        [TestMethod]
        public void TestLoad()
        {
            // Arrange
            var prospectStub = new ProspectStub();
            var customerStub = new CustomerStub();
            var apiClient = new ApiClientMock(prospectStub, customerStub);
            var requestBuilder = new ValidRequestBuilderMock();
            var manager = new ApiCallManager(apiClient, requestBuilder);
            var container = new ProspectContainer(manager);
            // Act
            container.Load();
            // Assert
            Assert.AreEqual(prospectStub.Prospects.Count, container.GetProspects().Count);
        }

        [TestMethod]
        public void TestConstructor()
        {
            // Arrange
            var prospectStub = new ProspectStub();
            var customerStub = new CustomerStub();
            var apiClient = new ApiClientMock(prospectStub, customerStub);
            var requestBuilder = new ValidRequestBuilderMock();
            var manager = new ApiCallManager(apiClient, requestBuilder);
            // Act
            var container = new ProspectContainer(manager);
            // Assert
            Assert.IsNotNull(container);
        }
    }
}