using System;
using System.Collections.Generic;
using System.Text;

namespace Task8
{
    internal class Product
    {
        //Fields
        private string name;
        private double unitPrice;

        //Constructor 
        public Product(string theName, double thePrice)
        {
            SetName(theName);
            SetUnitPrice(thePrice);
        }

        //Methods
        public string GetName()
        {
            return this.name.ToUpper();
        }

        public void SetName(string theName)
        {
            if (string.IsNullOrWhiteSpace(theName))
            {
                this.name = "Unknown Product";
            }
            else
            {
                this.name = theName;
            }
        }

        public double GetUnitPrice()
        {
            return this.unitPrice;
        }

        public void SetUnitPrice(double thePrice)
        {
            if (thePrice < 0)
            {
                this.unitPrice = 0;
            }
            else
            {
                this.unitPrice = thePrice;
            }
        }
    }
}
