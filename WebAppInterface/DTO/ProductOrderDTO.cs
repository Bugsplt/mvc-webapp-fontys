namespace InterfaceLayer.DTO
{
    public class ProductOrderDTO
    {
        public ProductDTO Product { get; set; }
        public int Amount { get; set; }
        public int _orderId { get; set; }
    }
}