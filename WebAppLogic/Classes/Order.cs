using System;
using System.Collections.Generic;
using InterfaceLayer.DTO;
using LogicLayer.Enums;

namespace LogicLayer.Classes
{
    public class Order
    {
        public PaymentStatus PaymentStatus { get; private set; }
        public DateTime Date { get; private set; }
        public string MollieId { get; private set; }

        public int Id { get; private set; }
        private List<ProductOrder> _productOrders = new();

        public IReadOnlyList<ProductOrder> GetProductOrders()
        {
            return _productOrders;
        }

        public void SetPaymentStatus(PaymentStatus paymentStatus)
        {
            PaymentStatus = paymentStatus;
        }

        public void SetDate(DateTime date)
        {
            Date = date;
        }

        public void SetMollieId(string id)
        {
            MollieId = id;
        }

        public void Add(ProductOrder productOrder)
        {
            _productOrders.Add(productOrder);
        }

        public void Remove(ProductOrder productOrder)
        {
            _productOrders.Remove(productOrder);
        }

        public void Refund()
        {
            PaymentStatus = PaymentStatus.Refunded;
        }

        public Order(){}

        public Order(OrderDTO dto)
        {
            var productOrders = new List<ProductOrder>();
            foreach (var productOrder in dto._productOrders)
            {
                productOrders.Add(new(productOrder));
            }

            PaymentStatus = (PaymentStatus) dto.PaymentStatus;
            Date = dto.Date;
            MollieId = dto.MollieId;
            Id = dto._id;
            _productOrders = productOrders;
        }
        
        public OrderDTO ToDto()
        {
            var productOrderDtos = new List<ProductOrderDTO>();
            foreach (var productOrder in _productOrders)
            {
                productOrderDtos.Add(productOrder.ToDto());
            }

            return new OrderDTO()
            {
                PaymentStatus = (InterfaceLayer.Enums.PaymentStatus) PaymentStatus,
                Date = Date,
                MollieId = MollieId,
                _id = Id,
                _productOrders = productOrderDtos
            };
        }
    }
}