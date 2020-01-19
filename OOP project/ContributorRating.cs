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

        Contributor seller = new Contributor();

        public ContributorRating(string username)
        {
            InitializeComponent();
            seller = seller.GetContributorInfo(username);

            lbl_UsernameValue.Text = seller.Username;
            lbl_NameValue.Text = seller.Name;
            lbl_SurnameValue.Text = seller.Surname;
            

            if (seller.rejtingu.currentRating == 0)
            {
                lbl_RatingValue.Text = "Ky perdorues ka 0 vleresime";
            }
            else
            {
                lbl_RatingValue.Text = String.Format("{0:0.#}", seller.rejtingu.currentRating.ToString()) + "    ("+ seller.rejtingu.ratingCount +")";
            }
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
            var user = Lists.ContributorsList.Where(x => x.Username == seller.Username).First();
            if (user != null)
            {
                user.rejtingu.currentRating = user.rejtingu.calculateRating(Convert.ToDouble(txt_RatingValue.Text));
                user.rejtingu.ratingCount += 1;
                lbl_RatingValue.Text = String.Format("{0:0.#}", user.rejtingu.currentRating.ToString()) + "    (" + user.rejtingu.ratingCount + ")";
            }
        }
    }
}
