﻿using System;
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
            rbt_Client.Checked = true;
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



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupDialog sd = new SignupDialog();
            sd.ShowDialog();          
        }

        private void tryLogin()
        {

            Client user = new Client();


            if (rbt_Client.Checked == true)
            {
                if (user.LogInCheck(txt_User.Text, txt_Password.Text) == true)
                {
                    MainPanel mp = new MainPanel(txt_User.Text, Person.usertype.Client);
                    this.Hide();
                    mp.Show();

                }
            }
            else if (rbt_Contributor.Checked == true)
            {
                user = new Contributor();
                if (user.LogInCheck(txt_User.Text, txt_Password.Text) == true)
                {
                    MainPanel mp = new MainPanel(txt_User.Text, Person.usertype.Contributor);
                    this.Hide();
                    mp.Show();

                }
            }

        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            tryLogin();
        }

        private void pcb_MainLogo_Click(object sender, EventArgs e)
        {
            AdminAuthentication a = new AdminAuthentication();
            a.ShowDialog();
            this.Hide();
        }

        private void txt_User_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tryLogin();
            }

        }
        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tryLogin();
            }
        }

        private void rbt_Client_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tryLogin();
            }
        }

        private void rbt_Contributor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tryLogin();
            }
        }
    }
}
