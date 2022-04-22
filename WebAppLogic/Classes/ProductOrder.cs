using InterfaceLayer.DTO;

namespace LogicLayer.Classes
{
    public class ProductOrder
    {
        public Product Product { get; private set; }
        public int Amount { get; private set; }

        private int _orderId;

        public void SetProduct(Product product)
        {
            Product = product;
        }

        public void SetAmount(int amount)
        {
            Amount = amount;
        }

        public ProductOrderDTO ToDto()
        {
            return new ProductOrderDTO()
            {
                Product = Product.ToDto(),
                Amount = Amount,
                _orderId = _orderId
            };
        }
    }
}