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
using System.Drawing.Drawing2D;

namespace QuanLyHocSinh
{
    public partial class frmXemDiem : FormFlat
    {

        //int m_maHS;
        //string m_maGV;
        DataGridViewRow m_row;
        HocSinh_BUS hs = new HocSinh_BUS();
        bool firstload = true;

        public frmXemDiem(DataGridViewRow row)
        {
            InitializeComponent();
            
            m_row = row;

            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            m_btClose.BackColor = m_btminimize.BackColor = Color.FromArgb(int.Parse(DataBase.CaiDat.TOPBUTTONCOLOR));
        }

        private void frmXemDiem_Load(object sender, EventArgs e)
        {
            m_cbbHocKi.Items.Add(1);
            m_cbbHocKi.Items.Add(2);

            m_lbMaHS.Text = m_row.Cells["MAHS"].Value.ToString();
            m_lbTenHS.Text = m_row.Cells["HOTEN"].Value.ToString();

            //foreach (var i in hs.LayNamHoc())
            //{
            //    m_cbbNamHoc.Items.Add(i.MANAMHOC);
            //}
            //m_cbbNamHoc.SelectedIndex = 0;

            m_lbLop.Text = FrmMain.Node;

            m_cbbNamHoc.DataSource = DataBase.NamHoc.LayNamHoc();
            m_cbbNamHoc.DisplayMember = "TENNAMHOC";
            m_cbbNamHoc.ValueMember = "MANAMHOC";

            m_cbbHocKi.SelectedIndex = 0;

            m_dgvMain.DataSource = DataBase.Diem.LayDiemHocSinh_AllMon(int.Parse(m_lbMaHS.Text.ToString()), int.Parse(m_cbbNamHoc.SelectedValue.ToString()), m_cbbHocKi.Text.ToString());
            firstload = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_cbbHocKi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!firstload)
                m_dgvMain.DataSource = DataBase.Diem.LayDiemHocSinh_AllMon(int.Parse(m_lbMaHS.Text.ToString()), int.Parse(m_cbbNamHoc.SelectedValue.ToString()), m_cbbHocKi.Text.ToString());
        }

        private void m_cbbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!firstload)
                m_dgvMain.DataSource = DataBase.Diem.LayDiemHocSinh_AllMon(int.Parse(m_lbMaHS.Text.ToString()), int.Parse(m_cbbNamHoc.SelectedValue.ToString()), m_cbbHocKi.Text.ToString());
        }

        private void m_btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_btminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
