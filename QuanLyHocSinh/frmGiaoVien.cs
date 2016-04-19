using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace QuanLyHocSinh
{
    public partial class frmGiaoVien : Form
    {
        private GIAOVIEN giaovien;
        private USER user;
        private int type = 0;
        public frmGiaoVien()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(int.Parse(DataBase.CaiDat.MAIN_BACKCOLOR));
            this.m_btclose.BackColor = m_btHide.BackColor = Color.FromArgb(int.Parse(DataBase.CaiDat.TOPBUTTONCOLOR));
        }
        
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
        
        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadColor();
        }

        private void LoadColor()
        {
            this.BackColor = Color.FromArgb(int.Parse(DataBase.CaiDat.MAIN_BACKCOLOR));
            m_btnThem.BackColor = m_btnLuu.BackColor = m_btnSua.BackColor = m_btnTaoTK.BackColor = m_btnXoa.BackColor = Color.FromArgb(int.Parse(DataBase.CaiDat.TABBUTTONCOLOR));
            m_btHide.BackColor = m_btclose.BackColor = Color.FromArgb(int.Parse(DataBase.CaiDat.TOPBUTTONCOLOR));
        }

        private void LoadData()
        {
            m_dgvGV.DataSource = DataBase.GiaoVien.LoadDuLieuGiaoVien();
        }

        private void m_dgvGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            m_btnTaoTK.Enabled = true;
            if (m_dgvGV.SelectedRows[0] != null)
            {
                DeleteTextBox();
                DataGridViewRow row = m_dgvGV.SelectedRows[0];
                m_txtMaGV.Text = row.Cells["MAGV"].Value.ToString();
                if (row.Cells["HOTEN"].Value!=null)
                    m_txtHoten.Text = row.Cells["HOTEN"].Value.ToString();
                if (row.Cells["GIOITINH"].Value != null)
                {
                    if (row.Cells["GIOITINH"].Value.ToString()=="Nam")
                        m_cbbGioitinh.SelectedIndex = 0;
                    else
                        m_cbbGioitinh.SelectedIndex = 1;
                }
                if (row.Cells["SODT"].Value!=null)
                    m_txtSoDT.Text = row.Cells["SODT"].Value.ToString();
                if (row.Cells["NGAYSINH"].Value!=null)
                    m_dtpNgaysinh.Text = row.Cells["NGAYSINH"].Value.ToString();
                if (row.Cells["EMAIL"].Value != null)
                    m_txtEmail.Text = row.Cells["EMAIL"].Value.ToString();
                if (row.Cells["PASSWORD"].Value != null)
                    m_txtPass.Text = row.Cells["PASSWORD"].Value.ToString();

                if (row.Cells["PHANQUYEN"].Value != null)
                {
                    if (row.Cells["PHANQUYEN"].Value.ToString() == "0")
                        m_cbbPhanquyen.SelectedIndex = 0;
                    else
                        m_cbbPhanquyen.SelectedIndex = 1;
                }
            }
        }

        private void DeleteTextBox()
        {
            m_txtMaGV.Text = "";
            m_txtHoten.Text = "";
            m_txtPass.Text = "";
            m_txtSoDT.Text = "";
            m_dtpNgaysinh.Text = "";
        }

        private void m_btnThem_Click(object sender, EventArgs e)
        {
            m_btnTaoTK.Enabled = false;
            m_btnLuu.Enabled = true;
            DeleteTextBox();
        }

        private void m_txtMaGV_TextChanged(object sender, EventArgs e)
        {
            m_txtDangnhap.Text = m_txtMaGV.Text;
        }

        private void m_btnTaoTK_Click(object sender, EventArgs e)
        {
            type = 1;
            InsertDuLieu();
            type = 0;
        }

        private void m_btnLuu_Click(object sender, EventArgs e)
        {
            m_btnTaoTK.Enabled = false;
            InsertDuLieu();
        }
        private void InsertDuLieu()
        {
            if (m_txtMaGV.Text == "")
            {
                MessageBox.Show("Thông tin trống", "Thông báo!");
                return;
            }
            giaovien = new GIAOVIEN();
            giaovien.MAGV = m_txtMaGV.Text;
            giaovien.HOTEN = m_txtHoten.Text;
            giaovien.GIOITINH = m_cbbGioitinh.SelectedItem.ToString();
            giaovien.SODT = m_txtSoDT.Text;
            giaovien.NGAYSINH = DateTime.Parse(m_dtpNgaysinh.Text);
            user = new USER();
            user.PASSWORD = m_txtPass.Text;
            user.EMAIL = m_txtEmail.Text;
            if (m_cbbPhanquyen.SelectedItem.ToString() != "")
                user.PHANQUYEN = int.Parse(m_cbbPhanquyen.SelectedItem.ToString());
            if (DataBase.GiaoVien.InsertDuLieuGV(giaovien, user, type))
            {
                MessageBox.Show("Thành công", "Thông báo");
                LoadData();
                return;
            }
            MessageBox.Show("Thất bại", "Thông báo");
        }
        private void m_btnXoa_Click(object sender, EventArgs e)
        {
            if (m_txtMaGV.Text == "")
            {
                MessageBox.Show("Thông tin trống", "Thông báo!");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            m_btnTaoTK.Enabled = false;
            giaovien = new GIAOVIEN();
            giaovien.MAGV = m_txtMaGV.Text;
            if (DataBase.GiaoVien.DeleteDuLieuGV(giaovien.MAGV))
            {
                MessageBox.Show("Thành công", "Thông báo");
                LoadData();
                return;
            }
            MessageBox.Show("Thất bại", "Thông báo");
        }

        private void m_btnSua_Click(object sender, EventArgs e)
        {
            m_btnTaoTK.Enabled = false;
            if (m_txtMaGV.Text == "")
            {
                MessageBox.Show("Thông tin trống", "Thông báo!");
                return;
            }
            giaovien = new GIAOVIEN();
            giaovien.MAGV = m_txtMaGV.Text;
            giaovien.HOTEN = m_txtHoten.Text;
            giaovien.GIOITINH = m_cbbGioitinh.SelectedItem.ToString();
            giaovien.SODT = m_txtSoDT.Text;
            giaovien.NGAYSINH = DateTime.Parse(m_dtpNgaysinh.Text);
            user = new USER();
            user.PASSWORD = m_txtPass.Text;
            user.EMAIL = m_txtEmail.Text;
            if (m_cbbPhanquyen.SelectedItem!=null)
                user.PHANQUYEN = int.Parse(m_cbbPhanquyen.SelectedItem.ToString());
            if (DataBase.GiaoVien.UpdateDuLieuGV(giaovien, user))
            {
                MessageBox.Show("Thành công", "Thông báo");
                LoadData();
                return;
            }
            MessageBox.Show("Thất bại", "Thông báo");
        }

        private void m_btclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
