namespace Project_AD
{
    partial class AdminDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboardForm));
            this.btnManageCars = new System.Windows.Forms.Button();
            this.btnManageCarParts = new System.Windows.Forms.Button();
            this.btnCustomerOrderDetails = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnManageCustomers = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnManageCars
            // 
            this.btnManageCars.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnManageCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCars.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCars.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnManageCars.Location = new System.Drawing.Point(379, 196);
            this.btnManageCars.Name = "btnManageCars";
            this.btnManageCars.Size = new System.Drawing.Size(220, 108);
            this.btnManageCars.TabIndex = 0;
            this.btnManageCars.Text = "MANAGE CARS";
            this.btnManageCars.UseVisualStyleBackColor = false;
            this.btnManageCars.Click += new System.EventHandler(this.btnManageCars_Click);
            // 
            // btnManageCarParts
            // 
            this.btnManageCarParts.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnManageCarParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCarParts.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.btnManageCarParts.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnManageCarParts.Location = new System.Drawing.Point(614, 196);
            this.btnManageCarParts.Name = "btnManageCarParts";
            this.btnManageCarParts.Size = new System.Drawing.Size(220, 108);
            this.btnManageCarParts.TabIndex = 1;
            this.btnManageCarParts.Text = "MANAGE CAR PARTS";
            this.btnManageCarParts.UseVisualStyleBackColor = false;
            this.btnManageCarParts.Click += new System.EventHandler(this.btnManageCarParts_Click);
            // 
            // btnCustomerOrderDetails
            // 
            this.btnCustomerOrderDetails.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCustomerOrderDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerOrderDetails.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.btnCustomerOrderDetails.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCustomerOrderDetails.Location = new System.Drawing.Point(614, 322);
            this.btnCustomerOrderDetails.Name = "btnCustomerOrderDetails";
            this.btnCustomerOrderDetails.Size = new System.Drawing.Size(220, 108);
            this.btnCustomerOrderDetails.TabIndex = 2;
            this.btnCustomerOrderDetails.Text = "CUSTOMER ORDER DETAILS";
            this.btnCustomerOrderDetails.UseVisualStyleBackColor = false;
            this.btnCustomerOrderDetails.Click += new System.EventHandler(this.btnCustomerOrderDetails_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(12, 196);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 307);
            this.panel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(323, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "ADMIN DASHBOARD";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(706, 462);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(128, 41);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "LOG OUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 99);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(124, 99);
            this.panel2.TabIndex = 0;
            // 
            // btnManageCustomers
            // 
            this.btnManageCustomers.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnManageCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCustomers.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.btnManageCustomers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnManageCustomers.Location = new System.Drawing.Point(379, 322);
            this.btnManageCustomers.Name = "btnManageCustomers";
            this.btnManageCustomers.Size = new System.Drawing.Size(220, 108);
            this.btnManageCustomers.TabIndex = 23;
            this.btnManageCustomers.Text = "MANAGE CUSTOMER";
            this.btnManageCustomers.UseVisualStyleBackColor = false;
            this.btnManageCustomers.Click += new System.EventHandler(this.btnManageCustomers_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Location = new System.Drawing.Point(0, 536);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(888, 71);
            this.panel4.TabIndex = 24;
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 604);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnManageCustomers);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnCustomerOrderDetails);
            this.Controls.Add(this.btnManageCarParts);
            this.Controls.Add(this.btnManageCars);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminDashboardForm";
            this.Text = "Admin Dashboard ";
            this.Load += new System.EventHandler(this.AdminDashboardForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManageCars;
        private System.Windows.Forms.Button btnManageCarParts;
        private System.Windows.Forms.Button btnCustomerOrderDetails;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnManageCustomers;
        private System.Windows.Forms.Panel panel4;
    }
}