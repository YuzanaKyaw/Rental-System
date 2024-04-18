
namespace HomeApplianceReantalSystem
{
    partial class RentalForm
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
            this.RentalCart = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtApplianceQuantity = new System.Windows.Forms.TextBox();
            this.DueDate = new System.Windows.Forms.DateTimePicker();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.txtRentalID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvRentalCart = new System.Windows.Forms.DataGridView();
            this.Cancel = new System.Windows.Forms.DataGridViewImageColumn();
            this.ApplianceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplianceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbApplianceID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.lbRentalFee = new System.Windows.Forms.Label();
            this.lbTypicalUse = new System.Windows.Forms.Label();
            this.lbDimension = new System.Windows.Forms.Label();
            this.lbBrandName = new System.Windows.Forms.Label();
            this.lbApplianceCategory = new System.Windows.Forms.Label();
            this.lbApplianceName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboRentalMonth = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ApplianceImage = new System.Windows.Forms.PictureBox();
            this.dgvApplianceSearch = new System.Windows.Forms.DataGridView();
            this.cboAppliance = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RentalCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalCart)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ApplianceImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplianceSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // RentalCart
            // 
            this.RentalCart.Controls.Add(this.txtTotal);
            this.RentalCart.Controls.Add(this.txtApplianceQuantity);
            this.RentalCart.Controls.Add(this.DueDate);
            this.RentalCart.Controls.Add(this.StartDate);
            this.RentalCart.Controls.Add(this.txtRentalID);
            this.RentalCart.Controls.Add(this.label16);
            this.RentalCart.Controls.Add(this.label15);
            this.RentalCart.Controls.Add(this.label14);
            this.RentalCart.Controls.Add(this.label13);
            this.RentalCart.Controls.Add(this.label12);
            this.RentalCart.Controls.Add(this.btnSave);
            this.RentalCart.Controls.Add(this.btnHome);
            this.RentalCart.Controls.Add(this.btnCancel);
            this.RentalCart.Controls.Add(this.dgvRentalCart);
            this.RentalCart.Location = new System.Drawing.Point(1, 361);
            this.RentalCart.Name = "RentalCart";
            this.RentalCart.Size = new System.Drawing.Size(1002, 323);
            this.RentalCart.TabIndex = 1;
            this.RentalCart.TabStop = false;
            this.RentalCart.Text = "Rental Cart";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(753, 215);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(234, 32);
            this.txtTotal.TabIndex = 24;
            // 
            // txtApplianceQuantity
            // 
            this.txtApplianceQuantity.Enabled = false;
            this.txtApplianceQuantity.Location = new System.Drawing.Point(755, 164);
            this.txtApplianceQuantity.Name = "txtApplianceQuantity";
            this.txtApplianceQuantity.Size = new System.Drawing.Size(232, 32);
            this.txtApplianceQuantity.TabIndex = 23;
            // 
            // DueDate
            // 
            this.DueDate.Enabled = false;
            this.DueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DueDate.Location = new System.Drawing.Point(755, 113);
            this.DueDate.Name = "DueDate";
            this.DueDate.Size = new System.Drawing.Size(232, 32);
            this.DueDate.TabIndex = 22;
            // 
            // StartDate
            // 
            this.StartDate.Enabled = false;
            this.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDate.Location = new System.Drawing.Point(755, 61);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(232, 32);
            this.StartDate.TabIndex = 21;
            // 
            // txtRentalID
            // 
            this.txtRentalID.Enabled = false;
            this.txtRentalID.Location = new System.Drawing.Point(755, 7);
            this.txtRentalID.Name = "txtRentalID";
            this.txtRentalID.Size = new System.Drawing.Size(232, 32);
            this.txtRentalID.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(574, 167);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(170, 24);
            this.label16.TabIndex = 19;
            this.label16.Text = "Appliance Quantity";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(574, 218);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 24);
            this.label15.TabIndex = 18;
            this.label15.Text = "Total";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(574, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 24);
            this.label14.TabIndex = 17;
            this.label14.Text = "Due Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(574, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 24);
            this.label13.TabIndex = 16;
            this.label13.Text = "Start Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(574, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 24);
            this.label12.TabIndex = 15;
            this.label12.Text = "RentalID";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(148)))), ((int)(((byte)(158)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(722, 261);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 41);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save Order";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(148)))), ((int)(((byte)(158)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(861, 261);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(126, 41);
            this.btnHome.TabIndex = 13;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(148)))), ((int)(((byte)(158)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(578, 261);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 41);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel Order";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvRentalCart
            // 
            this.dgvRentalCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentalCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cancel,
            this.ApplianceID,
            this.ApplianceName,
            this.UnitPrice,
            this.Duration,
            this.RentalFee});
            this.dgvRentalCart.Location = new System.Drawing.Point(0, 31);
            this.dgvRentalCart.Name = "dgvRentalCart";
            this.dgvRentalCart.RowHeadersWidth = 51;
            this.dgvRentalCart.RowTemplate.Height = 24;
            this.dgvRentalCart.Size = new System.Drawing.Size(568, 271);
            this.dgvRentalCart.TabIndex = 11;
            this.dgvRentalCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRentalCart_CellContentClick);
            // 
            // Cancel
            // 
            this.Cancel.DataPropertyName = "Cancel";
            this.Cancel.HeaderText = "Cancel";
            this.Cancel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Cancel.MinimumWidth = 6;
            this.Cancel.Name = "Cancel";
            this.Cancel.Width = 70;
            // 
            // ApplianceID
            // 
            this.ApplianceID.DataPropertyName = "ApplianceID";
            this.ApplianceID.HeaderText = "ApplianceID";
            this.ApplianceID.MinimumWidth = 6;
            this.ApplianceID.Name = "ApplianceID";
            this.ApplianceID.Width = 110;
            // 
            // ApplianceName
            // 
            this.ApplianceName.DataPropertyName = "ApplianceName";
            this.ApplianceName.HeaderText = "ApplianceName";
            this.ApplianceName.MinimumWidth = 6;
            this.ApplianceName.Name = "ApplianceName";
            this.ApplianceName.Width = 110;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "UnitPrice";
            this.UnitPrice.MinimumWidth = 6;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Width = 75;
            // 
            // Duration
            // 
            this.Duration.DataPropertyName = "Duration";
            this.Duration.HeaderText = "Duration";
            this.Duration.MinimumWidth = 6;
            this.Duration.Name = "Duration";
            this.Duration.Width = 75;
            // 
            // RentalFee
            // 
            this.RentalFee.DataPropertyName = "RentalFee";
            this.RentalFee.HeaderText = "RentalFee";
            this.RentalFee.MinimumWidth = 6;
            this.RentalFee.Name = "RentalFee";
            this.RentalFee.Width = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appliance Search";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbApplianceID);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnAddCart);
            this.panel1.Controls.Add(this.lbRentalFee);
            this.panel1.Controls.Add(this.lbTypicalUse);
            this.panel1.Controls.Add(this.lbDimension);
            this.panel1.Controls.Add(this.lbBrandName);
            this.panel1.Controls.Add(this.lbApplianceCategory);
            this.panel1.Controls.Add(this.lbApplianceName);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cboRentalMonth);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.ApplianceImage);
            this.panel1.Controls.Add(this.dgvApplianceSearch);
            this.panel1.Controls.Add(this.cboAppliance);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 354);
            this.panel1.TabIndex = 2;
            // 
            // lbApplianceID
            // 
            this.lbApplianceID.AutoSize = true;
            this.lbApplianceID.Location = new System.Drawing.Point(578, 21);
            this.lbApplianceID.Name = "lbApplianceID";
            this.lbApplianceID.Size = new System.Drawing.Size(16, 24);
            this.lbApplianceID.TabIndex = 26;
            this.lbApplianceID.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "Appliance ID";
            // 
            // btnAddCart
            // 
            this.btnAddCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(148)))), ((int)(((byte)(158)))));
            this.btnAddCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCart.ForeColor = System.Drawing.Color.White;
            this.btnAddCart.Location = new System.Drawing.Point(845, 282);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(146, 52);
            this.btnAddCart.TabIndex = 24;
            this.btnAddCart.Text = "Add to Cart";
            this.btnAddCart.UseVisualStyleBackColor = false;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // lbRentalFee
            // 
            this.lbRentalFee.AutoSize = true;
            this.lbRentalFee.Location = new System.Drawing.Point(574, 270);
            this.lbRentalFee.Name = "lbRentalFee";
            this.lbRentalFee.Size = new System.Drawing.Size(16, 24);
            this.lbRentalFee.TabIndex = 22;
            this.lbRentalFee.Text = "-";
            // 
            // lbTypicalUse
            // 
            this.lbTypicalUse.AutoSize = true;
            this.lbTypicalUse.Location = new System.Drawing.Point(574, 219);
            this.lbTypicalUse.Name = "lbTypicalUse";
            this.lbTypicalUse.Size = new System.Drawing.Size(16, 24);
            this.lbTypicalUse.TabIndex = 21;
            this.lbTypicalUse.Text = "-";
            // 
            // lbDimension
            // 
            this.lbDimension.AutoSize = true;
            this.lbDimension.Location = new System.Drawing.Point(574, 319);
            this.lbDimension.Name = "lbDimension";
            this.lbDimension.Size = new System.Drawing.Size(16, 24);
            this.lbDimension.TabIndex = 20;
            this.lbDimension.Text = "-";
            // 
            // lbBrandName
            // 
            this.lbBrandName.AutoSize = true;
            this.lbBrandName.Location = new System.Drawing.Point(574, 168);
            this.lbBrandName.Name = "lbBrandName";
            this.lbBrandName.Size = new System.Drawing.Size(16, 24);
            this.lbBrandName.TabIndex = 19;
            this.lbBrandName.Text = "-";
            // 
            // lbApplianceCategory
            // 
            this.lbApplianceCategory.AutoSize = true;
            this.lbApplianceCategory.Location = new System.Drawing.Point(574, 122);
            this.lbApplianceCategory.Name = "lbApplianceCategory";
            this.lbApplianceCategory.Size = new System.Drawing.Size(16, 24);
            this.lbApplianceCategory.TabIndex = 18;
            this.lbApplianceCategory.Text = "-";
            // 
            // lbApplianceName
            // 
            this.lbApplianceName.AutoSize = true;
            this.lbApplianceName.Location = new System.Drawing.Point(574, 73);
            this.lbApplianceName.Name = "lbApplianceName";
            this.lbApplianceName.Size = new System.Drawing.Size(16, 24);
            this.lbApplianceName.TabIndex = 17;
            this.lbApplianceName.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(751, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(236, 24);
            this.label11.TabIndex = 16;
            this.label11.Text = "Choose Your Rental Month";
            // 
            // cboRentalMonth
            // 
            this.cboRentalMonth.FormattingEnabled = true;
            this.cboRentalMonth.Items.AddRange(new object[] {
            "Choose your rental month",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboRentalMonth.Location = new System.Drawing.Point(755, 232);
            this.cboRentalMonth.Name = "cboRentalMonth";
            this.cboRentalMonth.Size = new System.Drawing.Size(236, 32);
            this.cboRentalMonth.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(751, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 24);
            this.label10.TabIndex = 14;
            this.label10.Text = "Image";
            // 
            // ApplianceImage
            // 
            this.ApplianceImage.BackColor = System.Drawing.Color.White;
            this.ApplianceImage.Location = new System.Drawing.Point(755, 35);
            this.ApplianceImage.Name = "ApplianceImage";
            this.ApplianceImage.Size = new System.Drawing.Size(236, 154);
            this.ApplianceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ApplianceImage.TabIndex = 13;
            this.ApplianceImage.TabStop = false;
            // 
            // dgvApplianceSearch
            // 
            this.dgvApplianceSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplianceSearch.Location = new System.Drawing.Point(15, 73);
            this.dgvApplianceSearch.Name = "dgvApplianceSearch";
            this.dgvApplianceSearch.ReadOnly = true;
            this.dgvApplianceSearch.RowHeadersWidth = 51;
            this.dgvApplianceSearch.RowTemplate.Height = 24;
            this.dgvApplianceSearch.Size = new System.Drawing.Size(390, 278);
            this.dgvApplianceSearch.TabIndex = 4;
            this.dgvApplianceSearch.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvApplianceSearch_CellMouseClick);
            // 
            // cboAppliance
            // 
            this.cboAppliance.FormattingEnabled = true;
            this.cboAppliance.Location = new System.Drawing.Point(15, 35);
            this.cboAppliance.Name = "cboAppliance";
            this.cboAppliance.Size = new System.Drawing.Size(390, 32);
            this.cboAppliance.TabIndex = 3;
            this.cboAppliance.SelectedIndexChanged += new System.EventHandler(this.cboAppliance_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(420, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 24);
            this.label9.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Appliance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Typical useage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dimension";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(420, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "Brand Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rental Fee";
            // 
            // RentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(230)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RentalCart);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RentalForm";
            this.Text = "RentalForm";
            this.RentalCart.ResumeLayout(false);
            this.RentalCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalCart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ApplianceImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplianceSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RentalCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvApplianceSearch;
        private System.Windows.Forms.ComboBox cboAppliance;
        private System.Windows.Forms.PictureBox ApplianceImage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Label lbRentalFee;
        private System.Windows.Forms.Label lbTypicalUse;
        private System.Windows.Forms.Label lbDimension;
        private System.Windows.Forms.Label lbBrandName;
        private System.Windows.Forms.Label lbApplianceCategory;
        private System.Windows.Forms.Label lbApplianceName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboRentalMonth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvRentalCart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbApplianceID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtApplianceQuantity;
        private System.Windows.Forms.DateTimePicker DueDate;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.TextBox txtRentalID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewImageColumn Cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplianceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplianceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalFee;
    }
}