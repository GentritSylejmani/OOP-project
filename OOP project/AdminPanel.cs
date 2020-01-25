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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();

            LoadDataGrids();
                
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

        private Product SelectedProduct(int dgv)
        {

            Product product = new Product();
            int productid;

            if (dgv == 1)
            {
                int selectedrowindex = dgv_PendingRequests.SelectedCells[0].RowIndex;
                DataGridViewRow selectedrow = dgv_PendingRequests.Rows[selectedrowindex];
                productid = Convert.ToInt32(selectedrow.Cells[0].Value.ToString());

                var item = Lists.productListings.Where(x => x.ProductID == productid).FirstOrDefault();

                if (item != null)
                {
                    return item;
                }
                return null;
            }
            else if (dgv == 2)
            {
                int selectedrowindex = dgv_Active.SelectedCells[0].RowIndex;
                DataGridViewRow selectedrow = dgv_Active.Rows[selectedrowindex];
                productid = Convert.ToInt32(selectedrow.Cells[0].Value.ToString());

                var item = Lists.productListings.Where(x => x.ProductID == productid).FirstOrDefault();

                if (item != null)
                {
                    return item;
                }
                return null;
            }
            else if (dgv == 3)
            {
                int selectedrowindex = dgv_Canceled.SelectedCells[0].RowIndex;
                DataGridViewRow selectedrow = dgv_Canceled.Rows[selectedrowindex];
                productid = Convert.ToInt32(selectedrow.Cells[0].Value.ToString());

                var item = Lists.productListings.Where(x => x.ProductID == productid).FirstOrDefault();

                if (item != null)
                {
                    return item;
                }
                return null;
            }
            else return null;
        }

        public void LoadDataGrids()
        {
            dgv_Active.DataSource = null;
            dgv_Users.DataSource = null;
            dgv_PendingRequests.DataSource = null;

            //dgv_Active.ForeColor = Color.Black;
            //dgv_Users.ForeColor = Color.Black;
            //dgv_PendingRequests.ForeColor = Color.Black;

            var Clients = Lists.ClientsList.Select(r => new { Username = r.Username, Name = r.Name, Surname = r.Surname, TYPE = r.UserType.ToString() }).ToList();
            var Contributors = Lists.ContributorsList.Select(r => new { Username = r.Username, Name = r.Name, Surname = r.Surname, TYPE = r.UserType.ToString() }).ToList();
            var ApprovedRequests = Lists.productListings.Where(x => x.status == Product.Status.Active).Select(r => new { ID = r.ProductID, Titulli = r.Name, Description = r.Description, Cmimi_Startues = r.StartingPrice, Cmimi_Akutal = r.CurrentBidPrice, Fillimi = r.AuctionStartDateTime.ToString(), Mbarimi = r.AuctionEndDateTime.ToString(), Shitesi = r.sellersUsername.Username }).ToList();
            var PendingRequests = Lists.productListings.Where(x => x.status == Product.Status.Pending).Select(r => new { ID = r.ProductID, Titulli = r.Name, Description = r.Description, Cmimi_Startues = r.StartingPrice, Cmimi_Akutal = r.CurrentBidPrice, Fillimi = r.AuctionStartDateTime.ToString(), Mbarimi = r.AuctionEndDateTime.ToString(), Shitesi = r.sellersUsername.Username }).ToList();
            var CanceledRequests = Lists.productListings.Where(x=> x.status ==Product.Status.Canceled).Select(r => new { ID = r.ProductID, Titulli = r.Name, Description = r.Description, Cmimi_Startues = r.StartingPrice, Cmimi_Akutal = r.CurrentBidPrice, Fillimi = r.AuctionStartDateTime.ToString(), Mbarimi = r.AuctionEndDateTime.ToString(), Shitesi = r.sellersUsername.Username }).ToList();

            var users = Clients.Concat(Contributors).ToList();

            if (users.Count != 0)
            {
                dgv_Users.DataSource = users;
                dgv_Users.ForeColor = Color.Black;
            }

            if (ApprovedRequests.Count != 0)
            {
                dgv_Active.DataSource = ApprovedRequests;
                dgv_Active.ForeColor = Color.Black;
            }

            if (PendingRequests.Count != 0)
            {
                dgv_PendingRequests.DataSource = PendingRequests;
                dgv_PendingRequests.ForeColor = Color.Black;
            }
            if(CanceledRequests.Count!=0)
            {
                dgv_Canceled.DataSource = CanceledRequests;
                dgv_Canceled.ForeColor = Color.Black;
            }

        }

        //private void dgv_Active_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    AdminApproveDialog aad = new AdminApproveDialog(SelectedProduct());
        //    aad.ShowDialog();
        //}

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn li = new LogIn();
            li.Show();
            this.Close();
        }

        private void dgv_PendingRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AdminApproveDialog aad = new AdminApproveDialog(SelectedProduct(1));
            aad.ShowDialog();

            LoadDataGrids();
        }

        private void dgv_Active_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AdminApproveDialog aad = new AdminApproveDialog(SelectedProduct(2));
            aad.ShowDialog();

            LoadDataGrids();
        }

        private void dgv_Canceled_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AdminApproveDialog aad = new AdminApproveDialog(SelectedProduct(3));
            aad.ShowDialog();

            LoadDataGrids();
        }
    }
}
