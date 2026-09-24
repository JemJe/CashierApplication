using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemNamespace
{
    public class DiscountedItem : Item
    {
        private double itemDiscount;
        private double discountedPrice;
        private double paymentAmount;
        private double changeAmount;

        public DiscountedItem(string name, double price, int quantity, double discount) : base (name, price, quantity)
        {
            this.itemDiscount = discount * 0.01;
        }

        public override double getTotalPrice()
        {
            discountedPrice = itemPrice - (itemPrice * itemDiscount);
            return discountedPrice * itemQuantity;
        }

        public override void setPayment(double payment)
        {
            this.paymentAmount = payment;
            this.changeAmount = paymentAmount - getTotalPrice();
        }

        public double getChange()
        {
            return changeAmount;
        }
    }
}
