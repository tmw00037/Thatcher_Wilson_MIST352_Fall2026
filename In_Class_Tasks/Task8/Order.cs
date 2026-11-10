using System;
using System.Collections.Generic;
using System.Text;

namespace Task8
{
    internal class Order
    {
        //Fields
        private int orderNumber;
        private string customerName;
        private Product product;

        //Constructor
        public Order(int theNumber, string theName, Product theProduct)
        {
            SetOrderNumber(theNumber);
            SetCustomerName(theName);
            SetProduct(theProduct);
        }

        //Methods
        public int GetOrderNumber()
        {
            return this.orderNumber;
        }

        public void SetOrderNumber(int theNumber)
        {
            if (theNumber < 1)
            {
                this.orderNumber = 1;
            }
            else
            {
                this.orderNumber = theNumber;
            }
        }

        public string GetCustomerName()
        {
            return this.customerName;
        }

        public void SetCustomerName(string theName)
        {
            if (string.IsNullOrWhiteSpace(theName))
            {
                this.customerName = "Unknown Customer";
            }
            else
            {
                this.customerName = theName;
            }
        }
        public Product GetProduct()
        {
            return this.product;
        }

        public void SetProduct(Product theProduct)
        {
            this.product = theProduct;
        }
    }

}
