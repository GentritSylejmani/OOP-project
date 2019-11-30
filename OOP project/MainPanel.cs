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
        public MainPanel()
        {
            InitializeComponent();
            ToolTip logoutExplanation = new ToolTip();
            logoutExplanation.ShowAlways = true;
            logoutExplanation.SetToolTip(pcb_LogOut, "Ckycuni!");
        }
        public MainPanel(string user,Person.usertype usertype)
        {

            InitializeComponent();
            ToolTip logoutExplanation = new ToolTip();
            logoutExplanation.ShowAlways = true;
            logoutExplanation.SetToolTip(pcb_LogOut, "Ckycuni!");
            _user = user;

            Client client = new Client();
            Client.Finances finance = new Client.Finances();
            

            if(usertype==Person.usertype.Client)
            {


                lbl_Welcome.Text = client.GetUserInfo(_user).Name.ToString() + " miresevini ne client :";
                lbl_Emri.Text = client.GetUserInfo(_user).Name.ToString();
                lbl_Mbiemri.Text = client.GetUserInfo(_user).Surname.ToString();
                lbl_NoPersonal.Text = client.GetUserInfo(_user).PersonalNo.ToString();
                lbl_NoTelefonit.Text = client.GetUserInfo(_user).PhoneNo.ToString();
                lbl_Emaili.Text = client.GetUserInfo(_user).Email.ToString();

                //label1.Text = "Llogaria: " + client.finance.AccountNo.ToString() + "-- Balanci: " + client.finance.Balance.ToString();
            }
            else if(usertype == Person.usertype.Contributor)

            {
                client = new Contributor();

                lbl_Welcome.Text = client.GetUserInfo(_user).Name.ToString() + " miresevini ne client :";
                lbl_Emri.Text = client.GetUserInfo(_user).Name.ToString();
                lbl_Mbiemri.Text = client.GetUserInfo(_user).Surname.ToString();
                lbl_NoPersonal.Text = client.GetUserInfo(_user).PersonalNo.ToString();
                lbl_NoTelefonit.Text = client.GetUserInfo(_user).PhoneNo.ToString();
                lbl_Emaili.Text = client.GetUserInfo(_user).Email.ToString();

                //label1.Text = "Llogaria: " + client.finance.AccountNo.ToString() + "-- Balanci: " + client.finance.Balance.ToString();
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

        
    }
}
