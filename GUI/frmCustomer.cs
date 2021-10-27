using GUI.DAO;
using GUI.DTO;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        public Customer customer;

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            DataTable data = CustomerDAO.GetCustomerMember(txtCustomerID.Text, chuan_xau(txtCustomerName.Text));

            if (data.Rows.Count == 0)
            {
                MessageBox.Show("ID hoặc Họ tên của Khách Hàng không chính xác!\nVui lòng nhập lại thông tin.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            customer = new Customer(data.Rows[0]);

            DialogResult = DialogResult.OK;
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
        private void txtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ràng buộc nhập tên
            e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122 || e.KeyChar == (char)32 ||
                e.KeyChar == (char)8) || char.IsLetter(e.KeyChar));
        }
    }
}
