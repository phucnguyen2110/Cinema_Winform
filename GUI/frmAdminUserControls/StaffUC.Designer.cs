namespace GUI.frmAdminUserControls
{
    partial class StaffUC
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
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.txtStaffId = new System.Windows.Forms.TextBox();
            this.txtStaffAddress = new System.Windows.Forms.TextBox();
            this.lblStaffINumber = new System.Windows.Forms.Label();
            this.lblStaffBirth = new System.Windows.Forms.Label();
            this.txtStaffPhone = new System.Windows.Forms.TextBox();
            this.lblStaffPhone = new System.Windows.Forms.Label();
            this.txtSearchStaff = new System.Windows.Forms.TextBox();
            this.txtStaffBirth = new System.Windows.Forms.TextBox();
            this.lblStaffAddress = new System.Windows.Forms.Label();
            this.txtStaffINumber = new System.Windows.Forms.TextBox();
            this.grpStaff = new System.Windows.Forms.GroupBox();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.dtgvStaff = new System.Windows.Forms.DataGridView();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnSearchStaff = new System.Windows.Forms.Button();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnUpdateStaff = new System.Windows.Forms.Button();
            this.btnShowStaff = new System.Windows.Forms.Button();
            this.grpStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStaffName
            // 
            this.txtStaffName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName.Location = new System.Drawing.Point(204, 66);
            this.txtStaffName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(191, 30);
            this.txtStaffName.TabIndex = 2;
            this.txtStaffName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStaffName_KeyPress);
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffID.ForeColor = System.Drawing.Color.Red;
            this.lblStaffID.Location = new System.Drawing.Point(94, 34);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(76, 23);
            this.lblStaffID.TabIndex = 4;
            this.lblStaffID.Text = "Mã NV:";
            // 
            // txtStaffId
            // 
            this.txtStaffId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffId.Location = new System.Drawing.Point(204, 27);
            this.txtStaffId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStaffId.Name = "txtStaffId";
            this.txtStaffId.Size = new System.Drawing.Size(191, 30);
            this.txtStaffId.TabIndex = 2;
            // 
            // txtStaffAddress
            // 
            this.txtStaffAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffAddress.Location = new System.Drawing.Point(629, 27);
            this.txtStaffAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStaffAddress.Name = "txtStaffAddress";
            this.txtStaffAddress.Size = new System.Drawing.Size(191, 30);
            this.txtStaffAddress.TabIndex = 2;
            // 
            // lblStaffINumber
            // 
            this.lblStaffINumber.AutoSize = true;
            this.lblStaffINumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffINumber.ForeColor = System.Drawing.Color.Red;
            this.lblStaffINumber.Location = new System.Drawing.Point(518, 106);
            this.lblStaffINumber.Name = "lblStaffINumber";
            this.lblStaffINumber.Size = new System.Drawing.Size(77, 23);
            this.lblStaffINumber.TabIndex = 4;
            this.lblStaffINumber.Text = "CMND:";
            // 
            // lblStaffBirth
            // 
            this.lblStaffBirth.AutoSize = true;
            this.lblStaffBirth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffBirth.ForeColor = System.Drawing.Color.Red;
            this.lblStaffBirth.Location = new System.Drawing.Point(94, 108);
            this.lblStaffBirth.Name = "lblStaffBirth";
            this.lblStaffBirth.Size = new System.Drawing.Size(99, 23);
            this.lblStaffBirth.TabIndex = 4;
            this.lblStaffBirth.Text = "Ngày sinh:";
            // 
            // txtStaffPhone
            // 
            this.txtStaffPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffPhone.Location = new System.Drawing.Point(629, 68);
            this.txtStaffPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStaffPhone.Name = "txtStaffPhone";
            this.txtStaffPhone.Size = new System.Drawing.Size(191, 30);
            this.txtStaffPhone.TabIndex = 2;
            this.txtStaffPhone.TextChanged += new System.EventHandler(this.txtStaffPhone_TextChanged);
            this.txtStaffPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStaffPhone_KeyPress);
            // 
            // lblStaffPhone
            // 
            this.lblStaffPhone.AutoSize = true;
            this.lblStaffPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffPhone.ForeColor = System.Drawing.Color.Red;
            this.lblStaffPhone.Location = new System.Drawing.Point(518, 68);
            this.lblStaffPhone.Name = "lblStaffPhone";
            this.lblStaffPhone.Size = new System.Drawing.Size(69, 23);
            this.lblStaffPhone.TabIndex = 4;
            this.lblStaffPhone.Text = "Số ĐT:";
            // 
            // txtSearchStaff
            // 
            this.txtSearchStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchStaff.Location = new System.Drawing.Point(998, 185);
            this.txtSearchStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchStaff.Name = "txtSearchStaff";
            this.txtSearchStaff.Size = new System.Drawing.Size(186, 26);
            this.txtSearchStaff.TabIndex = 21;
            this.txtSearchStaff.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchStaff_KeyDown);
            // 
            // txtStaffBirth
            // 
            this.txtStaffBirth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffBirth.Location = new System.Drawing.Point(204, 104);
            this.txtStaffBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStaffBirth.Name = "txtStaffBirth";
            this.txtStaffBirth.Size = new System.Drawing.Size(191, 30);
            this.txtStaffBirth.TabIndex = 2;
            // 
            // lblStaffAddress
            // 
            this.lblStaffAddress.AutoSize = true;
            this.lblStaffAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffAddress.ForeColor = System.Drawing.Color.Red;
            this.lblStaffAddress.Location = new System.Drawing.Point(518, 34);
            this.lblStaffAddress.Name = "lblStaffAddress";
            this.lblStaffAddress.Size = new System.Drawing.Size(75, 23);
            this.lblStaffAddress.TabIndex = 4;
            this.lblStaffAddress.Text = "Địa chỉ:";
            // 
            // txtStaffINumber
            // 
            this.txtStaffINumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffINumber.Location = new System.Drawing.Point(629, 106);
            this.txtStaffINumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStaffINumber.Name = "txtStaffINumber";
            this.txtStaffINumber.Size = new System.Drawing.Size(191, 30);
            this.txtStaffINumber.TabIndex = 2;
            this.txtStaffINumber.TextChanged += new System.EventHandler(this.txtStaffINumber_TextChanged);
            // 
            // grpStaff
            // 
            this.grpStaff.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grpStaff.Controls.Add(this.lblStaffID);
            this.grpStaff.Controls.Add(this.txtStaffId);
            this.grpStaff.Controls.Add(this.txtStaffAddress);
            this.grpStaff.Controls.Add(this.lblStaffINumber);
            this.grpStaff.Controls.Add(this.txtStaffName);
            this.grpStaff.Controls.Add(this.lblStaffBirth);
            this.grpStaff.Controls.Add(this.txtStaffPhone);
            this.grpStaff.Controls.Add(this.lblStaffPhone);
            this.grpStaff.Controls.Add(this.txtStaffBirth);
            this.grpStaff.Controls.Add(this.lblStaffAddress);
            this.grpStaff.Controls.Add(this.txtStaffINumber);
            this.grpStaff.Controls.Add(this.lblStaffName);
            this.grpStaff.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStaff.Location = new System.Drawing.Point(279, 18);
            this.grpStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStaff.Name = "grpStaff";
            this.grpStaff.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStaff.Size = new System.Drawing.Size(941, 145);
            this.grpStaff.TabIndex = 23;
            this.grpStaff.TabStop = false;
            this.grpStaff.Text = "Thông tin nhân viên";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.ForeColor = System.Drawing.Color.Red;
            this.lblStaffName.Location = new System.Drawing.Point(94, 75);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(73, 23);
            this.lblStaffName.TabIndex = 4;
            this.lblStaffName.Text = "Họ tên:";
            // 
            // dtgvStaff
            // 
            this.dtgvStaff.AllowUserToAddRows = false;
            this.dtgvStaff.AllowUserToDeleteRows = false;
            this.dtgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvStaff.BackgroundColor = System.Drawing.Color.White;
            this.dtgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStaff.Location = new System.Drawing.Point(279, 256);
            this.dtgvStaff.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvStaff.Name = "dtgvStaff";
            this.dtgvStaff.ReadOnly = true;
            this.dtgvStaff.RowHeadersWidth = 51;
            this.dtgvStaff.Size = new System.Drawing.Size(941, 377);
            this.dtgvStaff.TabIndex = 16;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.Image = global::GUI.Properties.Resources._218;
            this.btnAddStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStaff.Location = new System.Drawing.Point(536, 176);
            this.btnAddStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(138, 57);
            this.btnAddStaff.TabIndex = 20;
            this.btnAddStaff.Text = "      Thêm";
            this.btnAddStaff.UseVisualStyleBackColor = false;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnSearchStaff
            // 
            this.btnSearchStaff.BackColor = System.Drawing.Color.White;
            this.btnSearchStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStaff.Image = global::GUI.Properties.Resources._203;
            this.btnSearchStaff.Location = new System.Drawing.Point(1190, 185);
            this.btnSearchStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchStaff.Name = "btnSearchStaff";
            this.btnSearchStaff.Size = new System.Drawing.Size(30, 26);
            this.btnSearchStaff.TabIndex = 22;
            this.btnSearchStaff.UseVisualStyleBackColor = false;
            this.btnSearchStaff.Click += new System.EventHandler(this.btnSearchStaff_Click);
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDeleteStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStaff.Image = global::GUI.Properties.Resources._229;
            this.btnDeleteStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteStaff.Location = new System.Drawing.Point(691, 176);
            this.btnDeleteStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(133, 57);
            this.btnDeleteStaff.TabIndex = 18;
            this.btnDeleteStaff.Text = "      Xóa";
            this.btnDeleteStaff.UseVisualStyleBackColor = false;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnUpdateStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStaff.Image = global::GUI.Properties.Resources._238;
            this.btnUpdateStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateStaff.Location = new System.Drawing.Point(834, 176);
            this.btnUpdateStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Size = new System.Drawing.Size(139, 57);
            this.btnUpdateStaff.TabIndex = 19;
            this.btnUpdateStaff.Text = "      Sửa";
            this.btnUpdateStaff.UseVisualStyleBackColor = false;
            this.btnUpdateStaff.Click += new System.EventHandler(this.btnUpdateStaff_Click);
            // 
            // btnShowStaff
            // 
            this.btnShowStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnShowStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowStaff.Image = global::GUI.Properties.Resources._198;
            this.btnShowStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowStaff.Location = new System.Drawing.Point(279, 176);
            this.btnShowStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowStaff.Name = "btnShowStaff";
            this.btnShowStaff.Size = new System.Drawing.Size(154, 57);
            this.btnShowStaff.TabIndex = 17;
            this.btnShowStaff.Text = "      Xem";
            this.btnShowStaff.UseVisualStyleBackColor = false;
            this.btnShowStaff.Click += new System.EventHandler(this.btnShowStaff_Click);
            // 
            // StaffUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.btnSearchStaff);
            this.Controls.Add(this.txtSearchStaff);
            this.Controls.Add(this.btnDeleteStaff);
            this.Controls.Add(this.btnUpdateStaff);
            this.Controls.Add(this.grpStaff);
            this.Controls.Add(this.btnShowStaff);
            this.Controls.Add(this.dtgvStaff);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StaffUC";
            this.Size = new System.Drawing.Size(1850, 761);
            this.grpStaff.ResumeLayout(false);
            this.grpStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.TextBox txtStaffId;
        private System.Windows.Forms.TextBox txtStaffAddress;
        private System.Windows.Forms.Label lblStaffINumber;
        private System.Windows.Forms.Label lblStaffBirth;
        private System.Windows.Forms.TextBox txtStaffPhone;
        private System.Windows.Forms.Label lblStaffPhone;
        private System.Windows.Forms.Button btnSearchStaff;
        private System.Windows.Forms.TextBox txtSearchStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.TextBox txtStaffBirth;
        private System.Windows.Forms.Label lblStaffAddress;
        private System.Windows.Forms.TextBox txtStaffINumber;
        private System.Windows.Forms.GroupBox grpStaff;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Button btnShowStaff;
        private System.Windows.Forms.DataGridView dtgvStaff;
    }
}
