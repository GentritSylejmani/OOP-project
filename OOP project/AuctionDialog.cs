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
    public partial class AuctionDialog : Form
    {
        Product product;
        Person loggedUser;

        public PictureBox[] pcb = new PictureBox[7];

        public AuctionDialog()
        {        
   
        }

        public AuctionDialog(Product item, Person loggeduser)
        {
            InitializeComponent();

            product = item;

            loggedUser = loggeduser;

            pcb[0] = pcb_small1;
            pcb[1] = pcb_small2;
            pcb[2] = pcb_small3;
            pcb[3] = pcb_small4;
            pcb[4] = pcb_small5;
            pcb[5] = pcb_small6;
            pcb[6] = pcb_Main;
            
            pcb[6].SizeMode = PictureBoxSizeMode.StretchImage;
            if (item.productPicture[0] != "")
            {
                pcb[6].Image = Image.FromFile(item.productPicture[0]);
            }

            for (int i = 0; i<item.productPicture.Length;i++)
            {
                if (item.productPicture[i] != "")
                {
                    pcb[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    pcb[i].Image = Image.FromFile(item.productPicture[i]);
                }
            }


            lbl_StartingPriceValue.Text = item.StartingPrice.ToString();
            lbl_ActualPriceValue.Text = item.CurrentBidPrice.ToString();
            lbl_TitleValue.Text= item.Name;
            rtxt_Description.Text = item.Description;
            lbl_StartDateTimeValue.Text = item.AuctionStartDateTime.ToString();
            lbl_EndDatTimeValue.Text = item.AuctionEndDateTime.ToString();
            lbl_SellersIDValue.Text = item.sellersUsername.Username;

        }

        private string GetTimeString(TimeSpan AuctionEta)
        {
            return string.Format("{0:000}:{1:00}:{2:00}:{3:00}",
            AuctionEta.Days, AuctionEta.Hours, AuctionEta.Minutes, AuctionEta.Seconds);
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

        private void pcb_small1_Click(object sender, EventArgs e)
        {
            if (product.productPicture[0] != "")
            {
                pcb[6].Image = Image.FromFile(product.productPicture[0]);
            }
            else return;
        }

        private void pcb_small2_Click(object sender, EventArgs e)
        {
            if (product.productPicture[1] != "")
            {
                pcb[6].Image = Image.FromFile(product.productPicture[1]);
            }
            else return;
        }

        private void pcb_small3_Click(object sender, EventArgs e)
        {
            if (product.productPicture[2] != "")
            {
                pcb[6].Image = Image.FromFile(product.productPicture[2]);
            }
            else return;
        }

        private void pcb_small4_Click(object sender, EventArgs e)
        {
            if (product.productPicture[3] != "")
            {
                pcb[6].Image = Image.FromFile(product.productPicture[3]);
            }
            else return;
        }

        private void pcb_small5_Click(object sender, EventArgs e)
        {
            if (product.productPicture[4] != "")
            {
                pcb[6].Image = Image.FromFile(product.productPicture[4]);
            }
            else return;
        }

        private void pcb_small6_Click(object sender, EventArgs e)
        {
            if (product.productPicture[5] != "")
            {
                pcb[6].Image = Image.FromFile(product.productPicture[5]);
            }
            else return;
        }

        //private void Timer_Tick(object sender, EventArgs e)
        //{
        //    lbl_AuctionCountDown.Text = GetTimeString(product.AuctionEndDateTime - DateTime.Now);
        //}

        private void btn_Bid_Click(object sender, EventArgs e)
        {
            var item = Lists.ApprovedRequests.Where(x => x.ProductID == product.ProductID).FirstOrDefault();

            if (Convert.ToInt32(txt_BiddingValue.Text) < product.CurrentBidPrice + 1 )
            {
                MessageBox.Show("Vlera duhet te jete me e madhe se 1 euro");
            }
            else
            {
                
                if(item!=null)
                {
                    product.CurrentBidPrice= Convert.ToInt32(txt_BiddingValue.Text);
                    item.CurrentBidPrice = Convert.ToInt32(txt_BiddingValue.Text);
                    item.bidder = loggedUser;
                }
            }

            lbl_StartingPriceValue.Text = item.StartingPrice.ToString();
            lbl_ActualPriceValue.Text = item.CurrentBidPrice.ToString();

        }

        private void timeTXTnumberenter(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lbl_SellersIDValue_Click(object sender, EventArgs e)
        {
           
            ContributorRating cr = new ContributorRating(product.sellersUsername.Username);
            cr.ShowDialog();
        }

    }
    }

