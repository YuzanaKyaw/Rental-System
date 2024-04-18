
namespace HomeApplianceReantalSystem
{
    partial class RentalReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoAllData = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvRentalReport = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvRentalApplianceDetail = new System.Windows.Forms.DataGridView();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.lbRentalId = new System.Windows.Forms.Label();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.lbDueDate = new System.Windows.Forms.Label();
            this.lbTotalFee = new System.Windows.Forms.Label();
            this.rdoDate = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalApplianceDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(148)))), ((int)(((byte)(158)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 59);
            this.panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(16, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 40);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "RENTAL REPORT";
            // 
            // rdoAllData
            // 
            this.rdoAllData.AutoSize = true;
            this.rdoAllData.Location = new System.Drawing.Point(12, 73);
            this.rdoAllData.Name = "rdoAllData";
            this.rdoAllData.Size = new System.Drawing.Size(156, 28);
            this.rdoAllData.TabIndex = 1;
            this.rdoAllData.TabStop = true;
            this.rdoAllData.Text = "All Rental Data";
            this.rdoAllData.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(148)))), ((int)(((byte)(158)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(827, 95);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 49);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sarch all data:";
            // 
            // StartDate
            // 
            this.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDate.Location = new System.Drawing.Point(283, 106);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(200, 32);
            this.StartDate.TabIndex = 6;
            // 
            // endDate
            // 
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDate.Location = new System.Drawing.Point(566, 106);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 32);
            this.endDate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "From";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(510, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "to";
            // 
            // dgvRentalReport
            // 
            this.dgvRentalReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentalReport.Location = new System.Drawing.Point(16, 168);
            this.dgvRentalReport.Name = "dgvRentalReport";
            this.dgvRentalReport.RowHeadersWidth = 51;
            this.dgvRentalReport.RowTemplate.Height = 24;
            this.dgvRentalReport.Size = new System.Drawing.Size(573, 502);
            this.dgvRentalReport.TabIndex = 11;
            this.dgvRentalReport.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRentalReport_CellMouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(593, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "Detail Info";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(595, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Rental ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(593, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Customer Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(595, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "Rental Appliances Details:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(593, 530);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 24);
            this.label10.TabIndex = 16;
            this.label10.Text = "Start Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(593, 586);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 24);
            this.label11.TabIndex = 17;
            this.label11.Text = "Due Date:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(595, 639);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 24);
            this.label12.TabIndex = 18;
            this.label12.Text = "Total Fee:";
            // 
            // dgvRentalApplianceDetail
            // 
            this.dgvRentalApplianceDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentalApplianceDetail.Location = new System.Drawing.Point(599, 332);
            this.dgvRentalApplianceDetail.Name = "dgvRentalApplianceDetail";
            this.dgvRentalApplianceDetail.RowHeadersWidth = 51;
            this.dgvRentalApplianceDetail.RowTemplate.Height = 24;
            this.dgvRentalApplianceDetail.Size = new System.Drawing.Size(389, 174);
            this.dgvRentalApplianceDetail.TabIndex = 19;
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Location = new System.Drawing.Point(751, 530);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(16, 24);
            this.lbStartDate.TabIndex = 20;
            this.lbStartDate.Text = "-";
            // 
            // lbRentalId
            // 
            this.lbRentalId.AutoSize = true;
            this.lbRentalId.Location = new System.Drawing.Point(750, 209);
            this.lbRentalId.Name = "lbRentalId";
            this.lbRentalId.Size = new System.Drawing.Size(16, 24);
            this.lbRentalId.TabIndex = 21;
            this.lbRentalId.Text = "-";
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Location = new System.Drawing.Point(751, 254);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(16, 24);
            this.lbCustomerName.TabIndex = 22;
            this.lbCustomerName.Text = "-";
            // 
            // lbDueDate
            // 
            this.lbDueDate.AutoSize = true;
            this.lbDueDate.Location = new System.Drawing.Point(751, 586);
            this.lbDueDate.Name = "lbDueDate";
            this.lbDueDate.Size = new System.Drawing.Size(16, 24);
            this.lbDueDate.TabIndex = 23;
            this.lbDueDate.Text = "-";
            // 
            // lbTotalFee
            // 
            this.lbTotalFee.AutoSize = true;
            this.lbTotalFee.Location = new System.Drawing.Point(751, 639);
            this.lbTotalFee.Name = "lbTotalFee";
            this.lbTotalFee.Size = new System.Drawing.Size(16, 24);
            this.lbTotalFee.TabIndex = 24;
            this.lbTotalFee.Text = "-";
            // 
            // rdoDate
            // 
            this.rdoDate.AutoSize = true;
            this.rdoDate.Location = new System.Drawing.Point(220, 72);
            this.rdoDate.Name = "rdoDate";
            this.rdoDate.Size = new System.Drawing.Size(199, 28);
            this.rdoDate.TabIndex = 25;
            this.rdoDate.TabStop = true;
            this.rdoDate.Text = "Search Data by Date";
            this.rdoDate.UseVisualStyleBackColor = true;
            // 
            // RentalReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(230)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.rdoDate);
            this.Controls.Add(this.lbTotalFee);
            this.Controls.Add(this.lbDueDate);
            this.Controls.Add(this.lbCustomerName);
            this.Controls.Add(this.lbRentalId);
            this.Controls.Add(this.lbStartDate);
            this.Controls.Add(this.dgvRentalApplianceDetail);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvRentalReport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.rdoAllData);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RentalReport";
            this.Text = "RentalReport";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalApplianceDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoAllData;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvRentalReport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvRentalApplianceDetail;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.Label lbRentalId;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.Label lbDueDate;
        private System.Windows.Forms.Label lbTotalFee;
        private System.Windows.Forms.RadioButton rdoDate;
        private System.Windows.Forms.Button btnBack;
    }
}