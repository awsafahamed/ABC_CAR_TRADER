namespace Project_AD
{
    partial class Order_Car_Parts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order_Car_Parts));
            this.label1 = new System.Windows.Forms.Label();
            this.cbSelectPart = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOrderPart = new System.Windows.Forms.Button();
            this.dgvOrderSummary = new System.Windows.Forms.DataGridView();
            this.cbSelectCar = new System.Windows.Forms.ComboBox();
            this.cbSelectCarParts = new System.Windows.Forms.ComboBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchCarParts = new System.Windows.Forms.TextBox();
            this.blSearchCarParts = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(30, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECT CAR";
            // 
            // cbSelectPart
            // 
            this.cbSelectPart.AutoSize = true;
            this.cbSelectPart.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold);
            this.cbSelectPart.Location = new System.Drawing.Point(28, 325);
            this.cbSelectPart.Name = "cbSelectPart";
            this.cbSelectPart.Size = new System.Drawing.Size(93, 23);
            this.cbSelectPart.TabIndex = 1;
            this.cbSelectPart.Text = "SELECT PART";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(28, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "QUANTITY";
            // 
            // btnOrderPart
            // 
            this.btnOrderPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.btnOrderPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderPart.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPart.ForeColor = System.Drawing.Color.White;
            this.btnOrderPart.Location = new System.Drawing.Point(32, 540);
            this.btnOrderPart.Name = "btnOrderPart";
            this.btnOrderPart.Size = new System.Drawing.Size(331, 51);
            this.btnOrderPart.TabIndex = 3;
            this.btnOrderPart.Text = "ORDER";
            this.btnOrderPart.UseVisualStyleBackColor = false;
            this.btnOrderPart.Click += new System.EventHandler(this.btnOrderPart_Click);
            // 
            // dgvOrderSummary
            // 
            this.dgvOrderSummary.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOrderSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderSummary.Location = new System.Drawing.Point(397, 201);
            this.dgvOrderSummary.Name = "dgvOrderSummary";
            this.dgvOrderSummary.RowHeadersWidth = 51;
            this.dgvOrderSummary.RowTemplate.Height = 24;
            this.dgvOrderSummary.Size = new System.Drawing.Size(461, 390);
            this.dgvOrderSummary.TabIndex = 4;
            this.dgvOrderSummary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderSummary_CellContentClick);
            // 
            // cbSelectCar
            // 
            this.cbSelectCar.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold);
            this.cbSelectCar.FormattingEnabled = true;
            this.cbSelectCar.Location = new System.Drawing.Point(35, 281);
            this.cbSelectCar.Name = "cbSelectCar";
            this.cbSelectCar.Size = new System.Drawing.Size(331, 31);
            this.cbSelectCar.TabIndex = 5;
            // 
            // cbSelectCarParts
            // 
            this.cbSelectCarParts.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold);
            this.cbSelectCarParts.FormattingEnabled = true;
            this.cbSelectCarParts.Location = new System.Drawing.Point(32, 351);
            this.cbSelectCarParts.Name = "cbSelectCarParts";
            this.cbSelectCarParts.Size = new System.Drawing.Size(330, 31);
            this.cbSelectCarParts.TabIndex = 6;
            this.cbSelectCarParts.SelectedIndexChanged += new System.EventHandler(this.cbSelectCarParts_SelectedIndexChanged);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold);
            this.nudQuantity.Location = new System.Drawing.Point(32, 422);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(330, 27);
            this.nudQuantity.TabIndex = 7;
            this.nudQuantity.ValueChanged += new System.EventHandler(this.nudQuantity_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, 0);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(311, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 40);
            this.label2.TabIndex = 23;
            this.label2.Text = "ORDER CAR PARTS";
            // 
            // txtSearchCarParts
            // 
            this.txtSearchCarParts.Location = new System.Drawing.Point(566, 173);
            this.txtSearchCarParts.Name = "txtSearchCarParts";
            this.txtSearchCarParts.Size = new System.Drawing.Size(292, 22);
            this.txtSearchCarParts.TabIndex = 24;
            this.txtSearchCarParts.TextChanged += new System.EventHandler(this.txtSearchCarParts_TextChanged);
            // 
            // blSearchCarParts
            // 
            this.blSearchCarParts.AutoSize = true;
            this.blSearchCarParts.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold);
            this.blSearchCarParts.Location = new System.Drawing.Point(393, 172);
            this.blSearchCarParts.Name = "blSearchCarParts";
            this.blSearchCarParts.Size = new System.Drawing.Size(146, 23);
            this.blSearchCarParts.TabIndex = 25;
            this.blSearchCarParts.Text = "SEARCH CAR PARTS :";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(34, 495);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(332, 22);
            this.txtPrice.TabIndex = 26;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblPrice.Location = new System.Drawing.Point(31, 469);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(47, 23);
            this.lblPrice.TabIndex = 27;
            this.lblPrice.Text = "PRICE";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblCustomerName.Location = new System.Drawing.Point(31, 191);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(124, 23);
            this.lblCustomerName.TabIndex = 28;
            this.lblCustomerName.Text = "CUSTOMER NAME";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(32, 217);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(332, 22);
            this.txtCustomerName.TabIndex = 29;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // Order_Car_Parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 603);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.blSearchCarParts);
            this.Controls.Add(this.txtSearchCarParts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.cbSelectCarParts);
            this.Controls.Add(this.cbSelectCar);
            this.Controls.Add(this.dgvOrderSummary);
            this.Controls.Add(this.btnOrderPart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSelectPart);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Order_Car_Parts";
            this.Text = "Order Car Parts";
            this.Load += new System.EventHandler(this.Order_Car_Parts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cbSelectPart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOrderPart;
        private System.Windows.Forms.DataGridView dgvOrderSummary;
        private System.Windows.Forms.ComboBox cbSelectCar;
        private System.Windows.Forms.ComboBox cbSelectCarParts;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchCarParts;
        private System.Windows.Forms.Label blSearchCarParts;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
    }
}