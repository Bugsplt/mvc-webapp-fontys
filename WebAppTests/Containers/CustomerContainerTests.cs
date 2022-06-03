using System;
using InterfaceLayer.DTO;
using LogicLayer.Classes;
using LogicLayer.Containers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAppDAL;
using WebAppProftS2Tests.Mocks;
using WebAppProftS2Tests.Stubs;

namespace WebAppProftS2Tests.Containers
{
    [TestClass]
    public class CustomerContainerTests
    {
        [TestMethod]
        public void TestGetCustomers()
        {
            // Arrange
            var prospectStub = new ProspectStub();
            var customerStub = new CustomerStub();
            var apiClient = new ApiClientMock(prospectStub, customerStub);
            var requestBuilder = new ValidRequestBuilderMock();
            var manager = new ApiCallManager(apiClient, requestBuilder );
            var customerContainer = new CustomerContainer(manager);
            // Act
            var customers = customerContainer.GetCustomers();
            // Assert
            Assert.AreEqual(customerStub.Customers[0].Id ,customers[0].Id);
            Assert.AreEqual(customerStub.Customers[0].FirstName, customers[0].FirstName);
            Assert.AreEqual(customerStub.Customers[0].Language, customers[0].Language);
            Assert.AreEqual(customerStub.Customers[0].Country, customers[0].Country);
            Assert.AreEqual(customerStub.Customers[0].PhoneNr, customers[0].PhoneNr);
            Assert.AreEqual(customerStub.Customers[0].Email, customers[0].Email);
            Assert.AreEqual(customerStub.Customers[0].Status, customers[0].Status);
            Assert.AreEqual(customerStub.Customers[0]._searches.Count, customers[0].GetSearches().Count);
            Assert.AreEqual(customerStub.Customers[0]._activities.Count, customers[0].GetActivities().Count);
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
            var customerContainer = new CustomerContainer(manager);
            var removedCustomer = customerContainer.GetCustomers()[0];
            // Act
            customerContainer.Remove(removedCustomer.ToDto());
            // Assert
            Assert.AreEqual(customerStub.Customers.Count, customerContainer.GetCustomers().Count);
        }
        
        [TestMethod]
        public void TestUpdate()
        {
            // Arrange
            var prospectStub = new ProspectStub();
            var customerStub = new CustomerStub();
            var apiClient = new ApiClientMock(prospectStub, customerStub);
            var requestBuilder = new ValidRequestBuilderMock();
            var manager = new ApiCallManager(apiClient, requestBuilder);
            var customerContainer = new CustomerContainer(manager);
            var updatedCustomer = customerContainer.GetCustomers()[0];
            updatedCustomer.SetFirstName("TestFirstName");
            updatedCustomer.SetLastName("TestLastName");
            updatedCustomer.SetLanguage("TestLanguage");
            updatedCustomer.SetCountry("TestCountry");
            updatedCustomer.SetPhoneNr("TestPhoneNr");
            updatedCustomer.SetEmail("TestEmail");
            // Act
            customerContainer.Update(updatedCustomer.ToDto());
            // Assert
            var stubCustomer = new CustomerDTO();
            foreach (var customerStubCustomer in customerStub.Customers)
            {
                if (customerStubCustomer.Id == updatedCustomer.Id)
                {
                    stubCustomer = customerStubCustomer;
                }
            }
            Assert.AreEqual(updatedCustomer.FirstName, stubCustomer.FirstName);
            Assert.AreEqual(updatedCustomer.LastName, stubCustomer.LastName);
            Assert.AreEqual(updatedCustomer.Language, stubCustomer.Language);
            Assert.AreEqual(updatedCustomer.Country, stubCustomer.Country); 
            Assert.AreEqual(updatedCustomer.PhoneNr, stubCustomer.PhoneNr);
            Assert.AreEqual(updatedCustomer.Email, stubCustomer.Email);
        }

        [TestMethod]
        public void TestClear()
        {
            // Arrange
            var prospectStub = new ProspectStub();
            var customerStub = new CustomerStub();
            var apiClient = new ApiClientMock(prospectStub, customerStub);
            var requestBuilder = new ValidRequestBuilderMock();
            var manager = new ApiCallManager(apiClient, requestBuilder);
            var customerContainer = new CustomerContainer(manager);
            customerContainer.GetCustomers();
            // Act
            customerContainer.Clear();
            // Assert
            Assert.AreEqual(0, customerContainer.Customers.Count);
        }
        
        [TestMethod]
        public void TestGetCustomer()
        {
            // Arrange
            var prospectStub = new ProspectStub();
            var customerStub = new CustomerStub();
            var apiClient = new ApiClientMock(prospectStub, customerStub);
            var requestBuilder = new ValidRequestBuilderMock();
            var manager = new ApiCallManager(apiClient, requestBuilder);
            var customerContainer = new CustomerContainer(manager);
            var customer = customerContainer.GetCustomers()[0];
            // Act
            var customerDto = customerContainer.GetCustomer(customer.Id);
            // Assert
            Assert.AreEqual(customer.Id, customerDto.Id);
            Assert.AreEqual(customer.FirstName, customerDto.FirstName);
            Assert.AreEqual(customer.LastName, customerDto.LastName);
            Assert.AreEqual(customer.PhoneNr, customerDto.PhoneNr);
            Assert.AreEqual(customer.Email, customerDto.Email);
        }

        [TestMethod]
        public void TestLoadCustomer()
        {
            // Arrange
            var prospectStub = new ProspectStub();
            var customerStub = new CustomerStub();
            var apiClient = new ApiClientMock(prospectStub, customerStub);
            var requestBuilder = new ValidRequestBuilderMock();
            var manager = new ApiCallManager(apiClient, requestBuilder);
            var customerContainer = new CustomerContainer(manager);
            var customer = customerContainer.GetCustomers()[0];
            // Act
            var loadedCustomer = customerContainer.LoadCustomer(customer.Id);
            // Assert
            Assert.AreEqual(customer.Id, loadedCustomer.Id);
            Assert.AreEqual(customer.FirstName, loadedCustomer.FirstName);
            Assert.AreEqual(customer.LastName, loadedCustomer.LastName);
            Assert.AreEqual(customer.PhoneNr, loadedCustomer.PhoneNr);
            Assert.AreEqual(customer.Email, loadedCustomer.Email);
        }

        [TestMethod]
        public void TestCreate()
        {
            // Arrange
            var prospectStub = new ProspectStub();
            var customerStub = new CustomerStub();
            var apiClient = new ApiClientMock(prospectStub, customerStub);
            var requestBuilder = new ValidRequestBuilderMock();
            var manager = new ApiCallManager(apiClient, requestBuilder);
            var customerContainer = new CustomerContainer(manager);
            var customerDto = new CustomerDTO()
            {
                FirstName = "Test",
                PhoneNr = "12345678",
                Email = "some@Unique.Mail",
            };
            // Act
            var createdCustomerId = customerContainer.Create(customerDto);
            // Assert
            var createdCustomer = customerContainer.GetCustomer(createdCustomerId.ToString());
            Assert.AreEqual(customerDto.FirstName, createdCustomer.FirstName);
            Assert.AreEqual(customerDto.PhoneNr, createdCustomer.PhoneNr);
            Assert.AreEqual(customerDto.Email, createdCustomer.Email);
        }

        [TestMethod]
        public void TestCustomerContainer()
        {
            // Arrange
            var prospectStub = new ProspectStub();
            var customerStub = new CustomerStub();
            var apiClient = new ApiClientMock(prospectStub, customerStub);
            var requestBuilder = new ValidRequestBuilderMock();
            var manager = new ApiCallManager(apiClient, requestBuilder);
            // Act
            var customerContainer = new CustomerContainer(manager);
            // Assert
            Assert.IsNotNull(customerContainer);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGetNullCustomer()
        {
            // Arrange
            var prospectStub = new ProspectStub();
            var customerStub = new CustomerStub();
            var apiClient = new ApiClientMock(prospectStub, customerStub);
            var requestBuilder = new ValidRequestBuilderMock();
            var manager = new ApiCallManager(apiClient, requestBuilder);
            var customerContainer = new CustomerContainer(manager);
            // Act
            var customer = customerContainer.GetCustomer("nonexistent");
            // Assert
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestLoadNonexistentCustomer()
        {
            // Arrange
            var prospectStub = new ProspectStub();
            var customerStub = new CustomerStub();
            var apiClient = new ApiClientMock(prospectStub, customerStub);
            var requestBuilder = new ValidRequestBuilderMock();
            var manager = new ApiCallManager(apiClient, requestBuilder);
            var customerContainer = new CustomerContainer(manager);
            // Act
            var customer = customerContainer.LoadCustomer("nonexistent");
            // Assert
        }
    }
}