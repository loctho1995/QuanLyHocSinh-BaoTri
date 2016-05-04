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

namespace QuanLyHocSinh
{
    
    public partial class frmCaiDat : Form
    {
        FrmMain m_frmMain;
        Color m_btTabControlColor;
        Timer m_timer;
        CAIDAT caidat = new CAIDAT();
        
        public frmCaiDat(FrmMain frmMain)
        {
            InitializeComponent();

            m_timer = new Timer();
            m_timer.Interval = 300;
            m_timer.Tick += m_timer_Tick;

            m_frmMain = frmMain;

            //buttonFlat3.BackColor = buttonFlat4.BackColor = Color.FromArgb(int.Parse(DataBase.CaiDat.TOPBUTTONCOLOR));

            InitPanel();
        }

        void m_timer_Tick(object sender, EventArgs e)
        {
            
        }

        void InitPanel()
        {
            this.MaximumSize = this.MinimumSize = this.Size;
            m_panel.BackColor = m_frmMain.BackColor;           
        }

        private void buttonFlat2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Brushes.Gray, 2), new Rectangle(0, 0, this.Width, this.Height));
            base.OnPaint(e);
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

        private void m_btformBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                m_panel.BackColor = colorDialog1.Color;
            }
        }

        private void bt_tabButtonsColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                m_btBaoCao.BackColor = m_btSuaDiem.BackColor = m_btThemHS.BackColor = m_btXemThongTin.BackColor
                    = m_btXemDiem.BackColor = m_btXoaHS.BackColor = m_btSuaHS.BackColor = colorDialog1.Color;
            }            
        }

        private void m_bttopButtonsColor_Click(object sender, EventArgs e)
        {           
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //m_btclose.BackColor = m_btmaxSize.BackColor = m_btHide.BackColor =  m_btdangXuat.BackColor
                    //= m_btCaiDat.BackColor = colorDialog1.Color;
            }
        }

        private void m_bttabPageColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                for (int i = 0; i < m_tcMain.TabPages.Count; i++)
                {
                    m_tcMain.TabPages[i].BackColor = colorDialog1.Color;
                }

                m_scMain.ShadowColor = m_tcMain.TabPages[0].BackColor;
            }
        }

        private void m_btsearchColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                m_scMain.BackColor = colorDialog1.Color;
            }
        }

        private void buttonFlat1_Click(object sender, EventArgs e)
        {
            m_panel.BackColor = Color.FromArgb(32, 36, 63);
            m_tbHoSo.BackColor = Color.FromArgb(57, 66, 99);
            m_tbBaoCao.BackColor = m_tbBaoCao.BackColor;
            m_tbHocTap.BackColor = m_tbBaoCao.BackColor;

            //m_btclose.BackColor = Color.FromArgb(54, 104, 175);
            //m_btHide.BackColor = m_btclose.BackColor;
            //m_btmaxSize.BackColor = m_btclose.BackColor;
            //m_btGiaoVien.BackColor = m_btclose.BackColor;
            //m_btCaiDat.BackColor = m_btclose.BackColor;                                                         
            

            m_btBaoCao.BackColor = m_btSuaDiem.BackColor = m_btSuaHS.BackColor = m_btThemHS.BackColor
                = m_btXemDiem.BackColor = m_btXemThongTin.BackColor = m_btXoaHS.BackColor = Color.FromArgb(19, 167, 167); 

            m_scMain.BackColor = Color.FromArgb(237, 92, 75);
            m_scMain.ShadowColor = m_tbHoSo.BackColor;
            m_scMain.LabelSearch.ForeColor = Color.White;
        }

        private void m_btSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < m_frmMain.TabControl.TabPages.Count; i++)
            {
                m_frmMain.TabControl.TabPages[i].BackColor = m_tcMain.TabPages[0].BackColor;
            }

            DataBase.CaiDatBus.insertDuLieuCatDat(caidat);
            this.Close();
        }

        private void buttonFlat3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonFlat4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
