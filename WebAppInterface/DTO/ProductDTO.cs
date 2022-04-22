using InterfaceLayer.Enums;

namespace InterfaceLayer.DTO
{
    public class ProductDTO
    {
        public ProductType Type { get; set; }
        public float Price { get; set; }
        public float Discount { get; set; }
        public float DailyBudget { get; set; }
        public float ExpProfit { get; set; }
        public int Radius { get; set; }
        public int Reach { get; set; }
        public int _id { get; set; }

    }
}