using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemNamespace
{
    public abstract class Item
    {
        protected string itemName;
        protected double itemPrice;
        protected int itemQuantity;
        private double totalPrice;

        public Item(string name, double price, int quantity)
        {
            itemName = name;
            itemPrice = price;
            itemQuantity = quantity;
        }

        public abstract double getTotalPrice();
        public abstract void setPayment(double payment);
    }
}
