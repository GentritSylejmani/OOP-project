using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_project
{
    public partial class AdminAuthentication : Form
    {
        public AdminAuthentication()
        {
            InitializeComponent();
       
        }

        private void authenticationCloseKey(object sender,KeyEventArgs e)
        {

        }

        private void AdminAuthentication_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.OK;
                LogIn li = new LogIn();
                li.Show();
            }
            

            if (e.KeyCode == Keys.Enter)
            {
                if (txt_Password.Text == "123456")
                {
                    this.Hide();
                    AdminPanel ap = new AdminPanel();
                    ap.Show();
                    this.Close();
                }
            }
        }
    }
}
