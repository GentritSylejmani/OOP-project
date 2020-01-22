namespace OOP_project
{
    partial class AdminPanel
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
            this.btn_Back = new System.Windows.Forms.Button();
            this.tab_control = new System.Windows.Forms.TabControl();
            this.tab_Pending = new System.Windows.Forms.TabPage();
            this.dgv_PendingRequests = new System.Windows.Forms.DataGridView();
            this.tab_Active = new System.Windows.Forms.TabPage();
            this.dgv_Active = new System.Windows.Forms.DataGridView();
            this.tab_Canceled = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tab_Users = new System.Windows.Forms.TabPage();
            this.dgv_Users = new System.Windows.Forms.DataGridView();
            this.tab_control.SuspendLayout();
            this.tab_Pending.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PendingRequests)).BeginInit();
            this.tab_Active.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Active)).BeginInit();
            this.tab_Canceled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tab_Users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Back.Location = new System.Drawing.Point(1096, 457);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 29);
            this.btn_Back.TabIndex = 23;
            this.btn_Back.Text = "Prapa!";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // tab_control
            // 
            this.tab_control.Controls.Add(this.tab_Pending);
            this.tab_control.Controls.Add(this.tab_Active);
            this.tab_control.Controls.Add(this.tab_Canceled);
            this.tab_control.Controls.Add(this.tab_Users);
            this.tab_control.Location = new System.Drawing.Point(12, 12);
            this.tab_control.Name = "tab_control";
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(1159, 443);
            this.tab_control.TabIndex = 24;
            // 
            // tab_Pending
            // 
            this.tab_Pending.Controls.Add(this.dgv_PendingRequests);
            this.tab_Pending.Location = new System.Drawing.Point(4, 22);
            this.tab_Pending.Name = "tab_Pending";
            this.tab_Pending.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Pending.Size = new System.Drawing.Size(1151, 417);
            this.tab_Pending.TabIndex = 0;
            this.tab_Pending.Text = "Pending";
            this.tab_Pending.UseVisualStyleBackColor = true;
            // 
            // dgv_PendingRequests
            // 
            this.dgv_PendingRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PendingRequests.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_PendingRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PendingRequests.Location = new System.Drawing.Point(6, 6);
            this.dgv_PendingRequests.Name = "dgv_PendingRequests";
            this.dgv_PendingRequests.Size = new System.Drawing.Size(1139, 404);
            this.dgv_PendingRequests.TabIndex = 0;
            this.dgv_PendingRequests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PendingRequests_CellContentClick);
            // 
            // tab_Active
            // 
            this.tab_Active.Controls.Add(this.dgv_Active);
            this.tab_Active.Location = new System.Drawing.Point(4, 22);
            this.tab_Active.Name = "tab_Active";
            this.tab_Active.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Active.Size = new System.Drawing.Size(1151, 417);
            this.tab_Active.TabIndex = 1;
            this.tab_Active.Text = "Active";
            this.tab_Active.UseVisualStyleBackColor = true;
            // 
            // dgv_Active
            // 
            this.dgv_Active.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Active.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Active.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Active.Location = new System.Drawing.Point(6, 6);
            this.dgv_Active.Name = "dgv_Active";
            this.dgv_Active.Size = new System.Drawing.Size(1139, 404);
            this.dgv_Active.TabIndex = 0;
            
            // 
            // tab_Canceled
            // 
            this.tab_Canceled.Controls.Add(this.dataGridView1);
            this.tab_Canceled.Location = new System.Drawing.Point(4, 22);
            this.tab_Canceled.Name = "tab_Canceled";
            this.tab_Canceled.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Canceled.Size = new System.Drawing.Size(1151, 417);
            this.tab_Canceled.TabIndex = 2;
            this.tab_Canceled.Text = "Canceled";
            this.tab_Canceled.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1139, 405);
            this.dataGridView1.TabIndex = 0;
            // 
            // tab_Users
            // 
            this.tab_Users.Controls.Add(this.dgv_Users);
            this.tab_Users.Location = new System.Drawing.Point(4, 22);
            this.tab_Users.Name = "tab_Users";
            this.tab_Users.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Users.Size = new System.Drawing.Size(1151, 417);
            this.tab_Users.TabIndex = 3;
            this.tab_Users.Text = "Users";
            this.tab_Users.UseVisualStyleBackColor = true;
            // 
            // dgv_Users
            // 
            this.dgv_Users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Users.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Users.Location = new System.Drawing.Point(6, 6);
            this.dgv_Users.Name = "dgv_Users";
            this.dgv_Users.Size = new System.Drawing.Size(1139, 405);
            this.dgv_Users.TabIndex = 0;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 493);
            this.Controls.Add(this.tab_control);
            this.Controls.Add(this.btn_Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            this.tab_control.ResumeLayout(false);
            this.tab_Pending.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PendingRequests)).EndInit();
            this.tab_Active.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Active)).EndInit();
            this.tab_Canceled.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tab_Users.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TabControl tab_control;
        private System.Windows.Forms.TabPage tab_Pending;
        private System.Windows.Forms.DataGridView dgv_PendingRequests;
        private System.Windows.Forms.TabPage tab_Active;
        private System.Windows.Forms.DataGridView dgv_Active;
        private System.Windows.Forms.TabPage tab_Canceled;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tab_Users;
        private System.Windows.Forms.DataGridView dgv_Users;
    }
}