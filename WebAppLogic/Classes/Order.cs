using System;
using System.Collections.Generic;
using LogicLayer.Enums;

namespace LogicLayer.Classes
{
    public class Order
    {
        public PaymentStatus PaymentStatus { get; private set; }
        public DateTime Date { get; private set; }
        public string MollieId { get; private set; }

        private int _id;
        private List<ProductOrder> _productOrders;

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
    }
}