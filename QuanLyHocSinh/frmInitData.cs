using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class frmInitData : Form
    {
        public static String ConnectionString
        { get; set; }

        public frmInitData()
        {
            InitializeComponent();
            ConnectionString = "Data Source=Localhost;Initial Catalog=SQL_QUANLYHOCSINH;Integrated Security=True";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionString = String.Format("Data Source={0};Initial Catalog=SQL_QUANLYHOCSINH;Integrated Security=True", textBox1.Text);
            MessageBox.Show(ConnectionString);
            frmDangNhap dangnhap = new frmDangNhap();
            dangnhap.Show();
            dangnhap.Load += (o, b) =>
                {
                    this.Hide();
                };
        }
    }
}
