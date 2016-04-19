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

namespace QuanLyHocSinh
{
    public partial class frmXemSuaDiem_Mon : FormFlat
    {
        DataGridViewRow m_row;
        HocSinh_BUS hs = new HocSinh_BUS();
        bool sua;
        DataTable dt;
        bool firstload = true;

        public frmXemSuaDiem_Mon()
        {
            InitializeComponent();

            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;

            InitButton();
        }

        public frmXemSuaDiem_Mon(DataGridViewRow row, bool sua)
        {
            InitializeComponent();

            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;

            m_row = row;
            this.sua = sua;

            m_lbMaHS.Text = m_row.Cells["MAHS"].Value.ToString();
            m_lbHoTen.Text = m_row.Cells["HOTEN"].Value.ToString();
            m_lbLop.Text = FrmMain.Node;

            m_cbbMonHoc.DataSource = DataBase.MonHoc.LayMonHoc();
            m_cbbMonHoc.DisplayMember = "TENMONHOC";
            m_cbbMonHoc.ValueMember = "MAMONHOC";

            m_cbbNamHoc.DataSource = DataBase.NamHoc.LayNamHoc();
            m_cbbNamHoc.DisplayMember = "TENNAMHOC";
            m_cbbNamHoc.ValueMember = "MANAMHOC";

            InitButton();
        }

        private void InitButton()
        {
            m_btminimize.BackColor = m_btClose.BackColor = Color.FromArgb(int.Parse(DataBase.CaiDat.TOPBUTTONCOLOR));
            m_btSua.BackColor = m_btLuu.BackColor = Color.FromArgb(int.Parse(DataBase.CaiDat.TABBUTTONCOLOR));
        }

        private void frmXemSuaDiem_Mon_Load(object sender, EventArgs e)
        {

            if (!sua)
            {
                DisableAllTB();//disable all textbox

                m_btLuu.Enabled = false;
            }
            else
            {

                EnableAllTB(); //enable all text box

                m_btLuu.Enabled = true;

                m_btSua.Visible = false;

                m_lbTBHK1.Visible = false;
                m_lbTBHK2.Visible = false;

                m_lbTBHK1text.Visible = false;
                m_lbTBHK2text.Visible = false;
            }

            LoadDiem();
            firstload = false;
        }

        private void m_btSua_Click(object sender, EventArgs e)
        {
            if (m_btSua.ButtonText.ToString() != "Cancel")
            {
                EnableAllTB();

                m_btLuu.Enabled = true;

                m_lbTBHK1.Visible = false;
                m_lbTBHK2.Visible = false;

                m_lbTBHK1text.Visible = false;
                m_lbTBHK2text.Visible = false;

                m_btSua.ButtonText = "Cancel";
                m_btSua.ButtonImage = QuanLyHocSinh.Properties.Resources.iconClose;
                m_btSua.ImageOrigin = new Point(30, 0);
            }
            else
            {
                DisableAllTB();
                LoadDiem();

                m_btLuu.Enabled = false;

                m_lbTBHK1.Visible = true;
                m_lbTBHK2.Visible = true;

                m_lbTBHK1text.Visible = true;
                m_lbTBHK2text.Visible = true;

                m_btSua.ButtonText = "Sửa";
                m_btSua.ImageOrigin = new Point(30, 0);
                m_btSua.ButtonImage = QuanLyHocSinh.Properties.Resources.chinhsua;
            }
        }

        private void m_cbbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!firstload)
                LoadDiem();
        }

        private void m_btLuu_Click(object sender, EventArgs e)
        {            
            if (m_tbD15pHK1.Text == "" || m_tbD15pHK2.Text == "" || m_tbDMiengHK1.Text == "" || m_tbDMiengHK2.Text == "" || m_tbD1tietHK1.Text == "" || m_tbD1tietHK2.Text == "" || m_tbDThiHK1.Text == "" || m_tbDThiHK2.Text == "")
                MessageBox.Show("Các ô điểm không được để trống(có thể nhập '0' nếu chưa có điểm)");
            else
            {
                if (ConverDiem())
                {
                    if (DataBase.Diem.SuaDiem(int.Parse(m_lbMaHS.Text.ToString()), m_lbLop.Text.ToString(), m_cbbMonHoc.SelectedValue.ToString(), int.Parse(m_cbbNamHoc.SelectedValue.ToString()), float.Parse(m_tbDMiengHK1.Text.ToString()), float.Parse(m_tbD15pHK1.Text.ToString()), float.Parse(m_tbD1tietHK1.Text.ToString()), float.Parse(m_tbDThiHK1.Text.ToString()), float.Parse(m_tbDMiengHK2.Text.ToString()), float.Parse(m_tbD15pHK2.Text.ToString()), float.Parse(m_tbD1tietHK2.Text.ToString()), float.Parse(m_tbDThiHK2.Text.ToString())))
                    {
                        MessageBox.Show("Sửa thành công!");

                        if (!sua)
                        {
                            DisableAllTB();
                            m_btLuu.Enabled = false;

                            m_btSua.ButtonText = "Sửa";
                            m_btSua.ImageOrigin = new Point(30, 0);
                            m_btSua.ButtonImage = QuanLyHocSinh.Properties.Resources.chinhsua;

                            LoadDiem();

                            m_lbTBHK1.Visible = true;
                            m_lbTBHK2.Visible = true;

                            m_lbTBHK1text.Visible = true;
                            m_lbTBHK2text.Visible = true;

                        }
                        else
                        {

                        }

                    }
                    else
                        MessageBox.Show("Sửa không thành công! Lỗi Cơ Sở Dữ Liệu");
                }
                else
                    MessageBox.Show("Sửa không thành công! Vui lòng kiểm tra lại dữ liệu nhập");

            }
        }

        private void m_cbbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!firstload)
            LoadDiem();
        }

        private void LoadDiem()
        {
            dt = DataBase.Diem.LayDiem1HocSinh_Mon(int.Parse(m_lbMaHS.Text.ToString()), m_cbbMonHoc.SelectedValue.ToString(), int.Parse(m_cbbNamHoc.SelectedValue.ToString()), FrmMain.getmagv(), FrmMain.getphanquyen());
            if (dt != null)
            {
                m_btSua.Enabled = true;

                m_tbDMiengHK1.Text = dt.Rows[0][0].ToString();
                m_tbDMiengHK2.Text = dt.Rows[0][5].ToString();

                m_tbD15pHK1.Text = dt.Rows[0][1].ToString();
                m_tbD15pHK2.Text = dt.Rows[0][6].ToString();

                m_tbD1tietHK1.Text = dt.Rows[0][2].ToString();
                m_tbD1tietHK2.Text = dt.Rows[0][7].ToString();

                m_tbDThiHK1.Text = dt.Rows[0][3].ToString();
                m_tbDThiHK2.Text = dt.Rows[0][8].ToString();

                m_lbTBHK1.Text = dt.Rows[0][4].ToString();
                m_lbTBHK2.Text = dt.Rows[0][9].ToString();

                if (sua)
                    m_btLuu.Enabled = true;
            }
            else
            {
                m_btSua.Enabled = false;
                m_btLuu.Enabled = false;

                m_tbD15pHK1.Text = "";
                m_tbD15pHK2.Text = "";

                m_tbD1tietHK1.Text = "";
                m_tbD1tietHK2.Text = "";

                m_tbDMiengHK1.Text = "";
                m_tbDMiengHK2.Text = "";

                m_tbDThiHK1.Text = "";
                m_tbDThiHK2.Text = "";

                m_lbTBHK1.Text = "";
                m_lbTBHK2.Text = "";

                DisableAllTB();

            }
        }

        private void DisableAllTB()
        {
            m_tbD15pHK1.ReadOnly = true;
            m_tbD15pHK2.ReadOnly = true;

            m_tbD1tietHK1.ReadOnly = true;
            m_tbD1tietHK2.ReadOnly = true;

            m_tbDMiengHK1.ReadOnly = true;
            m_tbDMiengHK2.ReadOnly = true;

            m_tbDThiHK1.ReadOnly = true;
            m_tbDThiHK2.ReadOnly = true;
        }

        private void EnableAllTB()
        {
            m_tbD15pHK1.ReadOnly = false;
            m_tbD15pHK2.ReadOnly = false;

            m_tbD1tietHK1.ReadOnly = false;
            m_tbD1tietHK2.ReadOnly = false;

            m_tbDMiengHK1.ReadOnly = false;
            m_tbDMiengHK2.ReadOnly = false;

            m_tbDThiHK1.ReadOnly = false;
            m_tbDThiHK2.ReadOnly = false;
        }

        private bool ConverDiem()
        {
            try
            {
                float.Parse(m_tbDMiengHK1.Text.ToString());
                float.Parse(m_tbD15pHK1.Text.ToString());
                float.Parse(m_tbD1tietHK1.Text.ToString());
                float.Parse(m_tbDThiHK1.Text.ToString());
                float.Parse(m_tbDMiengHK2.Text.ToString());
                float.Parse(m_tbD15pHK2.Text.ToString());
                float.Parse(m_tbD1tietHK2.Text.ToString());
                float.Parse(m_tbDThiHK2.Text.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void m_cbbNamHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            //LoadDiem();
        }

        private void m_cbbMonHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            //LoadDiem();
        }

        private void m_btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_btminimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
