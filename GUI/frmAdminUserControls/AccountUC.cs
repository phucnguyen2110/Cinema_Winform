using GUI.DAO;
using GUI.DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUI.frmAdminUserControls
{
    public partial class AccountUC : UserControl
    {
        BindingSource accountList = new BindingSource();

        public AccountUC()
        {
            InitializeComponent();
            LoadAccount();
        }

        void LoadAccount()
        {
            dtgvAccount.DataSource = accountList;
            LoadAccountList();
            AddAccountBinding();
        }
        void LoadAccountList()
        {
            accountList.DataSource = AccountDAO.GetAccountList();
        }
        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccountList();
        }

        void AddAccountBinding()
        {
            txtUsername.DataBindings.Add("Text", dtgvAccount.DataSource, "Username", true, DataSourceUpdateMode.Never);
            nudAccountType.DataBindings.Add("Value", dtgvAccount.DataSource, "Loại tài khoản", true, DataSourceUpdateMode.Never);
            LoadStaffIntoComboBox(cboStaffID_Account);
        }
        void LoadStaffIntoComboBox(ComboBox cbo)
        {
            cbo.DataSource = StaffDAO.GetStaff();
            cbo.DisplayMember = "ID";
            cbo.ValueMember = "ID";
        }
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            string staffID = (string)dtgvAccount.SelectedCells[0].OwningRow.Cells["Mã nhân viên"].Value;
            Staff staff = StaffDAO.GetStaffByID(staffID);//The staff that we're currently selecting

            if (staff == null)
                //The case that nothing on dtgv - no result after searched
                return;

            cboStaffID_Account.SelectedItem = staff;

            int index = -1;
            int i = 0;
            foreach (Staff item in cboStaffID_Account.Items)
            {
                if (item.ID == staff.ID)
                {
                    index = i;
                    break;
                }
                i++;
            }
            cboStaffID_Account.SelectedIndex = index;
        }
        private void cboStaffID_Account_SelectedIndexChanged(object sender, EventArgs e)
        {
            Staff staff = cboStaffID_Account.SelectedItem as Staff;
            if (staff == null)
                return;
            txtStaffName_Account.Text = staff.Name;
        }

        void InsertAccount(string username, int accountType, string idStaff)
        {
            if (AccountDAO.InsertAccount(username, accountType, idStaff))
            {
                MessageBox.Show("Thêm tài khoản thành công, mật khẩu mặc định : 1", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnInsertAccount_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            int accountType = (int)nudAccountType.Value;
            string staffID = cboStaffID_Account.SelectedValue.ToString();
            InsertAccount(username, accountType, staffID);
            LoadAccountList();
        }

        void UpdateAccount(string username, int accountType)
        {
            if (AccountDAO.UpdateAccount(username, accountType))
            {
                MessageBox.Show("Sửa tài khoản thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sửa tài khoản thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            int accountType = (int)nudAccountType.Value;
            UpdateAccount(username, accountType);
            LoadAccountList();
        }

        void DeleteAccount(string username)
        {
            if (AccountDAO.DeleteAccount(username))
            {
                MessageBox.Show("Xóa tài khoản thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            DeleteAccount(username);
            LoadAccountList();
        }

        void ResetPassword(string username)
        {
            if (AccountDAO.ResetPassword(username))
            {
                MessageBox.Show("Reset mật khẩu thành công, mật khẩu mặc định : 1", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Reset mật khẩu thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnResetPass_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            ResetPassword(username);
            LoadAccountList();
        }

        private void btnSearchAccount_Click(object sender, EventArgs e)
        {
            string staffName = txtSearchAccount.Text;
            accountList.DataSource = AccountDAO.SearchAccountByStaffName(staffName);
        }

        private void txtSearchAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchAccount.PerformClick();
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
        /*private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ràng buộc nhập tên
            e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122 || e.KeyChar == (char)32 ||
                e.KeyChar == (char)8) || char.IsLetter(e.KeyChar));
        }*/

        private void txtStaffName_Account_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ràng buộc nhập tên
            e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122 || e.KeyChar == (char)32 ||
                e.KeyChar == (char)8) || char.IsLetter(e.KeyChar));
        }

        /*private void txtSearchAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ràng buộc nhập tên
            e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122 || e.KeyChar == (char)32 ||
                e.KeyChar == (char)8) || char.IsLetter(e.KeyChar));
        }*/
    }
}
