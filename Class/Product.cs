using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project6
{
    public class Product
    {
        // Fields
        private int productId;
        private string productName;
        private ProductCategory category;
        private float price;
        private int stockQuantity;
        private ShippingType shippingType;
        private int minimumAmountLimit;

        // Constructor
        public Product(int productId, string productName, ProductCategory category, float price, int stockQuantity, ShippingType shippingType, int minimumAmountLimit)
        {
            this.productId = productId;
            this.productName = productName;
            this.category = category;
            this.price = price;
            this.stockQuantity = stockQuantity;
            this.shippingType = shippingType;
            this.minimumAmountLimit = minimumAmountLimit;
        }

        // Methods

        public void UpdateStock(int amount)
        {
            stockQuantity += amount;
        }

        public float CalculateTotalValue()
        {
            return price * stockQuantity;
        }

        public bool IsLowStock()
        {
            return stockQuantity < minimumAmountLimit;
        }


    }
}
