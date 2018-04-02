using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CafeManager.DAO;

namespace CafeManager
{
    public partial class frmLogin : DevExpress.XtraBars.TabForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //txtUserName.Focus();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string passWord = txtPassWord.Text;
            if (Login(userName, passWord))
            {
                frmMain main = new frmMain();
                this.Hide();
                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu.\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        public void resetForm()
        {
            txtUserName.Text = txtPassWord.Text = "";
            txtUserName.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult result = MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //if (result != DialogResult.OK)
            //{
            //    e.Cancel = true;
            //}
        }
    }
}