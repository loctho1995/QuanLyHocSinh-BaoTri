
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAO;
using QuanLyHocSinh.Data;

namespace QuanLyHocSinh
{
    public partial class FrmMain : Form
    {
        #region - PROPERTIES, ATTRIBUTES -
        public static List<frmThongTinHS> ListThongTinHS
        { get; set; }

        public CustomTabControl TabControl
        {
            get { return m_tcMain; }
            set { m_tcMain = value; }
        }

        public static PhanQuyenDangNhap m_phanquyen = new PhanQuyenDangNhap();
        bool m_checkseach = false, bol = true;
        int tabpage = 0; //them 1 bien de xac dinh dang o tab nao, su dung cho treeview ( 0 = Ho So, 1 = Hoc Tap, 2 = Bao Cao, 3 = Tra Cuu)
        static string m_node = ""; //dung de xac dinh dang chon node nao trong treeview
        static int typebaocao = 10;
        #endregion

        #region - METHODS -
        public FrmMain()
        {
            //this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.CacheText, true);
            this.DoubleBuffered = true;
            InitializeComponent();

            if(FrmMain.m_phanquyen.PhanQuyen==0)
            {
                this.m_btnDuLieu.Enabled = false;
                this.m_btnGiaoVien.Enabled = false;
            }

            if (!DataBase.IsLoaded)
                DataBase.InitDataBase();

            ListThongTinHS = new List<frmThongTinHS>();
            FrmMain.m_phanquyen.LopCN = FrmMain.m_phanquyen.LopCN.Trim();
            LoadDataBaoCao();


            m_treeViewKhoi.ExpandAll();

            m_treeViewKhoi.ExpandAll();
            m_dgvMain.BorderStyle = BorderStyle.None;

            //m_lblLopBoMon.Text += m_phanquyen.LopBM[i];
            //m_btBaoCao.Enabled = false;

            m_tcMain.SelectedIndexChanged += m_tcMain_SelectedIndexChanged;//them su kien chuyen tabpage trong tabcontrol

            m_ccbPhanQuyen.Items.Add("GVCN");
            m_ccbPhanQuyen.Items.Add("GVBM");
            m_ccbPhanQuyen.SelectedIndex = 0;

            m_cbbBoMon.DataSource = DataBase.MonHoc.LayMonHoc();
            m_cbbBoMon.DisplayMember = "TENMONHOC";
            m_cbbBoMon.ValueMember = "MAMONHOC";

            m_cbbNamHoc.DataSource = DataBase.NamHoc.LayNamHoc();
            m_cbbNamHoc.DisplayMember = "TENNAMHOC";
            m_cbbNamHoc.ValueMember = "MANAMHOC";

            LoadColorApplication();
            LoadButtonsLocation();
        }

        private void LoadButtonsLocation()
        {
            //m_btXemThongTin.Location = m_btXemDiem.Location = new Point(0, -1);
            //m_btSuaHS.Location = new Point(m_btXemThongTin.Location.X + 170, m_btXemThongTin.Location.Y);
            //m_btXoaHS.Location = new Point(m_btSuaHS.Location.X + 170, m_btXemThongTin.Location.Y);
            //m_btThemHS.Location = new Point(m_btXoaHS.Location.X + 170, m_btXemThongTin.Location.Y);

            //m_btSuaDiem.Location = new Point(m_btXemDiem.Location.X + 160, m_btXemDiem.Location.Y);
        }

        private void LoadColorApplication()
        {
            this.BackColor = System.Drawing.Color.FromArgb(int.Parse(DataBase.CaiDat.MAIN_BACKCOLOR));

            for (int i = 0; i < this.TabControl.TabPages.Count; i++)
            {
                this.TabControl.TabPages[i].BackColor = System.Drawing.Color.FromArgb(int.Parse(DataBase.CaiDat.TABPANEL_COLOR));
            }             
        }
        //ham bat su kien chuyen tabpage

        public void LoadColor()
        {

        }

        private void LoadDataBaoCao()
        {
            //if (!bol) return;
            m_cbbBaoCaonamhoc.DataSource = DataBase.NamHoc.LayNamHoc();
            m_cbbBaoCaonamhoc.DisplayMember = "TENNAMHOC";
            m_cbbBaoCaonamhoc.ValueMember = "MANAMHOC";

            m_cbbBaoCaomonhoc.DataSource = DataBase.MonHoc.LayMonHoc();
            m_cbbBaoCaomonhoc.DisplayMember = "TENMONHOC";
            m_cbbBaoCaomonhoc.ValueMember = "MAMONHOC";

            m_cbbBaoCaohocky.DataSource = DataBase.HocKy.LayHocky();
            m_cbbBaoCaohocky.DisplayMember = "TENHOCKY";
            m_cbbBaoCaohocky.ValueMember = "MAHOCKY";

            if (FrmMain.m_phanquyen.PhanQuyen == 1)
            {
                m_cbbBaoCaoLoai.Items.Add("In danh sách lớp");
                m_cbbBaoCaoLoai.Items.Add("In bảng điểm môn");
                m_cbbBaoCaoLoai.Items.Add("In bảng điểm lớp");
                m_cbbBaoCaoLoai.Items.Add("In báo cáo tổng kết học kì");
                m_cbbBaoCaoLoai.Items.Add("In báo cáo tổng kêt môn");
            }
            else
            {
                m_cbbBaoCaoLoai.Items.Add("In danh sách lớp");
                m_cbbBaoCaoLoai.Items.Add("In bảng điểm môn");
                m_cbbBaoCaoLoai.Items.Add("In bảng điểm lớp");
            }


            m_dgvMain.DataSource = null;
        }

        private bool CheckGVInLopBM(string lop)
        {
            if (FrmMain.m_phanquyen.PhanQuyen == 1)
                return true;
            foreach (string malop in FrmMain.m_phanquyen.LopBM)
            {
                if (m_node.ToUpper() == malop.ToUpper().Trim())
                    return true;
            }

            return false;
        }

        private bool CheckGVCN(string lop)
        {
            if (FrmMain.m_phanquyen.PhanQuyen == 1)
                return true;
            string malop = m_dgvMain.SelectedRows[0].Cells["MALOP"].Value.ToString().ToUpper().Trim();
            if (lop.ToUpper() == FrmMain.m_phanquyen.LopCN.ToUpper().Trim() || malop == FrmMain.m_phanquyen.LopCN.ToUpper().Trim())
                return true;
            return false;
        }

        private void ShowHocSinh_Khoi()
        {
            //
            m_dgvMain.DataSource = DataBase.HocSinh.LayTatCa();
        }

        private void ThemHocSinh()
        {
            frmSuaNhapHS frmNhap = new frmSuaNhapHS();
            frmNhap.ShowDialog();

        }

        private void SuaHocSinh()
        {
            if (m_dgvMain.DataSource == null)
                MessageBox.Show("Chọn học sinh cần sửa");
            else if (!CheckGVCN(m_node)) MessageBox.Show("Bạn không có quyền sữa hồ sơ học sinh ở lớp này!");
            else
            {
                frmSuaNhapHS frmSua = new frmSuaNhapHS(m_dgvMain.SelectedRows[0]);
                frmSua.ShowDialog();
            }
        }

        private void XoaHocSinh()
        {
            if (m_dgvMain.DataSource == null)
                MessageBox.Show("chọn học sinh cần xóa");
            else if (!CheckGVCN(m_node)) MessageBox.Show("Bạn không có quyền xóa hồ sơ học sinh ở lớp này!");
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    return;
                int key = 0;
                if (m_dgvMain.SelectedRows[0].Cells["MAHS"] != null)
                    key = int.Parse(m_dgvMain.SelectedRows[0].Cells["MAHS"].Value.ToString());
                if (DataBase.HocSinh.DeleteHocSinh(key) && key != 0)
                {
                    DesignDataGridView(m_dgvMain, m_node);
                    MessageBox.Show("Xoá thành công");
                }

                else MessageBox.Show("Thất bại");
            }
        }

        private void XemThongTin()
        {
            if (m_dgvMain.DataSource == null)
                MessageBox.Show("Chọn học sinh cần xem thông tin");
            else
            {
                foreach (var item in ListThongTinHS)
                {
                    if (item.FormID.ToString() == m_dgvMain.SelectedRows[0].Cells["MAHS"].Value.ToString())
                    {
                        item.Hide();
                        item.Show();
                        return;
                    }                                                           
                }

                frmThongTinHS frmTT = new frmThongTinHS(m_dgvMain.SelectedRows[0]);
                frmTT.FormID = int.Parse(m_dgvMain.SelectedRows[0].Cells["MAHS"].Value.ToString());
                ListThongTinHS.Add(frmTT);
                frmTT.Show();
            }
        }

        private void XemDiem()
        {
            if (m_dgvMain.DataSource == null)
                MessageBox.Show("Chọn học sinh cần xem điểm");
            else
            {
                if (m_ccbPhanQuyen.Text.ToString() == "GVCN")
                {
                    frmXemDiem frmXD = new frmXemDiem(m_dgvMain.SelectedRows[0]);
                    frmXD.Show();
                }
                else
                {
                    frmXemSuaDiem_Mon frmXDM = new frmXemSuaDiem_Mon(m_dgvMain.SelectedRows[0], false);
                    frmXDM.Show();
                }
            }

        }

        private void SuaDiem()
        {
            if (m_dgvMain.DataSource == null)
                MessageBox.Show("Chọn học sinh cần xem sửa điểm");
            else
            {
                if (m_ccbPhanQuyen.Text.ToString() == "GVCN")
                {
                    MessageBox.Show("Bạn không có quyền sửa điểm của học sinh!");
                }
                else
                {
                    frmXemSuaDiem_Mon frmXDM = new frmXemSuaDiem_Mon(m_dgvMain.SelectedRows[0], true);
                    frmXDM.Show();
                }
            }
        }

        private void XuatBaoCao()
        {
            try
            {
                frmBaoCao frmBC = new frmBaoCao(m_dgvMain, m_treeViewKhoi.SelectedNode.Text, m_cbbBaoCaoLoai.SelectedItem.ToString());
                frmBC.ShowDialog();
            }
            catch
            {

            }

        }

        public static string Node
        {
            get { return m_node; }
        }

        public static string getmagv()
        {
            return m_phanquyen.ID;
        }

        public static int getphanquyen()
        {
            return m_phanquyen.PhanQuyen;
        }

        private void DesignDataGridView(DataGridView dgv, string node)
        {
            if (m_checkseach)//m_checkseach = true -> dang tim kiem hoc sinh
            {
                switch (tabpage)//tabpage se cho biet tabpage nao dang duoc chon
                {
                    case 0://tabpage Ho So
                        dgv.DataSource = DataBase.HocSinh.TimKiemThongTinHocSinh(node, FrmMain.m_phanquyen.ID, FrmMain.m_phanquyen.PhanQuyen);//hs.TimKiemThongTinHocSinh(ma);
                        break;

                    case 1://tabpage Hoc tap
                        if (m_ccbPhanQuyen.Text.ToString() == "GVCN")
                        {
                            dgv.DataSource = DataBase.Diem.TimThongTinDiem_LopChuNhiem(node, int.Parse(m_cbbNamHoc.SelectedValue.ToString()), m_phanquyen.ID, m_phanquyen.PhanQuyen);
                        }
                        else
                            dgv.DataSource = DataBase.Diem.TimThongTinDiemHocSinh_Mon(node, m_cbbBoMon.SelectedValue.ToString(), int.Parse(m_cbbNamHoc.SelectedValue.ToString()), m_phanquyen.ID, m_phanquyen.PhanQuyen);
                        break;

                    case 2://tabpage Bao Cao
                        break;

                    case 3://tabpage Tra Cuu
                        break;
                }
                
                m_checkseach = false;
            }
            else//m_checkseach = false -> dang su dung tree view
            {
                switch (tabpage)//tabpage se cho biet tabpage nao dang duoc chon
                {
                    case 0://tabpage Ho So
                        dgv.DataSource = null;
                        if (node.Length == 2)
                            dgv.DataSource = DataBase.HocSinh.LayHocSinh_Khoi(node, m_phanquyen.ID, m_phanquyen.PhanQuyen);
                        else if (CheckGVInLopBM(node))
                            dgv.DataSource = DataBase.HocSinh.LayHocSinh_Lop(node, m_phanquyen.ID, m_phanquyen.PhanQuyen);
                        if (dgv.DataSource == null) return;
                        dgv.Columns["STT"].Width = 40;
                        dgv.Columns["MAHS"].Width = 50;
                        dgv.Columns["HOTEN"].Width = 120;
                        dgv.Columns["GIOITINH"].Width = 50;
                        dgv.Columns["EMAIL"].Width = 120;
                        dgv.Columns["MALOP"].Width = 50;
                        dgv.Columns["MAKHOILOP"].Width = 40;

                        dgv.Columns["MAHS"].HeaderText = "Mã học sinh";
                        dgv.Columns["HOTEN"].HeaderText = "Họ và tên";
                        dgv.Columns["GIOITINH"].HeaderText = "Giới tính";
                        dgv.Columns["EMAIL"].HeaderText = "Email";
                        dgv.Columns["DIACHI"].HeaderText = "Địa chỉ";
                        dgv.Columns["MALOP"].HeaderText = "Mã lớp";
                        dgv.Columns["MAKHOILOP"].HeaderText = "Mã khối";
                        dgv.Columns["HOTENCHA"].HeaderText = "Họ tên cha";
                        dgv.Columns["HOTENME"].HeaderText = "Họ tên mẹ";
                        dgv.Columns["NGHENGHIEPCHA"].HeaderText = "Nghề nghiệp cha";
                        dgv.Columns["NGHENGHIEPME"].HeaderText = "Nghề nghiệp mẹ";

                        break;

                    case 1://tabpage Hoc tap
                        dgv.DataSource = null;

                        if (m_ccbPhanQuyen.Text.ToString() == "GVCN")
                        {
                            if (node.Length == 2)
                                dgv.DataSource = DataBase.Diem.LayDiemHocSinh_Khoi(node, int.Parse(m_cbbNamHoc.SelectedValue.ToString()), m_phanquyen.ID, m_phanquyen.PhanQuyen);
                            else if (CheckGVInLopBM(node))
                                 dgv.DataSource = DataBase.Diem.LayDiemHocSinh_LopChuNhiem(node, int.Parse(m_cbbNamHoc.SelectedValue.ToString()), m_phanquyen.ID, m_phanquyen.PhanQuyen);
                            if (dgv.DataSource == null) return;
                            dgv.Columns["STT"].Width = 40;
                            dgv.Columns["MAHS"].Width = 50;
                            dgv.Columns["HOTEN"].Width = 120;
                            dgv.Columns["DIEMTBHKI"].Width = 120;
                            dgv.Columns["DIEMTBHKII"].Width = 120;
                            dgv.Columns["DIEMTBCANAM"].Width = 120;
                            dgv.Columns["MANAMHOC"].Width = 40;

                            dgv.Columns["MAHS"].HeaderText = "Mã học sinh";
                            dgv.Columns["HOTEN"].HeaderText = "Họ và tên";
                            dgv.Columns["DIEMTBHKI"].HeaderText = "Điểm TB HKI";
                            dgv.Columns["DIEMTBHKII"].HeaderText = "Điểm TB HKII";
                            dgv.Columns["DIEMTBCANAM"].HeaderText = "Điểm TB Cả năm";
                            dgv.Columns["MANAMHOC"].HeaderText = "Năm học";
                        }
                        else
                        {
                            if (node.Length == 2)
                                dgv.DataSource = DataBase.Diem.LayDiemHocSinh_Mon_Khoi(node, m_cbbBoMon.SelectedValue.ToString(), int.Parse(m_cbbNamHoc.SelectedValue.ToString()), m_phanquyen.ID, m_phanquyen.PhanQuyen);
                            else if (CheckGVInLopBM(node))
                                dgv.DataSource = DataBase.Diem.LayDiemHocSinh_Mon(node, m_cbbBoMon.SelectedValue.ToString(), int.Parse(m_cbbNamHoc.SelectedValue.ToString()), m_phanquyen.ID, m_phanquyen.PhanQuyen);
                            if(dgv.DataSource == null) return;

                            dgv.Columns["STT"].Width = 40;
                            dgv.Columns["MAHS"].Width = 50;
                            dgv.Columns["HOTEN"].Width = 120;
                            dgv.Columns["DIEMTBMONHKI"].Width = 120;
                            dgv.Columns["DIEMTBMONHKII"].Width = 120;

                            dgv.Columns["MAHS"].HeaderText = "Mã học sinh";
                            dgv.Columns["HOTEN"].HeaderText = "Họ và tên";
                            dgv.Columns["DIEMTBMONHKI"].HeaderText = "Điểm TB Môn HKI";
                            dgv.Columns["DIEMTBMONHKII"].HeaderText = "Điểm TB Môn HKII";

                        }
                        break;

                    case 2://tabpage Bao Cao
                        {
                            switch (typebaocao)
                            {
                                case 0:
                                    InDanhSachLop();
                                    break;

                                case 1:
                                    InBangDiemChiTietTungHocky();
                                    break;

                                case 2:
                                    InBangDiemCuaLop();
                                    break;

                                case 3:

                                    break;
                                case 4:

                                    break;

                                default:
                                    break;
                            }
                        }
                        break;

                    case 3://tabpage Tra Cuu
                        break;
                }
            }
        }

        private void InDanhSachLop()
        {
            m_dgvMain.DataSource = DataBase.BaoCao.InDanhSachlop(FrmMain.m_phanquyen.ID, m_node, FrmMain.m_phanquyen.PhanQuyen);
        }

        private void InBangDiemCuaLop()
        {
            m_dgvMain.DataSource = DataBase.BaoCao.InBangDiemCuaLop(FrmMain.m_phanquyen.ID, m_node, FrmMain.m_phanquyen.PhanQuyen, int.Parse(m_cbbBaoCaonamhoc.SelectedValue.ToString()));
        }

        private void InBangDiemChiTietTungHocky()
        {
            int namhoc = int.Parse(m_cbbBaoCaonamhoc.SelectedValue.ToString());
            m_dgvMain.DataSource = DataBase.BaoCao.InBangDiemChiTietTunghocKy(FrmMain.m_phanquyen.ID, m_node, m_cbbBaoCaomonhoc.SelectedValue.ToString(), FrmMain.m_phanquyen.PhanQuyen, namhoc, m_cbbBaoCaohocky.SelectedValue.ToString());
        }

        private void InBaoCaoTongKetMon()
        {
            int namhoc = int.Parse(m_cbbBaoCaonamhoc.SelectedValue.ToString());
            m_dgvMain.DataSource = DataBase.BaoCao.BaoCaoTongKetMon(m_cbbBaoCaomonhoc.SelectedValue.ToString(), FrmMain.m_phanquyen.PhanQuyen, m_cbbBaoCaohocky.SelectedValue.ToString(), namhoc);
        }

        private void InBaoCaoTongKetHocKy()
        {
            int namhoc = int.Parse(m_cbbBaoCaonamhoc.SelectedValue.ToString());
            m_dgvMain.DataSource = DataBase.BaoCao.BaoCaoTongKetHocKy(FrmMain.m_phanquyen.PhanQuyen, m_cbbBaoCaohocky.SelectedValue.ToString(), namhoc);
        }
        #endregion

        #region - EVENTS -

        protected override void OnSizeChanged(EventArgs e)
        {

            base.OnSizeChanged(e);
        }

        void m_tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cac cau lenh dung de xac dinh tabpage nao dang duoc chon de gan cho bien static tab gia tri tuong ung
            if (m_tcMain.TabPages[0].Focus() == true)
                tabpage = 0;

            if (m_tcMain.TabPages[1].Focus() == true)
                tabpage = 1;

            if (m_tcMain.TabPages[2].Focus() == true)
            {

                tabpage = 2;
                bol = false;
            }

            //cau lenh lam mat datagridview khi chuyen tab
            m_dgvMain.DataSource = null;

        }

        private void m_cbbBaoCaoLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_dgvMain.DataSource = null;
            m_treeViewKhoi.SelectedNode = null;

            switch (m_cbbBaoCaoLoai.SelectedItem.ToString())
            {
                case "In danh sách lớp":
                    m_cbbBaoCaomonhoc.Enabled = false;
                    m_cbbBaoCaohocky.Enabled = false;
                    typebaocao = 0;
                    break;

                case "In bảng điểm môn":
                    m_cbbBaoCaomonhoc.Enabled = true;
                    m_cbbBaoCaohocky.Enabled = true;
                    typebaocao = 1;
                    break;

                case "In bảng điểm lớp":
                    m_cbbBaoCaomonhoc.Enabled = false;
                    m_cbbBaoCaohocky.Enabled = false;
                    typebaocao = 2;
                    break;

                case "In báo cáo tổng kết học kì":
                    m_cbbBaoCaomonhoc.Enabled = false;
                    m_cbbBaoCaohocky.Enabled = true;
                    InBaoCaoTongKetHocKy();
                    typebaocao = 3;
                    break;

                case "In báo cáo tổng kêt môn":
                    m_cbbBaoCaomonhoc.Enabled = true;
                    m_cbbBaoCaohocky.Enabled = true;
                    InBaoCaoTongKetMon();
                    typebaocao = 4;
                    break;
            }

        }

        private void m_cbbBaoCaonamhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typebaocao == 2)
                m_dgvMain.DataSource = DataBase.BaoCao.InBangDiemCuaLop(FrmMain.m_phanquyen.ID, m_node, FrmMain.m_phanquyen.PhanQuyen, int.Parse(m_cbbBaoCaonamhoc.SelectedValue.ToString()));
            else if (typebaocao == 1)
            {
                int namhoc = int.Parse(m_cbbBaoCaonamhoc.SelectedValue.ToString());
                m_dgvMain.DataSource = DataBase.BaoCao.InBangDiemChiTietTunghocKy(FrmMain.m_phanquyen.ID, m_node, m_cbbBaoCaomonhoc.SelectedValue.ToString(), FrmMain.m_phanquyen.PhanQuyen, namhoc, m_cbbBaoCaohocky.SelectedValue.ToString());
            }
            else if (typebaocao == 4)
            {
                int namhoc = int.Parse(m_cbbBaoCaonamhoc.SelectedValue.ToString());
                m_dgvMain.DataSource = DataBase.BaoCao.BaoCaoTongKetMon(m_cbbBaoCaomonhoc.SelectedValue.ToString(), FrmMain.m_phanquyen.PhanQuyen, m_cbbBaoCaohocky.SelectedValue.ToString(), namhoc);
            }
            else if (typebaocao == 3)
            {
                int namhoc = int.Parse(m_cbbBaoCaonamhoc.SelectedValue.ToString());
                m_dgvMain.DataSource = DataBase.BaoCao.BaoCaoTongKetHocKy(FrmMain.m_phanquyen.PhanQuyen, m_cbbBaoCaohocky.SelectedValue.ToString(), namhoc);
            }

        }

        private void m_cbbBaoCaomonhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typebaocao == 1)
            {
                int namhoc = int.Parse(m_cbbBaoCaonamhoc.SelectedValue.ToString());
                m_dgvMain.DataSource = DataBase.BaoCao.InBangDiemChiTietTunghocKy(FrmMain.m_phanquyen.ID, m_node, m_cbbBaoCaomonhoc.SelectedValue.ToString(), FrmMain.m_phanquyen.PhanQuyen, namhoc, m_cbbBaoCaohocky.SelectedValue.ToString());
            }
            else if (typebaocao == 4)
            {
                int namhoc = int.Parse(m_cbbBaoCaonamhoc.SelectedValue.ToString());
                m_dgvMain.DataSource = DataBase.BaoCao.BaoCaoTongKetMon(m_cbbBaoCaomonhoc.SelectedValue.ToString(), FrmMain.m_phanquyen.PhanQuyen, m_cbbBaoCaohocky.SelectedValue.ToString(), namhoc);
            }
        }

        private void m_cbbBaoCaohocky_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typebaocao == 1)
            {
                int namhoc = int.Parse(m_cbbBaoCaonamhoc.SelectedValue.ToString());
                m_dgvMain.DataSource = DataBase.BaoCao.InBangDiemChiTietTunghocKy(FrmMain.m_phanquyen.ID, m_node, m_cbbBaoCaomonhoc.SelectedValue.ToString(), FrmMain.m_phanquyen.PhanQuyen, namhoc, m_cbbBaoCaohocky.SelectedValue.ToString());
            }
            else if (typebaocao == 4)
            {
                int namhoc = int.Parse(m_cbbBaoCaonamhoc.SelectedValue.ToString());
                m_dgvMain.DataSource = DataBase.BaoCao.BaoCaoTongKetMon(m_cbbBaoCaomonhoc.SelectedValue.ToString(), FrmMain.m_phanquyen.PhanQuyen, m_cbbBaoCaohocky.SelectedValue.ToString(), namhoc);
            }
            else if (typebaocao == 3)
            {
                int namhoc = int.Parse(m_cbbBaoCaonamhoc.SelectedValue.ToString());
                m_dgvMain.DataSource = DataBase.BaoCao.BaoCaoTongKetHocKy(FrmMain.m_phanquyen.PhanQuyen, m_cbbBaoCaohocky.SelectedValue.ToString(), namhoc);
            }
        }

        private void m_dgvMain_DoubleClick(object sender, EventArgs e)
        {
            //if (m_tbHoSo.Focus())
                //this.XemThongTin();

            switch (tabpage)//tabpage se cho biet tabpage nao dang duoc chon
                {
                    case 0://tabpage Ho So
                        this.XemThongTin();
                        break;

                    case 1://tabpage Hoc tap
                        this.XemDiem();
                        break;

                    case 2://tabpage Bao Cao
                        break;

                    case 3://tabpage Tra Cuu
                        break;
                }
        }

        private void m_ccbPhanQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (m_ccbPhanQuyen.Text.ToString() == "GVCN")
                m_cbbBoMon.Enabled = false;
            else
                m_cbbBoMon.Enabled = true;

            DesignDataGridView(m_dgvMain, m_node);
        }

        private void m_cbbBoMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            DesignDataGridView(m_dgvMain, m_node);
        }

        private void m_cbbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            DesignDataGridView(m_dgvMain, m_node);
        }

        private void button_Click(object sender, EventArgs e)
        {
            switch ((sender as Control).Name)
            {
                case "m_btclose":
                    //  if (MessageBox.Show("Sure Mother fucker?", "Quit", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    this.Close();
                    break;

                case "m_btSuaDiem":
                    SuaDiem();
                    break;

                case "m_btXemDiem":
                    XemDiem();
                    break;

                case "m_btHide":
                    (sender as ButtonFlat).SaveChanged = true;
                    this.WindowState = FormWindowState.Minimized;

                    break;

                case "m_btCaiDat":
                    frmCaiDat frmcaiDat = new frmCaiDat(this);
                    frmcaiDat.Show();
                    break;

                default:
                    break;
            }
        }

        private void m_treeViewKhoi_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //Viet ham check cho button baocao
            //m_btBaoCao.Enabled = false;
            //for (int i = 0; i < m_phanquyen.LopBM.Count(); i++)
            //{
            //    if (e.Node.Text == m_phanquyen.LopBM[i])
            //    {
            //        m_btBaoCao.Enabled = true;
            //        break;
            //    }
            //}
            switch (e.Node.Name)
            {
                //Click vào node khối
                case "m_nodeKhoi":
                    break;

                //Click vào Node Khối 10
                case "m_nodeKhoi10":
                    m_node = "10";
                    break;

                //Click vào Node khối 11
                case "m_nodeKhoi11":
                    m_node = "11";
                    break;

                //Click vào Node khối 11
                case "m_nodeKhoi12":
                    m_node = "12";
                    break;

                case "m_node10A1":
                    m_node = "10a1";
                    break;

                case "m_node10A2":
                    m_node = "10a2";
                    break;

                case "m_node10A3":
                    m_node = "10a3";
                    break;

                case "m_node10A4":
                    m_node = "10a4";
                    break;

                case "m_node11A1":
                    m_node = "11a1";
                    break;

                case "m_node11A2":
                    m_node = "11a2";
                    break;

                case "m_node11A3":
                    m_node = "11a3";
                    break;

                case "m_node12A1":
                    m_node = "12a1";
                    break;

                case "m_node12A2":
                    m_node = "12a2";
                    break;
                default:
                    break;

            }
            DesignDataGridView(m_dgvMain, m_node);
        }

        //cho phép resize góc dưới bên phải
        private const int cGrip = 5;      // Grip size, khoảng range để xác định cho việc resize form xem thêm ở WndPrc
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);

                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;

                    Point pos = new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16);
                    pos = this.PointToClient(pos);

                    /*
                    const int htLeft = 10;
                    const int htRight = 11;
                    const int htTop = 12;
                    const int htTopLeft = 13;
                    const int htTopRight = 14;
                    const int htBottom = 15;            
                    const int htBottomLeft = 16;
                    const int htBottomRight = 17;  
                     */

                    //if (pos.Y < cCaption)
                    //{
                    //    m.Result = (IntPtr)2;  // HTCAPTION
                    //    return;
                    //}

                    //rê chuột vào phía cạnh bên trái
                    if (pos.X <= cGrip && pos.Y < this.ClientSize.Height - cGrip && pos.Y > cGrip)
                    {
                        m.Result = (IntPtr)10;  // HTCAPTION
                        return;
                    }

                    //rê chuột vào phía cạnh bên phải
                    if (pos.X >= this.ClientSize.Width - cGrip && pos.Y < this.ClientSize.Height - cGrip && pos.Y > cGrip)
                    {
                        m.Result = (IntPtr)11;
                        return;
                    }

                    //rê chuột vào góc dưới bên phải
                    if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                    {
                        m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                        return;
                    }

                    //rê chuột vào góc dưới bên trái
                    if (pos.X <= cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                    {
                        m.Result = (IntPtr)16;
                        return;
                    }

                    //rê chuột bên phía trên top
                    if (pos.Y < cGrip)
                    {
                        m.Result = (IntPtr)12;
                        return;
                    }

                    //rê chuột xuông dưới bottom
                    if (pos.Y > this.ClientSize.Height - cGrip)
                    {
                        m.Result = (IntPtr)15;
                        return;
                    }

                    this.Invalidate();
                    return;
            }

            base.WndProc(ref m);
        }

        private void m_tcMain_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            m_treeViewKhoi.SelectedNode = null;
        }

        #endregion

        public static void ResetDGV()
        {
            //
            FrmMain frm = new FrmMain();
            frm.resetDGV();
        }
        public void resetDGV()
        {
            m_dgvMain.DataSource = DataBase.HocSinh.LayHocSinh_Lop(m_node, m_phanquyen.ID, m_phanquyen.PhanQuyen);
        }
        private void m_btnDuLieu_Click(object sender, EventArgs e)
        {
            frmData frm_data = new frmData();
            frm_data.ShowDialog();
        }

        private void m_btnGiaoVien_Click(object sender, EventArgs e)
        {
            frmGiaoVien frm_giaovien = new frmGiaoVien();
            frm_giaovien.Show();
        }
        private void m_btdangXuat_Click_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("Dang Xuat?", "Thong Bao", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Hide();
                frmDangNhap frmdangNhap = new frmDangNhap();
                frmdangNhap.ShowDialog();
                this.Close();
            }
        }

        private void m_btXemThongTin_Click(object sender, EventArgs e)
        {
            XemThongTin();
        }

        private void m_btSuaHS_Click(object sender, EventArgs e)
        {
            SuaHocSinh();
        }

        private void m_btXoaHS_Click(object sender, EventArgs e)
        {
            XoaHocSinh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(DataBase.Lop.LayDuLieuLop(FrmMain.m_phanquyen.ID, FrmMain.m_phanquyen.PhanQuyen) != null)
            {
                ThemHocSinh();
            }                
        }

        private void m_btXemDiem_Click(object sender, EventArgs e)
        {
            this.XemDiem();
        }

        private void m_btSuaDiem_Click(object sender, EventArgs e)
        {
            this.SuaDiem();
        }

        private void m_btBaoCao_Click(object sender, EventArgs e)
        {
            XuatBaoCao();
        }

        private void m_btBaoCao_Click_1(object sender, EventArgs e)
        {

        }
    }
}