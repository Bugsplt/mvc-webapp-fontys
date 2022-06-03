using InterfaceLayer.DTO;
using LogicLayer.Enums;

namespace LogicLayer.Classes
{
    public class Product
    {
        public ProductType Type { get; private set; }
        public float Price { get; private set; }
        public float Discount { get; private set; }
        public float DailyBudget { get; private set; }
        public float ExpProfit { get; private set; }
        public int Radius { get; private set; }
        public int Reach { get; private set; }

        private int _id;

        public void SetType(ProductType productType)
        {
            Type = productType;
        }

        public void SetPrice(float price)
        {
            Price = price;
        }

        public void SetDiscount(float discount)
        {
            Discount = discount;
        }

        public void SetDailyBudget(float budget)
        {
            DailyBudget = budget;
        }

        public void SetExpProfit(float expProfit)
        {
            ExpProfit = expProfit;
        }

        public void SetRadius(int radius)
        {
            Radius = radius;
        }

        public void SetReach(int reach)
        {
            Reach = reach;
        }

        public Product(){}

        public Product(ProductDTO dto)
        {
            Type = (ProductType)dto.Type;
            Price = dto.Price;
            _id = dto._id;
            DailyBudget = dto.DailyBudget;
            Discount = dto.Discount;
            ExpProfit = dto.ExpProfit;
            Radius = dto.Radius;
            Reach = dto.Reach;
        }
        
        public ProductDTO ToDto()
        {
            return new()
            {
                Type = (InterfaceLayer.Enums.ProductType) Type,
                Price = Price,
                _id = _id,
                DailyBudget = DailyBudget,
                Discount = Discount,
                ExpProfit = ExpProfit,
                Radius = Radius,
                Reach = Reach
            };
        }
    }
}