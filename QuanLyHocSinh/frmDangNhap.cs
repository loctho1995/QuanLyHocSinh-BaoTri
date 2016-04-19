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
using QuanLyHocSinh.Data;
namespace QuanLyHocSinh
{
    public partial class frmDangNhap : Form
    {
        string name = null, malop = null;
        string[] malopbomon = null;
        int phanquyen = 0;

        public frmDangNhap()
        {
            InitializeComponent();

            if (!DataBase.IsLoaded)
            {
                DataBase.InitDataBase();
            }

            this.BackColor = Color.FromArgb(int.Parse(DataBase.CaiDat.MAIN_BACKCOLOR));
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);

                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }
            base.WndProc(ref m);
        }

        private void m_dangNhapBtn_Click(object sender, EventArgs e)
        {
            if(Check() == true)
            {
                DataBase.GiaoVien.LayGVBoMon(ref malopbomon, m_tbID.Text.ToUpper());
                this.Hide();
                FrmMain.m_phanquyen.ID = m_tbID.Text.ToUpper();
                FrmMain.m_phanquyen.Username = name;
                FrmMain.m_phanquyen.LopCN = malop.Trim();
                FrmMain.m_phanquyen.PhanQuyen = phanquyen;
                FrmMain.m_phanquyen.LopBM = malopbomon;
                FrmMain frmMain = new FrmMain();
                frmMain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không chính xác!!!");
            }
        }

        private bool Check()
        {
            int x = DataBase.User.DangNhap(m_tbID.Text, m_tbPass.Text, ref name, ref malop, ref phanquyen);
            if (x == 1)
                return true;
            else if (x == 2)
            {
                malop = "Trống";
                return true;
            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();
            this.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keydata)
        {
            if (keydata == Keys.Enter)
            {
                if (Check() == true)
                {
                    DataBase.GiaoVien.LayGVBoMon(ref malopbomon, m_tbID.Text.ToUpper());
                    this.Hide();
                    FrmMain.m_phanquyen.ID = m_tbID.Text.ToUpper();
                    FrmMain.m_phanquyen.Username = name;
                    FrmMain.m_phanquyen.LopCN = malop.ToUpper();
                    FrmMain.m_phanquyen.PhanQuyen = phanquyen;
                    FrmMain.m_phanquyen.LopBM = malopbomon;
                    FrmMain frmMain = new FrmMain();
                    frmMain.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác");
                }
                return true;
            }
            else
            {
                return false;
            }

        }

        private void buttonFlat1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_btminimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmData frm = new frmData();
            frm.Show();
        }
    }
}
