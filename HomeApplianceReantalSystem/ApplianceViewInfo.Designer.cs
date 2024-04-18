
namespace HomeApplianceReantalSystem
{
    partial class ApplianceViewInfo
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
            this.dgvApplianceInfo = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.rdoCategorySearch = new System.Windows.Forms.RadioButton();
            this.rdoAvailable = new System.Windows.Forms.RadioButton();
            this.cboCategorySearch = new System.Windows.Forms.ComboBox();
            this.cboAvailable = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.ApplianceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplianceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthlyFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinRentalMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypicalUsage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplianceInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvApplianceInfo
            // 
            this.dgvApplianceInfo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvApplianceInfo.ColumnHeadersHeight = 29;
            this.dgvApplianceInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ApplianceID,
            this.CategoryName,
            this.ApplianceName,
            this.BrandName,
            this.MonthlyFee,
            this.MinRentalMonth,
            this.Image,
            this.Length,
            this.Width,
            this.Height,
            this.TypicalUsage,
            this.Power});
            this.dgvApplianceInfo.Location = new System.Drawing.Point(3, 112);
            this.dgvApplianceInfo.Name = "dgvApplianceInfo";
            this.dgvApplianceInfo.RowHeadersWidth = 51;
            this.dgvApplianceInfo.RowTemplate.Height = 200;
            this.dgvApplianceInfo.Size = new System.Drawing.Size(994, 508);
            this.dgvApplianceInfo.TabIndex = 0;
            this.dgvApplianceInfo.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvApplianceInfo_CellMouseClick);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(148)))), ((int)(((byte)(158)))));
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(265, 626);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(168, 50);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create Appliance";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(148)))), ((int)(((byte)(158)))));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(468, 626);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(168, 50);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Home";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // rdoCategorySearch
            // 
            this.rdoCategorySearch.AutoSize = true;
            this.rdoCategorySearch.Location = new System.Drawing.Point(13, 13);
            this.rdoCategorySearch.Name = "rdoCategorySearch";
            this.rdoCategorySearch.Size = new System.Drawing.Size(190, 28);
            this.rdoCategorySearch.TabIndex = 4;
            this.rdoCategorySearch.TabStop = true;
            this.rdoCategorySearch.Text = "Search By Category";
            this.rdoCategorySearch.UseVisualStyleBackColor = true;
            // 
            // rdoAvailable
            // 
            this.rdoAvailable.AutoSize = true;
            this.rdoAvailable.Location = new System.Drawing.Point(387, 13);
            this.rdoAvailable.Name = "rdoAvailable";
            this.rdoAvailable.Size = new System.Drawing.Size(224, 28);
            this.rdoAvailable.TabIndex = 5;
            this.rdoAvailable.TabStop = true;
            this.rdoAvailable.Text = "Search By Un/Available";
            this.rdoAvailable.UseVisualStyleBackColor = true;
            // 
            // cboCategorySearch
            // 
            this.cboCategorySearch.FormattingEnabled = true;
            this.cboCategorySearch.Location = new System.Drawing.Point(13, 56);
            this.cboCategorySearch.Name = "cboCategorySearch";
            this.cboCategorySearch.Size = new System.Drawing.Size(302, 32);
            this.cboCategorySearch.TabIndex = 7;
            // 
            // cboAvailable
            // 
            this.cboAvailable.FormattingEnabled = true;
            this.cboAvailable.Items.AddRange(new object[] {
            "Choose options available or unavailabe",
            "Available",
            "Unavailable"});
            this.cboAvailable.Location = new System.Drawing.Point(387, 56);
            this.cboAvailable.Name = "cboAvailable";
            this.cboAvailable.Size = new System.Drawing.Size(302, 32);
            this.cboAvailable.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(148)))), ((int)(((byte)(158)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(725, 47);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 49);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(148)))), ((int)(((byte)(158)))));
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(869, 47);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(119, 49);
            this.btnShowAll.TabIndex = 9;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // ApplianceID
            // 
            this.ApplianceID.DataPropertyName = "ApplianceID";
            this.ApplianceID.HeaderText = "ApplianceID";
            this.ApplianceID.MinimumWidth = 6;
            this.ApplianceID.Name = "ApplianceID";
            this.ApplianceID.Width = 125;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "CategoryName";
            this.CategoryName.MinimumWidth = 6;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Width = 125;
            // 
            // ApplianceName
            // 
            this.ApplianceName.DataPropertyName = "ApplianceName";
            this.ApplianceName.HeaderText = "ApplianceName";
            this.ApplianceName.MinimumWidth = 6;
            this.ApplianceName.Name = "ApplianceName";
            this.ApplianceName.Width = 125;
            // 
            // BrandName
            // 
            this.BrandName.DataPropertyName = "BrandName";
            this.BrandName.HeaderText = "BrandName";
            this.BrandName.MinimumWidth = 6;
            this.BrandName.Name = "BrandName";
            this.BrandName.Width = 125;
            // 
            // MonthlyFee
            // 
            this.MonthlyFee.DataPropertyName = "MonthlyFee";
            this.MonthlyFee.HeaderText = "MonthlyFee";
            this.MonthlyFee.MinimumWidth = 6;
            this.MonthlyFee.Name = "MonthlyFee";
            this.MonthlyFee.Width = 125;
            // 
            // MinRentalMonth
            // 
            this.MinRentalMonth.DataPropertyName = "MinRentalMonth";
            this.MinRentalMonth.HeaderText = "MinRentalMonth";
            this.MinRentalMonth.MinimumWidth = 6;
            this.MinRentalMonth.Name = "MinRentalMonth";
            this.MinRentalMonth.Width = 125;
            // 
            // Image
            // 
            this.Image.DataPropertyName = "ApplianceImage";
            this.Image.HeaderText = "Image";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.Width = 125;
            // 
            // Length
            // 
            this.Length.DataPropertyName = "ApplianceLength";
            this.Length.HeaderText = "Length";
            this.Length.MinimumWidth = 6;
            this.Length.Name = "Length";
            this.Length.Width = 125;
            // 
            // Width
            // 
            this.Width.DataPropertyName = "ApplianceWidth";
            this.Width.HeaderText = "Width";
            this.Width.MinimumWidth = 6;
            this.Width.Name = "Width";
            this.Width.Width = 125;
            // 
            // Height
            // 
            this.Height.DataPropertyName = "ApplianceHeight";
            this.Height.HeaderText = "Height";
            this.Height.MinimumWidth = 6;
            this.Height.Name = "Height";
            this.Height.Width = 125;
            // 
            // TypicalUsage
            // 
            this.TypicalUsage.DataPropertyName = "TypicalUsage";
            this.TypicalUsage.HeaderText = "TypicalUsage";
            this.TypicalUsage.MinimumWidth = 6;
            this.TypicalUsage.Name = "TypicalUsage";
            this.TypicalUsage.Width = 125;
            // 
            // Power
            // 
            this.Power.DataPropertyName = "AppliancePower";
            this.Power.HeaderText = "Power";
            this.Power.MinimumWidth = 6;
            this.Power.Name = "Power";
            this.Power.Width = 125;
            // 
            // ApplianceViewInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(230)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.cboAvailable);
            this.Controls.Add(this.cboCategorySearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.rdoAvailable);
            this.Controls.Add(this.rdoCategorySearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dgvApplianceInfo);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ApplianceViewInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApplianceViewInfo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ApplianceViewInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplianceInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvApplianceInfo;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RadioButton rdoCategorySearch;
        private System.Windows.Forms.RadioButton rdoAvailable;
        private System.Windows.Forms.ComboBox cboCategorySearch;
        private System.Windows.Forms.ComboBox cboAvailable;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplianceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplianceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthlyFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinRentalMonth;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewTextBoxColumn Height;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypicalUsage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Power;
    }
}