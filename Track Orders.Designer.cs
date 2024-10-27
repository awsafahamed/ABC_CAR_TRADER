namespace Project_AD
{
    partial class Track_Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Track_Orders));
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.btnTrackOrder = new System.Windows.Forms.Button();
            this.dgvOrderTracking = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tabOrders = new System.Windows.Forms.TabControl();
            this.tabCarOders = new System.Windows.Forms.TabPage();
            this.tabCarPartsOrders = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTrackCarParts = new System.Windows.Forms.TextBox();
            this.dgvTrackingCarParts = new System.Windows.Forms.DataGridView();
            this.btcTrackCarParts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderTracking)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabOrders.SuspendLayout();
            this.tabCarOders.SuspendLayout();
            this.tabCarPartsOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrackingCarParts)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(9, 53);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(328, 33);
            this.txtOrderId.TabIndex = 0;
            this.txtOrderId.TextChanged += new System.EventHandler(this.txtOrderId_TextChanged);
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblOrderId.Location = new System.Drawing.Point(6, 23);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(116, 23);
            this.lblOrderId.TabIndex = 1;
            this.lblOrderId.Text = "TRACK ORDER ID";
            // 
            // btnTrackOrder
            // 
            this.btnTrackOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.btnTrackOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrackOrder.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnTrackOrder.ForeColor = System.Drawing.Color.White;
            this.btnTrackOrder.Location = new System.Drawing.Point(594, 23);
            this.btnTrackOrder.Name = "btnTrackOrder";
            this.btnTrackOrder.Size = new System.Drawing.Size(250, 52);
            this.btnTrackOrder.TabIndex = 2;
            this.btnTrackOrder.Text = "TRACK ORDER";
            this.btnTrackOrder.UseVisualStyleBackColor = false;
            this.btnTrackOrder.Click += new System.EventHandler(this.btnTrackOrder_Click);
            // 
            // dgvOrderTracking
            // 
            this.dgvOrderTracking.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderTracking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderTracking.Location = new System.Drawing.Point(10, 97);
            this.dgvOrderTracking.Name = "dgvOrderTracking";
            this.dgvOrderTracking.RowHeadersWidth = 51;
            this.dgvOrderTracking.RowTemplate.Height = 24;
            this.dgvOrderTracking.Size = new System.Drawing.Size(834, 278);
            this.dgvOrderTracking.TabIndex = 3;
            this.dgvOrderTracking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderTracking_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 99);
            this.panel1.TabIndex = 23;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(285, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 42);
            this.label2.TabIndex = 24;
            this.label2.Text = "TRACK YOUR ORDERS";
            // 
            // tabOrders
            // 
            this.tabOrders.Controls.Add(this.tabCarOders);
            this.tabOrders.Controls.Add(this.tabCarPartsOrders);
            this.tabOrders.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabOrders.Location = new System.Drawing.Point(12, 154);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.SelectedIndex = 0;
            this.tabOrders.Size = new System.Drawing.Size(858, 423);
            this.tabOrders.TabIndex = 26;
            // 
            // tabCarOders
            // 
            this.tabCarOders.BackColor = System.Drawing.Color.White;
            this.tabCarOders.Controls.Add(this.lblOrderId);
            this.tabCarOders.Controls.Add(this.txtOrderId);
            this.tabCarOders.Controls.Add(this.dgvOrderTracking);
            this.tabCarOders.Controls.Add(this.btnTrackOrder);
            this.tabCarOders.Location = new System.Drawing.Point(4, 39);
            this.tabCarOders.Name = "tabCarOders";
            this.tabCarOders.Padding = new System.Windows.Forms.Padding(3);
            this.tabCarOders.Size = new System.Drawing.Size(850, 380);
            this.tabCarOders.TabIndex = 0;
            this.tabCarOders.Text = "CAR ORDERS";
            // 
            // tabCarPartsOrders
            // 
            this.tabCarPartsOrders.BackColor = System.Drawing.Color.White;
            this.tabCarPartsOrders.Controls.Add(this.label3);
            this.tabCarPartsOrders.Controls.Add(this.txtTrackCarParts);
            this.tabCarPartsOrders.Controls.Add(this.dgvTrackingCarParts);
            this.tabCarPartsOrders.Controls.Add(this.btcTrackCarParts);
            this.tabCarPartsOrders.Location = new System.Drawing.Point(4, 39);
            this.tabCarPartsOrders.Name = "tabCarPartsOrders";
            this.tabCarPartsOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabCarPartsOrders.Size = new System.Drawing.Size(850, 380);
            this.tabCarPartsOrders.TabIndex = 1;
            this.tabCarPartsOrders.Text = "CAR PARTS ORDERS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(7, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "TRACK ORDER ID";
            // 
            // txtTrackCarParts
            // 
            this.txtTrackCarParts.Location = new System.Drawing.Point(10, 58);
            this.txtTrackCarParts.Name = "txtTrackCarParts";
            this.txtTrackCarParts.Size = new System.Drawing.Size(328, 33);
            this.txtTrackCarParts.TabIndex = 4;
            this.txtTrackCarParts.TextChanged += new System.EventHandler(this.txtTrackCarParts_TextChanged);
            // 
            // dgvTrackingCarParts
            // 
            this.dgvTrackingCarParts.BackgroundColor = System.Drawing.Color.White;
            this.dgvTrackingCarParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrackingCarParts.Location = new System.Drawing.Point(11, 99);
            this.dgvTrackingCarParts.Name = "dgvTrackingCarParts";
            this.dgvTrackingCarParts.RowHeadersWidth = 51;
            this.dgvTrackingCarParts.RowTemplate.Height = 24;
            this.dgvTrackingCarParts.Size = new System.Drawing.Size(833, 270);
            this.dgvTrackingCarParts.TabIndex = 7;
            this.dgvTrackingCarParts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrackingCarParts_CellContentClick);
            // 
            // btcTrackCarParts
            // 
            this.btcTrackCarParts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.btcTrackCarParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcTrackCarParts.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold);
            this.btcTrackCarParts.ForeColor = System.Drawing.Color.White;
            this.btcTrackCarParts.Location = new System.Drawing.Point(594, 28);
            this.btcTrackCarParts.Name = "btcTrackCarParts";
            this.btcTrackCarParts.Size = new System.Drawing.Size(250, 52);
            this.btcTrackCarParts.TabIndex = 6;
            this.btcTrackCarParts.Text = "TRACK ORDER";
            this.btcTrackCarParts.UseVisualStyleBackColor = false;
            this.btcTrackCarParts.Click += new System.EventHandler(this.btcTrackCarParts_Click);
            // 
            // Track_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 603);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabOrders);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Track_Orders";
            this.Text = "Track Orders";
            this.Load += new System.EventHandler(this.Track_Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderTracking)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabOrders.ResumeLayout(false);
            this.tabCarOders.ResumeLayout(false);
            this.tabCarOders.PerformLayout();
            this.tabCarPartsOrders.ResumeLayout(false);
            this.tabCarPartsOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrackingCarParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Button btnTrackOrder;
        private System.Windows.Forms.DataGridView dgvOrderTracking;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabOrders;
        private System.Windows.Forms.TabPage tabCarOders;
        private System.Windows.Forms.TabPage tabCarPartsOrders;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTrackCarParts;
        private System.Windows.Forms.DataGridView dgvTrackingCarParts;
        private System.Windows.Forms.Button btcTrackCarParts;
    }
}