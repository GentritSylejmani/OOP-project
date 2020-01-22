namespace OOP_project
{
    partial class AdminApproveDialog
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
            this.btn_Approve = new System.Windows.Forms.Button();
            this.btn_Deny = new System.Windows.Forms.Button();
            this.lbl_ProductID = new System.Windows.Forms.Label();
            this.lbl_ProductIDValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Approve
            // 
            this.btn_Approve.Location = new System.Drawing.Point(5, 63);
            this.btn_Approve.Name = "btn_Approve";
            this.btn_Approve.Size = new System.Drawing.Size(75, 23);
            this.btn_Approve.TabIndex = 0;
            this.btn_Approve.Text = "Aprovo";
            this.btn_Approve.UseVisualStyleBackColor = true;
            this.btn_Approve.Click += new System.EventHandler(this.btn_Approve_Click);
            // 
            // btn_Deny
            // 
            this.btn_Deny.Location = new System.Drawing.Point(86, 63);
            this.btn_Deny.Name = "btn_Deny";
            this.btn_Deny.Size = new System.Drawing.Size(75, 23);
            this.btn_Deny.TabIndex = 1;
            this.btn_Deny.Text = "Refuzo";
            this.btn_Deny.UseVisualStyleBackColor = true;
            this.btn_Deny.Click += new System.EventHandler(this.btn_Deny_Click);
            // 
            // lbl_ProductID
            // 
            this.lbl_ProductID.AutoSize = true;
            this.lbl_ProductID.Location = new System.Drawing.Point(25, 25);
            this.lbl_ProductID.Name = "lbl_ProductID";
            this.lbl_ProductID.Size = new System.Drawing.Size(55, 13);
            this.lbl_ProductID.TabIndex = 2;
            this.lbl_ProductID.Text = "ProduktID";
            // 
            // lbl_ProductIDValue
            // 
            this.lbl_ProductIDValue.AutoSize = true;
            this.lbl_ProductIDValue.Location = new System.Drawing.Point(86, 25);
            this.lbl_ProductIDValue.Name = "lbl_ProductIDValue";
            this.lbl_ProductIDValue.Size = new System.Drawing.Size(24, 13);
            this.lbl_ProductIDValue.TabIndex = 3;
            this.lbl_ProductIDValue.Text = "n/a";
            // 
            // AdminApproveDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(169, 98);
            this.Controls.Add(this.lbl_ProductIDValue);
            this.Controls.Add(this.lbl_ProductID);
            this.Controls.Add(this.btn_Deny);
            this.Controls.Add(this.btn_Approve);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminApproveDialog";
            this.Text = "AdminApproveDialog";
            this.Load += new System.EventHandler(this.AdminApproveDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Approve;
        private System.Windows.Forms.Button btn_Deny;
        private System.Windows.Forms.Label lbl_ProductID;
        private System.Windows.Forms.Label lbl_ProductIDValue;
    }
}