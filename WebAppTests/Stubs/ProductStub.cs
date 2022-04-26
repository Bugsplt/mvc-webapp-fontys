using System.Collections.Generic;
using InterfaceLayer.DTO;
using InterfaceLayer.Enums;

namespace WebAppProftS2Tests.Stubs
{
    public class ProductStub
    {
        public List<ProductDTO> Products;

        public ProductStub()
        {
            Products = new List<ProductDTO>
            {
                new()
                {
                    Type = ProductType.Edit,
                    _id = 1,
                    DailyBudget = (float) 1.1,
                    Price = (float) 1.1,
                    Discount = (float) 1.1,
                    ExpProfit = (float) 1.1,
                    Radius = 1,
                    Reach = 1
                },
                new()
                {
                    Type = ProductType.Extension,
                    _id = 2,
                    DailyBudget = (float) 2.2,
                    Price = (float) 2.2,
                    Discount = (float) 2.2,
                    ExpProfit = (float) 2.2,
                    Radius = 2,
                    Reach = 2
                },
                new()
                {
                    Type = ProductType.New,
                    _id = 3,
                    DailyBudget = (float) 3.3,
                    Price = (float) 3.3,
                    Discount = (float) 3.3,
                    ExpProfit = (float) 3.3,
                    Radius = 3,
                    Reach = 3
                }
            };
        }
    }
}