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
            
            

            if(usertype==Person.usertype.Client)
            {

                client.GetUserInfo(_user);

                lbl_Welcome.Text = client.GetUserInfo(_user).Name.ToString() + " miresevini ne ";
                lbl_Emri.Text = client.GetUserInfo(_user).Name.ToString();
                lbl_Mbiemri.Text = client.GetUserInfo(_user).Surname.ToString();
                lbl_NoPersonal.Text = client.GetUserInfo(_user).PersonalNo.ToString();
                lbl_NoTelefonit.Text = client.GetUserInfo(_user).PhoneNo.ToString();
                lbl_Emaili.Text = client.GetUserInfo(_user).Email.ToString();
                lbl_numriLlogarise.Text = client.GetUserInfo(_user).AccountNo.ToString();
                lbl_Balanci.Text = String.Format("{0:0.00}", client.GetUserInfo(_user).Credit);
            }
            else if(usertype == Person.usertype.Contributor)

            {
                client = new Contributor();
                client.GetUserInfo(_user);

                lbl_Welcome.Text = client.GetUserInfo(_user).Name.ToString() + " miresevini ne :";
                lbl_Emri.Text = client.GetUserInfo(_user).Name.ToString();
                lbl_Mbiemri.Text = client.GetUserInfo(_user).Surname.ToString();
                lbl_NoPersonal.Text = client.GetUserInfo(_user).PersonalNo.ToString();
                lbl_NoTelefonit.Text = client.GetUserInfo(_user).PhoneNo.ToString();
                lbl_Emaili.Text = client.GetUserInfo(_user).Email.ToString();
                lbl_numriLlogarise.Text = client.GetUserInfo(_user).AccountNo.ToString();
                lbl_Balanci.Text = String.Format("{0:0.00}", client.GetUserInfo(_user).Credit);

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
