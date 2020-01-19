namespace OOP_project
{
    partial class ContributorRating
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
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Surname = new System.Windows.Forms.Label();
            this.lbl_NameValue = new System.Windows.Forms.Label();
            this.lbl_SurnameValue = new System.Windows.Forms.Label();
            this.lbl_UsernameValue = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_Rating = new System.Windows.Forms.Label();
            this.lbl_RatingValue = new System.Windows.Forms.Label();
            this.txt_RatingValue = new System.Windows.Forms.TextBox();
            this.btn_Rate = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Username.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Username.Location = new System.Drawing.Point(29, 9);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(54, 19);
            this.lbl_Username.TabIndex = 7;
            this.lbl_Username.Text = "Nofka:";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Name.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Name.Location = new System.Drawing.Point(39, 28);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(44, 19);
            this.lbl_Name.TabIndex = 8;
            this.lbl_Name.Text = "Emri:";
            // 
            // lbl_Surname
            // 
            this.lbl_Surname.AutoSize = true;
            this.lbl_Surname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Surname.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Surname.Location = new System.Drawing.Point(12, 47);
            this.lbl_Surname.Name = "lbl_Surname";
            this.lbl_Surname.Size = new System.Drawing.Size(71, 19);
            this.lbl_Surname.TabIndex = 9;
            this.lbl_Surname.Text = "Mbiemri:";
            // 
            // lbl_NameValue
            // 
            this.lbl_NameValue.AutoSize = true;
            this.lbl_NameValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_NameValue.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_NameValue.Location = new System.Drawing.Point(89, 28);
            this.lbl_NameValue.Name = "lbl_NameValue";
            this.lbl_NameValue.Size = new System.Drawing.Size(36, 19);
            this.lbl_NameValue.TabIndex = 10;
            this.lbl_NameValue.Text = "N/A";
            // 
            // lbl_SurnameValue
            // 
            this.lbl_SurnameValue.AutoSize = true;
            this.lbl_SurnameValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_SurnameValue.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_SurnameValue.Location = new System.Drawing.Point(89, 47);
            this.lbl_SurnameValue.Name = "lbl_SurnameValue";
            this.lbl_SurnameValue.Size = new System.Drawing.Size(36, 19);
            this.lbl_SurnameValue.TabIndex = 11;
            this.lbl_SurnameValue.Text = "N/A";
            // 
            // lbl_UsernameValue
            // 
            this.lbl_UsernameValue.AutoSize = true;
            this.lbl_UsernameValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_UsernameValue.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_UsernameValue.Location = new System.Drawing.Point(89, 9);
            this.lbl_UsernameValue.Name = "lbl_UsernameValue";
            this.lbl_UsernameValue.Size = new System.Drawing.Size(36, 19);
            this.lbl_UsernameValue.TabIndex = 12;
            this.lbl_UsernameValue.Text = "N/A";
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Back.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Back.Location = new System.Drawing.Point(452, 45);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 29);
            this.btn_Back.TabIndex = 13;
            this.btn_Back.Text = "Prapa!";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_Rating
            // 
            this.lbl_Rating.AutoSize = true;
            this.lbl_Rating.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Rating.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Rating.Location = new System.Drawing.Point(12, 79);
            this.lbl_Rating.Name = "lbl_Rating";
            this.lbl_Rating.Size = new System.Drawing.Size(71, 19);
            this.lbl_Rating.TabIndex = 14;
            this.lbl_Rating.Text = "Vleresimi";
            // 
            // lbl_RatingValue
            // 
            this.lbl_RatingValue.AutoSize = true;
            this.lbl_RatingValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_RatingValue.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_RatingValue.Location = new System.Drawing.Point(89, 79);
            this.lbl_RatingValue.Name = "lbl_RatingValue";
            this.lbl_RatingValue.Size = new System.Drawing.Size(36, 19);
            this.lbl_RatingValue.TabIndex = 15;
            this.lbl_RatingValue.Text = "N/A";
            // 
            // txt_RatingValue
            // 
            this.txt_RatingValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txt_RatingValue.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_RatingValue.Location = new System.Drawing.Point(371, 12);
            this.txt_RatingValue.Name = "txt_RatingValue";
            this.txt_RatingValue.Size = new System.Drawing.Size(156, 27);
            this.txt_RatingValue.TabIndex = 29;
            // 
            // btn_Rate
            // 
            this.btn_Rate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Rate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Rate.Location = new System.Drawing.Point(371, 45);
            this.btn_Rate.Name = "btn_Rate";
            this.btn_Rate.Size = new System.Drawing.Size(75, 29);
            this.btn_Rate.TabIndex = 30;
            this.btn_Rate.Text = "Vlereso!";
            this.btn_Rate.UseVisualStyleBackColor = true;
            this.btn_Rate.Click += new System.EventHandler(this.btn_Rate_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(246, 199);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 31;
            this.trackBar1.TickFrequency = 5;
            // 
            // ContributorRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 491);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btn_Rate);
            this.Controls.Add(this.txt_RatingValue);
            this.Controls.Add(this.lbl_RatingValue);
            this.Controls.Add(this.lbl_Rating);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbl_UsernameValue);
            this.Controls.Add(this.lbl_SurnameValue);
            this.Controls.Add(this.lbl_NameValue);
            this.Controls.Add(this.lbl_Surname);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContributorRating";
            this.Text = "ContributorRating";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Surname;
        private System.Windows.Forms.Label lbl_NameValue;
        private System.Windows.Forms.Label lbl_SurnameValue;
        private System.Windows.Forms.Label lbl_UsernameValue;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_Rating;
        private System.Windows.Forms.Label lbl_RatingValue;
        private System.Windows.Forms.TextBox txt_RatingValue;
        private System.Windows.Forms.Button btn_Rate;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}