namespace QuanLyHocSinh
{
    partial class frmSuaNhapHS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_btHoanTat = new QuanLyHocSinh.ButtonFlat();
            this.m_btClose = new QuanLyHocSinh.ButtonFlat();
            this.m_lblManamhoc = new System.Windows.Forms.Label();
            this.m_dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.m_ccbManamhoc = new System.Windows.Forms.ComboBox();
            this.m_ccbLop = new System.Windows.Forms.ComboBox();
            this.m_tbHotenme = new System.Windows.Forms.TextBox();
            this.m_tbNghenghiepme = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.m_tbNghenghiepcha = new System.Windows.Forms.TextBox();
            this.m_tbHotencha = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.m_tbTonGiao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.m_tbEmail = new System.Windows.Forms.TextBox();
            this.m_tbDiaChi = new System.Windows.Forms.TextBox();
            this.m_tbGioiTinh = new System.Windows.Forms.TextBox();
            this.m_txtMahs = new System.Windows.Forms.TextBox();
            this.m_tbHoVaTen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_ptbHS = new System.Windows.Forms.PictureBox();
            this.m_btminimize = new QuanLyHocSinh.ButtonFlat();
            this.m_btnChonhinh = new QuanLyHocSinh.ButtonFlat();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.m_ptbHS)).BeginInit();
            this.SuspendLayout();
            // 
            // m_btHoanTat
            // 
            this.m_btHoanTat.AlphaGlow = 40F;
            this.m_btHoanTat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(99)))));
            this.m_btHoanTat.ButtonImage = global::QuanLyHocSinh.Properties.Resources.iconsave;
            this.m_btHoanTat.ButtonText = "Hoàn tất";
            this.m_btHoanTat.DeltaAlphaGlow = 2F;
            this.m_btHoanTat.DeltaDistance = 2F;
            this.m_btHoanTat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btHoanTat.HaveEffects = false;
            this.m_btHoanTat.ImageOrigin = new System.Drawing.Point(35, 0);
            this.m_btHoanTat.ImageSize = new System.Drawing.Size(30, 30);
            this.m_btHoanTat.Location = new System.Drawing.Point(740, 296);
            this.m_btHoanTat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_btHoanTat.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.m_btHoanTat.Name = "m_btHoanTat";
            this.m_btHoanTat.SaveChanged = false;
            this.m_btHoanTat.ShadownDistance = 6;
            this.m_btHoanTat.Size = new System.Drawing.Size(116, 34);
            this.m_btHoanTat.TabIndex = 59;
            this.m_btHoanTat.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Center;
            this.m_btHoanTat.TextColor = System.Drawing.Color.White;
            this.m_btHoanTat.TextOrigin = new System.Drawing.Point(-15, 0);
            this.m_btHoanTat.TransparentBackColor = System.Drawing.Color.Empty;
            this.m_btHoanTat.Type = QuanLyHocSinh.ButtonFlat.Types.FlatNormal;
            this.m_btHoanTat.Click += new System.EventHandler(this.m_btHoanTat_Click);
            // 
            // m_btClose
            // 
            this.m_btClose.AlphaGlow = 40F;
            this.m_btClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(99)))));
            this.m_btClose.ButtonImage = global::QuanLyHocSinh.Properties.Resources.iconClose;
            this.m_btClose.ButtonText = "";
            this.m_btClose.DeltaAlphaGlow = 2F;
            this.m_btClose.DeltaDistance = 2F;
            this.m_btClose.HaveEffects = false;
            this.m_btClose.ImageOrigin = new System.Drawing.Point(0, 0);
            this.m_btClose.ImageSize = new System.Drawing.Size(25, 25);
            this.m_btClose.Location = new System.Drawing.Point(871, 2);
            this.m_btClose.Margin = new System.Windows.Forms.Padding(4);
            this.m_btClose.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.m_btClose.Name = "m_btClose";
            this.m_btClose.SaveChanged = false;
            this.m_btClose.ShadownDistance = 6;
            this.m_btClose.Size = new System.Drawing.Size(43, 26);
            this.m_btClose.TabIndex = 57;
            this.m_btClose.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Bot;
            this.m_btClose.TextColor = System.Drawing.Color.White;
            this.m_btClose.TextOrigin = new System.Drawing.Point(0, 0);
            this.m_btClose.TransparentBackColor = System.Drawing.Color.Empty;
            this.m_btClose.Type = QuanLyHocSinh.ButtonFlat.Types.FlatNormal;
            this.m_btClose.Click += new System.EventHandler(this.m_btClose_Click);
            // 
            // m_lblManamhoc
            // 
            this.m_lblManamhoc.AutoSize = true;
            this.m_lblManamhoc.BackColor = System.Drawing.Color.Transparent;
            this.m_lblManamhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lblManamhoc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.m_lblManamhoc.Location = new System.Drawing.Point(152, 304);
            this.m_lblManamhoc.Name = "m_lblManamhoc";
            this.m_lblManamhoc.Size = new System.Drawing.Size(100, 24);
            this.m_lblManamhoc.TabIndex = 56;
            this.m_lblManamhoc.Text = "Năm học:";
            this.m_lblManamhoc.Visible = false;
            // 
            // m_dtpNgaysinh
            // 
            this.m_dtpNgaysinh.Location = new System.Drawing.Point(288, 154);
            this.m_dtpNgaysinh.Margin = new System.Windows.Forms.Padding(2);
            this.m_dtpNgaysinh.Name = "m_dtpNgaysinh";
            this.m_dtpNgaysinh.Size = new System.Drawing.Size(156, 20);
            this.m_dtpNgaysinh.TabIndex = 55;
            // 
            // m_ccbManamhoc
            // 
            this.m_ccbManamhoc.FormattingEnabled = true;
            this.m_ccbManamhoc.Location = new System.Drawing.Point(288, 308);
            this.m_ccbManamhoc.Margin = new System.Windows.Forms.Padding(2);
            this.m_ccbManamhoc.Name = "m_ccbManamhoc";
            this.m_ccbManamhoc.Size = new System.Drawing.Size(156, 21);
            this.m_ccbManamhoc.TabIndex = 54;
            this.m_ccbManamhoc.Visible = false;
            this.m_ccbManamhoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m_ccbManamhoc_KeyPress);
            // 
            // m_ccbLop
            // 
            this.m_ccbLop.FormattingEnabled = true;
            this.m_ccbLop.Location = new System.Drawing.Point(700, 81);
            this.m_ccbLop.Margin = new System.Windows.Forms.Padding(2);
            this.m_ccbLop.Name = "m_ccbLop";
            this.m_ccbLop.Size = new System.Drawing.Size(156, 21);
            this.m_ccbLop.TabIndex = 54;
            // 
            // m_tbHotenme
            // 
            this.m_tbHotenme.Location = new System.Drawing.Point(700, 195);
            this.m_tbHotenme.Multiline = true;
            this.m_tbHotenme.Name = "m_tbHotenme";
            this.m_tbHotenme.Size = new System.Drawing.Size(156, 20);
            this.m_tbHotenme.TabIndex = 53;
            this.m_tbHotenme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m_tb_KeyPress);
            // 
            // m_tbNghenghiepme
            // 
            this.m_tbNghenghiepme.Location = new System.Drawing.Point(700, 232);
            this.m_tbNghenghiepme.Multiline = true;
            this.m_tbNghenghiepme.Name = "m_tbNghenghiepme";
            this.m_tbNghenghiepme.Size = new System.Drawing.Size(156, 20);
            this.m_tbNghenghiepme.TabIndex = 53;
            this.m_tbNghenghiepme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m_tb_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(700, 195);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(156, 20);
            this.textBox4.TabIndex = 52;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(547, 232);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 24);
            this.label13.TabIndex = 50;
            this.label13.Text = "Nghề nghiệp:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(547, 195);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 24);
            this.label14.TabIndex = 51;
            this.label14.Text = "Họ và tên Mẹ:";
            // 
            // m_tbNghenghiepcha
            // 
            this.m_tbNghenghiepcha.Location = new System.Drawing.Point(700, 159);
            this.m_tbNghenghiepcha.Multiline = true;
            this.m_tbNghenghiepcha.Name = "m_tbNghenghiepcha";
            this.m_tbNghenghiepcha.Size = new System.Drawing.Size(156, 20);
            this.m_tbNghenghiepcha.TabIndex = 49;
            this.m_tbNghenghiepcha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m_tb_KeyPress);
            // 
            // m_tbHotencha
            // 
            this.m_tbHotencha.Location = new System.Drawing.Point(700, 122);
            this.m_tbHotencha.Multiline = true;
            this.m_tbHotencha.Name = "m_tbHotencha";
            this.m_tbHotencha.Size = new System.Drawing.Size(156, 20);
            this.m_tbHotencha.TabIndex = 48;
            this.m_tbHotencha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m_tb_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(547, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 24);
            this.label10.TabIndex = 45;
            this.label10.Text = "Nghề nghiệp:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(547, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 24);
            this.label11.TabIndex = 46;
            this.label11.Text = "Lớp:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(547, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 24);
            this.label12.TabIndex = 47;
            this.label12.Text = "Họ và tên Cha:";
            // 
            // m_tbTonGiao
            // 
            this.m_tbTonGiao.Location = new System.Drawing.Point(288, 271);
            this.m_tbTonGiao.Multiline = true;
            this.m_tbTonGiao.Name = "m_tbTonGiao";
            this.m_tbTonGiao.Size = new System.Drawing.Size(156, 20);
            this.m_tbTonGiao.TabIndex = 43;
            this.m_tbTonGiao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m_tb_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(152, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 24);
            this.label8.TabIndex = 42;
            this.label8.Text = "Tôn giáo:";
            // 
            // m_tbEmail
            // 
            this.m_tbEmail.Location = new System.Drawing.Point(700, 269);
            this.m_tbEmail.Multiline = true;
            this.m_tbEmail.Name = "m_tbEmail";
            this.m_tbEmail.Size = new System.Drawing.Size(156, 20);
            this.m_tbEmail.TabIndex = 40;
            this.m_tbEmail.TextChanged += new System.EventHandler(this.m_tbEmail_TextChanged);
            this.m_tbEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m_tb_KeyPress);
            // 
            // m_tbDiaChi
            // 
            this.m_tbDiaChi.Location = new System.Drawing.Point(288, 234);
            this.m_tbDiaChi.Multiline = true;
            this.m_tbDiaChi.Name = "m_tbDiaChi";
            this.m_tbDiaChi.Size = new System.Drawing.Size(156, 20);
            this.m_tbDiaChi.TabIndex = 39;
            this.m_tbDiaChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m_tb_KeyPress);
            // 
            // m_tbGioiTinh
            // 
            this.m_tbGioiTinh.Location = new System.Drawing.Point(288, 199);
            this.m_tbGioiTinh.Multiline = true;
            this.m_tbGioiTinh.Name = "m_tbGioiTinh";
            this.m_tbGioiTinh.Size = new System.Drawing.Size(156, 20);
            this.m_tbGioiTinh.TabIndex = 38;
            this.m_tbGioiTinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m_tb_KeyPress);
            // 
            // m_txtMahs
            // 
            this.m_txtMahs.Location = new System.Drawing.Point(288, 81);
            this.m_txtMahs.Multiline = true;
            this.m_txtMahs.Name = "m_txtMahs";
            this.m_txtMahs.ReadOnly = true;
            this.m_txtMahs.Size = new System.Drawing.Size(156, 20);
            this.m_txtMahs.TabIndex = 36;
            this.m_txtMahs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m_tb_KeyPress);
            // 
            // m_tbHoVaTen
            // 
            this.m_tbHoVaTen.Location = new System.Drawing.Point(288, 116);
            this.m_tbHoVaTen.Multiline = true;
            this.m_tbHoVaTen.Name = "m_tbHoVaTen";
            this.m_tbHoVaTen.Size = new System.Drawing.Size(156, 20);
            this.m_tbHoVaTen.TabIndex = 36;
            this.m_tbHoVaTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m_tb_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(307, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Thông tin chi tiết học sinh";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(547, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 24);
            this.label9.TabIndex = 24;
            this.label9.Text = "Lớp:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(547, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 24);
            this.label7.TabIndex = 26;
            this.label7.Text = "Lớp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(547, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 32;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(152, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 33;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(152, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(152, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "Ngày sinh:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(152, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 24);
            this.label15.TabIndex = 21;
            this.label15.Text = "Mã học sinh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(152, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Họ và tên:";
            // 
            // m_ptbHS
            // 
            this.m_ptbHS.BackColor = System.Drawing.Color.Transparent;
            this.m_ptbHS.Image = global::QuanLyHocSinh.Properties.Resources.Hacker;
            this.m_ptbHS.Location = new System.Drawing.Point(12, 81);
            this.m_ptbHS.Name = "m_ptbHS";
            this.m_ptbHS.Size = new System.Drawing.Size(120, 160);
            this.m_ptbHS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_ptbHS.TabIndex = 20;
            this.m_ptbHS.TabStop = false;
            // 
            // m_btminimize
            // 
            this.m_btminimize.AlphaGlow = 40F;
            this.m_btminimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(99)))));
            this.m_btminimize.ButtonImage = global::QuanLyHocSinh.Properties.Resources.iconminmize;
            this.m_btminimize.ButtonText = "";
            this.m_btminimize.DeltaAlphaGlow = 2F;
            this.m_btminimize.DeltaDistance = 2F;
            this.m_btminimize.HaveEffects = false;
            this.m_btminimize.ImageOrigin = new System.Drawing.Point(0, 0);
            this.m_btminimize.ImageSize = new System.Drawing.Size(25, 25);
            this.m_btminimize.Location = new System.Drawing.Point(822, 2);
            this.m_btminimize.Margin = new System.Windows.Forms.Padding(4);
            this.m_btminimize.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.m_btminimize.Name = "m_btminimize";
            this.m_btminimize.SaveChanged = false;
            this.m_btminimize.ShadownDistance = 6;
            this.m_btminimize.Size = new System.Drawing.Size(43, 26);
            this.m_btminimize.TabIndex = 60;
            this.m_btminimize.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Bot;
            this.m_btminimize.TextColor = System.Drawing.Color.White;
            this.m_btminimize.TextOrigin = new System.Drawing.Point(0, 0);
            this.m_btminimize.TransparentBackColor = System.Drawing.Color.Empty;
            this.m_btminimize.Type = QuanLyHocSinh.ButtonFlat.Types.FlatNormal;
            this.m_btminimize.Click += new System.EventHandler(this.m_btminimize_Click);
            // 
            // m_btnChonhinh
            // 
            this.m_btnChonhinh.AlphaGlow = 40F;
            this.m_btnChonhinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(99)))));
            this.m_btnChonhinh.ButtonImage = null;
            this.m_btnChonhinh.ButtonText = "Chọn hình";
            this.m_btnChonhinh.DeltaAlphaGlow = 2F;
            this.m_btnChonhinh.DeltaDistance = 2F;
            this.m_btnChonhinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btnChonhinh.HaveEffects = false;
            this.m_btnChonhinh.ImageOrigin = new System.Drawing.Point(0, 0);
            this.m_btnChonhinh.ImageSize = new System.Drawing.Size(50, 50);
            this.m_btnChonhinh.Location = new System.Drawing.Point(31, 249);
            this.m_btnChonhinh.Margin = new System.Windows.Forms.Padding(5);
            this.m_btnChonhinh.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.m_btnChonhinh.Name = "m_btnChonhinh";
            this.m_btnChonhinh.SaveChanged = false;
            this.m_btnChonhinh.ShadownDistance = 6;
            this.m_btnChonhinh.Size = new System.Drawing.Size(87, 32);
            this.m_btnChonhinh.TabIndex = 61;
            this.m_btnChonhinh.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Center;
            this.m_btnChonhinh.TextColor = System.Drawing.Color.White;
            this.m_btnChonhinh.TextOrigin = new System.Drawing.Point(0, 0);
            this.m_btnChonhinh.TransparentBackColor = System.Drawing.Color.Empty;
            this.m_btnChonhinh.Type = QuanLyHocSinh.ButtonFlat.Types.FlatNormal;
            this.m_btnChonhinh.Click += new System.EventHandler(this.m_btnChonhinh_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmSuaNhapHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(917, 365);
            this.Controls.Add(this.m_btnChonhinh);
            this.Controls.Add(this.m_btminimize);
            this.Controls.Add(this.m_btHoanTat);
            this.Controls.Add(this.m_btClose);
            this.Controls.Add(this.m_lblManamhoc);
            this.Controls.Add(this.m_dtpNgaysinh);
            this.Controls.Add(this.m_ccbManamhoc);
            this.Controls.Add(this.m_ccbLop);
            this.Controls.Add(this.m_tbHotenme);
            this.Controls.Add(this.m_tbNghenghiepme);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.m_tbNghenghiepcha);
            this.Controls.Add(this.m_tbHotencha);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.m_tbTonGiao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.m_tbEmail);
            this.Controls.Add(this.m_tbDiaChi);
            this.Controls.Add(this.m_tbGioiTinh);
            this.Controls.Add(this.m_txtMahs);
            this.Controls.Add(this.m_tbHoVaTen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_ptbHS);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSuaNhapHS";
            this.Text = "frmSuaNhapHS";
            ((System.ComponentModel.ISupportInitialize)(this.m_ptbHS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox m_ptbHS;
        private System.Windows.Forms.TextBox m_tbHoVaTen;
        private System.Windows.Forms.TextBox m_tbGioiTinh;
        private System.Windows.Forms.TextBox m_tbDiaChi;
        private System.Windows.Forms.TextBox m_tbEmail;
        private System.Windows.Forms.TextBox m_tbTonGiao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox m_tbNghenghiepcha;
        private System.Windows.Forms.TextBox m_tbHotencha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox m_tbNghenghiepme;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox m_tbHotenme;
        private System.Windows.Forms.TextBox m_txtMahs;
        private System.Windows.Forms.ComboBox m_ccbLop;
        private System.Windows.Forms.DateTimePicker m_dtpNgaysinh;
        private System.Windows.Forms.Label m_lblManamhoc;
        private System.Windows.Forms.ComboBox m_ccbManamhoc;
        private ButtonFlat m_btClose;
        private ButtonFlat m_btHoanTat;
        private ButtonFlat m_btminimize;
        private ButtonFlat m_btnChonhinh;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

    }
}