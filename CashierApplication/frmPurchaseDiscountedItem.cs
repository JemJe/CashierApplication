using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItemNamespace;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        private DiscountedItem item;

        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void computeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = itemBox.Text;
                double itemPriceText = Convert.ToDouble(priceBox.Text);
                int itemQuantityText = Convert.ToInt32(quantityBox.Text);
                double itemDiscountText = Convert.ToDouble(discountBox.Text);

                if (itemQuantityText <= 0 || itemPriceText <= 0 || itemDiscountText < 0 || itemDiscountText > 100)
                {
                    MessageBox.Show("[!] Please enter valid item details.");
                    return;
                }
                if(itemName == "")
                {
                    MessageBox.Show("[!] Please enter a valid item name.");
                    return;
                }

                item = new DiscountedItem(itemName, itemPriceText, itemQuantityText, itemDiscountText);

                TotalAmountLabel.Text = item.getTotalPrice().ToString("0.00");
            }
            catch(FormatException)
            {
                MessageBox.Show("[!] Please enter valid item details.");
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (item != null)
                {
                    double payment = Convert.ToDouble(paymentBox.Text);
                    item.setPayment(payment);

                    if (item.getChange() < 0)
                    {
                        MessageBox.Show("[!] Insufficient payment. Please enter a valid payment amount.");
                        return;
                    }

                    changeLabel.Text = item.getChange().ToString("0.00");
                }
                else
                {
                    MessageBox.Show("[!] Compute the total amount first before submitting payment.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("[!] Please enter a valid payment amount.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            itemBox.Clear();
            priceBox.Clear();
            quantityBox.Clear();
            discountBox.Clear();
            paymentBox.Clear();

            TotalAmountLabel.Text = "";
            changeLabel.Text = "";

            item = null;
        }
        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginAccount loginForm = new frmLoginAccount();
            loginForm.Show();
        }

        private void exitApplicationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
