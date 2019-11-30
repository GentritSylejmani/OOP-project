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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupDialog sd = new SignupDialog();
            sd.ShowDialog();
            
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            Client user = new Client();
          

            if (rbt_Client.Checked==true)
            {
                if(user.LogInCheck(txt_User.Text,txt_Password.Text)==true)
                {
                    MainPanel mp = new MainPanel(txt_User.Text,Person.usertype.Client) ;
                    this.Hide();
                    mp.Show();
                    
                }
            }
            else if(rbt_Contributor.Checked==true)
            {
                user = new Contributor();
                if(user.LogInCheck(txt_User.Text,txt_Password.Text)==true)
                {
                    MainPanel mp = new MainPanel(txt_User.Text,Person.usertype.Contributor);
                    this.Hide();
                    mp.Show();
                   
                }
            }

            
            
        }
    }
}
