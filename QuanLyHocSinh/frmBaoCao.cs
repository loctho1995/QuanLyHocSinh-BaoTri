using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Data;
using BUS;
using System.Drawing.Printing;

namespace QuanLyHocSinh
{
    public partial class frmBaoCao : FormFlat
    {

        public frmBaoCao(DataGridView data, string Lop, string TableName)
        {
            InitializeComponent();

            this.m_dgvData.DataSource = data.DataSource;
            this.AllowFormResize = true;
            m_lableLop.Text = Lop;
            m_tableName.Text = TableName;

            m_btclose.BackColor = m_btHide.BackColor = m_btmaxSize.BackColor = Color.FromArgb(int.Parse(DataBase.CaiDat.TOPBUTTONCOLOR));
            button2.BackColor = Print.BackColor = m_btnPreview.BackColor = Color.FromArgb(int.Parse(DataBase.CaiDat.TABBUTTONCOLOR));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel (*.xls) |*.xls | All Files (*.*) |*.*";
            save.ShowDialog();
            
            string path = save.FileName.ToString();
            if (path != "")
            {
                DataTable dataTable = new DataTable();
                dataTable = (DataTable)m_dgvData.DataSource;
                try
                {
                    ExpEcel(dataTable, path);
                    MessageBox.Show("Success");

                }
                catch
                {
                    MessageBox.Show("Youre fucking something up!!");

                }
            }
            


        }
        void ExpEcel(DataTable data, string path)
        {
            object misValue = System.Reflection.Missing.Value;
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();

            app.Visible = false;
            Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.ActiveSheet;


            for (int i = 0; i < data.Columns.Count; i++)
            {
                ws.Cells[1, i + 1] = data.Columns[i].ColumnName;
            }
            for (int i = 0; i < data.Rows.Count; i++)
            {
                for (int j = 0; j < data.Columns.Count; j++)
                {
                    ws.Cells[i + 2, j + 1] = data.Rows[i][j].ToString();
                }
            }
            ws.Name = m_tableName.Text + m_lableLop.Text;
            wb.SaveAs(path, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            wb.Close(true, misValue, misValue);
            app.Quit();
        }

        private void m_btclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_btmaxSize_Click(object sender, EventArgs e)
        {
            (sender as ButtonFlat).SaveChanged = true;

            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
                m_btmaxSize.ButtonImage = QuanLyHocSinh.Properties.Resources.iconminsize;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                m_btmaxSize.ButtonImage = QuanLyHocSinh.Properties.Resources.iconmaxsize;
            }
        }

        private void m_btHide_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            (sender as ButtonFlat).SaveChanged = true;
        }

        private void Print_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument;

            printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateTable);





            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();

            }



        }
        public void CreateTable(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.m_dgvData.Width, this.m_dgvData.Height);
            m_dgvData.DrawToBitmap(bm, new Rectangle(0, 0, this.m_dgvData.Width, this.m_dgvData.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void Preview_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();

            printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateTable);

            PrintPreviewDialog preview = new PrintPreviewDialog();

            preview.Document = printDocument;

            preview.Show();
        }







        /*
        private void LoadDataCombobox()
        {
            m_cbbNamHoc.DataSource = hs.LayNamHoc();
            m_cbbNamHoc.DisplayMember = "TENNAMHOC";
            m_cbbNamHoc.ValueMember = "TENNAMHOC";

            //insert data for combobox hoc ky
            m_cbbHocKi.DataSource = hs.LayDuLieuHocKy();
            m_cbbHocKi.DisplayMember = "TENHOCKY";
            m_cbbHocKi.ValueMember = "MAHOCKY";

            //insert data for combobox mon hoc
            m_cbbMonHoc.DataSource = hs.LayDuLieuMonHoc();
            m_cbbMonHoc.DisplayMember = "TENMONHOC";
            m_cbbMonHoc.ValueMember = "MAMONHOC";
        }*/
    }
}

