namespace OOP_project
{
    partial class AuctionDialog
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
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_StartDateTime = new System.Windows.Forms.Label();
            this.lbl_EndDateTime = new System.Windows.Forms.Label();
            this.pcb_Main = new System.Windows.Forms.PictureBox();
            this.pcb_small1 = new System.Windows.Forms.PictureBox();
            this.pcb_small2 = new System.Windows.Forms.PictureBox();
            this.pcb_small3 = new System.Windows.Forms.PictureBox();
            this.pcb_small4 = new System.Windows.Forms.PictureBox();
            this.pcb_small5 = new System.Windows.Forms.PictureBox();
            this.pcb_small6 = new System.Windows.Forms.PictureBox();
            this.lbl_Seller = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_TitleValue = new System.Windows.Forms.Label();
            this.lbl_StartDateTimeValue = new System.Windows.Forms.Label();
            this.lbl_EndDatTimeValue = new System.Windows.Forms.Label();
            this.lbl_SellersIDValue = new System.Windows.Forms.Label();
            this.rtxt_Description = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_small1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_small2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_small3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_small4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_small5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_small6)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Submit.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Submit.Location = new System.Drawing.Point(307, 674);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 29);
            this.btn_Submit.TabIndex = 2;
            this.btn_Submit.Text = "Submit!";
            this.btn_Submit.UseVisualStyleBackColor = true;
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Back.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Back.Location = new System.Drawing.Point(388, 674);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 29);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.Text = "Prapa!";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Title.Location = new System.Drawing.Point(46, 16);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(52, 19);
            this.lbl_Title.TabIndex = 4;
            this.lbl_Title.Text = "Titulli:";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Description.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Description.Location = new System.Drawing.Point(12, 35);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(86, 19);
            this.lbl_Description.TabIndex = 5;
            this.lbl_Description.Text = "Pershkrimi:";
            // 
            // lbl_StartDateTime
            // 
            this.lbl_StartDateTime.AutoSize = true;
            this.lbl_StartDateTime.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_StartDateTime.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_StartDateTime.Location = new System.Drawing.Point(45, 164);
            this.lbl_StartDateTime.Name = "lbl_StartDateTime";
            this.lbl_StartDateTime.Size = new System.Drawing.Size(53, 19);
            this.lbl_StartDateTime.TabIndex = 6;
            this.lbl_StartDateTime.Text = "Fillimi:";
            // 
            // lbl_EndDateTime
            // 
            this.lbl_EndDateTime.AutoSize = true;
            this.lbl_EndDateTime.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_EndDateTime.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_EndDateTime.Location = new System.Drawing.Point(27, 193);
            this.lbl_EndDateTime.Name = "lbl_EndDateTime";
            this.lbl_EndDateTime.Size = new System.Drawing.Size(71, 19);
            this.lbl_EndDateTime.TabIndex = 7;
            this.lbl_EndDateTime.Text = "Mbarimi:";
            // 
            // pcb_Main
            // 
            this.pcb_Main.Location = new System.Drawing.Point(31, 240);
            this.pcb_Main.Name = "pcb_Main";
            this.pcb_Main.Size = new System.Drawing.Size(432, 279);
            this.pcb_Main.TabIndex = 8;
            this.pcb_Main.TabStop = false;
            // 
            // pcb_small1
            // 
            this.pcb_small1.Location = new System.Drawing.Point(31, 525);
            this.pcb_small1.Name = "pcb_small1";
            this.pcb_small1.Size = new System.Drawing.Size(67, 55);
            this.pcb_small1.TabIndex = 9;
            this.pcb_small1.TabStop = false;
            // 
            // pcb_small2
            // 
            this.pcb_small2.Location = new System.Drawing.Point(104, 525);
            this.pcb_small2.Name = "pcb_small2";
            this.pcb_small2.Size = new System.Drawing.Size(67, 55);
            this.pcb_small2.TabIndex = 10;
            this.pcb_small2.TabStop = false;
            // 
            // pcb_small3
            // 
            this.pcb_small3.Location = new System.Drawing.Point(177, 525);
            this.pcb_small3.Name = "pcb_small3";
            this.pcb_small3.Size = new System.Drawing.Size(67, 55);
            this.pcb_small3.TabIndex = 11;
            this.pcb_small3.TabStop = false;
            // 
            // pcb_small4
            // 
            this.pcb_small4.Location = new System.Drawing.Point(250, 525);
            this.pcb_small4.Name = "pcb_small4";
            this.pcb_small4.Size = new System.Drawing.Size(67, 55);
            this.pcb_small4.TabIndex = 12;
            this.pcb_small4.TabStop = false;
            // 
            // pcb_small5
            // 
            this.pcb_small5.Location = new System.Drawing.Point(323, 525);
            this.pcb_small5.Name = "pcb_small5";
            this.pcb_small5.Size = new System.Drawing.Size(67, 55);
            this.pcb_small5.TabIndex = 13;
            this.pcb_small5.TabStop = false;
            // 
            // pcb_small6
            // 
            this.pcb_small6.Location = new System.Drawing.Point(396, 525);
            this.pcb_small6.Name = "pcb_small6";
            this.pcb_small6.Size = new System.Drawing.Size(67, 55);
            this.pcb_small6.TabIndex = 14;
            this.pcb_small6.TabStop = false;
            // 
            // lbl_Seller
            // 
            this.lbl_Seller.AutoSize = true;
            this.lbl_Seller.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Seller.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Seller.Location = new System.Drawing.Point(384, 164);
            this.lbl_Seller.Name = "lbl_Seller";
            this.lbl_Seller.Size = new System.Drawing.Size(58, 19);
            this.lbl_Seller.TabIndex = 15;
            this.lbl_Seller.Text = "Shitesi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(27, 597);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Shitesi:";
            // 
            // lbl_TitleValue
            // 
            this.lbl_TitleValue.AutoSize = true;
            this.lbl_TitleValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_TitleValue.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_TitleValue.Location = new System.Drawing.Point(104, 16);
            this.lbl_TitleValue.Name = "lbl_TitleValue";
            this.lbl_TitleValue.Size = new System.Drawing.Size(36, 19);
            this.lbl_TitleValue.TabIndex = 17;
            this.lbl_TitleValue.Text = "N/A";
            // 
            // lbl_StartDateTimeValue
            // 
            this.lbl_StartDateTimeValue.AutoSize = true;
            this.lbl_StartDateTimeValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_StartDateTimeValue.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_StartDateTimeValue.Location = new System.Drawing.Point(104, 164);
            this.lbl_StartDateTimeValue.Name = "lbl_StartDateTimeValue";
            this.lbl_StartDateTimeValue.Size = new System.Drawing.Size(36, 19);
            this.lbl_StartDateTimeValue.TabIndex = 18;
            this.lbl_StartDateTimeValue.Text = "N/A";
            // 
            // lbl_EndDatTimeValue
            // 
            this.lbl_EndDatTimeValue.AutoSize = true;
            this.lbl_EndDatTimeValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_EndDatTimeValue.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_EndDatTimeValue.Location = new System.Drawing.Point(104, 193);
            this.lbl_EndDatTimeValue.Name = "lbl_EndDatTimeValue";
            this.lbl_EndDatTimeValue.Size = new System.Drawing.Size(36, 19);
            this.lbl_EndDatTimeValue.TabIndex = 19;
            this.lbl_EndDatTimeValue.Text = "N/A";
            // 
            // lbl_SellersIDValue
            // 
            this.lbl_SellersIDValue.AutoSize = true;
            this.lbl_SellersIDValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_SellersIDValue.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_SellersIDValue.Location = new System.Drawing.Point(392, 183);
            this.lbl_SellersIDValue.Name = "lbl_SellersIDValue";
            this.lbl_SellersIDValue.Size = new System.Drawing.Size(36, 19);
            this.lbl_SellersIDValue.TabIndex = 20;
            this.lbl_SellersIDValue.Text = "N/A";
            // 
            // rtxt_Description
            // 
            this.rtxt_Description.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.rtxt_Description.Location = new System.Drawing.Point(104, 39);
            this.rtxt_Description.Name = "rtxt_Description";
            this.rtxt_Description.ReadOnly = true;
            this.rtxt_Description.Size = new System.Drawing.Size(338, 122);
            this.rtxt_Description.TabIndex = 21;
            this.rtxt_Description.Text = "";
            // 
            // AuctionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 715);
            this.Controls.Add(this.rtxt_Description);
            this.Controls.Add(this.lbl_SellersIDValue);
            this.Controls.Add(this.lbl_EndDatTimeValue);
            this.Controls.Add(this.lbl_StartDateTimeValue);
            this.Controls.Add(this.lbl_TitleValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Seller);
            this.Controls.Add(this.pcb_small6);
            this.Controls.Add(this.pcb_small5);
            this.Controls.Add(this.pcb_small4);
            this.Controls.Add(this.pcb_small3);
            this.Controls.Add(this.pcb_small2);
            this.Controls.Add(this.pcb_small1);
            this.Controls.Add(this.pcb_Main);
            this.Controls.Add(this.lbl_EndDateTime);
            this.Controls.Add(this.lbl_StartDateTime);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Submit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AuctionDialog";
            this.Text = "AuctionDialog";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_small1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_small2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_small3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_small4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_small5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_small6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_StartDateTime;
        private System.Windows.Forms.Label lbl_EndDateTime;
        private System.Windows.Forms.PictureBox pcb_Main;
        private System.Windows.Forms.PictureBox pcb_small1;
        private System.Windows.Forms.PictureBox pcb_small2;
        private System.Windows.Forms.PictureBox pcb_small3;
        private System.Windows.Forms.PictureBox pcb_small4;
        private System.Windows.Forms.PictureBox pcb_small5;
        private System.Windows.Forms.PictureBox pcb_small6;
        private System.Windows.Forms.Label lbl_Seller;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_TitleValue;
        private System.Windows.Forms.Label lbl_StartDateTimeValue;
        private System.Windows.Forms.Label lbl_EndDatTimeValue;
        private System.Windows.Forms.Label lbl_SellersIDValue;
        private System.Windows.Forms.RichTextBox rtxt_Description;
    }
}