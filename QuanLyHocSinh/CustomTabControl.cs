using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace QuanLyHocSinh
{
    public partial class CustomTabControl : TabControl
    {
        public CustomTabControl()
        {
            InitializeComponent();
        }

        private const int TCM_ADJUSTRECT = 0x1328;

        protected override void WndProc(ref Message m)
        {
            ////xoa header cua tab, xoa duong vien cua tabcontrol
            if (m.Msg == TCM_ADJUSTRECT)
            {
                RECT rect = (RECT)(m.GetLParam(typeof(RECT)));
                rect.Left = this.Left - this.Margin.Left;
                rect.Right = this.Right + this.Margin.Right;

                rect.Top = this.Top - this.Margin.Top + 1;
                rect.Bottom = this.Bottom + this.Margin.Bottom + 1;
                Marshal.StructureToPtr(rect, m.LParam, true);

            }
            //else
            // call the base class implementation
            base.WndProc(ref m);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Red, this.ClientRectangle);
            base.OnPaint(e);
        }

        private struct RECT
        {
            public int Left, Top, Right, Bottom;
        }
    }
}
