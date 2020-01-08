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

        public AuctionDialog()
        {
            

        }

        public AuctionDialog(Product item)
        {
            InitializeComponent();

            lbl_TitleValue.Text= item.Name;
            rtxt_Description.Text = item.Description;
            lbl_StartDateTimeValue.Text = item.AuctionStartDateTime.ToString();
            lbl_EndDatTimeValue.Text = item.AuctionEndDateTime.ToString();
            lbl_SellersIDValue.Text = item.sellersUsername.ToString();
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

       
    }
    }

