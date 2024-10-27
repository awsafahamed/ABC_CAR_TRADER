namespace Project_AD
{
    partial class CustomerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboard));
            this.btnOrderCarsParts = new System.Windows.Forms.Button();
            this.btnTrackOrders = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOrderCars = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOrderCarsParts
            // 
            this.btnOrderCarsParts.BackColor = System.Drawing.Color.Black;
            this.btnOrderCarsParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderCarsParts.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.btnOrderCarsParts.ForeColor = System.Drawing.Color.White;
            this.btnOrderCarsParts.Location = new System.Drawing.Point(617, 192);
            this.btnOrderCarsParts.Name = "btnOrderCarsParts";
            this.btnOrderCarsParts.Size = new System.Drawing.Size(213, 108);
            this.btnOrderCarsParts.TabIndex = 3;
            this.btnOrderCarsParts.Text = "ORDER CARS PARTS";
            this.btnOrderCarsParts.UseVisualStyleBackColor = false;
            this.btnOrderCarsParts.Click += new System.EventHandler(this.btnOrderCarsParts_Click);
            // 
            // btnTrackOrders
            // 
            this.btnTrackOrders.BackColor = System.Drawing.Color.Black;
            this.btnTrackOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrackOrders.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.btnTrackOrders.ForeColor = System.Drawing.Color.White;
            this.btnTrackOrders.Location = new System.Drawing.Point(398, 319);
            this.btnTrackOrders.Name = "btnTrackOrders";
            this.btnTrackOrders.Size = new System.Drawing.Size(213, 108);
            this.btnTrackOrders.TabIndex = 4;
            this.btnTrackOrders.Text = "TRACK ORDERS";
            this.btnTrackOrders.UseVisualStyleBackColor = false;
            this.btnTrackOrders.Click += new System.EventHandler(this.btnTrackOrders_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(12, 192);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 328);
            this.panel3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(271, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "CUSTOMER DASHBOARD";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 99);
            this.panel1.TabIndex = 21;
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
            // btnOrderCars
            // 
            this.btnOrderCars.BackColor = System.Drawing.Color.Black;
            this.btnOrderCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderCars.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.btnOrderCars.ForeColor = System.Drawing.Color.White;
            this.btnOrderCars.Location = new System.Drawing.Point(398, 192);
            this.btnOrderCars.Name = "btnOrderCars";
            this.btnOrderCars.Size = new System.Drawing.Size(213, 108);
            this.btnOrderCars.TabIndex = 22;
            this.btnOrderCars.Text = "ORDER CARS ";
            this.btnOrderCars.UseVisualStyleBackColor = false;
            this.btnOrderCars.Click += new System.EventHandler(this.btnOrderCars_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(702, 479);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(128, 41);
            this.btnLogout.TabIndex = 23;
            this.btnLogout.Text = "LOG OUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Location = new System.Drawing.Point(3, 540);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(878, 68);
            this.panel4.TabIndex = 24;
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(882, 603);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnOrderCars);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnTrackOrders);
            this.Controls.Add(this.btnOrderCarsParts);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerDashboard";
            this.Text = "Customer Dashboard";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOrderCarsParts;
        private System.Windows.Forms.Button btnTrackOrders;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOrderCars;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel4;
    }
}