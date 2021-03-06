﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

using BOL;

namespace OOP_project
{
    public partial class MainPanel : Form
    {
        public Person userPerson = null;
        public static Person.usertype userType;
        public List<Product> bidItems = new List<Product>() { };
        public int imageCount = 0;
        public PictureBox[] pcb = new PictureBox[6];
        public string[] image = new string[] { "", "", "", "", "", "" };
        public int selectedImg;

        


        public MainPanel()
        {
            InitializeComponent();          
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

        public MainPanel(string user, Person.usertype usertype)
        {

            InitializeComponent();
            ToolTip logoutExplanation = new ToolTip();
            logoutExplanation.ShowAlways = true;
            logoutExplanation.SetToolTip(pcb_LogOut, "Ckycuni!");
            _user = user;
            dtp_AuctionEndTime.Value = DateTime.Now.AddDays(1);
            cmb_CategorySearch.DataSource = Enum.GetValues(typeof(Product.ProductCategory));        

            pcb[0] = pcb_Small1;
            pcb[1] = pcb_Small2;
            pcb[2] = pcb_Small3;
            pcb[3] = pcb_Small4;
            pcb[4] = pcb_Small5;
            pcb[5] = pcb_Small6;

            userType = usertype;

            if (userType == Person.usertype.Client)
            {
                userPerson = Client.GetUserInfo(user);
                tab_MyListings.Enabled = false;
                tab_AddListing.Enabled = false;
                lbl_Rating.Hide();
                lbl_RatingValue.Hide();
            }
            else
            {
                userPerson = Contributor.GetUserInfo(user);
            }

            LoadDatagrids();

                
            
                lbl_Welcome.Text = userPerson.Name.ToString() + " miresevini ne ";
                lbl_Emri.Text = userPerson.Name.ToString();
                lbl_Mbiemri.Text = userPerson.Surname.ToString();
                lbl_NoPersonal.Text = userPerson.PersonalNo.ToString();
                lbl_NoTelefonit.Text = userPerson.PhoneNo.ToString();
                lbl_Emaili.Text = userPerson.Email.ToString();
                lbl_numriLlogarise.Text = userPerson.AccountNo.ToString();
                lbl_Balanci.Text = String.Format("{0:0.00}", userPerson.Credit);
                
                
        }

        public void LoadDatagrids()
        {
            
            dgv_ActiveAuctions.DataSource = null;
            dgv_ApprovedListings.DataSource = null;
            dgv_PersonalListings.DataSource = null;
            dgv_Purchased.DataSource = null;

            //userPerson.Display();
            //MessageBox.Show(userPerson.testPerDispay);

            if (userType == Person.usertype.Contributor)
            {
                
                var personalListings = Lists.productListings.Where(x => x.sellersUsername.Username == userPerson.Username).Select(r => new { ID = r.ProductID, Titulli = r.Name, Description = r.Description, Kategoria = r.Category.ToString(), Cmimi_Startues = r.StartingPrice, Cmimi_Akutal = r.CurrentBidPrice, Fillimi = r.AuctionStartDateTime.ToString(), Mbarimi = r.AuctionEndDateTime.ToString(), Shitesi = r.sellersUsername.Username, OfertuesiFundit = r.bidder != null ? r.bidder.Username : "S'ka ofertues",Shikuar = r.ViewCount, Statusi = r.status.ToString() }).ToList();

                if (personalListings.Count != 0)
                {
                    dgv_PersonalListings.DataSource = personalListings;
                    dgv_PersonalListings.ForeColor = Color.Black;
                }
            }
            bool keepgoing = true;

            var endedAuctions = Lists.productListings.FirstOrDefault(x => x.AuctionEndDateTime < DateTime.Now && x.status==Product.Status.Active);//.Select(x => new { ID = x.ProductID, Titulli = x.Name, Cmimi_Aktual = x.CurrentBidPrice }).ToList();
            while(keepgoing)
            {
                endedAuctions = Lists.productListings.FirstOrDefault(x => x.AuctionEndDateTime < DateTime.Now && x.status == Product.Status.Active);

                if (endedAuctions != null)
                {
                    endedAuctions.status = Product.Status.Ended;
                }
                else keepgoing = false;
            }
            var wonActions = Lists.productListings.Where(x=> x.bidder!=null && x.bidder.Username==userPerson.Username && x.AuctionEndDateTime < DateTime.Now && x.status == Product.Status.Ended).Select(x => new { ID = x.ProductID, Titulli = x.Name, Cmimi_final = x.CurrentBidPrice }).ToList();
            var activeAuctions = Lists.productListings.Where(x => x.bidder != null && ((Client)userPerson).bidProducts.Contains(x.ProductID) && x.AuctionEndDateTime > DateTime.Now && x.status == Product.Status.Active).Select(x => new { ID = x.ProductID, Titulli = x.Name, Cmimi_Aktual = x.CurrentBidPrice,Ofertuesi_Fundit = x.bidder.Username }).ToList();
            var approvedListings= Lists.productListings.Where(x => x.status == Product.Status.Active).Select(r => new { ID = r.ProductID, Titulli = r.Name, Description = r.Description, Kategoria = r.Category.ToString(), Cmimi_Startues = r.StartingPrice, Cmimi_Akutal = r.CurrentBidPrice, Fillimi = r.AuctionStartDateTime.ToString(), Mbarimi = r.AuctionEndDateTime.ToString(), Shitesi = r.sellersUsername.Username }).ToList();  
            var purchased = Lists.productListings.Where(x=> x.status==Product.Status.Sold).Select(x => new { ID = x.ProductID, Titulli = x.Name, Cmimi_final = x.CurrentBidPrice,Paguar=x.SoldPrice }).ToList();

           // var endedNotPurchased = wonActions.Except(purchased);
            
            if (wonActions!=null)
            {
                dgv_WonAuctions.DataSource = wonActions; //endedNotPurchased;
                dgv_WonAuctions.ForeColor = Color.Black;
            }
            
            

            if (activeAuctions != null)
            {
                dgv_ActiveAuctions.DataSource = activeAuctions;
                dgv_ActiveAuctions.ForeColor = Color.Black;
            }          

            if (approvedListings != null)
            {
                dgv_ApprovedListings.DataSource = approvedListings;
                dgv_ApprovedListings.ForeColor = Color.Black;
            }

            if(purchased != null)
            {
                dgv_Purchased.DataSource = purchased;
                dgv_Purchased.ForeColor = Color.Black;
            }
            
        }

        private string _user;

        private void pcb_LogOut_Click(object sender, EventArgs e)
        {
            LogIn li = new LogIn();
            this.Hide();
            li.Show();
            this.Close();
        }

        private void btn_AddCredit_Click(object sender, EventArgs e)
        {
            if (txt_AddCredit.Text == null || txt_AddCredit.Text == "")
            {
                MessageBox.Show("Ju lutem shkruani ne rubrike shumen qe doni te shtoni!");
                return;
            }


            Transactions t = new Transactions();

            if (userType == Person.usertype.Client)
            {
                userPerson.Credit = t.CreditMoney(userPerson.Credit, Convert.ToDouble(txt_AddCredit.Text));
                txt_AddCredit.Text = "";

                foreach (var user in Lists.ClientsList)
                {
                    if (user.Username == _user)
                    {
                        user.Credit = userPerson.Credit;
                    }

                    lbl_Balanci.Text = String.Format("{0:0.00}", ((Client)userPerson).Credit);
                }
            }
            else if (userType == Person.usertype.Contributor)
            {
                userPerson.Credit = t.CreditMoney(userPerson.Credit, Convert.ToDouble(txt_AddCredit.Text));
                txt_AddCredit.Text = "";

                foreach (var user in Lists.ContributorsList)
                {
                    if (user.Username == _user)
                    {
                        user.Credit = userPerson.Credit;
                    }
                }

                lbl_Balanci.Text = String.Format("{0:0.00}", userPerson.Credit);
            }
        }

        private void btn_AddImage_Click(object sender, EventArgs e)
        {
            string imagepath = "";


            if (imageCount >= 6)
            {
                MessageBox.Show("Fshijeni nje fotografi, pasi qe numri maksimal eshte 6");
            }
            else
            {

                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagepath = openFileDialog.FileName.ToString();
                    openFileDialog.Dispose();
                }
                else return;

                switch (imageCount)
                {
                    case 0:
                        image[0] = imagepath;
                        pcb_Small1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pcb_Small1.Image = Image.FromFile(image[0]);
                        selectedImg = 0;
                        imageCount += 1;
                        break;

                    case 1:
                        image[1] = imagepath;
                        pcb_Small2.SizeMode = PictureBoxSizeMode.StretchImage;
                        pcb_Small2.Image = Image.FromFile(image[1]);
                        imageCount += 1;
                        break;


                    case 2:
                        image[2] = imagepath;
                        pcb_Small3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pcb_Small3.Image = Image.FromFile(image[2]);
                        imageCount += 1;
                        break;

                    case 3:
                        image[3] = imagepath;
                        pcb_Small4.SizeMode = PictureBoxSizeMode.StretchImage;
                        pcb_Small4.Image = Image.FromFile(image[3]);
                        imageCount += 1;
                        break;

                    case 4:
                        image[4] = imagepath;
                        pcb_Small5.SizeMode = PictureBoxSizeMode.StretchImage;
                        pcb_Small5.Image = Image.FromFile(image[4]);
                        imageCount += 1;
                        break;

                    case 5:
                        image[5] = imagepath;
                        pcb_Small6.SizeMode = PictureBoxSizeMode.StretchImage;
                        pcb_Small6.Image = Image.FromFile(image[5]);
                        imageCount += 1;
                        break;

                    default:

                        break;
                }

                lbl_imagePath.Text = imagepath;
                pcb_Main.SizeMode = PictureBoxSizeMode.StretchImage;
                pcb_Main.Image = Image.FromFile(imagepath);
            }


        }

        private void pcb_Small1_Click(object sender, EventArgs e)
        {

            if (image[0] != "")
            {
                //MessageBox.Show(image[0]);
                pcb_Main.Image = Image.FromFile(image[0]);
                lbl_imagePath.Text = image[0];
                selectedImg = 0;
            }
            else
                return;

        }

        private void pcb_Small2_Click(object sender, EventArgs e)
        {

            if (image[1] != "")
            {
                pcb_Main.Image = Image.FromFile(image[1]);
                lbl_imagePath.Text = image[1];
                selectedImg = 1;
            }
            else
                return;
        }

        private void pcb_Small3_Click(object sender, EventArgs e)
        {

            if (image[2] != "")
            {
                pcb_Main.Image = Image.FromFile(image[2]);
                lbl_imagePath.Text = image[2];
                selectedImg = 2;
            }
            else
                return;
        }

        private void pcb_Small4_Click(object sender, EventArgs e)
        {

            if (image[3] != "")
            {
                pcb_Main.Image = Image.FromFile(image[3]);
                lbl_imagePath.Text = image[3];
                selectedImg = 3;
            }
            else
                return;
        }

        private void pcb_Small5_Click(object sender, EventArgs e)
        {

            if (image[4] != "")
            {
                pcb_Main.Image = Image.FromFile(image[4]);
                lbl_imagePath.Text = image[4];
                selectedImg = 4;
            }
            else
                return;
        }

        private void pcb_Small6_Click(object sender, EventArgs e)
        {

            if (image[5] != "")
            {
                pcb_Main.Image = Image.FromFile(image[5]);
                lbl_imagePath.Text = image[5];
                selectedImg = 5;
            }
            else
                return;
        }

        private void pcb_Delete_Click(object sender, EventArgs e)
        {
            if (imageCount == 0)
            {
                MessageBox.Show("Nuk keni asnje fotografi te zgjedhur!");
                return;
            }
            else
            {
                //string message = "";
                if (image[selectedImg] == "")
                {
                    selectedImg -= 1;
                }

                image[selectedImg] = "";
                imageCount -= 1;
                //lbl_imagePath.Text = image[selectedImg];

                sortImageArray();
                populatePCBs();

                //for (int i = 0; i < 6; i++)
                //{
                //    message = message + i + " : " + image[i] + "\n";
                //}

                //MessageBox.Show(message);
            }

        }

        private void sortImageArray()
        {
            //string tempImagepath;

            for (int i = 0; i < 5; i++)
            {
                if (image[i] == "" || image[i] == null)
                {
                    image[i] = image[i + 1];
                    image[i + 1] = "";
                }

            }
        }

        private void populatePCBs()
        {
            for (int i = 0; i < 6; i++)
            {
                if (image[i] == "" || image[i] == null)
                {
                    pcb[i].Image = null;

                }
                else
                {
                    pcb[i].Image = Image.FromFile(image[i]);
                }

                if (image[0] == "")
                {
                    pcb_Main.Image = null;
                    lbl_imagePath.Text = "N/A";
                }
                else
                    pcb_Main.Image = Image.FromFile(image[0]);
            }
        }

        private DateTime GetAcutionEndTime(int day, int hours)
        {
            DateTime dt = DateTime.Now;

            dt = dt.AddDays(day);
            dt = dt.AddHours(hours);

            dt = new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, 0, 0);

            return dt;
        }

        private TimeSpan GetAuctionEndTime(DateTime EndTime)
        {
            DateTime dt = DateTime.Now;
            TimeSpan ts = EndTime - dt;

            return ts;
        }

        //private string AuctionTimeETA(string time)
        //{
        //    return time;

        //}

        private void btn_AddListingRequest_Click(object sender, EventArgs e)
        {
            Contributor c = new Contributor();
            
            if (txt_ProductTitle.Text == null || txt_ProductTitle.Text == "" || txt_StartingPrice.Text == null || txt_StartingPrice.Text == "" || rtxt_Description == null || rtxt_Description.Text=="")
            {
                MessageBox.Show("Ju lutem plotesoni te gjitha fushat e nevojshme!");
                return;
            }

            string message = "";

            if (AuctionETA() > DateTime.Now)
            {
                int selectedCategory = cmb_Category.SelectedIndex;
                c.SubmitAuctionRequest(txt_ProductTitle.Text, rtxt_Description.Text, Convert.ToDouble(txt_StartingPrice.Text), Convert.ToDouble(txt_StartingPrice.Text), AuctionETA(), image, ((Contributor)userPerson), (Product.ProductCategory)selectedCategory, Product.Status.Pending);

                MessageBox.Show("U shtua me sukses!");
                LoadDatagrids();
            }
            else MessageBox.Show("Zgjedhni date valide!");

            }

        private DateTime AuctionETA()
        {
            if (tab_auctionTimes.SelectedTab == tab_auctionTimes.TabPages["tab_Time"])
            {
                int Days = 0;
                int Hours = 0;

                if (txt_Days.Text == "" || txt_Days.Text == null)
                {
                    Days = 0;
                }
                else
                {
                    Days = Convert.ToInt32(txt_Days.Text);
                }

                if (txt_Hours.Text == "" || txt_Hours.Text == null)
                {
                    Hours = 0;
                }
                else
                {
                    Hours = Convert.ToInt32(txt_Hours.Text);
                }

                if (Days == 0 && Hours == 0)
                {
                    MessageBox.Show("Koha minimale per ankand eshte 1 ore");
                    txt_Hours.Text = (1).ToString();
                    txt_Days.Text = (0).ToString();
                    Hours = 1;
                }



                //DateTime dateTime = GetAcutionEndTime(Days, Hours);

                //lbl_AuctionTimeETA.Text = GetAcutionEndTime(10, 10);


                DateTime formatedDate = DateTime.Now.AddDays(Days);
                formatedDate = formatedDate.AddHours(Hours);

                TimeSpan timeSpan = formatedDate - DateTime.Now;

                lbl_AuctionTimeETA.Text = "Me " + formatedDate.ToString() + "\n ose ne " + timeSpan.Days.ToString() + " dite e " + timeSpan.Hours.ToString() + " ore";
                //txt_Days.Text = formatedDate.Day.ToString();
                //txt_Hours.Text = formatedDate.Hour.ToString();

                return formatedDate;

            }
            else if (tab_auctionTimes.SelectedTab == tab_auctionTimes.TabPages["tab_Date"])
            {
                DateTime dt = dtp_AuctionEndTime.Value;
                TimeSpan timeSpan;
                timeSpan = (dt - DateTime.Now);
                if (timeSpan.TotalHours < 1)
                {
                    MessageBox.Show("Koha me e vogel duhet te jete se paku 1 ore");
                }
                else
                {
                    DateTime formatedDate = new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second);

                    //dtp_AuctionEndTime.Value = new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, 0, 0);
                    //MessageBox.Show(formatedDate.ToString());

                    TimeSpan ts = GetAuctionEndTime(formatedDate);
                    int days = ts.Days;
                    int hours = ts.Hours;

                    lbl_AuctionTimeETA.Text = "Me " + dtp_AuctionEndTime.Value.ToString() + "\n ose ne " + days.ToString() + " dite e " + hours.ToString() + " ore";

                    return formatedDate;
                }
            }
            return DateTime.Now;
        }

        private void dtp_AuctionEndTime_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dtp_AuctionEndTime.Value;
            dtp_AuctionEndTime.Value = new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second);

            AuctionETA();
        }

        private void timeTXTnumberenter(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void EnterTimeETA(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AuctionETA();
            }
        }

        public void PopulateListingsDataGrid()
        {
            dgv_ApprovedListings.DataSource = null;

            dgv_ApprovedListings.ForeColor = Color.Black;

            var result = Lists.ApprovedRequests.Select(r => new { ID = r.ProductID, Titulli = r.Name, Description = r.Description, Cmimi_Startues = r.StartingPrice, Cmimi_Akutal = r.CurrentBidPrice, Fillimi = r.AuctionStartDateTime.ToString(), Mbarimi = r.AuctionEndDateTime.ToString(), Shitesi = r.sellersUsername.Username }).ToList();

            dgv_ApprovedListings.DataSource = result;
        }

        private void MainPanel_Load(object sender, EventArgs e)
        {
            cmb_Category.DataSource = Enum.GetValues(typeof(Product.ProductCategory));
        }

        private void btn_RefreshDataGrid_Click(object sender, EventArgs e)
        {
            LoadDatagrids();
        }

        private void dgv_ApprovedListings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SelectedProduct(1).sellersUsername.Username == _user)
            {
                MessageBox.Show("Nuk mund te ofertoni ne shpalljen tuaj!");
                return;
            }
            else
            {
                AuctionDialog ad = new AuctionDialog(SelectedProduct(1), (Person)userPerson);
                ad.ShowDialog();

                LoadDatagrids();
            }
        }

        private Product SelectedProduct(int dgv)
        {
            if (dgv == 1)
            {
                Product product = new Product();

                int productid;

                int selectedrowindex = dgv_ApprovedListings.SelectedCells[0].RowIndex;
                DataGridViewRow selectedrow = dgv_ApprovedListings.Rows[selectedrowindex];
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
                Product product = new Product();

                int productid;

                int selectedrowindex = dgv_ActiveAuctions.SelectedCells[0].RowIndex;
                DataGridViewRow selectedrow = dgv_ActiveAuctions.Rows[selectedrowindex];
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
                Product product = new Product();

                int productid;

                int selectedrowindex = dgv_WonAuctions.SelectedCells[0].RowIndex;
                DataGridViewRow selectedrow = dgv_WonAuctions.Rows[selectedrowindex];
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

        private void SearchItem(string title)
        {

            dgv_PersonalListings.DataSource = null;
            dgv_PersonalListings.ForeColor = Color.Black;

            var searchedList = Lists.productListings.Where(x => x.Name.Contains(title)).Select(r => new { ID = r.ProductID, Titulli = r.Name, Description = r.Description, Cmimi_Startues = r.StartingPrice, Cmimi_Akutal = r.CurrentBidPrice, Fillimi = r.AuctionStartDateTime.ToString(), Mbarimi = r.AuctionEndDateTime.ToString(), Shitesi = r.sellersUsername.Username }).ToList();

            dgv_ApprovedListings.DataSource = searchedList;
        }

        private void SearchItem(string title,double minPrice)
        {
            dgv_ApprovedListings.DataSource = null;
            dgv_ApprovedListings.ForeColor = Color.Black;

            var searchedList = Lists.productListings.Where(x => x.Name.Contains(title) && x.CurrentBidPrice>minPrice).Select(r => new { ID = r.ProductID, Titulli = r.Name, Description = r.Description, Cmimi_Startues = r.StartingPrice, Cmimi_Akutal = r.CurrentBidPrice, Fillimi = r.AuctionStartDateTime.ToString(), Mbarimi = r.AuctionEndDateTime.ToString(), Shitesi = r.sellersUsername.Username }).ToList();

            dgv_ApprovedListings.DataSource = searchedList;
        }

        private void SearchItem(string title, double minPrice,double maxPrice,string seller)
        {
            dgv_ApprovedListings.DataSource = null;
           dgv_ApprovedListings.ForeColor = Color.Black;

            var searchedList = Lists.productListings.Where(x => x.Name.Contains(title) && x.CurrentBidPrice >= minPrice && x.CurrentBidPrice<=maxPrice && x.sellersUsername.Username.Contains(seller)).Select(r => new { ID = r.ProductID, Titulli = r.Name, Description = r.Description,Kategoria =r.Category.ToString(), Cmimi_Startues = r.StartingPrice, Cmimi_Akutal = r.CurrentBidPrice, Fillimi = r.AuctionStartDateTime.ToString(), Mbarimi = r.AuctionEndDateTime.ToString(), Shitesi = r.sellersUsername.Username }).ToList();

            dgv_ApprovedListings.DataSource = searchedList;
        }

        private void SearchItem(string title,double minPrice,double maxPrice,Product.ProductCategory category, string seller)
        {
            dgv_ApprovedListings.DataSource = null;
            dgv_ApprovedListings.ForeColor = Color.Black;

            var searchedList = Lists.productListings.Where(x => x.Name.Contains(title) && x.CurrentBidPrice >= minPrice && x.CurrentBidPrice <= maxPrice && x.sellersUsername.Username.Contains(seller) && x.Category==category
            ).Select(r => new { ID = r.ProductID, Titulli = r.Name, Description = r.Description, Kategoria = r.Category.ToString(), Cmimi_Startues = r.StartingPrice, Cmimi_Akutal = r.CurrentBidPrice, Fillimi = r.AuctionStartDateTime.ToString(), Mbarimi = r.AuctionEndDateTime.ToString(), Shitesi = r.sellersUsername.Username }).ToList();

            dgv_ApprovedListings.DataSource = searchedList;
        }

        private void Search()
        {

            string titulli = txt_Article.Text;
            string shitesi = txt_SellersUsername.Text;
            double minvalue = (txt_MinPrice.Text == "" || txt_MinPrice.Text == null) ? 0 : Convert.ToDouble(txt_MinPrice.Text);
            double maxvalue = (txt_MaxPrice.Text == "" || txt_MaxPrice.Text == null) ? 9999999 : Convert.ToDouble(txt_MaxPrice.Text);
            int productCategory = cmb_CategorySearch.SelectedIndex;

            if (productCategory == 0)
            {
                SearchItem(titulli, minvalue, maxvalue, shitesi);
            }
            else
            {
                SearchItem(titulli, minvalue, maxvalue, (Product.ProductCategory)productCategory, shitesi);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btn_RefreshMyListings_Click(object sender, EventArgs e)
        {
            LoadDatagrids();
        }

        private void txt_Article_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                Search();
            }
        }

        private void cmb_CategorySearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void txt_MinPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void txt_MaxPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void txt_SellersUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void btn_RefreshAccountTab_Click(object sender, EventArgs e)
        {
            LoadDatagrids();
        }

        private void dgv_ActiveAuctions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                AuctionDialog ad = new AuctionDialog(SelectedProduct(2),userPerson);
                ad.ShowDialog();

                LoadDatagrids();
            
        }

        private void dgv_WonAuctions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PurchaseDialog pd = new PurchaseDialog(SelectedProduct(3),userPerson);
            pd.Show();

            //userPerson.GetUserInfo(_user);
            //lbl_Balanci.Text = String.Format("{0:0.00}", userPerson.Credit);

            LoadDatagrids();
        }
    }
}
