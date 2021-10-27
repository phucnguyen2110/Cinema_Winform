using GUI.DAO;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI.frmAdminUserControls
{
    public partial class StaffUC : UserControl
    {
        BindingSource staffList = new BindingSource();

        public StaffUC()
        {
            InitializeComponent();
            LoadStaff();
        }
        void LoadStaff()
        {
            dtgvStaff.DataSource = staffList;
            LoadStaffList();
            AddStaffBinding();
        }

        void LoadStaffList()
        {
            staffList.DataSource = StaffDAO.GetListStaff();
        }

        private void btnShowStaff_Click(object sender, EventArgs e)
        {
            LoadStaffList();
        }
        void AddStaffBinding()
        {
            txtStaffId.DataBindings.Add("Text", dtgvStaff.DataSource, "Mã nhân viên", true, DataSourceUpdateMode.Never);
            txtStaffName.DataBindings.Add("Text", dtgvStaff.DataSource, "Họ tên", true, DataSourceUpdateMode.Never);
            txtStaffBirth.DataBindings.Add("Text", dtgvStaff.DataSource, "Ngày sinh", true, DataSourceUpdateMode.Never);
            txtStaffAddress.DataBindings.Add("Text", dtgvStaff.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never);
            txtStaffPhone.DataBindings.Add("Text", dtgvStaff.DataSource, "SĐT", true, DataSourceUpdateMode.Never);
            txtStaffINumber.DataBindings.Add("Text", dtgvStaff.DataSource, "CMND", true, DataSourceUpdateMode.Never);

        }


        //Thêm Staff
        void AddStaff(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, int cmnd)
        {
            if (StaffDAO.InsertStaff(id, hoTen, ngaySinh, diaChi, sdt, cmnd))
            {
                MessageBox.Show("Thêm nhân viên thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            if (txtStaffName.Text == "" || txtStaffBirth.Text=="" || txtStaffPhone.Text == "" || txtStaffAddress.Text == "" 
                || txtStaffPhone.ForeColor == Color.Red || txtStaffINumber.ForeColor==Color.Red)
            {
                MessageBox.Show("Bạn nhập sai Thông Tin hoặc thiếu Thông Tin\n" +
                    "Số điện thoại vượt quá 10 số hoặc chưa đủ 10 số\nPhải bắt đầu bằng số 0 hoặc +84\n" +
                    "Vd:0123456789 || +84123456789\nMời bạn Kiểm tra lại Thông Tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //DialogResult = DialogResult.None;

            }
            else
            {
                string staffId = txtStaffId.Text;
                string staffName = chuan_xau(txtStaffName.Text);
                DateTime staffBirth = DateTime.Parse(txtStaffBirth.Text);
                string staffAddress = chuan_xau(txtStaffAddress.Text);
                string staffPhone = txtStaffPhone.Text;
                int staffINumber = Int32.Parse(txtStaffINumber.Text);
                AddStaff(staffId, staffName, staffBirth, staffAddress, staffPhone, staffINumber);
                LoadStaffList();
            }
        }

        //Sửa Staff
        void UpdateStaff(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, int cmnd)
        {
            if (StaffDAO.UpdateStaff(id, hoTen, ngaySinh, diaChi, sdt, cmnd))
            {
                MessageBox.Show("Sửa nhân viên thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sửa nhân viên thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            string staffId = txtStaffId.Text;
            string staffName = chuan_xau(txtStaffName.Text);
            DateTime staffBirth = DateTime.Parse(txtStaffBirth.Text);
            string staffAddress = chuan_xau(txtStaffAddress.Text);
            string staffPhone = txtStaffPhone.Text;
            int staffINumber = Int32.Parse(txtStaffINumber.Text);
            UpdateStaff(staffId, staffName, staffBirth, staffAddress, staffPhone, staffINumber);
            LoadStaffList();
        }

        //Xóa Staff
        void DeleteStaff(string id)
        {
            if (StaffDAO.DeleteStaff(id))
            {
                MessageBox.Show("Xóa nhân viên thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            string staffId = txtStaffId.Text;
            DeleteStaff(staffId);
            LoadStaffList();
        }

        //Tìm kiếm Staff
        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            string staffName = chuan_xau(txtSearchStaff.Text);
            DataTable staffSearchList = StaffDAO.SearchStaffByName(staffName);
            staffList.DataSource = staffSearchList;
        }

        private void txtSearchStaff_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchStaff.PerformClick();
                e.SuppressKeyPress = true;//Tắt tiếng *ting của windows
            }
        }
        private string chuan_xau(string xau)
        {
            string kq = "";
            xau = xau.Trim().ToLower();//Phải đổi sang Unicode thì sử dụng .ToLower() không bị lỗi font
            for (int i = 0; i < xau.Length; i++)
            {
                if (i == 0)
                    kq += xau[i].ToString().ToUpper();
                else
                    kq += xau[i];
                if (xau[i] == ' ')
                {
                    while (xau[i] == ' ')
                    {
                        i++;
                    }
                    kq += xau[i].ToString().ToUpper();
                }
            }
            return kq.ToString();
        }
        private void txtStaffName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ràng buộc nhập tên
            e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122 || e.KeyChar == (char)32 ||
                e.KeyChar == (char)8) || char.IsLetter(e.KeyChar));
        }

        private void txtStaffPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar == (char)16)) //&& e.KeyChar == (char)43
            {
                e.Handled = true;
            }
        }

        private void txtStaffPhone_TextChanged(object sender, EventArgs e)
        {
            string phone = txtStaffPhone.Text;
            Regex regex = new Regex(@"^(^[0][1-9]\d{8}$)+$");
            Regex regex1 = new Regex(@"^(^[+][8][4][1-9]\d{8}$)+$");
            Match match = regex.Match(phone);
            Match match1 = regex1.Match(phone);
            if (match.Success || match1.Success)
            {
                txtStaffPhone.ForeColor = Color.Green;
            }
            else
            {
                txtStaffPhone.ForeColor = Color.Red;
            }
        }

        private void txtStaffINumber_TextChanged(object sender, EventArgs e)
        {
            string inu = txtStaffINumber.Text;
            Regex regex = new Regex(@"^(^\d{12}$)+$");
            Regex regex1 = new Regex(@"^(^\d{9}$)+$");
            Match match = regex.Match(inu);
            Match match1 = regex1.Match(inu);
            if (match.Success || match1.Success)
            {
                txtStaffINumber.ForeColor = Color.Green;
            }
            else
            {
                txtStaffINumber.ForeColor = Color.Red;
            }
        }
    }
}
