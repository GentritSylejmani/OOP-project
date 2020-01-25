using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOL;

namespace OOP_project
{
    public partial class PurchaseDialog : Form
    {
        public PurchaseDialog()
        {
            InitializeComponent();
        }

        Product produkti = null;
        Person loggedUser = null;

        public PurchaseDialog(Product product,Person loggeduser)
        {
            InitializeComponent();
            lbl_ProductIDValue.Text = product.ProductID.ToString();
            lbl_TitleValue.Text = product.Name;
            rtxt_Description.Text = product.Description;
            lbl_WonPriceValue.Text = product.CurrentBidPrice.ToString();
            produkti = product;
            loggedUser = loggeduser;
            tempPrice = product.CurrentBidPrice;
        }

        private bool mouseDown;
        private static Point lastLocation;

        double tempPrice;

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Coupon_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if (txt_Coupon.Text == "riinvest5")
                {
                    lbl_WonPriceValue.Text = (produkti.CurrentBidPrice.ToString()) + " - " + produkti.CurrentBidPrice * 0.05 + " = " + produkti.CurrentBidPrice * 0.95;
                    tempPrice= produkti.CurrentBidPrice * 0.95;
                }
                else if (txt_Coupon.Text == "riinvest10")
                {
                    lbl_WonPriceValue.Text = (produkti.CurrentBidPrice.ToString()) + " - " + produkti.CurrentBidPrice * 0.1 + " = " + produkti.CurrentBidPrice * 0.90;
                    tempPrice = produkti.CurrentBidPrice * 0.90;
                }
                else if (txt_Coupon.Text == "riinvest15")
                {
                    lbl_WonPriceValue.Text = (produkti.CurrentBidPrice.ToString()) + " - " + produkti.CurrentBidPrice * 0.15 + " = " + produkti.CurrentBidPrice * 0.85;
                    tempPrice = produkti.CurrentBidPrice * 0.85;
                }
                else MessageBox.Show("Kodi i shkruajtur eshte i pavlefshem!");
            }
        }

        private void btn_EraseCoupon_Click(object sender, EventArgs e)
        {
            tempPrice = produkti.CurrentBidPrice;
            txt_Coupon.Text = "";
            lbl_WonPriceValue.Text = tempPrice.ToString();
        }

        private void btn_Purchase_Click(object sender, EventArgs e)
        {
            Client person = new Client();

            person.PayProduct(produkti.ProductID, loggedUser, tempPrice);

            MessageBox.Show("OK");
        }
    }
}
