using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace QuanLyHocSinh
{
    public partial class frmThongTinHS : FormFlat
    {
        DataGridViewRow m_row;
        HocSinh_BUS hs = new HocSinh_BUS();
        /// <summary>
        /// mỗi frm có 1 ID riêng để tránh việc xem thông tin của 1 học sinh trên 2 frm
        /// </summary>
        public int FormID
        { get; set; }
        
        public frmThongTinHS(DataGridViewRow row)
        {            
            InitializeComponent();
            this.InitGraphics();

            m_row = row;            

            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            m_btchinhSua.BackColor = m_btClose.BackColor = m_btminimize.BackColor = Color.FromArgb(int.Parse(DataBase.CaiDat.TOPBUTTONCOLOR));
        }

        //cho phép resize góc dưới bên phải
        private const int cGrip = 5;      // Grip size, khoảng range để xác định cho việc resize form xem thêm ở WndPrc
        
        private void frmThongTinHS_Load(object sender, EventArgs e)
        {
            m_lblName.Text = m_row.Cells["HOTEN"].Value.ToString();
            m_lblNgaysinh.Text = m_row.Cells["NGAYSINH"].Value.ToString();
            m_lblGioitinh.Text = m_row.Cells["GIOITINH"].Value.ToString();
            m_lblDiachi.Text = m_row.Cells["DIACHI"].Value.ToString();
            m_lblEmail.Text = m_row.Cells["EMAIL"].Value.ToString();
            m_lblLop.Text = m_row.Cells["MALOP"].Value.ToString();
            m_lblTonGiao.Text = m_row.Cells["TONGIAO"].Value.ToString();
            m_lblHoTenCha.Text = m_row.Cells["HOTENCHA"].Value.ToString();
            m_lblHoTenMe.Text = m_row.Cells["HOTENME"].Value.ToString();
            m_lblNgheNghiepCha.Text = m_row.Cells["NGHENGHIEPCHA"].Value.ToString();
            m_lblNgheNghiepMe.Text = m_row.Cells["NGHENGHIEPME"].Value.ToString();
            if (DataBase.HocSinh.Image(int.Parse(m_row.Cells["MAHS"].Value.ToString())) != null)
                m_ptbHS.Image = (Image)(new Bitmap(DataBase.HocSinh.Image(int.Parse(m_row.Cells["MAHS"].Value.ToString()))));
            try
            {
                m_lblName.Text = m_row.Cells["HOTEN"].Value.ToString();
                m_lblNgaysinh.Text = m_row.Cells["NGAYSINH"].Value.ToString();
                m_lblGioitinh.Text = m_row.Cells["GIOITINH"].Value.ToString();
                m_lblDiachi.Text = m_row.Cells["DIACHI"].Value.ToString();
                m_lblEmail.Text = m_row.Cells["EMAIL"].Value.ToString();
                m_lblLop.Text = m_row.Cells["MALOP"].Value.ToString();
                if (DataBase.HocSinh.Image(int.Parse(m_row.Cells["MAHS"].Value.ToString())) != null)
                    m_ptbHS.Image = (Image)(new Bitmap(DataBase.HocSinh.Image(int.Parse(m_row.Cells["MAHS"].Value.ToString()))));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void m_btClose_Click(object sender, EventArgs e)
        {
            FrmMain.ListThongTinHS.Remove(this);
            m_ptbHS.Image = null;
            this.Close();
        }

        private void m_btchinhSua_Click(object sender, EventArgs e)
        {
            frmSuaNhapHS frm = new frmSuaNhapHS(m_row);
            frm.ShowDialog();
            this.Hide();
            FrmMain.ListThongTinHS.Remove(this);
            this.Close();
        }

        private void m_btminimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
