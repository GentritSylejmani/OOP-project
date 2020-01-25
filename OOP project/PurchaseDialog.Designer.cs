namespace OOP_project
{
    partial class PurchaseDialog
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
            this.lbl_Description = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_TitleValue = new System.Windows.Forms.Label();
            this.rtxt_Description = new System.Windows.Forms.RichTextBox();
            this.lbl_ProductID = new System.Windows.Forms.Label();
            this.lbl_ProductIDValue = new System.Windows.Forms.Label();
            this.btn_Purchase = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_WonPrice = new System.Windows.Forms.Label();
            this.lbl_WonPriceValue = new System.Windows.Forms.Label();
            this.lbl_ApplyCoupon = new System.Windows.Forms.Label();
            this.txt_Coupon = new System.Windows.Forms.TextBox();
            this.btn_EraseCoupon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Description.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Description.Location = new System.Drawing.Point(30, 58);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(86, 19);
            this.lbl_Description.TabIndex = 5;
            this.lbl_Description.Text = "Pershkrimi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(64, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Titulli:";
            // 
            // lbl_TitleValue
            // 
            this.lbl_TitleValue.AutoSize = true;
            this.lbl_TitleValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_TitleValue.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_TitleValue.Location = new System.Drawing.Point(122, 39);
            this.lbl_TitleValue.Name = "lbl_TitleValue";
            this.lbl_TitleValue.Size = new System.Drawing.Size(36, 19);
            this.lbl_TitleValue.TabIndex = 17;
            this.lbl_TitleValue.Text = "N/A";
            // 
            // rtxt_Description
            // 
            this.rtxt_Description.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.rtxt_Description.ForeColor = System.Drawing.Color.DarkGray;
            this.rtxt_Description.Location = new System.Drawing.Point(122, 62);
            this.rtxt_Description.Name = "rtxt_Description";
            this.rtxt_Description.ReadOnly = true;
            this.rtxt_Description.Size = new System.Drawing.Size(338, 122);
            this.rtxt_Description.TabIndex = 21;
            this.rtxt_Description.Text = "";
            // 
            // lbl_ProductID
            // 
            this.lbl_ProductID.AutoSize = true;
            this.lbl_ProductID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_ProductID.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_ProductID.Location = new System.Drawing.Point(12, 20);
            this.lbl_ProductID.Name = "lbl_ProductID";
            this.lbl_ProductID.Size = new System.Drawing.Size(104, 19);
            this.lbl_ProductID.TabIndex = 22;
            this.lbl_ProductID.Text = "ID e produktit";
            // 
            // lbl_ProductIDValue
            // 
            this.lbl_ProductIDValue.AutoSize = true;
            this.lbl_ProductIDValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_ProductIDValue.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_ProductIDValue.Location = new System.Drawing.Point(122, 20);
            this.lbl_ProductIDValue.Name = "lbl_ProductIDValue";
            this.lbl_ProductIDValue.Size = new System.Drawing.Size(36, 19);
            this.lbl_ProductIDValue.TabIndex = 23;
            this.lbl_ProductIDValue.Text = "N/A";
            // 
            // btn_Purchase
            // 
            this.btn_Purchase.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Purchase.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Purchase.Location = new System.Drawing.Point(137, 497);
            this.btn_Purchase.Name = "btn_Purchase";
            this.btn_Purchase.Size = new System.Drawing.Size(293, 29);
            this.btn_Purchase.TabIndex = 23;
            this.btn_Purchase.Text = "Paguaj!";
            this.btn_Purchase.UseVisualStyleBackColor = true;
            this.btn_Purchase.Click += new System.EventHandler(this.btn_Purchase_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Back.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Back.Location = new System.Drawing.Point(436, 497);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(119, 29);
            this.btn_Back.TabIndex = 24;
            this.btn_Back.Text = "Prapa!";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_WonPrice
            // 
            this.lbl_WonPrice.AutoSize = true;
            this.lbl_WonPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_WonPrice.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_WonPrice.Location = new System.Drawing.Point(235, 187);
            this.lbl_WonPrice.Name = "lbl_WonPrice";
            this.lbl_WonPrice.Size = new System.Drawing.Size(101, 19);
            this.lbl_WonPrice.TabIndex = 25;
            this.lbl_WonPrice.Text = "Cmimi i fituar";
            // 
            // lbl_WonPriceValue
            // 
            this.lbl_WonPriceValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_WonPriceValue.AutoSize = true;
            this.lbl_WonPriceValue.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_WonPriceValue.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_WonPriceValue.Location = new System.Drawing.Point(239, 206);
            this.lbl_WonPriceValue.Name = "lbl_WonPriceValue";
            this.lbl_WonPriceValue.Size = new System.Drawing.Size(87, 49);
            this.lbl_WonPriceValue.TabIndex = 26;
            this.lbl_WonPriceValue.Text = "N/A";
            this.lbl_WonPriceValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ApplyCoupon
            // 
            this.lbl_ApplyCoupon.AutoSize = true;
            this.lbl_ApplyCoupon.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_ApplyCoupon.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_ApplyCoupon.Location = new System.Drawing.Point(222, 442);
            this.lbl_ApplyCoupon.Name = "lbl_ApplyCoupon";
            this.lbl_ApplyCoupon.Size = new System.Drawing.Size(114, 19);
            this.lbl_ApplyCoupon.TabIndex = 27;
            this.lbl_ApplyCoupon.Text = "Apliko kuponin";
            // 
            // txt_Coupon
            // 
            this.txt_Coupon.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Coupon.Location = new System.Drawing.Point(137, 464);
            this.txt_Coupon.Name = "txt_Coupon";
            this.txt_Coupon.Size = new System.Drawing.Size(293, 27);
            this.txt_Coupon.TabIndex = 28;
            this.txt_Coupon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Coupon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Coupon_KeyDown);
            // 
            // btn_EraseCoupon
            // 
            this.btn_EraseCoupon.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_EraseCoupon.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btn_EraseCoupon.Location = new System.Drawing.Point(436, 462);
            this.btn_EraseCoupon.Name = "btn_EraseCoupon";
            this.btn_EraseCoupon.Size = new System.Drawing.Size(51, 29);
            this.btn_EraseCoupon.TabIndex = 29;
            this.btn_EraseCoupon.Text = "X";
            this.btn_EraseCoupon.UseVisualStyleBackColor = true;
            this.btn_EraseCoupon.Click += new System.EventHandler(this.btn_EraseCoupon_Click);
            // 
            // PurchaseDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 538);
            this.Controls.Add(this.btn_EraseCoupon);
            this.Controls.Add(this.txt_Coupon);
            this.Controls.Add(this.lbl_ApplyCoupon);
            this.Controls.Add(this.lbl_WonPriceValue);
            this.Controls.Add(this.lbl_WonPrice);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Purchase);
            this.Controls.Add(this.lbl_ProductIDValue);
            this.Controls.Add(this.lbl_ProductID);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_TitleValue);
            this.Controls.Add(this.rtxt_Description);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchaseDialog";
            this.Text = "PurchaseDialog";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_TitleValue;
        private System.Windows.Forms.RichTextBox rtxt_Description;
        private System.Windows.Forms.Label lbl_ProductID;
        private System.Windows.Forms.Label lbl_ProductIDValue;
        private System.Windows.Forms.Button btn_Purchase;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_WonPrice;
        private System.Windows.Forms.Label lbl_WonPriceValue;
        private System.Windows.Forms.Label lbl_ApplyCoupon;
        private System.Windows.Forms.TextBox txt_Coupon;
        private System.Windows.Forms.Button btn_EraseCoupon;
    }
}