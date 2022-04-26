using System;
using System.Collections.Generic;
using InterfaceLayer.DTO;
using InterfaceLayer.Enums;
using LogicLayer.Classes;

namespace WebAppProftS2Tests.Stubs
{
    public class OrderStub
    {
        public List<OrderDTO> Orders;

        public OrderStub()
        {
            ProductOrderStub productOrderStub = new();
            
            Orders = new List<OrderDTO>
            {
                new()
                {
                    _id = 1,
                    _productOrders = new List<ProductOrderDTO>{productOrderStub.ProductOrders[0]},
                    Date = new DateTime(2022, 4, 26),
                    MollieId = "1",
                    PaymentStatus = PaymentStatus.Cancelled
                },
                new()
                {
                    _id = 2,
                    _productOrders = new List<ProductOrderDTO>{productOrderStub.ProductOrders[1]},
                    Date = new DateTime(2022, 4, 27),
                    MollieId = "2",
                    PaymentStatus = PaymentStatus.Expired
                },
                new()
                {
                    _id = 3,
                    _productOrders = new List<ProductOrderDTO>{productOrderStub.ProductOrders[2]},
                    Date = new DateTime(2022, 4, 28),
                    MollieId = "3",
                    PaymentStatus = PaymentStatus.Failed
                }
            };
        }
    }
}