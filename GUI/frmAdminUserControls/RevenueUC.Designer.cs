namespace GUI.frmAdminUserControls
{
    partial class RevenueUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSelectMovie = new System.Windows.Forms.Label();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvRevenue = new System.Windows.Forms.DataGridView();
            this.btnReportRevenue = new System.Windows.Forms.Button();
            this.cboSelectMovie = new System.Windows.Forms.ComboBox();
            this.dtmToDate = new System.Windows.Forms.DateTimePicker();
            this.dtmFromDate = new System.Windows.Forms.DateTimePicker();
            this.btnShowRevenue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectMovie
            // 
            this.lblSelectMovie.AutoSize = true;
            this.lblSelectMovie.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectMovie.Location = new System.Drawing.Point(358, 16);
            this.lblSelectMovie.Name = "lblSelectMovie";
            this.lblSelectMovie.Size = new System.Drawing.Size(106, 23);
            this.lblSelectMovie.TabIndex = 39;
            this.lblSelectMovie.Text = "Chọn phim:";
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDoanhThu.ForeColor = System.Drawing.Color.Red;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(876, 540);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(147, 23);
            this.lblTongDoanhThu.TabIndex = 38;
            this.lblTongDoanhThu.Text = "Tổng doanh thu:";
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDoanhThu.Enabled = false;
            this.txtDoanhThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoanhThu.Location = new System.Drawing.Point(1046, 538);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.Size = new System.Drawing.Size(235, 30);
            this.txtDoanhThu.TabIndex = 37;
            this.txtDoanhThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenNgay.Location = new System.Drawing.Point(647, 62);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(96, 23);
            this.lblDenNgay.TabIndex = 36;
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 35;
            this.label1.Text = "Từ ngày:";
            // 
            // dtgvRevenue
            // 
            this.dtgvRevenue.AllowUserToAddRows = false;
            this.dtgvRevenue.AllowUserToDeleteRows = false;
            this.dtgvRevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvRevenue.BackgroundColor = System.Drawing.Color.White;
            this.dtgvRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRevenue.Location = new System.Drawing.Point(248, 101);
            this.dtgvRevenue.Name = "dtgvRevenue";
            this.dtgvRevenue.ReadOnly = true;
            this.dtgvRevenue.RowHeadersWidth = 51;
            this.dtgvRevenue.Size = new System.Drawing.Size(1033, 421);
            this.dtgvRevenue.TabIndex = 34;
            // 
            // btnReportRevenue
            // 
            this.btnReportRevenue.AutoSize = true;
            this.btnReportRevenue.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnReportRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportRevenue.Location = new System.Drawing.Point(1079, 54);
            this.btnReportRevenue.Name = "btnReportRevenue";
            this.btnReportRevenue.Size = new System.Drawing.Size(107, 41);
            this.btnReportRevenue.TabIndex = 32;
            this.btnReportRevenue.Text = "Báo Cáo";
            this.btnReportRevenue.UseVisualStyleBackColor = false;
            this.btnReportRevenue.Click += new System.EventHandler(this.btnReportRevenue_Click);
            // 
            // cboSelectMovie
            // 
            this.cboSelectMovie.BackColor = System.Drawing.Color.White;
            this.cboSelectMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectMovie.FormattingEnabled = true;
            this.cboSelectMovie.Location = new System.Drawing.Point(483, 15);
            this.cboSelectMovie.Name = "cboSelectMovie";
            this.cboSelectMovie.Size = new System.Drawing.Size(379, 28);
            this.cboSelectMovie.TabIndex = 31;
            // 
            // dtmToDate
            // 
            this.dtmToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmToDate.Location = new System.Drawing.Point(760, 59);
            this.dtmToDate.Name = "dtmToDate";
            this.dtmToDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtmToDate.Size = new System.Drawing.Size(162, 27);
            this.dtmToDate.TabIndex = 29;
            // 
            // dtmFromDate
            // 
            this.dtmFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmFromDate.Location = new System.Drawing.Point(465, 59);
            this.dtmFromDate.Name = "dtmFromDate";
            this.dtmFromDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtmFromDate.Size = new System.Drawing.Size(156, 27);
            this.dtmFromDate.TabIndex = 30;
            // 
            // btnShowRevenue
            // 
            this.btnShowRevenue.AutoSize = true;
            this.btnShowRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnShowRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowRevenue.Location = new System.Drawing.Point(953, 54);
            this.btnShowRevenue.Name = "btnShowRevenue";
            this.btnShowRevenue.Size = new System.Drawing.Size(120, 41);
            this.btnShowRevenue.TabIndex = 33;
            this.btnShowRevenue.Text = "Thống kê";
            this.btnShowRevenue.UseVisualStyleBackColor = false;
            this.btnShowRevenue.Click += new System.EventHandler(this.btnShowRevenue_Click);
            // 
            // RevenueUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblSelectMovie);
            this.Controls.Add(this.lblTongDoanhThu);
            this.Controls.Add(this.txtDoanhThu);
            this.Controls.Add(this.lblDenNgay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvRevenue);
            this.Controls.Add(this.btnReportRevenue);
            this.Controls.Add(this.btnShowRevenue);
            this.Controls.Add(this.cboSelectMovie);
            this.Controls.Add(this.dtmToDate);
            this.Controls.Add(this.dtmFromDate);
            this.Name = "RevenueUC";
            this.Size = new System.Drawing.Size(1850, 753);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectMovie;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvRevenue;
        private System.Windows.Forms.Button btnReportRevenue;
        private System.Windows.Forms.Button btnShowRevenue;
        private System.Windows.Forms.ComboBox cboSelectMovie;
        private System.Windows.Forms.DateTimePicker dtmToDate;
        private System.Windows.Forms.DateTimePicker dtmFromDate;
    }
}
