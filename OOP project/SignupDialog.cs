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
            else if(txt_passwordcheck.Text=="")
            {
                pcb_Confirmation.Hide();
            }

        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            string userslist = null; ;  //testing purpose

            bool check = false;

            Client user = new Client();

            

            if (rb_Client.Checked == true)
            {
                
                check=user.SignUp(2, txt_Name.Text, txt_Surname.Text, txt_Username.Text, txt_phoneno.Text, txt_personalno.Text, txt_Password.Text, txt_email.Text, Person.usertype.Client,321456,0.00);
            }
            else if (rb_Contributor.Checked == true)
            {
               
                user = new Contributor();
                check=user.SignUp(3, txt_Name.Text, txt_Surname.Text, txt_Username.Text, txt_phoneno.Text, txt_personalno.Text, txt_Password.Text, txt_email.Text, Person.usertype.Contributor,321456, 0.00);
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
                userslist += "Emri:" + person.Name + " - Mbiemri: " + person.Surname + " - Perdoruesi: " + person.Username + "AccountNo: " + person.AccountNo.ToString() + "\n"; 
                
            }
            foreach (var person in Lists.ClientsList)
            {
                userslist += "Emri:" + person.Name + " - Mbiemri: " + person.Surname + " - Perdoruesi: " + person.Username + "AccountNo: "+ person.AccountNo.ToString()  + "\n";

            }

            MessageBox.Show(userslist);
            
            
           

        }
    }
}
