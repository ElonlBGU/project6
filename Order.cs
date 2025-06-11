using System;

namespace Project6
{
    public class Order
    {
        // Fields
        private int orderId;
        private int customerId;
        private DateTime orderDate;
        private string destinationAddress;
        private OrderStatus status;
        private PaymentStatus paymentStatus;

        // Constructor
        public Order(int orderId, int customerId, DateTime orderDate, string destinationAddress, OrderStatus status, PaymentStatus paymentStatus)
        {
            this.orderId = orderId;
            this.customerId = customerId;
            this.orderDate = orderDate;
            this.destinationAddress = destinationAddress;
            this.status = status;
            this.paymentStatus = paymentStatus;
        }

        // Methods

        public PaymentStatus GetPaymentStatus()
        {
            return paymentStatus;
        }

        public DateTime GetEstimatedShippingTime()
        {
            return orderDate.AddDays(3); // Example shipping time
        }

        public PaymentStatus PaymentStatus()
        {
            return paymentStatus;
        }

        // Optional Getters
        public int GetOrderId() => orderId;
        public int GetCustomerId() => customerId;
        public DateTime GetOrderDate() => orderDate;
        public string GetDestinationAddress() => destinationAddress;
        public OrderStatus GetStatus() => status;
    }
}
