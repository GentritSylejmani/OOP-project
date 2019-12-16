using System;
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
        public static object userPerson;
        public static Person.usertype userType;
        public int imageCount = 0;
        public PictureBox[] pcb = new PictureBox[6];
        public string[] image = new string[] { "", "", "", "", "", "" };
        public int selectedImg;
        
        


        public MainPanel()
        {
            InitializeComponent();
            ToolTip logoutExplanation = new ToolTip();
            logoutExplanation.ShowAlways = true;
            logoutExplanation.SetToolTip(pcb_LogOut, "Ckycuni!");
            

            
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

            pcb[0] = pcb_Small1;
            pcb[1] = pcb_Small2;
            pcb[2] = pcb_Small3;
            pcb[3] = pcb_Small4;
            pcb[4] = pcb_Small5;
            pcb[5] = pcb_Small6;

            userType = usertype;

            if (userType == Person.usertype.Client)
            {
                userPerson = new Client();
            }
            else
            {
                userPerson = new Contributor();
            }

            Client client = new Client();

            var userperson = new Client();

            if (usertype == Person.usertype.Client)
            {
                userPerson = (Client)client.GetUserInfo(_user);

                lbl_Welcome.Text = ((Client)userPerson).Name.ToString() + " miresevini ne ";
                lbl_Emri.Text = ((Client)userPerson).Name.ToString();
                lbl_Mbiemri.Text = ((Client)userPerson).Surname.ToString();
                lbl_NoPersonal.Text = ((Client)userPerson).PersonalNo.ToString();
                lbl_NoTelefonit.Text = ((Client)userPerson).PhoneNo.ToString();
                lbl_Emaili.Text = ((Client)userPerson).Email.ToString();
                lbl_numriLlogarise.Text = ((Client)userPerson).AccountNo.ToString();
                lbl_Balanci.Text = String.Format("{0:0.00}", ((Client)userPerson).Credit);
            }
            else if (usertype == Person.usertype.Contributor)

            {
                client = new Contributor();
                userPerson = (Contributor)client.GetUserInfo(_user);

                lbl_Welcome.Text = ((Contributor)userPerson).Name.ToString() + " miresevini ne :";
                lbl_Emri.Text = ((Contributor)userPerson).Name.ToString();
                lbl_Mbiemri.Text = ((Contributor)userPerson).Surname.ToString();
                lbl_NoPersonal.Text = ((Contributor)userPerson).PersonalNo.ToString();
                lbl_NoTelefonit.Text = ((Contributor)userPerson).PhoneNo.ToString();
                lbl_Emaili.Text = ((Contributor)userPerson).Email.ToString();
                lbl_numriLlogarise.Text = ((Contributor)userPerson).AccountNo.ToString();
                lbl_Balanci.Text = String.Format("{0:0.00}", ((Contributor)userPerson).Credit);

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
                ((Client)userPerson).Credit = t.CreditMoney(((Client)userPerson).Credit, Convert.ToDouble(txt_AddCredit.Text));
                txt_AddCredit.Text = "";

                foreach (var user in Lists.ClientsList)
                {
                    if (user.Username == _user)
                    {
                        user.Credit = ((Client)userPerson).Credit;
                    }

                    lbl_Balanci.Text = String.Format("{0:0.00}", ((Client)userPerson).Credit);
                }
            }
            else if (userType == Person.usertype.Contributor)
            {
                ((Contributor)userPerson).Credit = t.CreditMoney(((Contributor)userPerson).Credit, Convert.ToDouble(txt_AddCredit.Text));
                txt_AddCredit.Text = "";

                foreach (var user in Lists.ContributorsList)
                {
                    if (user.Username == _user)
                    {
                        user.Credit = ((Contributor)userPerson).Credit;
                    }
                }

                lbl_Balanci.Text = String.Format("{0:0.00}", ((Contributor)userPerson).Credit);
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

        private DateTime GetAcutionEndTime(int day,int hours)
        {
            DateTime dt = DateTime.Now;

            dt = dt.AddDays(day);
            dt = dt.AddHours(hours);

            dt = new DateTime(dt.Year, dt.Month,dt.Day, dt.Hour, 0, 0);

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
            if (AuctionETA() > DateTime.Now)
            {
                AuctionETA();
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

                if (txt_Hours.Text =="" || txt_Hours.Text==null)
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
               

                DateTime formatedDate = GetAcutionEndTime(Days, Hours+1);

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
                if (timeSpan.TotalHours <1)
                {
                    MessageBox.Show("Koha me e vogel duhet te jete se paku 1 ore");                                 
                }
                else
                {
                    DateTime formatedDate = new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, 0, 0);

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
            dtp_AuctionEndTime.Value = new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, 0, 0);
        }

        private void AddAuction(string Title,string Description,double startingPrice, string[] images,DateTime auctionEta)
        {
            //Lists.ApprovedRequests.Add(new Product())
        }
       
    }
}
