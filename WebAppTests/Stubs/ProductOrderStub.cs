using System.Collections.Generic;
using InterfaceLayer.DTO;

namespace WebAppProftS2Tests.Stubs
{
    public class ProductOrderStub
    {
        public List<ProductOrderDTO> ProductOrders;

        public ProductOrderStub()
        {
            ProductStub productStub = new();
            ProductOrders = new List<ProductOrderDTO>
            {
                new()
                {
                    _orderId = 1,
                    Amount = 1,
                    Product = productStub.Products[0]
                },
                new()
                {
                    _orderId = 2,
                    Amount = 2,
                    Product = productStub.Products[1]
                },
                new()
                {
                    _orderId = 3,
                    Amount = 3,
                    Product = productStub.Products[2]
                }
            };
        }
    }
}