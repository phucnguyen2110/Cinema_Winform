using GUI.DAO;
using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI.frmAdminUserControls
{
    public partial class CustomerUC : UserControl
    {
        BindingSource customerList = new BindingSource();
        public CustomerUC()
        {
            InitializeComponent();
            LoadCustomer();
        }

        void LoadCustomer()
        {
            dtgvCustomer.DataSource = customerList;
            LoadCustomerList();
            AddCustomerBinding();
        }

        void LoadCustomerList()
        {
            customerList.DataSource = CustomerDAO.GetListCustomer();
        }
        private void btnShowCustomer_Click(object sender, EventArgs e)
        {
            LoadCustomerList();
        }

        void AddCustomerBinding()
        {
            txtCusID.DataBindings.Add("Text", dtgvCustomer.DataSource, "Mã khách hàng", true, DataSourceUpdateMode.Never);
            txtCusName.DataBindings.Add("Text", dtgvCustomer.DataSource, "Họ tên", true, DataSourceUpdateMode.Never);
            txtCusBirth.DataBindings.Add("Text", dtgvCustomer.DataSource, "Ngày sinh", true, DataSourceUpdateMode.Never);
            txtCusAddress.DataBindings.Add("Text", dtgvCustomer.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never);
            txtCusPhone.DataBindings.Add("Text", dtgvCustomer.DataSource, "SĐT", true, DataSourceUpdateMode.Never);
            txtCusINumber.DataBindings.Add("Text", dtgvCustomer.DataSource, "CMND", true, DataSourceUpdateMode.Never);
            nudPoint.DataBindings.Add("Value", dtgvCustomer.DataSource, "Điểm tích lũy", true, DataSourceUpdateMode.Never);
        }

        void InsertCustomer(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, int cmnd)
        {
            if (CustomerDAO.InsertCustomer(id, hoTen, ngaySinh, diaChi, sdt, cmnd))
            {
                MessageBox.Show("Thêm khách hàng thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            //DialogResult = DialogResult.OK;
            if (txtCusName.Text == "" || txtCusBirth.Text == "" || txtCusAddress.Text == "" || txtCusINumber.Text=="" 
                || txtCusINumber.ForeColor == Color.Red || txtCusINumber.ForeColor==Color.Red)
            {
                MessageBox.Show("Bạn nhập sai Thông Tin hoặc thiếu Thông Tin\n" +
                    "Số điện thoại vượt quá 10 số hoặc chưa đủ 10 số\nPhải bắt đầu bằng số 0 hoặc +84\n" +
                    "Vd:0123456789 || +84123456789\nMời bạn Kiểm tra lại Thông Tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //DialogResult = DialogResult.None;

            }
            else
            {
                string cusID = txtCusID.Text;
                string cusName = chuan_xau(txtCusName.Text);
                DateTime cusBirth = DateTime.Parse(txtCusBirth.Text);
                string cusAddress = chuan_xau(txtCusAddress.Text);
                string cusPhone = txtCusPhone.Text;
                int cusINumber = Int32.Parse(txtCusINumber.Text);
                InsertCustomer(cusID, cusName, cusBirth, cusAddress, cusPhone, cusINumber);
                LoadCustomerList();
            }
        }

        void UpdateCustomer(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, int cmnd, int point)
        {
            if (CustomerDAO.UpdateCustomer(id, hoTen, ngaySinh, diaChi, sdt, cmnd, point))
            {
                MessageBox.Show("Sửa khách hàng thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sửa khách hàng thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            string cusID = txtCusID.Text;
            string cusName = chuan_xau(txtCusName.Text);
            DateTime cusBirth = DateTime.Parse(txtCusBirth.Text);
            string cusAddress = chuan_xau(txtCusAddress.Text);
            string cusPhone = txtCusPhone.Text;
            int cusINumber = Int32.Parse(txtCusINumber.Text);
            int cusPoint = (int)nudPoint.Value;
            UpdateCustomer(cusID, cusName, cusBirth, cusAddress, cusPhone, cusINumber, cusPoint);
            LoadCustomerList();
        }

        void DeleteCustomer(string id)
        {
            if (CustomerDAO.DeleteCustomer(id))
            {
                MessageBox.Show("Xóa khách hàng thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa khách hàng thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            string cusID = txtCusID.Text;
            DeleteCustomer(cusID);
            LoadCustomerList();
        }

        private void btnSearchCus_Click(object sender, EventArgs e)
        {
            string cusName = chuan_xau(txtSearchCus.Text);
            customerList.DataSource = CustomerDAO.SearchCustomerByName(cusName);
        }

		private void txtSearchCus_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnSearchCus.PerformClick();
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
        private void txtCusName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ràng buộc nhập tên
            e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122 || e.KeyChar == (char)32 ||
                e.KeyChar == (char)8) || char.IsLetter(e.KeyChar));
        }

        private void txtSearchCus_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ràng buộc nhập tên
            e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122 || e.KeyChar == (char)32 ||
                e.KeyChar == (char)8) || char.IsLetter(e.KeyChar));
        }

        private void txtCusPhone_TextChanged(object sender, EventArgs e)
        {
            string phone = txtCusPhone.Text;
            Regex regex = new Regex(@"^(^[0][1-9]\d{8}$)+$");
            Regex regex1 = new Regex(@"^(^[+][8][4][1-9]\d{8}$)+$");
            Match match = regex.Match(phone);
            Match match1 = regex1.Match(phone);
            if (match.Success || match1.Success)
            {
                txtCusPhone.ForeColor = Color.Green;
            }
            else
            {
                txtCusPhone.ForeColor = Color.Red;
            }
        }

        private void txtCusINumber_TextChanged(object sender, EventArgs e)
        {
            string inu = txtCusINumber.Text;
            Regex regex = new Regex(@"^(^\d{12}$)+$");
            Regex regex1 = new Regex(@"^(^\d{9}$)+$");
            Match match = regex.Match(inu);
            Match match1 = regex1.Match(inu);
            if (match.Success || match1.Success)
            {
                txtCusINumber.ForeColor = Color.Green;
            }
            else
            {
                txtCusINumber.ForeColor = Color.Red;
            }
        }
    }
}
