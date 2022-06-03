using System;
using InterfaceLayer.DTO;
using LogicLayer.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebAppProftS2Tests.Classes
{
    [TestClass]
    public class ProductOrderTest
    {
        // public void SetProduct(Product product)
        [TestMethod]
        public void TestSetProduct()
        {
            // Arrange
            var productOrder = new ProductOrder();
            var product = new Product();
            // Act
            productOrder.SetProduct(product);
            // Assert
            Assert.AreEqual(product, productOrder.Product);
        }
        
        // public void SetAmount(int amount)
        [TestMethod]
        public void TestSetAmount()
        {
            // Arrange
            var productOrder = new ProductOrder();
            var amount = 1;
            // Act
            productOrder.SetAmount(amount);
            // Assert
            Assert.AreEqual(amount, productOrder.Amount);
        }
        
        // public ProductOrder(ProductOrderDTO dto)
        [TestMethod]
        public void TestProductOrderDTO()
        {
            // Arrange
            var productDto = new ProductDTO();
            var productOrderDTO = new ProductOrderDTO()
            {
                _orderId = 1,
                Amount = 2,
                Product = productDto
            };
            // Act
            var productOrder = new ProductOrder(productOrderDTO);
            // Assert
            Assert.AreEqual(productOrderDTO.Amount, productOrder.Amount);
        }
        
        // public ProductOrderDTO ToDto()
        [TestMethod]
        public void TestToDto()
        {
            // Arrange
            var productDto = new ProductDTO();
            var productOrder = new ProductOrder(new ProductOrderDTO() {
                Amount = 2,
                Product = productDto
            });
            var productOrderDTO = new ProductOrderDTO()
            {
                _orderId = 1,
                Amount = 2,
                Product = productDto
            };
            // Act
            var productOrderDto = productOrder.ToDto();
            // Assert
            Assert.AreEqual(productOrderDTO.Amount, productOrderDto.Amount);
        }
    }
}