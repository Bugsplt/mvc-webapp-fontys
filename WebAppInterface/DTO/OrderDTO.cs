using System;
using System.Collections.Generic;
using InterfaceLayer.Enums;

namespace InterfaceLayer.DTO
{
    public class OrderDTO
    {
        public PaymentStatus PaymentStatus { get; set; }
        public DateTime Date { get; set; }
        public string MollieId { get; set; }
        public int _id { get; set; }
        public List<ProductOrderDTO> _productOrders { get; set; }
    }
}