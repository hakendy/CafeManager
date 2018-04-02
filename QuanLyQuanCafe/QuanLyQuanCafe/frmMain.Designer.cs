namespace CafeManager
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_PhanQuyen = new DevExpress.XtraBars.BarButtonItem();
            this.btn_QLNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLHangHoa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_Exit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLBan = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.page_HeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnMenu = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage3 = new DevExpress.XtraBars.Navigation.NavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btn_PhanQuyen,
            this.btn_QLNhanVien,
            this.btnQLHangHoa,
            this.barButtonItem2,
            this.barButtonItem3,
            this.btn_DoiMatKhau,
            this.btnLogout,
            this.barBtn_Exit,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem5,
            this.btnQLBan});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 17;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1});
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.page_HeThong,
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.Size = new System.Drawing.Size(1127, 185);
            // 
            // btn_PhanQuyen
            // 
            this.btn_PhanQuyen.Caption = "Phân quyền";
            this.btn_PhanQuyen.Id = 3;
            this.btn_PhanQuyen.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_PhanQuyen.ImageOptions.LargeImage")));
            this.btn_PhanQuyen.Name = "btn_PhanQuyen";
            // 
            // btn_QLNhanVien
            // 
            this.btn_QLNhanVien.Caption = "Quản lý nhân viên";
            this.btn_QLNhanVien.Id = 4;
            this.btn_QLNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_QLNhanVien.ImageOptions.Image")));
            this.btn_QLNhanVien.Name = "btn_QLNhanVien";
            this.btn_QLNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_QLNhanVien_ItemClick);
            // 
            // btnQLHangHoa
            // 
            this.btnQLHangHoa.Caption = "Quản lý hàng hóa";
            this.btnQLHangHoa.Id = 5;
            this.btnQLHangHoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLHangHoa.ImageOptions.Image")));
            this.btnQLHangHoa.Name = "btnQLHangHoa";
            this.btnQLHangHoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLHangHoa_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Nhật ký";
            this.barButtonItem2.Id = 6;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Thêm tài khoản";
            this.barButtonItem3.Id = 7;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // btn_DoiMatKhau
            // 
            this.btn_DoiMatKhau.Caption = "Đổi mật khẩu";
            this.btn_DoiMatKhau.Id = 8;
            this.btn_DoiMatKhau.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DoiMatKhau.ImageOptions.LargeImage")));
            this.btn_DoiMatKhau.Name = "btn_DoiMatKhau";
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Đăng xuất";
            this.btnLogout.Id = 9;
            this.btnLogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.Image")));
            this.btnLogout.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.LargeImage")));
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // barBtn_Exit
            // 
            this.barBtn_Exit.Caption = "Thoát";
            this.barBtn_Exit.Id = 10;
            this.barBtn_Exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtn_Exit.ImageOptions.Image")));
            this.barBtn_Exit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtn_Exit.ImageOptions.LargeImage")));
            this.barBtn_Exit.Name = "barBtn_Exit";
            this.barBtn_Exit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_Exit_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Hóa đơn";
            this.barButtonItem6.Id = 12;
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Chứng từ";
            this.barButtonItem7.Id = 13;
            this.barButtonItem7.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.LargeImage")));
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Order";
            this.barButtonItem8.Id = 14;
            this.barButtonItem8.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.LargeImage")));
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Doanh Thu";
            this.barButtonItem5.Id = 15;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // btnQLBan
            // 
            this.btnQLBan.Caption = "Quản lí bàn";
            this.btnQLBan.Id = 16;
            this.btnQLBan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLBan.ImageOptions.Image")));
            this.btnQLBan.Name = "btnQLBan";
            this.btnQLBan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLBan_ItemClick);
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Text = "ribbonPageCategory1";
            // 
            // page_HeThong
            // 
            this.page_HeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.page_HeThong.Name = "page_HeThong";
            this.page_HeThong.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_PhanQuyen);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Bảo mật";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_DoiMatKhau);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnLogout);
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtn_Exit);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Tải khoản";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản lý";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_QLNhanVien);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnQLHangHoa);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnQLBan);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Quản lý";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Công nợ";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Danh mục";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Đặt hàng";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Báo Cáo";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Báo Cáo";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Coffee";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "ORDER";
            this.navBarGroup1.LargeImage = global::CafeManager.Properties.Resources.Break_48;
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "DANH SÁCH CHỜ ";
            this.navBarGroup2.LargeImage = global::CafeManager.Properties.Resources.Waiter_48px;
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // btnMenu
            // 
            this.btnMenu.Caption = "MENU";
            this.btnMenu.Expanded = true;
            this.btnMenu.LargeImage = global::CafeManager.Properties.Resources._402_48;
            this.btnMenu.Name = "btnMenu";
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.btnMenu;
            this.navBarControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.btnMenu});
            this.navBarControl.Location = new System.Drawing.Point(0, 185);
            this.navBarControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 200;
            this.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl.Size = new System.Drawing.Size(200, 495);
            this.navBarControl.TabIndex = 1;
            this.navBarControl.Text = "navBarControl";
            this.navBarControl.ActiveGroupChanged += new DevExpress.XtraNavBar.NavBarGroupEventHandler(this.navBarControl_ActiveGroupChanged);
            // 
            // navigationFrame
            // 
            this.navigationFrame.Controls.Add(this.navigationPage1);
            this.navigationFrame.Controls.Add(this.navigationPage2);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(200, 185);
            this.navigationFrame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navigationFrame.SelectedPage = this.navigationPage1;
            this.navigationFrame.Size = new System.Drawing.Size(927, 495);
            this.navigationFrame.TabIndex = 5;
            this.navigationFrame.Text = "navigationFrame1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(927, 495);
            // 
            // navigationPage2
            // 
            this.navigationPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(927, 495);
            // 
            // navigationPage3
            // 
            this.navigationPage3.Caption = "navigationPage3";
            this.navigationPage3.Name = "navigationPage3";
            this.navigationPage3.Size = new System.Drawing.Size(747, 417);
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 680);
            this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.navBarControl);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "HỆ THỐNG QUẢN LÝ CAFE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage page_HeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btn_PhanQuyen;
        private DevExpress.XtraBars.BarButtonItem btn_QLNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnQLHangHoa;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem btn_DoiMatKhau;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barBtn_Exit;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarGroup btnMenu;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem btnQLBan;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage3;
    }
}

