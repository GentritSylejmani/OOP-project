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
    public partial class SignupDialog : Form
    {
        public SignupDialog()
        {
            InitializeComponent();

            pcb_exclamationmark.Image = SystemIcons.Information.ToBitmap();
            ToolTip userExplanation = new ToolTip();
            userExplanation.ShowAlways = true;
            userExplanation.SetToolTip(pcb_exclamationmark, "Nese regjistroheni si shites, ju automatikisht gezoni te gjitha privilegjet edhe si bleres!");
            pcb_Confirmation.Hide();

        }

        private void pcb_X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void passwordCheck(object sender, EventArgs e)
        {
            if(txt_Password.Text==txt_passwordcheck.Text)
            {
                pcb_Confirmation.Show();
                pcb_Confirmation.Image = OOP_project.Properties.Resources.tick;
                pcb_Confirmation.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            if (txt_Password.Text!=txt_passwordcheck.Text)
            {
                pcb_Confirmation.Show();
                pcb_Confirmation.Image = OOP_project.Properties.Resources.x;
                pcb_Confirmation.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if(txt_passwordcheck.Text==null)
            {
                pcb_Confirmation.Hide();
            }

        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            string userslist = null; ;  //testing purpose

            bool check = false;

            Client user = new Client();

            Client.Finances finance = new Client.Finances();

            if (rb_Client.Checked == true)
            {
                
                check=user.SignUp(2, txt_Name.Text, txt_Surname.Text, txt_Username.Text, txt_phoneno.Text, txt_personalno.Text, txt_Password.Text, txt_email.Text, Person.usertype.Client,finance.AccountNo=12345,finance.Balance=100.00);
            }
            else if (rb_Contributor.Checked == true)
            {
                finance = new Contributor.Finances();
                user = new Contributor();
                check=user.SignUp(3, txt_Name.Text, txt_Surname.Text, txt_Username.Text, txt_phoneno.Text, txt_personalno.Text, txt_Password.Text, txt_email.Text, Person.usertype.Contributor, finance.AccountNo = 12345, finance.Balance = 100.00);
            }
            if (check == true)
            {
                MessageBox.Show("Perdoruesi u shtua me sukses!");
            }
            else
            {
                MessageBox.Show("Regjistrimi nuk pati sukses.Provoni perseri!");
            }
            //Arsye testuese

            MessageBox.Show("Numri i kontribuesve: " + Lists.ContributorsList.Count() +
                           "\nNumri i klienteve: " + Lists.ClientsList.Count());

            foreach (var person in Lists.ContributorsList)
            {
                userslist += "Emri:" + person.Name + " Mbiemri: "+ person.Surname + "Perdoruesi: " + person.Username + "\n"; 
                
            }

            MessageBox.Show(userslist);
            
            
           

        }
    }
}
