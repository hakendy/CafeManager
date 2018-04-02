using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeManager.Views;
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;

namespace CafeManager
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        List<int> lt = new List<int>();
        private void navBarControl_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        {
            navigationFrame.SelectedPageIndex = navBarControl.Groups.IndexOf(e.Group);
            if (!lt.Contains(navigationFrame.SelectedPageIndex))
            {
                lt.Add(navigationFrame.SelectedPageIndex);
                switch (navigationFrame.SelectedPageIndex)
                {
                    case 0:
                        navigationFrame.Pages[navigationFrame.SelectedPageIndex].Controls.Add(new uscOrder() { Dock = DockStyle.Fill });
                        break;
                    case 1:
                        navigationFrame.Pages[navigationFrame.SelectedPageIndex].Controls.Add(new uscDScho() { Dock = DockStyle.Fill });
                        break;
                    case 2:
                        navigationFrame.Pages[navigationFrame.SelectedPageIndex].Controls.Add(new uscMenu() { Dock = DockStyle.Fill });
                        break;

                    default:
                        break;
                }
            }
        }

        private void barBtn_Exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            //frmLogin login = new frmLogin();
            //login.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            {
                //DialogResult result = MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                //if (result != DialogResult.OK)
                //{
                //    e.Cancel = true;
                //}
            }
        }

        private void btnQLHangHoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQLHangHoa qlhh = new frmQLHangHoa();
            qlhh.ShowDialog();
        }

        

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Hide();
            frm.ShowDialog();
        }

        private void btn_QLNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhanVien frmNhanVien = new frmNhanVien();
            frmNhanVien.ShowDialog();
        }

        private void btnQLBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQLBan frmQLBan = new frmQLBan();
            frmQLBan.ShowDialog();
        }
    }
}
