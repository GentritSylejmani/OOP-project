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
    public partial class ContributorRating : Form
    {
        public ContributorRating()
        {
            InitializeComponent();
      
        }

        Contributor seller = null;


    public ContributorRating(string username)
        {
            InitializeComponent();
            seller = Contributor.GetUserInfo(username);
            //seller.rejtingu = new Contributor.Rating();
            lbl_UsernameValue.Text = seller.Username;
            lbl_NameValue.Text = seller.Name;
            lbl_SurnameValue.Text = seller.Surname;
            //lbl_RatingValue.Text = Formated(seller.rejtingu.calculateRating().ToString() + "    (" + seller.rejtingu.ratingCount().ToString() + ")");
            lbl_RatingValue.Text = seller.rejtingu.calculateRating().ToString("0.##") + "    (" + seller.rejtingu.ratingCount().ToString("") + ")";
        }


        private string Formated(string stringu)
        {
            return String.Format("{0:0.}", stringu);
        }

        private bool mouseDown;
        private static Point lastLocation;

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

        private void btn_Rate_Click(object sender, EventArgs e)
        {
            Client c = new Client();

            c.RateUser(Convert.ToInt32(txt_RatingValue.Text), seller);

            //lbl_RatingValue.Text = Formated(seller.rejtingu.currentRating.ToString() + "    (" + seller.rejtingu.ratingCount().ToString() + ")");
            lbl_RatingValue.Text = seller.rejtingu.calculateRating().ToString("0.##") + "    (" + seller.rejtingu.ratingCount().ToString("") + ")";
        }
        //private void ratingTXTkeypress(object sender, KeyPressEventArgs e)
        //{
        //    txt_RatingValue.Text = "";

        //    if ((e.KeyChar.ToString() != "1") || (e.KeyChar.ToString() != "2") || (e.KeyChar.ToString() != "3") || (e.KeyChar.ToString() != "4") || (e.KeyChar.ToString() != "5"))
        //    {
        //        e.Handled = true;

        //    }
        //}
    }
}
