using GUI.DAO;
using GUI.DTO;
using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmAccountSettings : Form
    {
        Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }

        public frmAccountSettings(Account account)
        {
            InitializeComponent();

            LoginAccount = account;
        }

        void ChangeAccount(Account account)
        {
            txtStaffID.Text = account.StaffID.ToString();
            txtUsername.Text = account.UserName.ToString();
        }

        void ApplyChanges()
        {
            string username = txtUsername.Text;
            string newPass = txtNewPass.Text;
            string reEnterPass = txtReEnter.Text;
            string confirmPass = txtConfirmPass.Text;

            if (newPass != reEnterPass)
            {
                MessageBox.Show("Hai mật khẩu mới chưa trùng nhau!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (newPass == "")
            {
                MessageBox.Show("Mật khẩu không được để trống.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtNewPass.ForeColor == Color.Red)
            {
                MessageBox.Show("Mật khẩu bắt đầu bằng chữ in hoa A-Z _ có kí 1 tự đặc biệt và phải đủ 8 kí tự!", 
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (AccountDAO.UpdatePasswordForAccount(username, confirmPass, newPass))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            ApplyChanges();
        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            string pass = txtNewPass.Text;
            Regex regex = new Regex(@"^(^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$)+$");
            Match match = regex.Match(pass);
            if (match.Success)
            {
                txtNewPass.ForeColor = Color.Green;
            }
            else
            {
                txtNewPass.ForeColor = Color.Red;
            }
        }

        private void txtReEnter_TextChanged(object sender, EventArgs e)
        {
            string pass = txtReEnter.Text;
            Regex regex = new Regex(@"^(^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$)+$");
            Match match = regex.Match(pass);
            if (match.Success)
            {
                txtReEnter.ForeColor = Color.Green;
            }
            else
            {
                txtReEnter.ForeColor = Color.Red;
            }
        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPass.Checked)
            {
                txtNewPass.UseSystemPasswordChar = false;
                txtReEnter.UseSystemPasswordChar = false;
            }
            else
            {
                txtNewPass.UseSystemPasswordChar = true;
                txtReEnter.UseSystemPasswordChar = true;
            }
        }
    }
}
