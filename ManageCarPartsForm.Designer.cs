namespace Project_AD
{
    partial class ManageCarPartsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCarPartsForm));
            this.dgvCarParts = new System.Windows.Forms.DataGridView();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.btnDeletePart = new System.Windows.Forms.Button();
            this.btnEditPar = new System.Windows.Forms.Button();
            this.txtPartPrice = new System.Windows.Forms.TextBox();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.lblPartPrice = new System.Windows.Forms.Label();
            this.lblPartName = new System.Windows.Forms.Label();
            this.lblCar = new System.Windows.Forms.Label();
            this.cbCar = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.blSearchCarParts = new System.Windows.Forms.Label();
            this.txtSearchCarParts = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarParts)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCarParts
            // 
            this.dgvCarParts.BackgroundColor = System.Drawing.Color.White;
            this.dgvCarParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarParts.Location = new System.Drawing.Point(287, 205);
            this.dgvCarParts.Name = "dgvCarParts";
            this.dgvCarParts.RowHeadersWidth = 51;
            this.dgvCarParts.RowTemplate.Height = 24;
            this.dgvCarParts.Size = new System.Drawing.Size(583, 349);
            this.dgvCarParts.TabIndex = 18;
            this.dgvCarParts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarParts_CellContentClick);
            // 
            // btnAddPart
            // 
            this.btnAddPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.btnAddPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPart.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPart.ForeColor = System.Drawing.Color.White;
            this.btnAddPart.Location = new System.Drawing.Point(11, 455);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(260, 47);
            this.btnAddPart.TabIndex = 16;
            this.btnAddPart.Text = "ADD PART";
            this.btnAddPart.UseVisualStyleBackColor = false;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // btnDeletePart
            // 
            this.btnDeletePart.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnDeletePart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePart.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePart.Location = new System.Drawing.Point(143, 508);
            this.btnDeletePart.Name = "btnDeletePart";
            this.btnDeletePart.Size = new System.Drawing.Size(128, 46);
            this.btnDeletePart.TabIndex = 17;
            this.btnDeletePart.Text = "DELETE PART";
            this.btnDeletePart.UseVisualStyleBackColor = false;
            this.btnDeletePart.Click += new System.EventHandler(this.btnDeletePart_Click);
            // 
            // btnEditPar
            // 
            this.btnEditPar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditPar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPar.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPar.Location = new System.Drawing.Point(11, 508);
            this.btnEditPar.Name = "btnEditPar";
            this.btnEditPar.Size = new System.Drawing.Size(117, 46);
            this.btnEditPar.TabIndex = 15;
            this.btnEditPar.Text = "EDIT PART";
            this.btnEditPar.UseVisualStyleBackColor = false;
            // 
            // txtPartPrice
            // 
            this.txtPartPrice.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartPrice.Location = new System.Drawing.Point(11, 373);
            this.txtPartPrice.Name = "txtPartPrice";
            this.txtPartPrice.Size = new System.Drawing.Size(260, 27);
            this.txtPartPrice.TabIndex = 14;
            // 
            // txtPartName
            // 
            this.txtPartName.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartName.Location = new System.Drawing.Point(11, 293);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(260, 27);
            this.txtPartName.TabIndex = 13;
            // 
            // lblPartPrice
            // 
            this.lblPartPrice.AutoSize = true;
            this.lblPartPrice.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartPrice.Location = new System.Drawing.Point(7, 347);
            this.lblPartPrice.Name = "lblPartPrice";
            this.lblPartPrice.Size = new System.Drawing.Size(84, 23);
            this.lblPartPrice.TabIndex = 11;
            this.lblPartPrice.Text = "PART PRICE";
            // 
            // lblPartName
            // 
            this.lblPartName.AutoSize = true;
            this.lblPartName.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartName.Location = new System.Drawing.Point(7, 267);
            this.lblPartName.Name = "lblPartName";
            this.lblPartName.Size = new System.Drawing.Size(86, 23);
            this.lblPartName.TabIndex = 10;
            this.lblPartName.Text = "PART NAME";
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCar.Location = new System.Drawing.Point(8, 179);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(87, 23);
            this.lblCar.TabIndex = 9;
            this.lblCar.Text = "SELECT CAR";
            // 
            // cbCar
            // 
            this.cbCar.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCar.FormattingEnabled = true;
            this.cbCar.Location = new System.Drawing.Point(11, 209);
            this.cbCar.Name = "cbCar";
            this.cbCar.Size = new System.Drawing.Size(260, 31);
            this.cbCar.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 99);
            this.panel1.TabIndex = 20;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(280, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 40);
            this.label2.TabIndex = 22;
            this.label2.Text = "MANAGE CAR PARTS";
            // 
            // blSearchCarParts
            // 
            this.blSearchCarParts.AutoSize = true;
            this.blSearchCarParts.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold);
            this.blSearchCarParts.Location = new System.Drawing.Point(472, 179);
            this.blSearchCarParts.Name = "blSearchCarParts";
            this.blSearchCarParts.Size = new System.Drawing.Size(146, 23);
            this.blSearchCarParts.TabIndex = 26;
            this.blSearchCarParts.Text = "SEARCH CAR PARTS :";
            // 
            // txtSearchCarParts
            // 
            this.txtSearchCarParts.Location = new System.Drawing.Point(623, 178);
            this.txtSearchCarParts.Name = "txtSearchCarParts";
            this.txtSearchCarParts.Size = new System.Drawing.Size(246, 22);
            this.txtSearchCarParts.TabIndex = 27;
            this.txtSearchCarParts.TextChanged += new System.EventHandler(this.txtSearchCarParts_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(1, 570);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(881, 37);
            this.panel3.TabIndex = 28;
            // 
            // ManageCarPartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 603);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtSearchCarParts);
            this.Controls.Add(this.blSearchCarParts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.dgvCarParts);
            this.Controls.Add(this.btnDeletePart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEditPar);
            this.Controls.Add(this.txtPartPrice);
            this.Controls.Add(this.cbCar);
            this.Controls.Add(this.txtPartName);
            this.Controls.Add(this.lblPartPrice);
            this.Controls.Add(this.lblCar);
            this.Controls.Add(this.lblPartName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageCarPartsForm";
            this.Text = "Manage Car Parts ";
            this.Load += new System.EventHandler(this.ManageCarPartsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarParts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCarParts;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Button btnDeletePart;
        private System.Windows.Forms.Button btnEditPar;
        private System.Windows.Forms.TextBox txtPartPrice;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.Label lblPartPrice;
        private System.Windows.Forms.Label lblPartName;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.ComboBox cbCar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label blSearchCarParts;
        private System.Windows.Forms.TextBox txtSearchCarParts;
        private System.Windows.Forms.Panel panel3;
    }
}