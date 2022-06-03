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

        public ProductOrder(){}

        public ProductOrder(ProductOrderDTO dto)
        {
            if (dto.Product != null)
            {
                Product = new Product(dto.Product);
            }
            Amount = dto.Amount;
            _orderId = dto._orderId;
        }
        
        public ProductOrderDTO ToDto()
        {
            var product = new ProductDTO();
            if (Product != null)
            {
                product = Product.ToDto();
            }

            return new ProductOrderDTO
            {
                Product = product,
                Amount = Amount,
                _orderId = _orderId
            };
        }
    }
}