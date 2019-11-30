namespace OOP_project
{
    partial class LogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.lbl_SignUp = new System.Windows.Forms.LinkLabel();
            this.lbl_NewHere = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pcb_X = new System.Windows.Forms.PictureBox();
            this.rbt_Client = new System.Windows.Forms.RadioButton();
            this.rbt_Contributor = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_X)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_User
            // 
            this.txt_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_User.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txt_User.Location = new System.Drawing.Point(78, 120);
            this.txt_User.Margin = new System.Windows.Forms.Padding(2);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(147, 20);
            this.txt_User.TabIndex = 0;
            this.txt_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Password
            // 
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Password.Location = new System.Drawing.Point(78, 151);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '•';
            this.txt_Password.Size = new System.Drawing.Size(147, 20);
            this.txt_Password.TabIndex = 1;
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.FlatAppearance.BorderSize = 50;
            this.btn_LogIn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_LogIn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn_LogIn.Location = new System.Drawing.Point(78, 200);
            this.btn_LogIn.Margin = new System.Windows.Forms.Padding(2);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(147, 27);
            this.btn_LogIn.TabIndex = 2;
            this.btn_LogIn.Text = "Kyçu!";
            this.btn_LogIn.UseVisualStyleBackColor = true;
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // lbl_SignUp
            // 
            this.lbl_SignUp.AutoSize = true;
            this.lbl_SignUp.Location = new System.Drawing.Point(152, 229);
            this.lbl_SignUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SignUp.Name = "lbl_SignUp";
            this.lbl_SignUp.Size = new System.Drawing.Size(63, 13);
            this.lbl_SignUp.TabIndex = 3;
            this.lbl_SignUp.TabStop = true;
            this.lbl_SignUp.Text = "Regjistrohu!";
            this.lbl_SignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_SignUp_LinkClicked);
            // 
            // lbl_NewHere
            // 
            this.lbl_NewHere.AutoSize = true;
            this.lbl_NewHere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewHere.Location = new System.Drawing.Point(85, 229);
            this.lbl_NewHere.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NewHere.Name = "lbl_NewHere";
            this.lbl_NewHere.Size = new System.Drawing.Size(63, 13);
            this.lbl_NewHere.TabIndex = 5;
            this.lbl_NewHere.Text = "I/e re ketu?";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_ID.Location = new System.Drawing.Point(50, 120);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(23, 19);
            this.lbl_ID.TabIndex = 7;
            this.lbl_ID.Text = "ID";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Password.Location = new System.Drawing.Point(49, 151);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(25, 19);
            this.lbl_Password.TabIndex = 8;
            this.lbl_Password.Text = "FK";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OOP_project.Properties.Resources.e_ankandi_logo_;
            this.pictureBox2.Location = new System.Drawing.Point(40, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(206, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pcb_X
            // 
            this.pcb_X.Image = global::OOP_project.Properties.Resources.x;
            this.pcb_X.Location = new System.Drawing.Point(251, 12);
            this.pcb_X.Margin = new System.Windows.Forms.Padding(2);
            this.pcb_X.Name = "pcb_X";
            this.pcb_X.Size = new System.Drawing.Size(24, 25);
            this.pcb_X.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_X.TabIndex = 4;
            this.pcb_X.TabStop = false;
            this.pcb_X.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // rbt_Client
            // 
            this.rbt_Client.AutoSize = true;
            this.rbt_Client.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Client.Location = new System.Drawing.Point(88, 176);
            this.rbt_Client.Name = "rbt_Client";
            this.rbt_Client.Size = new System.Drawing.Size(55, 19);
            this.rbt_Client.TabIndex = 9;
            this.rbt_Client.TabStop = true;
            this.rbt_Client.Text = "Klient";
            this.rbt_Client.UseVisualStyleBackColor = true;
            // 
            // rbt_Contributor
            // 
            this.rbt_Contributor.AutoSize = true;
            this.rbt_Contributor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Contributor.Location = new System.Drawing.Point(149, 176);
            this.rbt_Contributor.Name = "rbt_Contributor";
            this.rbt_Contributor.Size = new System.Drawing.Size(56, 19);
            this.rbt_Contributor.TabIndex = 10;
            this.rbt_Contributor.TabStop = true;
            this.rbt_Contributor.Text = "Shitës";
            this.rbt_Contributor.UseVisualStyleBackColor = true;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 261);
            this.Controls.Add(this.rbt_Contributor);
            this.Controls.Add(this.rbt_Client);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_NewHere);
            this.Controls.Add(this.pcb_X);
            this.Controls.Add(this.lbl_SignUp);
            this.Controls.Add(this.btn_LogIn);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_X)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_LogIn;
        private System.Windows.Forms.LinkLabel lbl_SignUp;
        private System.Windows.Forms.PictureBox pcb_X;
        private System.Windows.Forms.Label lbl_NewHere;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.RadioButton rbt_Client;
        private System.Windows.Forms.RadioButton rbt_Contributor;
    }
}

