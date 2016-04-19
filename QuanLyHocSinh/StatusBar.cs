using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class StatusBar : UserControl
    {
        Label m_lbID, m_lbName, m_lbLopCN, m_lbLopBM;
        string m_id, m_name, m_lopCN, m_lopBM;

        public String ID
        {
            get { return m_id; }
            set { m_id = value; ReloadPosition(); }
        }

        public String HoVaTen
        {
            get { return m_name; }
            set { m_name = value; ReloadPosition();}
        }

        public String LopCN
        {
            get { return m_lopCN; }
            set { m_lopCN = value; ReloadPosition(); }
        }

        public String LopBM
        {
            get { return m_lopBM; }
            set { m_lopBM = value; ReloadPosition(); }
        }

        protected override void OnFontChanged(EventArgs e)
        {
            m_lbID.Font = m_lbName.Font = m_lbLopCN.Font = m_lbLopBM.Font = this.Font;
            base.OnFontChanged(e);
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            m_lbID.ForeColor = m_lbName.ForeColor = m_lbLopCN.ForeColor = m_lbLopBM.ForeColor = this.ForeColor;
            base.OnForeColorChanged(e);
        }

        public StatusBar()
        {
            InitializeComponent();

            m_lbID = new Label();
            m_lbName = new Label();
            m_lbLopCN = new Label();
            m_lbLopBM = new Label();

            m_lbID.Text = "ID: ";
            m_lbLopBM.Text = "Lớp BM: ";
            m_lbLopCN.Text = "Lớp CN: ";
            m_lbName.Text = "Họ và Tên: ";

            m_lbID.AutoSize = true;
            m_lbLopBM.AutoSize = true;
            m_lbLopCN.AutoSize = true;
            m_lbName.AutoSize = true;

            this.Controls.Add(m_lbID);
            this.Controls.Add(m_lbName);
            this.Controls.Add(m_lbLopCN);
            this.Controls.Add(m_lbLopBM);

            ReloadPosition();
        }

        private void ReloadPosition()
        {
            int distance = 20;
            if(m_lbID != null)
            {
                m_lbID.Location = new Point(0, this.Height / 2 - m_lbID.Height / 2);
                m_lbID.Text = "ID: " + m_id;
            }
               

            if (m_lbName != null)
            {
                m_lbName.Location = new Point(m_lbID.Location.X + m_lbID.Width + distance, m_lbID.Location.Y);
                m_lbName.Text = "Họ và tên: " + m_name;
            }                

            if (m_lbLopCN != null)
            {
                m_lbLopCN.Location = new Point(m_lbName.Location.X + m_lbName.Width + distance, m_lbID.Location.Y);
                m_lbLopCN.Text = "Lớp CN: " + m_lopCN;
            }
                

            if (m_lbLopBM != null)
            {
                m_lbLopBM.Location = new Point(m_lbLopCN.Location.X + m_lbLopCN.Width + distance, m_lbID.Location.Y);
                m_lbLopBM.Text = m_lopBM;
            }                         
                
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            try
            {
                ReloadPosition();
            }
            catch (Exception ex)
            {
            }
            
            base.OnSizeChanged(e);
        }
    }
}
