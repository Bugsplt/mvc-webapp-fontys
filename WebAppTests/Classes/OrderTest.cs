using System;
using System.Collections.Generic;
using InterfaceLayer.DTO;
using LogicLayer.Classes;
using LogicLayer.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebAppProftS2Tests.Classes
{
    [TestClass]
    public class OrderTest
    {
        //public PaymentStatus PaymentStatus { get; private set; }
        // public DateTime Date { get; private set; }
        // public string MollieId { get; private set; }
        // public int Id { get; private set; }
        // private List<ProductOrder> _productOrders;
        //
        // public IReadOnlyList<ProductOrder> GetProductOrders()
        [TestMethod]
        public void TestGetProductOrders()
        {
            // Arrange
            var order = new Order();
            var productOrder = new ProductOrder();
            var productOrder2 = new ProductOrder();
            order.Add(productOrder);
            order.Add(productOrder2);
            // Act
            var result = order.GetProductOrders();
            // Assert
            Assert.AreEqual(2, result.Count);
        }
        
        //public void SetPaymentStatus(PaymentStatus paymentStatus)
        [TestMethod]
        public void TestSetPaymentStatus()
        {
            // Arrange
            var order = new Order();
            var paymentStatus = PaymentStatus.Paid;
            // Act
            order.SetPaymentStatus(paymentStatus);
            // Assert
            Assert.AreEqual(paymentStatus, order.PaymentStatus);
        }
        
        //public void SetDate(DateTime date)
        [TestMethod]
        public void TestSetDate()
        {
            // Arrange
            var order = new Order();
            var date = DateTime.Now;
            // Act
            order.SetDate(date);
            // Assert
            Assert.AreEqual(date, order.Date);
        }
        
        
        // public void SetMollieId(string id)
        [TestMethod]
        public void TestSetMollieId()
        {
            // Arrange
            var order = new Order();
            var id = "12345";
            // Act
            order.SetMollieId(id);
            // Assert
            Assert.AreEqual(id, order.MollieId);
        }
               
        // public void Add(ProductOrder productOrder)
        [TestMethod]
        public void TestAdd()
        {
            // Arrange
            var order = new Order();
            var productOrder = new ProductOrder();
            // Act
            order.Add(productOrder);
            // Assert
            Assert.AreEqual(1, order.GetProductOrders().Count);
        }
        
        // public void Remove(ProductOrder productOrder)
        [TestMethod]
        public void TestRemove()
        {
            // Arrange
            var order = new Order();
            var productOrder = new ProductOrder();
            order.Add(productOrder);
            // Act
            order.Remove(productOrder);
            // Assert
            Assert.AreEqual(0, order.GetProductOrders().Count);
        }
        
        // public void Refund()
        [TestMethod]
        public void TestRefund()
        {
            // Arrange
            var order = new Order();
            var productOrder = new ProductOrder();
            order.Add(productOrder);
            // Act
            order.Refund();
            // Assert
            Assert.AreEqual(PaymentStatus.Refunded, order.PaymentStatus);
        }
        
        // public Order(OrderDTO dto
        [TestMethod]
        public void TestOrderDTOConstructor()
        {
            // Arrange
            var dto = new OrderDTO(){_id = 1};
            dto.MollieId = "12345";
            dto.PaymentStatus = (InterfaceLayer.Enums.PaymentStatus)PaymentStatus.Paid;
            dto.Date = DateTime.Now;
            dto._productOrders = new List<ProductOrderDTO>();
            dto._productOrders.Add(new ProductOrderDTO());
            // Act
            var order = new Order(dto);
            // Assert
            Assert.AreEqual(dto._id, order.Id);
            Assert.AreEqual(dto.MollieId, order.MollieId);
            Assert.AreEqual(dto.PaymentStatus.ToString(), order.PaymentStatus.ToString());
            Assert.AreEqual(dto.Date, order.Date);
            Assert.AreEqual(dto._productOrders.Count, order.GetProductOrders().Count);
        }
        // public OrderDTO ToDto()
        [TestMethod]
        public void TestToDto()
        {
            // Arrange
            var order = new Order();
            var productOrder = new ProductOrder();
            order.Add(productOrder);
            var dto = new OrderDTO();
            // Act
            dto = order.ToDto();
            // Assert
            Assert.AreEqual(order.Id, dto._id);
            Assert.AreEqual(order.MollieId, dto.MollieId);
            Assert.AreEqual(order.PaymentStatus.ToString(), dto.PaymentStatus.ToString());
            Assert.AreEqual(order.Date, dto.Date);
            Assert.AreEqual(order.GetProductOrders().Count, dto._productOrders.Count);
        }
        
    }
}