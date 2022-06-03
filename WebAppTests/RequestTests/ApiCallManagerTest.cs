using System;
using System.Collections.Generic;
using InterfaceLayer.DTO;
using InterfaceLayer.Enums;
using InterfaceLayer.Interface;
using LogicLayer.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAppDAL;
using WebAppProftS2Tests.Mocks;
using WebAppProftS2Tests.Stubs;

namespace WebAppProftS2Tests.DAL
{
    [TestClass]
    public class ApiCallManagerTest
    {
        [TestMethod]
        public void LoadCustomerDetailViewValid()
        {
            //arrange
            var prospectStub = new ProspectStub();
            var customerStub = new CustomerStub();
            var client = new ApiClientMock(prospectStub, customerStub);
            var requestBuilder = new ValidRequestBuilderMock();
            IApiCallManager manager = new ApiCallManager(client, requestBuilder);
            var validId = "1";
            CustomerDTO expectedStub = null;
            foreach (var customer in customerStub.Customers)
            {
                if (customer.Id == validId)
                {
                    expectedStub = customer;
                }
            }
            //act
            var result = manager.LoadCustomerDetailView(validId);
            //assert
            Assert.AreEqual(expectedStub.FirstName, result.FirstName, "Didn't get the expected DTO");
            Assert.AreEqual(expectedStub.Id, result.Id, "Didn't get the expected DTO");
            Assert.AreEqual(expectedStub.Country, result.Country, "Didn't get the expected DTO");
            Assert.AreEqual(expectedStub.Email, result.Email, "Didn't get the expected DTO");
            Assert.AreEqual(expectedStub.PhoneNr, result.PhoneNr, "Didn't get the expected DTO");
            Assert.AreEqual(expectedStub.Language, result.Language, "Didn't get the expected DTO");
            Assert.AreEqual(expectedStub._searches[0]._tips[0].Content, result._searches[0]._tips[0].Content, "Didn't get the expected DTO");
            Assert.AreEqual(expectedStub._activities[0].Type, result._activities[0].Type, "Didn't get the expected DTO");
            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LoadCustomerDetailViewInvalidId()
        {
            //arrange
            var prospectStub = new ProspectStub();
            var customerStub = new CustomerStub();
            var client = new ApiClientMock(prospectStub, customerStub);
            var requestBuilder = new ValidRequestBuilderMock();
            IApiCallManager manager = new ApiCallManager(client, requestBuilder);
            var inValidId = "999999";
            //act
            var result = manager.LoadCustomerDetailView(inValidId);
            //assert
        }
        
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void LoadCustomerDetailViewInvalidBody()
        {
            //arrange
            var prospectStub = new ProspectStub();
            var customerStub = new CustomerStub();
            var client = new ApiClientMock(prospectStub, customerStub);
            var requestBuilder = new InvalidRequestBodyBuilderMock();
            IApiCallManager manager = new ApiCallManager(client, requestBuilder);
            var validId = "1";
            //act
            var result = manager.LoadCustomerDetailView(validId);
            //assert
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LoadCustomerDetailViewInvalidUrl()
        {
            //arrange
            var prospectStub = new ProspectStub();
            var customerStub = new CustomerStub();
            var client = new ApiClientMock(prospectStub, customerStub);
            var requestBuilder = new InvalidRequestUrlBuilderMock();
            IApiCallManager manager = new ApiCallManager(client, requestBuilder);
            var validId = "1";
            //act
            var result = manager.LoadCustomerDetailView(validId);
            //assert
        }

        [TestMethod]
        public void UpdateValidCustomerDetails()
        {
            //arrange
            var prospectStub = new ProspectStub();
            var customerStub = new CustomerStub();
            var client = new ApiClientMock(prospectStub, customerStub);
            var requestBuilder = new ValidRequestBuilderMock();
            IApiCallManager manager = new ApiCallManager(client, requestBuilder);
            var validDto = customerStub.Customers[0];
            validDto.Email = "newEmail";
            validDto.Country = "DE";
            validDto.Language = "DE";
            validDto.FirstName = "newFirstName";
            validDto.PhoneNr = "newPhoneNr";
            validDto._searches[0]._tips[0].Content = "newTipContent";
            validDto._activities[0].Type = "newType";
            //act
            manager.UpdateCustomerDetails(validDto);
            //assert
            Assert.AreEqual(customerStub.Customers[0].Email, validDto.Email, "Email was not changed");
            Assert.AreEqual(customerStub.Customers[0].Country, validDto.Country, "Country was not changed");
            Assert.AreEqual(customerStub.Customers[0].Language, validDto.Language, "Language was not changed");   
            Assert.AreEqual(customerStub.Customers[0].FirstName, validDto.FirstName, "FirstName was not changed"); 
            Assert.AreEqual(customerStub.Customers[0].PhoneNr, validDto.PhoneNr, "PhoneNr was not changed");
            Assert.AreEqual(customerStub.Customers[0]._searches[0]._tips[0].Content, validDto._searches[0]._tips[0].Content, "TipContent was not changed");
            Assert.AreEqual(customerStub.Customers[0]._searches[0]._tips[0].Content, validDto._searches[0]._tips[0].Content, "Email was not changed");
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void UpdateInvalidUrlCustomerDetails()
        {
            //arrange
            var prospectStub = new ProspectStub();
            var customerStub = new CustomerStub();
            var client = new ApiClientMock(prospectStub, customerStub);
            var requestBuilder = new InvalidRequestUrlBuilderMock();
            IApiCallManager manager = new ApiCallManager(client, requestBuilder);
            var validDto = customerStub.Customers[0];
            validDto.Email = "newEmail";
            validDto.Country = "DE";
            validDto.Language = "DE";
            validDto.FirstName = "newFirstName";
            validDto.PhoneNr = "newPhoneNr";
            validDto._searches[0]._tips[0].Content = "newTipContent";
            validDto._activities[0].Type = "newType";
            //act
            manager.UpdateCustomerDetails(validDto);
            //assert
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UpdateInvalidCustomerDetails()
        {
            //arrange
            var prospectStub = new ProspectStub();
            var customerStub = new CustomerStub();
            var client = new ApiClientMock(prospectStub, customerStub);
            var requestBuilder = new ValidRequestBuilderMock();
            IApiCallManager manager = new ApiCallManager(client, requestBuilder);
            var inValidDto = customerStub.Customers[0];
            var inValidId = "9999999";
            inValidDto.Email = "newEmail";
            inValidDto.Country = "DE";
            inValidDto.Language = "DE";
            inValidDto.FirstName = "newFirstName";
            inValidDto.PhoneNr = "newPhoneNr";
            inValidDto._searches[0]._tips[0].Content = "newTipContent";
            inValidDto._activities[0].Type = "newType";
            inValidDto.Id = inValidId;
            //act
            manager.UpdateCustomerDetails(inValidDto);
            //assert
        }
        
        [TestMethod]
        public void LoadCustomerView()
        {
            //arrange
            var prospectStub = new ProspectStub();
            var customerStub = new CustomerStub();
            var client = new ApiClientMock(prospectStub, customerStub);
            var requestBuilder = new ValidRequestBuilderMock();
            IApiCallManager manager = new ApiCallManager(client, requestBuilder);
            //act
            var (prospects, customers) = manager.LoadCustomerView();
            //assert
            Assert.AreEqual(prospectStub.Prospects.Count, prospects.Count, "Not all prospects where retrieved");
            Assert.AreEqual(customerStub.Customers.Count, customers.Count, "Not all customers where retrieved");
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LoadCustomerViewInvalidUrl()
        {
            //arrange
            var prospectStub = new ProspectStub();
            var customerStub = new CustomerStub();
            var client = new ApiClientMock(prospectStub, customerStub);
            var requestBuilder = new InvalidRequestUrlBuilderMock();
            IApiCallManager manager = new ApiCallManager(client, requestBuilder);
            //act
            var (prospects, customers) = manager.LoadCustomerView();
            //assert
        }
        
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void LoadCustomerViewInvalidBody()
        {
            //arrange
            var prospectStub = new ProspectStub();
            var customerStub = new CustomerStub();
            var client = new ApiClientMock(prospectStub, customerStub);
            var requestBuilder = new InvalidRequestBodyBuilderMock();
            IApiCallManager manager = new ApiCallManager(client, requestBuilder);
            //act
            var (prospects, customers) = manager.LoadCustomerView();
            //assert
        }
        
        [TestMethod]
        public void CreateCustomer()
        {
            //arrange
            var prospectStub = new ProspectStub();
            var customerStub = new CustomerStub();
            var client = new ApiClientMock(prospectStub, customerStub);
            var requestBuilder = new ValidRequestBuilderMock();
            IApiCallManager manager = new ApiCallManager(client, requestBuilder);
            var customerDto = new CustomerDTO() {
                FirstName = "Test",
                Email = "EmailTest",
                PhoneNr = "12345678",
                Country = "DE",
                Language = "NL",
                _searches = new List<SearchDTO>()
                {
                    new SearchDTO()
                    {
                        CatName = "CatName",
                        IgPostId = "IgPostId",
                        FbPostId = "FbPostId",
                        _areas = new List<AreaDTO>()
                        {
                            new AreaDTO()
                            {
                                IgAdId = "IgAdId",
                                FbAdId = "FbAdId",
                            }
                        }
                    }
                }
            };
            //act
            manager.CreateCustomer(customerDto);
            //assert
            Assert.AreEqual(customerDto.FirstName, customerStub.Customers[^1].FirstName, "Customer FirstName was not created"); 
            Assert.AreEqual(customerDto.Email, customerStub.Customers[^1].Email, "Customer Email was not created"); 
            Assert.AreEqual(customerDto.PhoneNr, customerStub.Customers[^1].PhoneNr, "Customer PhoneNr was not created"); 
            Assert.AreEqual(customerDto.Country, customerStub.Customers[^1].Country, "Customer Country was not created"); 
            Assert.AreEqual(customerDto.Language, customerStub.Customers[^1].Language, "Customer Language was not created"); 
            Assert.AreEqual(customerDto._searches[0].CatName, customerStub.Customers[^1]._searches[0].CatName, "Customer CatName was not created"); 
            Assert.AreEqual(customerDto._searches[0].IgPostId, customerStub.Customers[^1]._searches[0].IgPostId, "Customer IgPostId was not created"); 
            Assert.AreEqual(customerDto._searches[0].FbPostId, customerStub.Customers[^1]._searches[0].FbPostId, "Customer FbPostId was not created"); 
            Assert.AreEqual(customerDto._searches[0]._areas[0].IgAdId, customerStub.Customers[^1]._searches[0]._areas[0].IgAdId, "Customer IgAdId was not created"); 
            Assert.AreEqual(customerDto._searches[0]._areas[0].FbAdId, customerStub.Customers[^1]._searches[0]._areas[0].FbAdId, "Customer FbAdId was not created");
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateCustomer_InvalidCustomerDto()
        {
            //arrange
            var prospectStub = new ProspectStub();
            var customerStub = new CustomerStub();
            var client = new ApiClientMock(prospectStub, customerStub);
            var requestBuilder = new ValidRequestBuilderMock();
            IApiCallManager manager = new ApiCallManager(client, requestBuilder);
            var inValidDto = customerStub.Customers[0];
            //act
            var result = manager.CreateCustomer(inValidDto);
            //assert
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateCustomer_InvalidUrl()
        {
            //arrange
            var prospectStub = new ProspectStub();
            var customerStub = new CustomerStub();
            var client = new ApiClientMock(prospectStub, customerStub);
            var requestBuilder = new InvalidRequestUrlBuilderMock();
            IApiCallManager manager = new ApiCallManager(client, requestBuilder);
            var inValidDto = customerStub.Customers[0];
            var correctAmount = customerStub.Customers.Count;
            //act
            manager.CreateCustomer(inValidDto);
            //assert
        }
        
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CreateCustomer_InvalidBody()
        {
            //arrange
            var prospectStub = new ProspectStub();
            var customerStub = new CustomerStub();
            var client = new ApiClientMock(prospectStub, customerStub);
            var requestBuilder = new InvalidRequestBodyBuilderMock();
            IApiCallManager manager = new ApiCallManager(client, requestBuilder);
            var inValidDto = customerStub.Customers[0];
            var correctAmount = customerStub.Customers.Count;
            //act
            manager.CreateCustomer(inValidDto);
            //assert
        }
        
        [TestMethod]
        public void RemoveCustomer_ValidCustomer()
        {
            //arrange
            var prospectStub = new ProspectStub();
            var customerStub = new CustomerStub();
            var client = new ApiClientMock(prospectStub, customerStub);
            var requestBuilder = new ValidRequestBuilderMock();
            IApiCallManager manager = new ApiCallManager(client, requestBuilder);
            var correctAmount = customerStub.Customers.Count - 1;
            //act
            manager.RemoveCustomer(customerStub.Customers[0]);
            //assert
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveCustomer_InvalidCustomer()
        {
            //arrange
            var prospectStub = new ProspectStub();
            var customerStub = new CustomerStub();
            var client = new ApiClientMock(prospectStub, customerStub);
            var requestBuilder = new ValidRequestBuilderMock();
            IApiCallManager manager = new ApiCallManager(client, requestBuilder);
            var correctAmount = customerStub.Customers.Count;
            var customer = new CustomerDTO();
            customer.Id = "invalid";
            //act
            manager.RemoveCustomer(customer);
            //assert
        }
        
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void LoadMapData_NotImplemented()
        {
            //arrange
            var prospectStub = new ProspectStub();
            var customerStub = new CustomerStub();
            var client = new ApiClientMock(prospectStub, customerStub);
            var requestBuilder = new ValidRequestBuilderMock();
            IApiCallManager manager = new ApiCallManager(client, requestBuilder);
            //act
            manager.LoadMapData();
            //assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void testCreateCustomerExistingEmail()
        {
            //arrange
            var prospectStub = new ProspectStub();
            var customerStub = new CustomerStub();
            var client = new ApiClientMock(prospectStub, customerStub);
            var requestBuilder = new ValidRequestBuilderMock();
            IApiCallManager manager = new ApiCallManager(client, requestBuilder);
            var inValidDto = customerStub.Customers[0];
            //act
            manager.CreateCustomer(inValidDto);
            //assert
        }
    }
}

