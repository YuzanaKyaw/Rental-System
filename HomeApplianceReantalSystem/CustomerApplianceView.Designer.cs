
namespace HomeApplianceReantalSystem
{
    partial class CustomerApplianceView
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
            this.dgvAppliances = new System.Windows.Forms.DataGridView();
            this.ApplianceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthlyFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinRentalMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplianceImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRentalForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.rdoNameSearch = new System.Windows.Forms.RadioButton();
            this.txtApplianceSearch = new System.Windows.Forms.TextBox();
            this.rdoCategorySearch = new System.Windows.Forms.RadioButton();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbNotFound = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppliances)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAppliances
            // 
            this.dgvAppliances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppliances.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ApplianceName,
            this.CategoryName,
            this.MonthlyFee,
            this.MinRentalMonth,
            this.ApplianceImage});
            this.dgvAppliances.Location = new System.Drawing.Point(0, 161);
            this.dgvAppliances.Name = "dgvAppliances";
            this.dgvAppliances.RowHeadersWidth = 51;
            this.dgvAppliances.RowTemplate.Height = 150;
            this.dgvAppliances.Size = new System.Drawing.Size(997, 510);
            this.dgvAppliances.TabIndex = 0;
            // 
            // ApplianceName
            // 
            this.ApplianceName.DataPropertyName = "ApplianceName";
            this.ApplianceName.HeaderText = "ApplianceName";
            this.ApplianceName.MinimumWidth = 6;
            this.ApplianceName.Name = "ApplianceName";
            this.ApplianceName.Width = 140;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "CategoroyName";
            this.CategoryName.MinimumWidth = 6;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Width = 140;
            // 
            // MonthlyFee
            // 
            this.MonthlyFee.DataPropertyName = "MonthlyFee";
            this.MonthlyFee.HeaderText = "MonthlyFee";
            this.MonthlyFee.MinimumWidth = 6;
            this.MonthlyFee.Name = "MonthlyFee";
            this.MonthlyFee.Width = 140;
            // 
            // MinRentalMonth
            // 
            this.MinRentalMonth.DataPropertyName = "MinRentalMonth";
            this.MinRentalMonth.HeaderText = "MinRentalMonth";
            this.MinRentalMonth.MinimumWidth = 6;
            this.MinRentalMonth.Name = "MinRentalMonth";
            this.MinRentalMonth.Width = 140;
            // 
            // ApplianceImage
            // 
            this.ApplianceImage.DataPropertyName = "ApplianceImage";
            this.ApplianceImage.HeaderText = "ApplianceImage";
            this.ApplianceImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ApplianceImage.MinimumWidth = 6;
            this.ApplianceImage.Name = "ApplianceImage";
            this.ApplianceImage.Width = 200;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(148)))), ((int)(((byte)(158)))));
            this.panel1.Controls.Add(this.btnRentalForm);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 54);
            this.panel1.TabIndex = 1;
            // 
            // btnRentalForm
            // 
            this.btnRentalForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentalForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentalForm.ForeColor = System.Drawing.Color.White;
            this.btnRentalForm.Location = new System.Drawing.Point(795, 8);
            this.btnRentalForm.Name = "btnRentalForm";
            this.btnRentalForm.Size = new System.Drawing.Size(193, 40);
            this.btnRentalForm.TabIndex = 2;
            this.btnRentalForm.Text = "Rental Appliances";
            this.btnRentalForm.UseVisualStyleBackColor = true;
            this.btnRentalForm.Click += new System.EventHandler(this.btnRentalForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appliance Data View";
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(12, 8);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(112, 40);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(403, 102);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(293, 32);
            this.cboCategory.TabIndex = 3;
            // 
            // rdoNameSearch
            // 
            this.rdoNameSearch.AutoSize = true;
            this.rdoNameSearch.Location = new System.Drawing.Point(13, 61);
            this.rdoNameSearch.Name = "rdoNameSearch";
            this.rdoNameSearch.Size = new System.Drawing.Size(253, 28);
            this.rdoNameSearch.TabIndex = 4;
            this.rdoNameSearch.TabStop = true;
            this.rdoNameSearch.Text = "Search by Appliance Name";
            this.rdoNameSearch.UseVisualStyleBackColor = true;
            // 
            // txtApplianceSearch
            // 
            this.txtApplianceSearch.Location = new System.Drawing.Point(13, 102);
            this.txtApplianceSearch.Name = "txtApplianceSearch";
            this.txtApplianceSearch.Size = new System.Drawing.Size(293, 32);
            this.txtApplianceSearch.TabIndex = 5;
            // 
            // rdoCategorySearch
            // 
            this.rdoCategorySearch.AutoSize = true;
            this.rdoCategorySearch.Location = new System.Drawing.Point(403, 61);
            this.rdoCategorySearch.Name = "rdoCategorySearch";
            this.rdoCategorySearch.Size = new System.Drawing.Size(244, 28);
            this.rdoCategorySearch.TabIndex = 6;
            this.rdoCategorySearch.TabStop = true;
            this.rdoCategorySearch.Text = "Search by Category Name";
            this.rdoCategorySearch.UseVisualStyleBackColor = true;
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(148)))), ((int)(((byte)(158)))));
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(862, 87);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(126, 47);
            this.btnShowAll.TabIndex = 7;
            this.btnShowAll.Text = "Show all";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(148)))), ((int)(((byte)(158)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(719, 87);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(126, 47);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbNotFound
            // 
            this.lbNotFound.AutoSize = true;
            this.lbNotFound.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotFound.Location = new System.Drawing.Point(377, 252);
            this.lbNotFound.Name = "lbNotFound";
            this.lbNotFound.Size = new System.Drawing.Size(346, 41);
            this.lbNotFound.TabIndex = 9;
            this.lbNotFound.Text = "There is no data found!";
            this.lbNotFound.Visible = false;
            // 
            // CustomerApplianceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(230)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.lbNotFound);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.rdoCategorySearch);
            this.Controls.Add(this.txtApplianceSearch);
            this.Controls.Add(this.rdoNameSearch);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvAppliances);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerApplianceView";
            this.Text = "CustomerApplianceView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppliances)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAppliances;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRentalForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.RadioButton rdoNameSearch;
        private System.Windows.Forms.TextBox txtApplianceSearch;
        private System.Windows.Forms.RadioButton rdoCategorySearch;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbNotFound;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplianceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthlyFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinRentalMonth;
        private System.Windows.Forms.DataGridViewImageColumn ApplianceImage;
    }
}