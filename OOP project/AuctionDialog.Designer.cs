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
            this.components = new System.ComponentModel.Container();
            this.btn_Bid = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_StartDateTime = new System.Windows.Forms.Label();
            this.lbl_EndDateTime = new System.Windows.Forms.Label();
            this.lbl_Seller = new System.Windows.Forms.Label();
            this.lbl_AuctenETA = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_TitleValue = new System.Windows.Forms.Label();
            this.lbl_StartDateTimeValue = new System.Windows.Forms.Label();
            this.lbl_EndDatTimeValue = new System.Windows.Forms.Label();
            this.lbl_SellersIDValue = new System.Windows.Forms.Label();
            this.rtxt_Description = new System.Windows.Forms.RichTextBox();
            this.lbl_Days = new System.Windows.Forms.Label();
            this.lbl_Hours = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_AuctionCountDown = new System.Windows.Forms.Label();
            this.lbl_Seconds = new System.Windows.Forms.Label();
            this.txt_BiddingValue = new System.Windows.Forms.TextBox();
            this.lbl_BiddingValue = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.lbl_StartingPrice = new System.Windows.Forms.Label();
            this.lbl_ActualPrice = new System.Windows.Forms.Label();
            this.lbl_StartingPriceValue = new System.Windows.Forms.Label();
            this.lbl_ActualPriceValue = new System.Windows.Forms.Label();
            this.pcb_small6 = new System.Windows.Forms.PictureBox();
            this.pcb_small5 = new System.Windows.Forms.PictureBox();
            this.pcb_small4 = new System.Windows.Forms.PictureBox();
            this.pcb_small3 = new System.Windows.Forms.PictureBox();
            this.pcb_small2 = new System.Windows.Forms.PictureBox();
            this.pcb_small1 = new System.Windows.Forms.PictureBox();
            this.pcb_Main = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_small6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_small5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_small4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_small3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_small2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_small1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Bid
            // 
            this.btn_Bid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Bid.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Bid.Location = new System.Drawing.Point(321, 733);
            this.btn_Bid.Name = "btn_Bid";
            this.btn_Bid.Size = new System.Drawing.Size(75, 29);
            this.btn_Bid.TabIndex = 2;
            this.btn_Bid.Text = "Oferto!";
            this.btn_Bid.UseVisualStyleBackColor = true;
            this.btn_Bid.Click += new System.EventHandler(this.btn_Bid_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Back.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Back.Location = new System.Drawing.Point(402, 733);
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
            // lbl_AuctenETA
            // 
            this.lbl_AuctenETA.AutoSize = true;
            this.lbl_AuctenETA.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_AuctenETA.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_AuctenETA.Location = new System.Drawing.Point(11, 673);
            this.lbl_AuctenETA.Name = "lbl_AuctenETA";
            this.lbl_AuctenETA.Size = new System.Drawing.Size(252, 27);
            this.lbl_AuctenETA.TabIndex = 16;
            this.lbl_AuctenETA.Text = "Koha e mbetur e ankandit";
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
            this.lbl_SellersIDValue.Location = new System.Drawing.Point(384, 183);
            this.lbl_SellersIDValue.Name = "lbl_SellersIDValue";
            this.lbl_SellersIDValue.Size = new System.Drawing.Size(36, 19);
            this.lbl_SellersIDValue.TabIndex = 20;
            this.lbl_SellersIDValue.Text = "N/A";
            this.lbl_SellersIDValue.Click += new System.EventHandler(this.lbl_SellersIDValue_Click);
            // 
            // rtxt_Description
            // 
            this.rtxt_Description.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.rtxt_Description.ForeColor = System.Drawing.Color.DarkGray;
            this.rtxt_Description.Location = new System.Drawing.Point(104, 39);
            this.rtxt_Description.Name = "rtxt_Description";
            this.rtxt_Description.ReadOnly = true;
            this.rtxt_Description.Size = new System.Drawing.Size(338, 122);
            this.rtxt_Description.TabIndex = 21;
            this.rtxt_Description.Text = "";
            // 
            // lbl_Days
            // 
            this.lbl_Days.AutoSize = true;
            this.lbl_Days.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Days.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Days.Location = new System.Drawing.Point(46, 700);
            this.lbl_Days.Name = "lbl_Days";
            this.lbl_Days.Size = new System.Drawing.Size(37, 19);
            this.lbl_Days.TabIndex = 23;
            this.lbl_Days.Text = "Dite";
            // 
            // lbl_Hours
            // 
            this.lbl_Hours.AutoSize = true;
            this.lbl_Hours.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Hours.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Hours.Location = new System.Drawing.Point(89, 700);
            this.lbl_Hours.Name = "lbl_Hours";
            this.lbl_Hours.Size = new System.Drawing.Size(34, 19);
            this.lbl_Hours.TabIndex = 24;
            this.lbl_Hours.Text = "Ore";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(129, 700);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Min";
            // 
            // lbl_AuctionCountDown
            // 
            this.lbl_AuctionCountDown.AutoSize = true;
            this.lbl_AuctionCountDown.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold);
            this.lbl_AuctionCountDown.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_AuctionCountDown.Location = new System.Drawing.Point(42, 719);
            this.lbl_AuctionCountDown.Name = "lbl_AuctionCountDown";
            this.lbl_AuctionCountDown.Size = new System.Drawing.Size(181, 41);
            this.lbl_AuctionCountDown.TabIndex = 26;
            this.lbl_AuctionCountDown.Text = "00:00:00:00";
            // 
            // lbl_Seconds
            // 
            this.lbl_Seconds.AutoSize = true;
            this.lbl_Seconds.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Seconds.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Seconds.Location = new System.Drawing.Point(171, 700);
            this.lbl_Seconds.Name = "lbl_Seconds";
            this.lbl_Seconds.Size = new System.Drawing.Size(36, 19);
            this.lbl_Seconds.TabIndex = 27;
            this.lbl_Seconds.Text = "Min";
            // 
            // txt_BiddingValue
            // 
            this.txt_BiddingValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txt_BiddingValue.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_BiddingValue.Location = new System.Drawing.Point(321, 700);
            this.txt_BiddingValue.Name = "txt_BiddingValue";
            this.txt_BiddingValue.Size = new System.Drawing.Size(156, 27);
            this.txt_BiddingValue.TabIndex = 28;
            this.txt_BiddingValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeTXTnumberenter);
            // 
            // lbl_BiddingValue
            // 
            this.lbl_BiddingValue.AutoSize = true;
            this.lbl_BiddingValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_BiddingValue.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_BiddingValue.Location = new System.Drawing.Point(319, 678);
            this.lbl_BiddingValue.Name = "lbl_BiddingValue";
            this.lbl_BiddingValue.Size = new System.Drawing.Size(44, 19);
            this.lbl_BiddingValue.TabIndex = 29;
            this.lbl_BiddingValue.Text = "Vlera";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
           // this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // lbl_StartingPrice
            // 
            this.lbl_StartingPrice.AutoSize = true;
            this.lbl_StartingPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_StartingPrice.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_StartingPrice.Location = new System.Drawing.Point(27, 583);
            this.lbl_StartingPrice.Name = "lbl_StartingPrice";
            this.lbl_StartingPrice.Size = new System.Drawing.Size(106, 19);
            this.lbl_StartingPrice.TabIndex = 30;
            this.lbl_StartingPrice.Text = "Cmimi fillestar";
            // 
            // lbl_ActualPrice
            // 
            this.lbl_ActualPrice.AutoSize = true;
            this.lbl_ActualPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_ActualPrice.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_ActualPrice.Location = new System.Drawing.Point(357, 583);
            this.lbl_ActualPrice.Name = "lbl_ActualPrice";
            this.lbl_ActualPrice.Size = new System.Drawing.Size(98, 19);
            this.lbl_ActualPrice.TabIndex = 31;
            this.lbl_ActualPrice.Text = "Cmimi aktual";
            // 
            // lbl_StartingPriceValue
            // 
            this.lbl_StartingPriceValue.AutoSize = true;
            this.lbl_StartingPriceValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_StartingPriceValue.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_StartingPriceValue.Location = new System.Drawing.Point(27, 619);
            this.lbl_StartingPriceValue.Name = "lbl_StartingPriceValue";
            this.lbl_StartingPriceValue.Size = new System.Drawing.Size(36, 19);
            this.lbl_StartingPriceValue.TabIndex = 32;
            this.lbl_StartingPriceValue.Text = "N/A";
            this.lbl_StartingPriceValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ActualPriceValue
            // 
            this.lbl_ActualPriceValue.AutoSize = true;
            this.lbl_ActualPriceValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_ActualPriceValue.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_ActualPriceValue.Location = new System.Drawing.Point(427, 619);
            this.lbl_ActualPriceValue.Name = "lbl_ActualPriceValue";
            this.lbl_ActualPriceValue.Size = new System.Drawing.Size(36, 19);
            this.lbl_ActualPriceValue.TabIndex = 33;
            this.lbl_ActualPriceValue.Text = "N/A";
            this.lbl_ActualPriceValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pcb_small6
            // 
            this.pcb_small6.Location = new System.Drawing.Point(396, 525);
            this.pcb_small6.Name = "pcb_small6";
            this.pcb_small6.Size = new System.Drawing.Size(67, 55);
            this.pcb_small6.TabIndex = 14;
            this.pcb_small6.TabStop = false;
            this.pcb_small6.Click += new System.EventHandler(this.pcb_small6_Click);
            // 
            // pcb_small5
            // 
            this.pcb_small5.Location = new System.Drawing.Point(323, 525);
            this.pcb_small5.Name = "pcb_small5";
            this.pcb_small5.Size = new System.Drawing.Size(67, 55);
            this.pcb_small5.TabIndex = 13;
            this.pcb_small5.TabStop = false;
            this.pcb_small5.Click += new System.EventHandler(this.pcb_small5_Click);
            // 
            // pcb_small4
            // 
            this.pcb_small4.Location = new System.Drawing.Point(250, 525);
            this.pcb_small4.Name = "pcb_small4";
            this.pcb_small4.Size = new System.Drawing.Size(67, 55);
            this.pcb_small4.TabIndex = 12;
            this.pcb_small4.TabStop = false;
            this.pcb_small4.Click += new System.EventHandler(this.pcb_small4_Click);
            // 
            // pcb_small3
            // 
            this.pcb_small3.Location = new System.Drawing.Point(177, 525);
            this.pcb_small3.Name = "pcb_small3";
            this.pcb_small3.Size = new System.Drawing.Size(67, 55);
            this.pcb_small3.TabIndex = 11;
            this.pcb_small3.TabStop = false;
            this.pcb_small3.Click += new System.EventHandler(this.pcb_small3_Click);
            // 
            // pcb_small2
            // 
            this.pcb_small2.Location = new System.Drawing.Point(104, 525);
            this.pcb_small2.Name = "pcb_small2";
            this.pcb_small2.Size = new System.Drawing.Size(67, 55);
            this.pcb_small2.TabIndex = 10;
            this.pcb_small2.TabStop = false;
            this.pcb_small2.Click += new System.EventHandler(this.pcb_small2_Click);
            // 
            // pcb_small1
            // 
            this.pcb_small1.Location = new System.Drawing.Point(31, 525);
            this.pcb_small1.Name = "pcb_small1";
            this.pcb_small1.Size = new System.Drawing.Size(67, 55);
            this.pcb_small1.TabIndex = 9;
            this.pcb_small1.TabStop = false;
            this.pcb_small1.Click += new System.EventHandler(this.pcb_small1_Click);
            // 
            // pcb_Main
            // 
            this.pcb_Main.Location = new System.Drawing.Point(31, 240);
            this.pcb_Main.Name = "pcb_Main";
            this.pcb_Main.Size = new System.Drawing.Size(432, 279);
            this.pcb_Main.TabIndex = 8;
            this.pcb_Main.TabStop = false;
            // 
            // AuctionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 774);
            this.Controls.Add(this.lbl_ActualPriceValue);
            this.Controls.Add(this.lbl_StartingPriceValue);
            this.Controls.Add(this.lbl_ActualPrice);
            this.Controls.Add(this.lbl_StartingPrice);
            this.Controls.Add(this.lbl_BiddingValue);
            this.Controls.Add(this.txt_BiddingValue);
            this.Controls.Add(this.lbl_Seconds);
            this.Controls.Add(this.lbl_AuctionCountDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Hours);
            this.Controls.Add(this.lbl_Days);
            this.Controls.Add(this.rtxt_Description);
            this.Controls.Add(this.lbl_SellersIDValue);
            this.Controls.Add(this.lbl_EndDatTimeValue);
            this.Controls.Add(this.lbl_StartDateTimeValue);
            this.Controls.Add(this.lbl_TitleValue);
            this.Controls.Add(this.lbl_AuctenETA);
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
            this.Controls.Add(this.btn_Bid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AuctionDialog";
            this.Text = "AuctionDialog";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_small6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_small5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_small4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_small3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_small2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_small1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Bid;
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
        private System.Windows.Forms.Label lbl_AuctenETA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_TitleValue;
        private System.Windows.Forms.Label lbl_StartDateTimeValue;
        private System.Windows.Forms.Label lbl_EndDatTimeValue;
        private System.Windows.Forms.Label lbl_SellersIDValue;
        private System.Windows.Forms.RichTextBox rtxt_Description;
        private System.Windows.Forms.Label lbl_Days;
        private System.Windows.Forms.Label lbl_Hours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_AuctionCountDown;
        private System.Windows.Forms.Label lbl_Seconds;
        private System.Windows.Forms.TextBox txt_BiddingValue;
        private System.Windows.Forms.Label lbl_BiddingValue;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label lbl_StartingPrice;
        private System.Windows.Forms.Label lbl_ActualPrice;
        private System.Windows.Forms.Label lbl_StartingPriceValue;
        private System.Windows.Forms.Label lbl_ActualPriceValue;
    }
}