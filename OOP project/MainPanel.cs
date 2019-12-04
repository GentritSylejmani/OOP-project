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
    public partial class MainPanel : Form
    {
        public static object userPerson;
        public static Person.usertype userType;

        public MainPanel()
        {
            InitializeComponent();
            ToolTip logoutExplanation = new ToolTip();
            logoutExplanation.ShowAlways = true;
            logoutExplanation.SetToolTip(pcb_LogOut, "Ckycuni!");
        }
        public MainPanel(string user, Person.usertype usertype)
        {

            InitializeComponent();
            ToolTip logoutExplanation = new ToolTip();
            logoutExplanation.ShowAlways = true;
            logoutExplanation.SetToolTip(pcb_LogOut, "Ckycuni!");
            _user = user;

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

                //userPerson = userperson;

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
            string image="";

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                image = openFileDialog.FileName;
            }

            //pcb_Main.SizeMode = PictureBoxSizeMode.StretchImage;
            //pcb_Main.ImageLocation = "@" + image;
            lbl_imagePath.Text = image;

           
        }
    }
}
