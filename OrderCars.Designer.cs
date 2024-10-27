namespace Project_AD
{
    partial class OrderCars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderCars));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nudCarsQuantity = new System.Windows.Forms.NumericUpDown();
            this.cbSelectCar = new System.Windows.Forms.ComboBox();
            this.dgvOrderSummaryCars = new System.Windows.Forms.DataGridView();
            this.btnOrderCars = new System.Windows.Forms.Button();
            this.lblCarQuantity = new System.Windows.Forms.Label();
            this.lblSelectCar = new System.Windows.Forms.Label();
            this.lblSearchCars = new System.Windows.Forms.Label();
            this.txrtSearchCars = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCarsPrice = new System.Windows.Forms.Label();
            this.txtCarsPrice = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarsQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderSummaryCars)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-9, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 99);
            this.panel1.TabIndex = 34;
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
            // nudCarsQuantity
            // 
            this.nudCarsQuantity.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold);
            this.nudCarsQuantity.Location = new System.Drawing.Point(24, 377);
            this.nudCarsQuantity.Name = "nudCarsQuantity";
            this.nudCarsQuantity.Size = new System.Drawing.Size(330, 27);
            this.nudCarsQuantity.TabIndex = 33;
            this.nudCarsQuantity.ValueChanged += new System.EventHandler(this.nudCarsQuantity_ValueChanged);
            // 
            // cbSelectCar
            // 
            this.cbSelectCar.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold);
            this.cbSelectCar.FormattingEnabled = true;
            this.cbSelectCar.Location = new System.Drawing.Point(23, 308);
            this.cbSelectCar.Name = "cbSelectCar";
            this.cbSelectCar.Size = new System.Drawing.Size(331, 31);
            this.cbSelectCar.TabIndex = 31;
            this.cbSelectCar.SelectedIndexChanged += new System.EventHandler(this.cbSelectCar_SelectedIndexChanged);
            // 
            // dgvOrderSummaryCars
            // 
            this.dgvOrderSummaryCars.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOrderSummaryCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderSummaryCars.Location = new System.Drawing.Point(387, 221);
            this.dgvOrderSummaryCars.Name = "dgvOrderSummaryCars";
            this.dgvOrderSummaryCars.RowHeadersWidth = 51;
            this.dgvOrderSummaryCars.RowTemplate.Height = 24;
            this.dgvOrderSummaryCars.Size = new System.Drawing.Size(461, 320);
            this.dgvOrderSummaryCars.TabIndex = 30;
            this.dgvOrderSummaryCars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderSummaryCars_CellContentClick);
            // 
            // btnOrderCars
            // 
            this.btnOrderCars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.btnOrderCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderCars.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderCars.ForeColor = System.Drawing.Color.White;
            this.btnOrderCars.Location = new System.Drawing.Point(24, 490);
            this.btnOrderCars.Name = "btnOrderCars";
            this.btnOrderCars.Size = new System.Drawing.Size(331, 51);
            this.btnOrderCars.TabIndex = 29;
            this.btnOrderCars.Text = "ORDER";
            this.btnOrderCars.UseVisualStyleBackColor = false;
            this.btnOrderCars.Click += new System.EventHandler(this.btnOrderCars_Click);
            // 
            // lblCarQuantity
            // 
            this.lblCarQuantity.AutoSize = true;
            this.lblCarQuantity.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblCarQuantity.Location = new System.Drawing.Point(20, 351);
            this.lblCarQuantity.Name = "lblCarQuantity";
            this.lblCarQuantity.Size = new System.Drawing.Size(78, 23);
            this.lblCarQuantity.TabIndex = 28;
            this.lblCarQuantity.Text = "QUANTITY";
            // 
            // lblSelectCar
            // 
            this.lblSelectCar.AutoSize = true;
            this.lblSelectCar.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblSelectCar.Location = new System.Drawing.Point(19, 282);
            this.lblSelectCar.Name = "lblSelectCar";
            this.lblSelectCar.Size = new System.Drawing.Size(87, 23);
            this.lblSelectCar.TabIndex = 26;
            this.lblSelectCar.Text = "SELECT CAR";
            // 
            // lblSearchCars
            // 
            this.lblSearchCars.AutoSize = true;
            this.lblSearchCars.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblSearchCars.Location = new System.Drawing.Point(383, 194);
            this.lblSearchCars.Name = "lblSearchCars";
            this.lblSearchCars.Size = new System.Drawing.Size(104, 23);
            this.lblSearchCars.TabIndex = 37;
            this.lblSearchCars.Text = "SEARCH CAR  :";
            // 
            // txrtSearchCars
            // 
            this.txrtSearchCars.Location = new System.Drawing.Point(493, 193);
            this.txrtSearchCars.Name = "txrtSearchCars";
            this.txrtSearchCars.Size = new System.Drawing.Size(355, 22);
            this.txrtSearchCars.TabIndex = 36;
            this.txrtSearchCars.TextChanged += new System.EventHandler(this.txrtSearchCars_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(337, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 40);
            this.label2.TabIndex = 35;
            this.label2.Text = "ORDER CARS";
            // 
            // lblCarsPrice
            // 
            this.lblCarsPrice.AutoSize = true;
            this.lblCarsPrice.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblCarsPrice.Location = new System.Drawing.Point(21, 416);
            this.lblCarsPrice.Name = "lblCarsPrice";
            this.lblCarsPrice.Size = new System.Drawing.Size(47, 23);
            this.lblCarsPrice.TabIndex = 38;
            this.lblCarsPrice.Text = "PRICE";
            // 
            // txtCarsPrice
            // 
            this.txtCarsPrice.Location = new System.Drawing.Point(24, 442);
            this.txtCarsPrice.Name = "txtCarsPrice";
            this.txtCarsPrice.Size = new System.Drawing.Size(331, 22);
            this.txtCarsPrice.TabIndex = 39;
            this.txtCarsPrice.TextChanged += new System.EventHandler(this.txtCarsPrice_TextChanged);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblCustomerName.Location = new System.Drawing.Point(20, 221);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(124, 23);
            this.lblCustomerName.TabIndex = 40;
            this.lblCustomerName.Text = "CUSTOMER NAME";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(24, 247);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(331, 22);
            this.txtCustomerName.TabIndex = 41;
    
            // 
            // OrderCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 604);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.txtCarsPrice);
            this.Controls.Add(this.lblCarsPrice);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nudCarsQuantity);
            this.Controls.Add(this.cbSelectCar);
            this.Controls.Add(this.dgvOrderSummaryCars);
            this.Controls.Add(this.btnOrderCars);
            this.Controls.Add(this.lblCarQuantity);
            this.Controls.Add(this.lblSelectCar);
            this.Controls.Add(this.lblSearchCars);
            this.Controls.Add(this.txrtSearchCars);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderCars";
            this.Text = "Order Cars";
            this.Load += new System.EventHandler(this.OrderCars_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCarsQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderSummaryCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nudCarsQuantity;
        private System.Windows.Forms.ComboBox cbSelectCar;
        private System.Windows.Forms.DataGridView dgvOrderSummaryCars;
        private System.Windows.Forms.Button btnOrderCars;
        private System.Windows.Forms.Label lblCarQuantity;
        private System.Windows.Forms.Label lblSelectCar;
        private System.Windows.Forms.Label lblSearchCars;
        private System.Windows.Forms.TextBox txrtSearchCars;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCarsPrice;
        private System.Windows.Forms.TextBox txtCarsPrice;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
    }
}