using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManager.Views
{
    public partial class uscMenu : DevExpress.XtraEditors.XtraUserControl
    {
        CafeDBDataContext db = new CafeDBDataContext();
        public uscMenu()
        {
            InitializeComponent();
        }

        private void uscMenu_Load(object sender, EventArgs e)
        {
            ShowLoaiHangHoa();
        }

        private void ShowLoaiHangHoa()
        {
            //lấy toàn bộ dữ liệu bảng loại hàng hóa (bằng thủ tục)
            var loaihanghoa = db.getAllLoaiHangHoa();
            //đọc dữ liệu lên treeview
            TreeNode root = new TreeNode("Danh mục menu", 0, 0);
            trvMenu.Nodes.Add(root);
            foreach (var l in loaihanghoa)
            {
                TreeNode child = new TreeNode(l.tenLoaiHangHoa, 1, 1);
                child.Tag = l.maLoaiHangHoa;
                root.Nodes.Add(child);
            }
            //mở cây
            trvMenu.ExpandAll();
        }

        private void trvMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lstMenu.Items.Clear();
            //lấy nút được chọn
            var node = e.Node;
            if (node != null && node.Tag != null)
            {
                string maloaihanghoa = (string)node.Tag;
                //lấy tất cả sinh viên của lớp đó (gọi thủ tục)
                var hanghoa = db.GetHangHoaByMaLoaiHangHoa(maloaihanghoa);
                foreach (var h in hanghoa)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = h.maHangHoa;
                    item.SubItems.Add(h.tenHangHoa);
                    item.SubItems.Add(h.kichThuoc);
                    item.SubItems.Add(h.soLuongTon.Value.ToString());
                    item.SubItems.Add(h.gia.ToString());
                    item.SubItems.Add(h.trangThai.Value.ToString());
                    
                    lstMenu.Items.Add(item);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstMenu.Items.Clear();
            //lấy nút được chọn
            var node = trvMenu.SelectedNode;
            if (node != null && node.Tag != null)
            {
                string maloaihanghoa = (string)node.Tag;
                //tìm sinh viên theo firstname (gọi thủ tục)
                var hanghoa = db.SearchHangHoa(txtSearch.Text);
                foreach (var h in hanghoa)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = h.maHangHoa;
                    item.SubItems.Add(h.tenHangHoa);
                    item.SubItems.Add(h.kichThuoc);
                    item.SubItems.Add(h.soLuongTon.Value.ToString());
                    item.SubItems.Add(h.gia.ToString());
                    item.SubItems.Add(h.trangThai.Value.ToString());
                    lstMenu.Items.Add(item);
                }
            }
        }
    }
}
