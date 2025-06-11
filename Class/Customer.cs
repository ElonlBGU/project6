using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project6
{
    using System;
    using System.Collections.Generic;

    namespace Project6
    {
        public class Customer
        {
            // Fields
            private string fullName;
            private string address;
            private string email;
            private string phoneNumber;

            // Optional: List of orders (1 customer → many orders)
            private List<Order> orders;

            // Constructor
            public Customer(string fullName, string address, string email, string phoneNumber)
            {
                this.fullName = fullName;
                this.address = address;
                this.email = email;
                this.phoneNumber = phoneNumber;
                this.orders = new List<Order>();
            }

            // Methods

            public void CreateOrder(Order order)
            {
                if (order != null)
                {
                    orders.Add(order);
                    Console.WriteLine("Order created successfully.");
                }
            }

            public void UpdateContactInfo(string newAddress, string newEmail, string newPhoneNumber)
            {
                this.address = newAddress;
                this.email = newEmail;
                this.phoneNumber = newPhoneNumber;
            }

            // Optional Getters

            public string GetFullName() => fullName;
            public string GetAddress() => address;
            public string GetEmail() => email;
            public string GetPhoneNumber() => phoneNumber;
            public List<Order> GetOrders() => orders;
        }
    }


}
