namespace OOP_project
{
    partial class MainPanel
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
            this.tab_Tabs = new System.Windows.Forms.TabControl();
            this.tab_Listings = new System.Windows.Forms.TabPage();
            this.tab_AddListing = new System.Windows.Forms.TabPage();
            this.lbl_AuctionTimeETA = new System.Windows.Forms.Label();
            this.lbl_AuctionTime = new System.Windows.Forms.Label();
            this.lbl_EndDateTime = new System.Windows.Forms.Label();
            this.tab_auctionTimes = new System.Windows.Forms.TabControl();
            this.tab_Date = new System.Windows.Forms.TabPage();
            this.dtp_AuctionEndTime = new System.Windows.Forms.DateTimePicker();
            this.tab_Time = new System.Windows.Forms.TabPage();
            this.txt_Hours = new System.Windows.Forms.TextBox();
            this.txt_Days = new System.Windows.Forms.TextBox();
            this.lb_Hours = new System.Windows.Forms.Label();
            this.lbl_Day = new System.Windows.Forms.Label();
            this.btn_AddListingRequest = new System.Windows.Forms.Button();
            this.pcb_Delete = new System.Windows.Forms.PictureBox();
            this.txt_StartingPrice = new System.Windows.Forms.TextBox();
            this.rtxt_Description = new System.Windows.Forms.RichTextBox();
            this.txt_ProductTitle = new System.Windows.Forms.TextBox();
            this.pcb_Small6 = new System.Windows.Forms.PictureBox();
            this.pcb_Small5 = new System.Windows.Forms.PictureBox();
            this.pcb_Small4 = new System.Windows.Forms.PictureBox();
            this.pcb_Small3 = new System.Windows.Forms.PictureBox();
            this.pcb_Small2 = new System.Windows.Forms.PictureBox();
            this.pcb_Small1 = new System.Windows.Forms.PictureBox();
            this.pcb_Main = new System.Windows.Forms.PictureBox();
            this.btn_AddImage = new System.Windows.Forms.Button();
            this.lbl_Image = new System.Windows.Forms.Label();
            this.lbl_imagePath = new System.Windows.Forms.Label();
            this.lbl_StartingPrice = new System.Windows.Forms.Label();
            this.lbl_Descripton = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.tab_MyListings = new System.Windows.Forms.TabPage();
            this.tab_Llogaria = new System.Windows.Forms.TabPage();
            this.txt_AddCredit = new System.Windows.Forms.TextBox();
            this.btn_AddCredit = new System.Windows.Forms.Button();
            this.lbl_Balanci = new System.Windows.Forms.Label();
            this.lbl_numriLlogarise = new System.Windows.Forms.Label();
            this.lbl_Balance = new System.Windows.Forms.Label();
            this.lbl_AccountNo = new System.Windows.Forms.Label();
            this.lbl_Emaili = new System.Windows.Forms.Label();
            this.lbl_NoTelefonit = new System.Windows.Forms.Label();
            this.lbl_NoPersonal = new System.Windows.Forms.Label();
            this.lbl_Mbiemri = new System.Windows.Forms.Label();
            this.lbl_Emri = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_PhoneNo = new System.Windows.Forms.Label();
            this.lbl_PersonalNo = new System.Windows.Forms.Label();
            this.lbl_Surname = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.pcb_LogOut = new System.Windows.Forms.PictureBox();
            this.pcb_eAnkandiLogo = new System.Windows.Forms.PictureBox();
            this.dgv_ApprovedListings = new System.Windows.Forms.DataGridView();
            this.btn_RefreshDataGrid = new System.Windows.Forms.Button();
            this.tab_Tabs.SuspendLayout();
            this.tab_Listings.SuspendLayout();
            this.tab_AddListing.SuspendLayout();
            this.tab_auctionTimes.SuspendLayout();
            this.tab_Date.SuspendLayout();
            this.tab_Time.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Small6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Small5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Small4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Small3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Small2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Small1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Main)).BeginInit();
            this.tab_Llogaria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_LogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_eAnkandiLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ApprovedListings)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_Tabs
            // 
            this.tab_Tabs.Controls.Add(this.tab_Listings);
            this.tab_Tabs.Controls.Add(this.tab_AddListing);
            this.tab_Tabs.Controls.Add(this.tab_MyListings);
            this.tab_Tabs.Controls.Add(this.tab_Llogaria);
            this.tab_Tabs.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.tab_Tabs.Location = new System.Drawing.Point(12, 73);
            this.tab_Tabs.Name = "tab_Tabs";
            this.tab_Tabs.SelectedIndex = 0;
            this.tab_Tabs.Size = new System.Drawing.Size(1347, 526);
            this.tab_Tabs.TabIndex = 0;
            // 
            // tab_Listings
            // 
            this.tab_Listings.BackColor = System.Drawing.SystemColors.Control;
            this.tab_Listings.Controls.Add(this.btn_RefreshDataGrid);
            this.tab_Listings.Controls.Add(this.dgv_ApprovedListings);
            this.tab_Listings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.tab_Listings.ForeColor = System.Drawing.SystemColors.Control;
            this.tab_Listings.Location = new System.Drawing.Point(4, 28);
            this.tab_Listings.Name = "tab_Listings";
            this.tab_Listings.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tab_Listings.Size = new System.Drawing.Size(1339, 494);
            this.tab_Listings.TabIndex = 2;
            this.tab_Listings.Text = "Shpalljet";
            // 
            // tab_AddListing
            // 
            this.tab_AddListing.BackColor = System.Drawing.SystemColors.Control;
            this.tab_AddListing.Controls.Add(this.lbl_AuctionTimeETA);
            this.tab_AddListing.Controls.Add(this.lbl_AuctionTime);
            this.tab_AddListing.Controls.Add(this.lbl_EndDateTime);
            this.tab_AddListing.Controls.Add(this.tab_auctionTimes);
            this.tab_AddListing.Controls.Add(this.btn_AddListingRequest);
            this.tab_AddListing.Controls.Add(this.pcb_Delete);
            this.tab_AddListing.Controls.Add(this.txt_StartingPrice);
            this.tab_AddListing.Controls.Add(this.rtxt_Description);
            this.tab_AddListing.Controls.Add(this.txt_ProductTitle);
            this.tab_AddListing.Controls.Add(this.pcb_Small6);
            this.tab_AddListing.Controls.Add(this.pcb_Small5);
            this.tab_AddListing.Controls.Add(this.pcb_Small4);
            this.tab_AddListing.Controls.Add(this.pcb_Small3);
            this.tab_AddListing.Controls.Add(this.pcb_Small2);
            this.tab_AddListing.Controls.Add(this.pcb_Small1);
            this.tab_AddListing.Controls.Add(this.pcb_Main);
            this.tab_AddListing.Controls.Add(this.btn_AddImage);
            this.tab_AddListing.Controls.Add(this.lbl_Image);
            this.tab_AddListing.Controls.Add(this.lbl_imagePath);
            this.tab_AddListing.Controls.Add(this.lbl_StartingPrice);
            this.tab_AddListing.Controls.Add(this.lbl_Descripton);
            this.tab_AddListing.Controls.Add(this.lbl_Title);
            this.tab_AddListing.Location = new System.Drawing.Point(4, 28);
            this.tab_AddListing.Name = "tab_AddListing";
            this.tab_AddListing.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tab_AddListing.Size = new System.Drawing.Size(1339, 494);
            this.tab_AddListing.TabIndex = 3;
            this.tab_AddListing.Text = "Posto shpallje";
            // 
            // lbl_AuctionTimeETA
            // 
            this.lbl_AuctionTimeETA.Location = new System.Drawing.Point(406, 226);
            this.lbl_AuctionTimeETA.Name = "lbl_AuctionTimeETA";
            this.lbl_AuctionTimeETA.Size = new System.Drawing.Size(217, 50);
            this.lbl_AuctionTimeETA.TabIndex = 23;
            this.lbl_AuctionTimeETA.Text = "N/A";
            this.lbl_AuctionTimeETA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_AuctionTime
            // 
            this.lbl_AuctionTime.Location = new System.Drawing.Point(308, 226);
            this.lbl_AuctionTime.Name = "lbl_AuctionTime";
            this.lbl_AuctionTime.Size = new System.Drawing.Size(92, 57);
            this.lbl_AuctionTime.TabIndex = 22;
            this.lbl_AuctionTime.Text = "Perfundimi i ankandit:";
            this.lbl_AuctionTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_EndDateTime
            // 
            this.lbl_EndDateTime.Location = new System.Drawing.Point(6, 242);
            this.lbl_EndDateTime.Name = "lbl_EndDateTime";
            this.lbl_EndDateTime.Size = new System.Drawing.Size(129, 45);
            this.lbl_EndDateTime.TabIndex = 3;
            this.lbl_EndDateTime.Text = "Koha e mbylljes se ankandit";
            this.lbl_EndDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tab_auctionTimes
            // 
            this.tab_auctionTimes.Controls.Add(this.tab_Date);
            this.tab_auctionTimes.Controls.Add(this.tab_Time);
            this.tab_auctionTimes.Location = new System.Drawing.Point(141, 198);
            this.tab_auctionTimes.Name = "tab_auctionTimes";
            this.tab_auctionTimes.SelectedIndex = 0;
            this.tab_auctionTimes.Size = new System.Drawing.Size(165, 89);
            this.tab_auctionTimes.TabIndex = 21;
            // 
            // tab_Date
            // 
            this.tab_Date.BackColor = System.Drawing.SystemColors.Control;
            this.tab_Date.Controls.Add(this.dtp_AuctionEndTime);
            this.tab_Date.ForeColor = System.Drawing.Color.DarkGray;
            this.tab_Date.Location = new System.Drawing.Point(4, 28);
            this.tab_Date.Name = "tab_Date";
            this.tab_Date.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tab_Date.Size = new System.Drawing.Size(157, 57);
            this.tab_Date.TabIndex = 0;
            this.tab_Date.Text = "Date";
            // 
            // dtp_AuctionEndTime
            // 
            this.dtp_AuctionEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_AuctionEndTime.Location = new System.Drawing.Point(3, 23);
            this.dtp_AuctionEndTime.Name = "dtp_AuctionEndTime";
            this.dtp_AuctionEndTime.Size = new System.Drawing.Size(153, 27);
            this.dtp_AuctionEndTime.TabIndex = 18;
            this.dtp_AuctionEndTime.ValueChanged += new System.EventHandler(this.dtp_AuctionEndTime_ValueChanged);
            // 
            // tab_Time
            // 
            this.tab_Time.BackColor = System.Drawing.SystemColors.Control;
            this.tab_Time.Controls.Add(this.txt_Hours);
            this.tab_Time.Controls.Add(this.txt_Days);
            this.tab_Time.Controls.Add(this.lb_Hours);
            this.tab_Time.Controls.Add(this.lbl_Day);
            this.tab_Time.Location = new System.Drawing.Point(4, 28);
            this.tab_Time.Name = "tab_Time";
            this.tab_Time.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tab_Time.Size = new System.Drawing.Size(157, 57);
            this.tab_Time.TabIndex = 1;
            this.tab_Time.Text = "Kohe";
            // 
            // txt_Hours
            // 
            this.txt_Hours.Location = new System.Drawing.Point(66, 25);
            this.txt_Hours.Name = "txt_Hours";
            this.txt_Hours.Size = new System.Drawing.Size(50, 27);
            this.txt_Hours.TabIndex = 26;
            this.txt_Hours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeTXTnumberenter);
            this.txt_Hours.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterTimeETA);
            // 
            // txt_Days
            // 
            this.txt_Days.Location = new System.Drawing.Point(10, 26);
            this.txt_Days.Name = "txt_Days";
            this.txt_Days.Size = new System.Drawing.Size(50, 27);
            this.txt_Days.TabIndex = 25;
            this.txt_Days.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeTXTnumberenter);
            this.txt_Days.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterTimeETA);
            // 
            // lb_Hours
            // 
            this.lb_Hours.AutoSize = true;
            this.lb_Hours.Location = new System.Drawing.Point(69, 3);
            this.lb_Hours.Name = "lb_Hours";
            this.lb_Hours.Size = new System.Drawing.Size(34, 19);
            this.lb_Hours.TabIndex = 24;
            this.lb_Hours.Text = "Ore";
            // 
            // lbl_Day
            // 
            this.lbl_Day.AutoSize = true;
            this.lbl_Day.Location = new System.Drawing.Point(6, 3);
            this.lbl_Day.Name = "lbl_Day";
            this.lbl_Day.Size = new System.Drawing.Size(37, 19);
            this.lbl_Day.TabIndex = 23;
            this.lbl_Day.Text = "Dite";
            // 
            // btn_AddListingRequest
            // 
            this.btn_AddListingRequest.Location = new System.Drawing.Point(141, 352);
            this.btn_AddListingRequest.Name = "btn_AddListingRequest";
            this.btn_AddListingRequest.Size = new System.Drawing.Size(247, 29);
            this.btn_AddListingRequest.TabIndex = 20;
            this.btn_AddListingRequest.Text = "Posto produktin!";
            this.btn_AddListingRequest.UseVisualStyleBackColor = true;
            this.btn_AddListingRequest.Click += new System.EventHandler(this.btn_AddListingRequest_Click);
            // 
            // pcb_Delete
            // 
            this.pcb_Delete.Image = global::OOP_project.Properties.Resources.bin;
            this.pcb_Delete.Location = new System.Drawing.Point(633, 59);
            this.pcb_Delete.Name = "pcb_Delete";
            this.pcb_Delete.Size = new System.Drawing.Size(50, 33);
            this.pcb_Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Delete.TabIndex = 19;
            this.pcb_Delete.TabStop = false;
            this.pcb_Delete.Click += new System.EventHandler(this.pcb_Delete_Click);
            // 
            // txt_StartingPrice
            // 
            this.txt_StartingPrice.Location = new System.Drawing.Point(141, 165);
            this.txt_StartingPrice.Name = "txt_StartingPrice";
            this.txt_StartingPrice.Size = new System.Drawing.Size(107, 27);
            this.txt_StartingPrice.TabIndex = 17;
            // 
            // rtxt_Description
            // 
            this.rtxt_Description.Location = new System.Drawing.Point(141, 40);
            this.rtxt_Description.Name = "rtxt_Description";
            this.rtxt_Description.Size = new System.Drawing.Size(482, 119);
            this.rtxt_Description.TabIndex = 16;
            this.rtxt_Description.Text = "";
            // 
            // txt_ProductTitle
            // 
            this.txt_ProductTitle.Location = new System.Drawing.Point(141, 6);
            this.txt_ProductTitle.Name = "txt_ProductTitle";
            this.txt_ProductTitle.Size = new System.Drawing.Size(482, 27);
            this.txt_ProductTitle.TabIndex = 15;
            // 
            // pcb_Small6
            // 
            this.pcb_Small6.Location = new System.Drawing.Point(1230, 418);
            this.pcb_Small6.Name = "pcb_Small6";
            this.pcb_Small6.Size = new System.Drawing.Size(102, 75);
            this.pcb_Small6.TabIndex = 13;
            this.pcb_Small6.TabStop = false;
            this.pcb_Small6.Click += new System.EventHandler(this.pcb_Small6_Click);
            // 
            // pcb_Small5
            // 
            this.pcb_Small5.Location = new System.Drawing.Point(1122, 418);
            this.pcb_Small5.Name = "pcb_Small5";
            this.pcb_Small5.Size = new System.Drawing.Size(102, 75);
            this.pcb_Small5.TabIndex = 12;
            this.pcb_Small5.TabStop = false;
            this.pcb_Small5.Click += new System.EventHandler(this.pcb_Small5_Click);
            // 
            // pcb_Small4
            // 
            this.pcb_Small4.Location = new System.Drawing.Point(1014, 418);
            this.pcb_Small4.Name = "pcb_Small4";
            this.pcb_Small4.Size = new System.Drawing.Size(102, 75);
            this.pcb_Small4.TabIndex = 11;
            this.pcb_Small4.TabStop = false;
            this.pcb_Small4.Click += new System.EventHandler(this.pcb_Small4_Click);
            // 
            // pcb_Small3
            // 
            this.pcb_Small3.Location = new System.Drawing.Point(906, 418);
            this.pcb_Small3.Name = "pcb_Small3";
            this.pcb_Small3.Size = new System.Drawing.Size(102, 75);
            this.pcb_Small3.TabIndex = 10;
            this.pcb_Small3.TabStop = false;
            this.pcb_Small3.Click += new System.EventHandler(this.pcb_Small3_Click);
            // 
            // pcb_Small2
            // 
            this.pcb_Small2.Location = new System.Drawing.Point(798, 418);
            this.pcb_Small2.Name = "pcb_Small2";
            this.pcb_Small2.Size = new System.Drawing.Size(102, 75);
            this.pcb_Small2.TabIndex = 9;
            this.pcb_Small2.TabStop = false;
            this.pcb_Small2.Click += new System.EventHandler(this.pcb_Small2_Click);
            // 
            // pcb_Small1
            // 
            this.pcb_Small1.Location = new System.Drawing.Point(690, 418);
            this.pcb_Small1.Name = "pcb_Small1";
            this.pcb_Small1.Size = new System.Drawing.Size(102, 75);
            this.pcb_Small1.TabIndex = 8;
            this.pcb_Small1.TabStop = false;
            this.pcb_Small1.Click += new System.EventHandler(this.pcb_Small1_Click);
            // 
            // pcb_Main
            // 
            this.pcb_Main.Location = new System.Drawing.Point(690, 26);
            this.pcb_Main.Name = "pcb_Main";
            this.pcb_Main.Size = new System.Drawing.Size(642, 386);
            this.pcb_Main.TabIndex = 7;
            this.pcb_Main.TabStop = false;
            // 
            // btn_AddImage
            // 
            this.btn_AddImage.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btn_AddImage.Location = new System.Drawing.Point(633, 25);
            this.btn_AddImage.Name = "btn_AddImage";
            this.btn_AddImage.Size = new System.Drawing.Size(50, 28);
            this.btn_AddImage.TabIndex = 6;
            this.btn_AddImage.Text = "+";
            this.btn_AddImage.UseVisualStyleBackColor = true;
            this.btn_AddImage.Click += new System.EventHandler(this.btn_AddImage_Click);
            // 
            // lbl_Image
            // 
            this.lbl_Image.AutoSize = true;
            this.lbl_Image.Location = new System.Drawing.Point(629, 3);
            this.lbl_Image.Name = "lbl_Image";
            this.lbl_Image.Size = new System.Drawing.Size(54, 19);
            this.lbl_Image.TabIndex = 5;
            this.lbl_Image.Text = "Image:";
            // 
            // lbl_imagePath
            // 
            this.lbl_imagePath.AutoSize = true;
            this.lbl_imagePath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_imagePath.Location = new System.Drawing.Point(689, 3);
            this.lbl_imagePath.Name = "lbl_imagePath";
            this.lbl_imagePath.Size = new System.Drawing.Size(36, 19);
            this.lbl_imagePath.TabIndex = 4;
            this.lbl_imagePath.Text = "N/A";
            // 
            // lbl_StartingPrice
            // 
            this.lbl_StartingPrice.AutoSize = true;
            this.lbl_StartingPrice.Location = new System.Drawing.Point(25, 168);
            this.lbl_StartingPrice.Name = "lbl_StartingPrice";
            this.lbl_StartingPrice.Size = new System.Drawing.Size(110, 19);
            this.lbl_StartingPrice.TabIndex = 2;
            this.lbl_StartingPrice.Text = "Cmimi fillestar:";
            // 
            // lbl_Descripton
            // 
            this.lbl_Descripton.AutoSize = true;
            this.lbl_Descripton.Location = new System.Drawing.Point(49, 43);
            this.lbl_Descripton.Name = "lbl_Descripton";
            this.lbl_Descripton.Size = new System.Drawing.Size(86, 19);
            this.lbl_Descripton.TabIndex = 1;
            this.lbl_Descripton.Text = "Pershkrimi:";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(83, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(52, 19);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Titulli:";
            // 
            // tab_MyListings
            // 
            this.tab_MyListings.BackColor = System.Drawing.SystemColors.Control;
            this.tab_MyListings.Location = new System.Drawing.Point(4, 28);
            this.tab_MyListings.Name = "tab_MyListings";
            this.tab_MyListings.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tab_MyListings.Size = new System.Drawing.Size(1339, 494);
            this.tab_MyListings.TabIndex = 4;
            this.tab_MyListings.Text = "Shpalljet e mia";
            // 
            // tab_Llogaria
            // 
            this.tab_Llogaria.BackColor = System.Drawing.SystemColors.Control;
            this.tab_Llogaria.Controls.Add(this.txt_AddCredit);
            this.tab_Llogaria.Controls.Add(this.btn_AddCredit);
            this.tab_Llogaria.Controls.Add(this.lbl_Balanci);
            this.tab_Llogaria.Controls.Add(this.lbl_numriLlogarise);
            this.tab_Llogaria.Controls.Add(this.lbl_Balance);
            this.tab_Llogaria.Controls.Add(this.lbl_AccountNo);
            this.tab_Llogaria.Controls.Add(this.lbl_Emaili);
            this.tab_Llogaria.Controls.Add(this.lbl_NoTelefonit);
            this.tab_Llogaria.Controls.Add(this.lbl_NoPersonal);
            this.tab_Llogaria.Controls.Add(this.lbl_Mbiemri);
            this.tab_Llogaria.Controls.Add(this.lbl_Emri);
            this.tab_Llogaria.Controls.Add(this.lbl_Email);
            this.tab_Llogaria.Controls.Add(this.lbl_PhoneNo);
            this.tab_Llogaria.Controls.Add(this.lbl_PersonalNo);
            this.tab_Llogaria.Controls.Add(this.lbl_Surname);
            this.tab_Llogaria.Controls.Add(this.lbl_Name);
            this.tab_Llogaria.Location = new System.Drawing.Point(4, 28);
            this.tab_Llogaria.Name = "tab_Llogaria";
            this.tab_Llogaria.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tab_Llogaria.Size = new System.Drawing.Size(1339, 494);
            this.tab_Llogaria.TabIndex = 5;
            this.tab_Llogaria.Text = "Llogaria";
            // 
            // txt_AddCredit
            // 
            this.txt_AddCredit.Location = new System.Drawing.Point(372, 120);
            this.txt_AddCredit.Name = "txt_AddCredit";
            this.txt_AddCredit.Size = new System.Drawing.Size(95, 27);
            this.txt_AddCredit.TabIndex = 18;
            // 
            // btn_AddCredit
            // 
            this.btn_AddCredit.Location = new System.Drawing.Point(271, 118);
            this.btn_AddCredit.Name = "btn_AddCredit";
            this.btn_AddCredit.Size = new System.Drawing.Size(95, 29);
            this.btn_AddCredit.TabIndex = 17;
            this.btn_AddCredit.Text = "Shto para";
            this.btn_AddCredit.UseVisualStyleBackColor = true;
            this.btn_AddCredit.Click += new System.EventHandler(this.btn_AddCredit_Click);
            // 
            // lbl_Balanci
            // 
            this.lbl_Balanci.AutoSize = true;
            this.lbl_Balanci.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Balanci.ForeColor = System.Drawing.Color.Black;
            this.lbl_Balanci.Location = new System.Drawing.Point(112, 128);
            this.lbl_Balanci.Name = "lbl_Balanci";
            this.lbl_Balanci.Size = new System.Drawing.Size(36, 19);
            this.lbl_Balanci.TabIndex = 16;
            this.lbl_Balanci.Text = "N/A";
            // 
            // lbl_numriLlogarise
            // 
            this.lbl_numriLlogarise.AutoSize = true;
            this.lbl_numriLlogarise.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_numriLlogarise.ForeColor = System.Drawing.Color.Black;
            this.lbl_numriLlogarise.Location = new System.Drawing.Point(112, 109);
            this.lbl_numriLlogarise.Name = "lbl_numriLlogarise";
            this.lbl_numriLlogarise.Size = new System.Drawing.Size(36, 19);
            this.lbl_numriLlogarise.TabIndex = 15;
            this.lbl_numriLlogarise.Text = "N/A";
            // 
            // lbl_Balance
            // 
            this.lbl_Balance.AutoSize = true;
            this.lbl_Balance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Balance.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_Balance.Location = new System.Drawing.Point(44, 128);
            this.lbl_Balance.Name = "lbl_Balance";
            this.lbl_Balance.Size = new System.Drawing.Size(62, 19);
            this.lbl_Balance.TabIndex = 14;
            this.lbl_Balance.Text = "Balanci:";
            // 
            // lbl_AccountNo
            // 
            this.lbl_AccountNo.AutoSize = true;
            this.lbl_AccountNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_AccountNo.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_AccountNo.Location = new System.Drawing.Point(12, 109);
            this.lbl_AccountNo.Name = "lbl_AccountNo";
            this.lbl_AccountNo.Size = new System.Drawing.Size(94, 19);
            this.lbl_AccountNo.TabIndex = 13;
            this.lbl_AccountNo.Text = "No llogarise:";
            // 
            // lbl_Emaili
            // 
            this.lbl_Emaili.AutoSize = true;
            this.lbl_Emaili.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Emaili.ForeColor = System.Drawing.Color.Black;
            this.lbl_Emaili.Location = new System.Drawing.Point(112, 90);
            this.lbl_Emaili.Name = "lbl_Emaili";
            this.lbl_Emaili.Size = new System.Drawing.Size(36, 19);
            this.lbl_Emaili.TabIndex = 12;
            this.lbl_Emaili.Text = "N/A";
            // 
            // lbl_NoTelefonit
            // 
            this.lbl_NoTelefonit.AutoSize = true;
            this.lbl_NoTelefonit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_NoTelefonit.ForeColor = System.Drawing.Color.Black;
            this.lbl_NoTelefonit.Location = new System.Drawing.Point(112, 71);
            this.lbl_NoTelefonit.Name = "lbl_NoTelefonit";
            this.lbl_NoTelefonit.Size = new System.Drawing.Size(36, 19);
            this.lbl_NoTelefonit.TabIndex = 11;
            this.lbl_NoTelefonit.Text = "N/A";
            // 
            // lbl_NoPersonal
            // 
            this.lbl_NoPersonal.AutoSize = true;
            this.lbl_NoPersonal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_NoPersonal.ForeColor = System.Drawing.Color.Black;
            this.lbl_NoPersonal.Location = new System.Drawing.Point(112, 52);
            this.lbl_NoPersonal.Name = "lbl_NoPersonal";
            this.lbl_NoPersonal.Size = new System.Drawing.Size(36, 19);
            this.lbl_NoPersonal.TabIndex = 10;
            this.lbl_NoPersonal.Text = "N/A";
            // 
            // lbl_Mbiemri
            // 
            this.lbl_Mbiemri.AutoSize = true;
            this.lbl_Mbiemri.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Mbiemri.ForeColor = System.Drawing.Color.Black;
            this.lbl_Mbiemri.Location = new System.Drawing.Point(112, 33);
            this.lbl_Mbiemri.Name = "lbl_Mbiemri";
            this.lbl_Mbiemri.Size = new System.Drawing.Size(36, 19);
            this.lbl_Mbiemri.TabIndex = 9;
            this.lbl_Mbiemri.Text = "N/A";
            // 
            // lbl_Emri
            // 
            this.lbl_Emri.AutoSize = true;
            this.lbl_Emri.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Emri.ForeColor = System.Drawing.Color.Black;
            this.lbl_Emri.Location = new System.Drawing.Point(112, 14);
            this.lbl_Emri.Name = "lbl_Emri";
            this.lbl_Emri.Size = new System.Drawing.Size(36, 19);
            this.lbl_Emri.TabIndex = 4;
            this.lbl_Emri.Text = "N/A";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Email.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_Email.Location = new System.Drawing.Point(47, 90);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(59, 19);
            this.lbl_Email.TabIndex = 8;
            this.lbl_Email.Text = "E-mail :";
            // 
            // lbl_PhoneNo
            // 
            this.lbl_PhoneNo.AutoSize = true;
            this.lbl_PhoneNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_PhoneNo.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_PhoneNo.Location = new System.Drawing.Point(6, 71);
            this.lbl_PhoneNo.Name = "lbl_PhoneNo";
            this.lbl_PhoneNo.Size = new System.Drawing.Size(100, 19);
            this.lbl_PhoneNo.TabIndex = 7;
            this.lbl_PhoneNo.Text = "No telefonit :";
            // 
            // lbl_PersonalNo
            // 
            this.lbl_PersonalNo.AutoSize = true;
            this.lbl_PersonalNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_PersonalNo.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_PersonalNo.Location = new System.Drawing.Point(6, 52);
            this.lbl_PersonalNo.Name = "lbl_PersonalNo";
            this.lbl_PersonalNo.Size = new System.Drawing.Size(100, 19);
            this.lbl_PersonalNo.TabIndex = 6;
            this.lbl_PersonalNo.Text = "No personal :";
            // 
            // lbl_Surname
            // 
            this.lbl_Surname.AutoSize = true;
            this.lbl_Surname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Surname.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_Surname.Location = new System.Drawing.Point(31, 33);
            this.lbl_Surname.Name = "lbl_Surname";
            this.lbl_Surname.Size = new System.Drawing.Size(75, 19);
            this.lbl_Surname.TabIndex = 5;
            this.lbl_Surname.Text = "Mbiemri :";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Name.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_Name.Location = new System.Drawing.Point(58, 14);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(48, 19);
            this.lbl_Name.TabIndex = 4;
            this.lbl_Name.Text = "Emri :";
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Welcome.ForeColor = System.Drawing.Color.Black;
            this.lbl_Welcome.Location = new System.Drawing.Point(12, 24);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(139, 19);
            this.lbl_Welcome.TabIndex = 1;
            this.lbl_Welcome.Text = "N/A , mirësevini në";
            // 
            // pcb_LogOut
            // 
            this.pcb_LogOut.Image = global::OOP_project.Properties.Resources.logout;
            this.pcb_LogOut.Location = new System.Drawing.Point(1329, 12);
            this.pcb_LogOut.Name = "pcb_LogOut";
            this.pcb_LogOut.Size = new System.Drawing.Size(30, 31);
            this.pcb_LogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_LogOut.TabIndex = 3;
            this.pcb_LogOut.TabStop = false;
            this.pcb_LogOut.Click += new System.EventHandler(this.pcb_LogOut_Click);
            // 
            // pcb_eAnkandiLogo
            // 
            this.pcb_eAnkandiLogo.Image = global::OOP_project.Properties.Resources.e_ankandi_logo_;
            this.pcb_eAnkandiLogo.Location = new System.Drawing.Point(185, 1);
            this.pcb_eAnkandiLogo.Name = "pcb_eAnkandiLogo";
            this.pcb_eAnkandiLogo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pcb_eAnkandiLogo.Size = new System.Drawing.Size(149, 66);
            this.pcb_eAnkandiLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_eAnkandiLogo.TabIndex = 2;
            this.pcb_eAnkandiLogo.TabStop = false;
            // 
            // dgv_ApprovedListings
            // 
            this.dgv_ApprovedListings.AllowUserToAddRows = false;
            this.dgv_ApprovedListings.AllowUserToDeleteRows = false;
            this.dgv_ApprovedListings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ApprovedListings.Location = new System.Drawing.Point(6, 76);
            this.dgv_ApprovedListings.Name = "dgv_ApprovedListings";
            this.dgv_ApprovedListings.ReadOnly = true;
            this.dgv_ApprovedListings.Size = new System.Drawing.Size(990, 412);
            this.dgv_ApprovedListings.TabIndex = 0;
            // 
            // btn_RefreshDataGrid
            // 
            this.btn_RefreshDataGrid.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btn_RefreshDataGrid.Location = new System.Drawing.Point(420, 22);
            this.btn_RefreshDataGrid.Name = "btn_RefreshDataGrid";
            this.btn_RefreshDataGrid.Size = new System.Drawing.Size(75, 29);
            this.btn_RefreshDataGrid.TabIndex = 1;
            this.btn_RefreshDataGrid.Text = "Fresko!";
            this.btn_RefreshDataGrid.UseVisualStyleBackColor = true;
            this.btn_RefreshDataGrid.Click += new System.EventHandler(this.btn_RefreshDataGrid_Click);
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 604);
            this.Controls.Add(this.pcb_LogOut);
            this.Controls.Add(this.pcb_eAnkandiLogo);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.tab_Tabs);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPanel";
            this.Load += new System.EventHandler(this.MainPanel_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            this.tab_Tabs.ResumeLayout(false);
            this.tab_Listings.ResumeLayout(false);
            this.tab_AddListing.ResumeLayout(false);
            this.tab_AddListing.PerformLayout();
            this.tab_auctionTimes.ResumeLayout(false);
            this.tab_Date.ResumeLayout(false);
            this.tab_Time.ResumeLayout(false);
            this.tab_Time.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Small6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Small5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Small4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Small3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Small2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Small1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Main)).EndInit();
            this.tab_Llogaria.ResumeLayout(false);
            this.tab_Llogaria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_LogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_eAnkandiLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ApprovedListings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Tabs;
        private System.Windows.Forms.TabPage tab_Listings;
        private System.Windows.Forms.TabPage tab_AddListing;
        private System.Windows.Forms.TabPage tab_MyListings;
        private System.Windows.Forms.TabPage tab_Llogaria;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.PictureBox pcb_eAnkandiLogo;
        private System.Windows.Forms.PictureBox pcb_LogOut;
        private System.Windows.Forms.Label lbl_PersonalNo;
        private System.Windows.Forms.Label lbl_Surname;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Emaili;
        private System.Windows.Forms.Label lbl_NoTelefonit;
        private System.Windows.Forms.Label lbl_NoPersonal;
        private System.Windows.Forms.Label lbl_Mbiemri;
        private System.Windows.Forms.Label lbl_Emri;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_PhoneNo;
        private System.Windows.Forms.Label lbl_AccountNo;
        private System.Windows.Forms.Label lbl_Balanci;
        private System.Windows.Forms.Label lbl_numriLlogarise;
        private System.Windows.Forms.Label lbl_Balance;
        private System.Windows.Forms.TextBox txt_AddCredit;
        private System.Windows.Forms.Button btn_AddCredit;
        private System.Windows.Forms.Label lbl_Descripton;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_EndDateTime;
        private System.Windows.Forms.Label lbl_StartingPrice;
        private System.Windows.Forms.PictureBox pcb_Small6;
        private System.Windows.Forms.PictureBox pcb_Small5;
        private System.Windows.Forms.PictureBox pcb_Small4;
        private System.Windows.Forms.PictureBox pcb_Small3;
        private System.Windows.Forms.PictureBox pcb_Small2;
        private System.Windows.Forms.PictureBox pcb_Small1;
        private System.Windows.Forms.PictureBox pcb_Main;
        private System.Windows.Forms.Button btn_AddImage;
        private System.Windows.Forms.Label lbl_Image;
        private System.Windows.Forms.Label lbl_imagePath;
        private System.Windows.Forms.DateTimePicker dtp_AuctionEndTime;
        private System.Windows.Forms.TextBox txt_StartingPrice;
        private System.Windows.Forms.RichTextBox rtxt_Description;
        private System.Windows.Forms.TextBox txt_ProductTitle;
        private System.Windows.Forms.PictureBox pcb_Delete;
        private System.Windows.Forms.TabControl tab_auctionTimes;
        private System.Windows.Forms.TabPage tab_Date;
        private System.Windows.Forms.TabPage tab_Time;
        private System.Windows.Forms.TextBox txt_Hours;
        private System.Windows.Forms.TextBox txt_Days;
        private System.Windows.Forms.Label lb_Hours;
        private System.Windows.Forms.Label lbl_Day;
        private System.Windows.Forms.Button btn_AddListingRequest;
        private System.Windows.Forms.Label lbl_AuctionTimeETA;
        private System.Windows.Forms.Label lbl_AuctionTime;
        private System.Windows.Forms.Button btn_RefreshDataGrid;
        private System.Windows.Forms.DataGridView dgv_ApprovedListings;
    }
}