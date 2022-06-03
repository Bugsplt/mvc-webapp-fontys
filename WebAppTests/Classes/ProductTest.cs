using LogicLayer.Classes;
using LogicLayer.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebAppProftS2Tests.Classes
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void SetType_ProductType_ProductType()
        {
            //Arrange
            var product = new Product();
            var productType = ProductType.New;

            //Act
            product.SetType(productType);

            //Assert
            Assert.AreEqual(productType, product.Type);
        }
        
        [TestMethod]
        public void SetPrice_Float_Float()
        {
            //Arrange
            var product = new Product();
            var price = 10.0f;

            //Act
            product.SetPrice(price);

            //Assert
            Assert.AreEqual(price, product.Price);
        }
        
        [TestMethod]
        public void SetDiscount_Float_Float()
        {
            //Arrange
            var product = new Product();
            var discount = 10.0f;

            //Act
            product.SetDiscount(discount);

            //Assert
            Assert.AreEqual(discount, product.Discount);
        }
        
        [TestMethod]
        public void SetDailyBudget_Float_Float()
        {
            //Arrange
            var product = new Product();
            var budget = 10.0f;

            //Act
            product.SetDailyBudget(budget);

            //Assert
            Assert.AreEqual(budget, product.DailyBudget);
        }
        
        [TestMethod]
        public void SetExpProfit_Float_Float()
        {
            //Arrange
            var product = new Product();
            var expProfit = 10.0f;

            //Act
            product.SetExpProfit(expProfit);

            //Assert
            Assert.AreEqual(expProfit, product.ExpProfit);
        }
        
        [TestMethod]
        public void SetRadius_Int_Int()
        {
            //Arrange
            var product = new Product();
            var radius = 10;

            //Act
            product.SetRadius(radius);

            //Assert
            Assert.AreEqual(radius, product.Radius);
        }
        
        [TestMethod]
        public void SetReach_Int_Int()
        {
            //Arrange
            var product = new Product();
            var reach = 10;

            //Act
            product.SetReach(reach);

            //Assert
            Assert.AreEqual(reach, product.Reach);
        }
    }
}