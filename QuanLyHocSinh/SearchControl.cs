using System.Drawing;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace QuanLyHocSinh
{
    public partial class SearchControl : UserControl
    {
        #region - PROPERTIES AND ATTRIBUTES -
        //size khi hien len
        Size m_hideSize;
        /// <summary>
        /// Size của Control khi bị ẩn đi (chỉ con mình button)
        /// </summary>
        public Size HideSize
        {
            get { return m_hideSize; }
            set { m_hideSize = value; }
        }

        Size m_showSize;
        /// <summary>
        /// Size của Control khi được hiện lên
        /// </summary>
        public Size ShowSize
        {
            get { return m_showSize; }
            set { m_showSize = value; }
        }

        TextBox m_tb;
        public TextBox TextBoxSearch
        { 
            get { return m_tb; }
            set { m_tb = value; }
        }

        Button m_bt;
        public Button ButtonSearch
        {
            get { return m_bt; }
            set { m_bt = value; }
        }

        Label m_lb;
        public Label LabelSearch
        {
            get { return m_lb; }
            set { m_lb = value; }
        }

        public enum States
        {
            Show, Hide, Moving
        }
        States m_state;
        public States State
        {
            get { return m_state; }
            set { m_state = value; }
        }

        public enum MouseStates
        {
            Leave, Hover
        }
        MouseStates m_mouseState;

        float m_opacity;
        public float Opacity
        {
            get { return m_opacity; }
            set { m_opacity = value; }
        }

        int m_speed;
        /// <summary>
        /// Tốc độ di chuyển của Control khi hiện / ẩn
        /// </summary>
        public int Speed
        {
            get { return m_speed; }
            set { m_speed = value; }
        }

        int m_deltaSpeed;
        /// <summary>
        /// Tốc độ biến thiên (nhanh dần đều / chậm dần đều)
        /// </summary>
        public int DeltaSpeed
        {
            get { return m_deltaSpeed; }
            set { m_deltaSpeed = value; }
        }

        public Color m_shadowColor;
        public Color ShadowColor
        {
            get { return m_shadowColor; }
            set { m_shadowColor = value; }
        }

        Timer   m_timer, m_timerGlowAlpha; //timer hide/ show form và timer làm ảnh mập mờ
        Point   m_oldLocation; //vị trí của Control trước khi di chuyển ta sẽ dùng vị trí này làm chuẩn setposition cho control
        bool    m_firstTimeChange,//lần đầu thay đổi postion để set old position
                m_btClick; //cho biết kếu button click thì sẽ không set đến mousemove để có thể đóng control

        private enum AlphaStates
        {
            GlowUp, GlowDown
        }

        #endregion

        #region - Methods -
        public SearchControl()
        {
            #region -Init-
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            #region -Init Attributes-
            m_speed = 1; //tốc độ di chuyển hiện tại
            m_deltaSpeed = 2; //tốc độ biến thiên
            m_opacity = 1;
            m_firstTimeChange = false;

            m_hideSize = new System.Drawing.Size(30, this.Height);
            m_showSize = new System.Drawing.Size(250, this.Height);
            #endregion

            #region -Button Search-
            m_bt = new Button();
            m_bt.Size = new System.Drawing.Size(25, m_showSize.Height);
            m_bt.Location = new System.Drawing.Point(this.Location.X, this.Location.Y);
            m_bt.Image = new Bitmap(QuanLyHocSinh.Properties.Resources.showButton, new Size((int)(m_bt.Width * 0.8), m_bt.Height));
            m_bt.Anchor = AnchorStyles.Left;
            m_bt.FlatStyle = FlatStyle.Flat;
            m_bt.FlatAppearance.BorderSize = 0;
            m_bt.MouseMove += m_MouseMove;
            m_bt.BackColor = Color.Transparent;
            m_bt.MouseClick += (o, e) =>
                {
                    if (m_state == States.Show)
                    {
                        m_btClick = true;
                        m_mouseState = MouseStates.Leave;
                        m_timer.Start();
                    }
                    else
                    {
                        if (e.X < this.Location.X || e.X > this.Location.X + this.Width || e.Y < this.Location.Y
                            || e.Y > this.Location.Y + this.Height)
                        {
                            //khi vào control, cho chạy timmer lúc này sẽ kéo dài control ra
                            m_mouseState = MouseStates.Hover;
                            m_timer.Start();
                        }
                    }    
                };

            m_bt.SizeChanged += (o, e) =>
                {
                    m_bt.Location = new Point(this.HideSize.Width - m_bt.Width, 0);
                };
           
                        #endregion

            #region -TextBox Search-
            m_tb = new TextBox();
            m_tb.Size = new System.Drawing.Size(this.Width - m_bt.Width - 10, this.Height * 2 / 3);
            m_tb.Location = new Point(m_bt.Location.X + m_bt.Width + 5, this.Height / 2 - m_tb.Height / 2);
            m_tb.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Italic);
            m_tb.Text = "Nhập tên học sinh";
            m_tb.Anchor = AnchorStyles.Left;
            m_tb.MouseMove += m_MouseMove;     
            //khi TextBox được Focus thì xóa text để cho người dùng nhập text
            m_tb.GotFocus += (o, e) =>
                {
                    m_tb.Text = "";
                };
            //khi TextBox không còn được focus thì đóng control lại
            #endregion

            #region -Label-
            m_lb = new Label();
            m_lb.AutoSize = true;
            m_lb.Font = new System.Drawing.Font("Tahoma", 12, FontStyle.Bold);
            m_lb.Text = "Tìm kiếm học sinh";
            m_lb.Location = new Point(m_tb.Location.X + (m_showSize.Width / 2 - m_lb.Width), this.Location.Y + 5);//this.Location;
            m_lb.ForeColor = Color.Red;
            m_lb.BackColor = Color.Transparent;
            #endregion

            #region -Add controls-
            this.Controls.Add(m_bt);
            this.Controls.Add(m_tb);
            this.Controls.Add(m_lb);
            #endregion

            #region -Timers-
            m_timer = new Timer();
            m_timer.Interval = 100;
            m_timer.Tick += m_timer_Tick;
            m_timer.Enabled = true;
            m_timer.Stop();

            m_timerGlowAlpha = new Timer();
            m_timerGlowAlpha.Interval = 100;
            m_timerGlowAlpha.Tick += m_timer_Tick;
            m_timerGlowAlpha.Enabled = true;
            m_timerGlowAlpha.Stop();
            #endregion

            this.LocationChanged += (o, e) =>
                {
                    if (m_state != States.Moving)
                    {
                        //kiểm tra trường hợp thay đổi Location của control ta phải cập nhật lại để khi control di chuyển thì dừng
                        //đúng vị trí không bị lệch
                        m_oldLocation = this.Location;
                    }
                };

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ContainerControl | ControlStyles.AllPaintingInWmPaint, true);
            #endregion
        }        

        #region - EVENTS - 
        private void m_MouseMove(object sender, MouseEventArgs e)
        {
            //if (m_btClick)
            //    return;

            //if (e.X < this.Location.X || e.X > this.Location.X + this.Width || e.Y < this.Location.Y
            //    || e.Y > this.Location.Y + this.Height)
            //{
            //    //khi vào control, cho chạy timmer lúc này sẽ kéo dài control ra
            //    m_mouseState = MouseStates.Hover;
            //    m_timer.Start();
            //}
            //else
            //{
            //    //ngược lại với trên
            //    //m_mouseState = MouseStates.Leave;
            //    //m_timer.Start();
            //}
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            m_bt.Location = new Point(0, 0);
            m_tb.Location = new Point(m_bt.Location.X + m_bt.Width + 5, this.Height / 2 - m_tb.Height / 2);
            m_bt.Height = this.Height;

            //LinearGradientBrush brush = new LinearGradientBrush(new System.Drawing.Point(0, 0), new System.Drawing.Point(this.HideSize.Width - m_bt.Width, 0),
            //                                                        ShadowColor, Color.FromArgb(180, 20, 20, 20));
            
            //e.Graphics.FillRectangle(brush, new Rectangle(0, 0, (this.HideSize.Width - m_bt.Width), this.Height));
            
            base.OnPaint(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (m_btClick)
                return;

            //kiểm tra nếu rê chuột vào trong vùng thì lúc này thực hiện Show/Hide
            if (e.X < this.Location.X || e.X > this.Location.X + this.Width || e.Y < this.Location.Y
                || e.Y > this.Location.Y + this.Height)
            {
                m_mouseState = MouseStates.Hover;
                m_timer.Start();
            }
            else
            {
                m_mouseState = MouseStates.Leave;
                m_timer.Start();
            }

            base.OnMouseMove(e);
        }

        void m_timer_Tick(object sender, EventArgs e)
        {
            switch (m_mouseState)
            {
                case MouseStates.Leave:
                    if (m_state == States.Hide)
                        break;

                    if (this.Width - m_speed < m_hideSize.Width)
                    {
                        //nguyên tẵng của việc đóng control là ta thu nhỏ độ dài và chuyển position dịch sang phải vì ta lấy điểm vẽ là
                        //góc trái trên. Tương tự với việc kéo control ra
                        this.Width = m_hideSize.Width;
                        this.Location = m_oldLocation;
                        this.Invalidate();

                        m_firstTimeChange = true;
                        Bitmap bm = new Bitmap(QuanLyHocSinh.Properties.Resources.showButton,
                                                    new Size((int)(m_bt.Width * 0.8), m_bt.Height));
                        m_state = States.Hide;
                        m_bt.Image = bm;
                        m_btClick = false;
                        m_speed = 1;
                        m_timer.Stop();
                        break;
                    }

                    if (m_firstTimeChange)
                    {
                        //phải xử lý hàm này vì nếu không có khi Control ở state Show mà phóng to form sẽ bị lỗi chỗ Location
                        //khi phóng to form thì location của control sẽ bị sai lệch (m_oldLocation)
                        m_firstTimeChange = false;
                        m_oldLocation = new Point(this.Location.X + this.ShowSize.Width - m_hideSize.Width, this.Location.Y);
                    }

                    m_state = States.Moving;
                    this.Width -= m_speed;//new Size(this.Width - 5, this.Height);
                    this.Location = new Point(this.Location.X + m_speed, this.Location.Y);
                    m_speed += m_deltaSpeed;
                    this.Invalidate(); //gọi hàm này để vẽ lại form

                    break;

                case MouseStates.Hover:
                    if (m_state == States.Show)
                        break;

                    if (this.Width + m_speed > m_showSize.Width)
                    {
                        this.Width = m_showSize.Width;
                        this.Location = new Point(m_oldLocation.X - m_showSize.Width + m_hideSize.Width, m_oldLocation.Y);
                        this.Invalidate();

                        //lật ngược ảnh khi đủ size
                        m_firstTimeChange = true;
                        Bitmap bm = new Bitmap(QuanLyHocSinh.Properties.Resources.showButton,
                                                 new Size((int)(m_bt.Width * 0.8), m_bt.Height));
                        bm.RotateFlip(RotateFlipType.RotateNoneFlipX);
                        m_bt.Image = bm;
                        m_state = States.Show;
                        m_speed = 1;
                        m_timer.Stop();
                        break;
                    }                                                 

                    if(m_firstTimeChange)
                    {
                        m_firstTimeChange = false;
                        m_oldLocation = this.Location;
                    }

                    m_state = States.Moving;
                    this.Width += m_speed;// new Size(this.Width + 5, this.Height);
                    this.Location = new Point(this.Location.X - m_speed, this.Location.Y);
                    m_speed += m_deltaSpeed;
                    this.Invalidate();
                    break;
            }
        }
        #endregion

        #endregion
    }
}
