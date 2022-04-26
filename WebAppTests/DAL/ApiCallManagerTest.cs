using InterfaceLayer.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAppDAL;
using WebAppProftS2Tests.Stubs;

namespace WebAppProftS2Tests.DAL
{
    [TestClass]
    public class ApiCallManagerTest
    {
        [TestMethod]
        public static void LoadCustomerDetailViewValidId()
        {
            
            //arrange
            var client = new ApiClientStub();
            var requestBuilder = new RequestBuilderStub();
            IApiCallManager manager = new ApiCallManager(client, requestBuilder);
            var validId = "1";
            //act
            var result = manager.LoadCustomerDetailView(validId);
            //assert
            
        }

        [TestMethod]
        public static void LoadCustomerDetailViewInvalidId()
        {
            //arrange
            IApiCallManager manager = new ApiCallManager(new ApiClientStub(), new RequestBuilderStub());
            //act
            //assert
        }

        [TestMethod]
        public static void LoadCustomerDetailViewInvalidCustomerContent()
        {
            //arrange
            IApiCallManager manager = new ApiCallManager(new ApiClientStub(), new RequestBuilderStub());
            //act
            //assert
        }

        [TestMethod]
        public static void LoadCustomerDetailViewNoConnection()
        {
            //arrange
            IApiCallManager manager = new ApiCallManager(new ApiClientStub(), new RequestBuilderStub());
            //act
            //assert 
        }
    }
}