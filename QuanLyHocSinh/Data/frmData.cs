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

namespace QuanLyHocSinh.Data
{
    public partial class frmData : Form
    {
        public frmData()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(int.Parse(DataBase.CaiDat.MAIN_BACKCOLOR));
            this.MaximumSize = this.MinimumSize = this.Size;
        }

        private void m_btnBackup_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Bak (*.bak) | *.bak | SQL (*.sql)|*.sql";
            save.ShowDialog();

            string path = save.FileName.ToString();
            if (path == "") return;
            if(DataBase.Data.BackupData(path))
            {
                MessageBox.Show("Thành công","Thông báo");
                return;
            }
            MessageBox.Show("Thất bại", "Thông báo");
        }

        private void m_btnRestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();

            string path = open.FileName.ToString();
            if (path == "") return;
            if(DataBase.Data.RestoreData(path))
            {
                MessageBox.Show("Thành công","Thông báo");
                return;
            }
            MessageBox.Show("Thất bại", "Thông báo");
        }

        private void m_btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_btHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
    }
}
