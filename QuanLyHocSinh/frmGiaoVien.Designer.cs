namespace QuanLyHocSinh
{
    partial class frmGiaoVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.m_dgvGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.m_txtMaGV = new System.Windows.Forms.TextBox();
            this.m_txtHoten = new System.Windows.Forms.TextBox();
            this.m_txtSoDT = new System.Windows.Forms.TextBox();
            this.m_dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_cbbPhanquyen = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.m_txtPass = new System.Windows.Forms.TextBox();
            this.m_txtDangnhap = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.m_txtEmail = new System.Windows.Forms.TextBox();
            this.m_cbbGioitinh = new System.Windows.Forms.ComboBox();
            this.m_btnXoa = new QuanLyHocSinh.ButtonFlat();
            this.m_btnSua = new QuanLyHocSinh.ButtonFlat();
            this.m_btnLuu = new QuanLyHocSinh.ButtonFlat();
            this.m_btnThem = new QuanLyHocSinh.ButtonFlat();
            this.m_btHide = new QuanLyHocSinh.ButtonFlat();
            this.m_btclose = new QuanLyHocSinh.ButtonFlat();
            this.m_btnTaoTK = new QuanLyHocSinh.ButtonFlat();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_dgvGV
            // 
            this.m_dgvGV.AllowUserToAddRows = false;
            this.m_dgvGV.AllowUserToDeleteRows = false;
            this.m_dgvGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.m_dgvGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.m_dgvGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.m_dgvGV.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.m_dgvGV.Location = new System.Drawing.Point(0, 353);
            this.m_dgvGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_dgvGV.Name = "m_dgvGV";
            this.m_dgvGV.ReadOnly = true;
            this.m_dgvGV.RowTemplate.Height = 24;
            this.m_dgvGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_dgvGV.Size = new System.Drawing.Size(1041, 235);
            this.m_dgvGV.TabIndex = 0;
            this.m_dgvGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.m_dgvGV_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã GV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(20, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(7, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(339, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(365, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày sinh:";
            // 
            // m_txtMaGV
            // 
            this.m_txtMaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txtMaGV.Location = new System.Drawing.Point(103, 58);
            this.m_txtMaGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_txtMaGV.Name = "m_txtMaGV";
            this.m_txtMaGV.Size = new System.Drawing.Size(221, 30);
            this.m_txtMaGV.TabIndex = 3;
            this.m_txtMaGV.TextChanged += new System.EventHandler(this.m_txtMaGV_TextChanged);
            // 
            // m_txtHoten
            // 
            this.m_txtHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txtHoten.Location = new System.Drawing.Point(101, 100);
            this.m_txtHoten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_txtHoten.Name = "m_txtHoten";
            this.m_txtHoten.Size = new System.Drawing.Size(223, 30);
            this.m_txtHoten.TabIndex = 3;
            // 
            // m_txtSoDT
            // 
            this.m_txtSoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txtSoDT.Location = new System.Drawing.Point(473, 101);
            this.m_txtSoDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_txtSoDT.Name = "m_txtSoDT";
            this.m_txtSoDT.Size = new System.Drawing.Size(184, 30);
            this.m_txtSoDT.TabIndex = 3;
            // 
            // m_dtpNgaysinh
            // 
            this.m_dtpNgaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_dtpNgaysinh.Location = new System.Drawing.Point(473, 58);
            this.m_dtpNgaysinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_dtpNgaysinh.Name = "m_dtpNgaysinh";
            this.m_dtpNgaysinh.Size = new System.Drawing.Size(184, 24);
            this.m_dtpNgaysinh.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_btnTaoTK);
            this.groupBox1.Controls.Add(this.m_cbbPhanquyen);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.m_txtPass);
            this.groupBox1.Controls.Add(this.m_txtDangnhap);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(701, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(335, 231);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tạo tài khoản đăng nhập";
            // 
            // m_cbbPhanquyen
            // 
            this.m_cbbPhanquyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cbbPhanquyen.FormattingEnabled = true;
            this.m_cbbPhanquyen.Items.AddRange(new object[] {
            "0",
            "1"});
            this.m_cbbPhanquyen.Location = new System.Drawing.Point(144, 132);
            this.m_cbbPhanquyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_cbbPhanquyen.Name = "m_cbbPhanquyen";
            this.m_cbbPhanquyen.Size = new System.Drawing.Size(184, 33);
            this.m_cbbPhanquyen.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(11, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Phân quyền:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(11, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mật khẩu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(11, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Đăng nhập:";
            // 
            // m_txtPass
            // 
            this.m_txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txtPass.Location = new System.Drawing.Point(144, 85);
            this.m_txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_txtPass.Name = "m_txtPass";
            this.m_txtPass.Size = new System.Drawing.Size(184, 30);
            this.m_txtPass.TabIndex = 3;
            // 
            // m_txtDangnhap
            // 
            this.m_txtDangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txtDangnhap.Location = new System.Drawing.Point(145, 39);
            this.m_txtDangnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_txtDangnhap.Name = "m_txtDangnhap";
            this.m_txtDangnhap.ReadOnly = true;
            this.m_txtDangnhap.Size = new System.Drawing.Size(184, 30);
            this.m_txtDangnhap.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(400, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Email:";
            // 
            // m_txtEmail
            // 
            this.m_txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txtEmail.Location = new System.Drawing.Point(473, 144);
            this.m_txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_txtEmail.Name = "m_txtEmail";
            this.m_txtEmail.Size = new System.Drawing.Size(184, 30);
            this.m_txtEmail.TabIndex = 3;
            // 
            // m_cbbGioitinh
            // 
            this.m_cbbGioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cbbGioitinh.FormattingEnabled = true;
            this.m_cbbGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.m_cbbGioitinh.Location = new System.Drawing.Point(101, 145);
            this.m_cbbGioitinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_cbbGioitinh.Name = "m_cbbGioitinh";
            this.m_cbbGioitinh.Size = new System.Drawing.Size(223, 33);
            this.m_cbbGioitinh.TabIndex = 4;
            // 
            // m_btnXoa
            // 
            this.m_btnXoa.AlphaGlow = 60F;
            this.m_btnXoa.BackColor = System.Drawing.Color.Maroon;
            this.m_btnXoa.ButtonImage = global::QuanLyHocSinh.Properties.Resources.xoa;
            this.m_btnXoa.ButtonText = "Xóa";
            this.m_btnXoa.DeltaAlphaGlow = 8F;
            this.m_btnXoa.DeltaDistance = 2F;
            this.m_btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btnXoa.HaveEffects = false;
            this.m_btnXoa.ImageOrigin = new System.Drawing.Point(0, -12);
            this.m_btnXoa.ImageSize = new System.Drawing.Size(30, 30);
            this.m_btnXoa.Location = new System.Drawing.Point(507, 226);
            this.m_btnXoa.Margin = new System.Windows.Forms.Padding(5);
            this.m_btnXoa.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.m_btnXoa.Name = "m_btnXoa";
            this.m_btnXoa.SaveChanged = false;
            this.m_btnXoa.ShadownDistance = 6;
            this.m_btnXoa.Size = new System.Drawing.Size(136, 82);
            this.m_btnXoa.TabIndex = 22;
            this.m_btnXoa.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Bot;
            this.m_btnXoa.TextColor = System.Drawing.Color.White;
            this.m_btnXoa.TextOrigin = new System.Drawing.Point(0, 0);
            this.m_btnXoa.TransparentBackColor = System.Drawing.Color.Empty;
            this.m_btnXoa.Type = QuanLyHocSinh.ButtonFlat.Types.FlatNormal;
            this.m_btnXoa.Click += new System.EventHandler(this.m_btnXoa_Click);
            // 
            // m_btnSua
            // 
            this.m_btnSua.AlphaGlow = 60F;
            this.m_btnSua.BackColor = System.Drawing.Color.Maroon;
            this.m_btnSua.ButtonImage = global::QuanLyHocSinh.Properties.Resources.chinhsua;
            this.m_btnSua.ButtonText = "Sửa";
            this.m_btnSua.DeltaAlphaGlow = 8F;
            this.m_btnSua.DeltaDistance = 2F;
            this.m_btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btnSua.HaveEffects = false;
            this.m_btnSua.ImageOrigin = new System.Drawing.Point(0, -12);
            this.m_btnSua.ImageSize = new System.Drawing.Size(30, 30);
            this.m_btnSua.Location = new System.Drawing.Point(344, 226);
            this.m_btnSua.Margin = new System.Windows.Forms.Padding(5);
            this.m_btnSua.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.m_btnSua.Name = "m_btnSua";
            this.m_btnSua.SaveChanged = false;
            this.m_btnSua.ShadownDistance = 6;
            this.m_btnSua.Size = new System.Drawing.Size(136, 82);
            this.m_btnSua.TabIndex = 21;
            this.m_btnSua.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Bot;
            this.m_btnSua.TextColor = System.Drawing.Color.White;
            this.m_btnSua.TextOrigin = new System.Drawing.Point(0, 0);
            this.m_btnSua.TransparentBackColor = System.Drawing.Color.Empty;
            this.m_btnSua.Type = QuanLyHocSinh.ButtonFlat.Types.FlatNormal;
            this.m_btnSua.Click += new System.EventHandler(this.m_btnSua_Click);
            // 
            // m_btnLuu
            // 
            this.m_btnLuu.AlphaGlow = 60F;
            this.m_btnLuu.BackColor = System.Drawing.Color.Maroon;
            this.m_btnLuu.ButtonImage = global::QuanLyHocSinh.Properties.Resources.iconsave;
            this.m_btnLuu.ButtonText = "Lưu";
            this.m_btnLuu.DeltaAlphaGlow = 8F;
            this.m_btnLuu.DeltaDistance = 2F;
            this.m_btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btnLuu.HaveEffects = false;
            this.m_btnLuu.ImageOrigin = new System.Drawing.Point(0, -12);
            this.m_btnLuu.ImageSize = new System.Drawing.Size(30, 30);
            this.m_btnLuu.Location = new System.Drawing.Point(183, 226);
            this.m_btnLuu.Margin = new System.Windows.Forms.Padding(5);
            this.m_btnLuu.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.m_btnLuu.Name = "m_btnLuu";
            this.m_btnLuu.SaveChanged = false;
            this.m_btnLuu.ShadownDistance = 6;
            this.m_btnLuu.Size = new System.Drawing.Size(136, 82);
            this.m_btnLuu.TabIndex = 20;
            this.m_btnLuu.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Bot;
            this.m_btnLuu.TextColor = System.Drawing.Color.White;
            this.m_btnLuu.TextOrigin = new System.Drawing.Point(0, 0);
            this.m_btnLuu.TransparentBackColor = System.Drawing.Color.Empty;
            this.m_btnLuu.Type = QuanLyHocSinh.ButtonFlat.Types.FlatNormal;
            this.m_btnLuu.Click += new System.EventHandler(this.m_btnLuu_Click);
            // 
            // m_btnThem
            // 
            this.m_btnThem.AlphaGlow = 60F;
            this.m_btnThem.BackColor = System.Drawing.Color.Maroon;
            this.m_btnThem.ButtonImage = global::QuanLyHocSinh.Properties.Resources.themhs;
            this.m_btnThem.ButtonText = "Thêm";
            this.m_btnThem.DeltaAlphaGlow = 8F;
            this.m_btnThem.DeltaDistance = 2F;
            this.m_btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btnThem.HaveEffects = false;
            this.m_btnThem.ImageOrigin = new System.Drawing.Point(0, -12);
            this.m_btnThem.ImageSize = new System.Drawing.Size(30, 30);
            this.m_btnThem.Location = new System.Drawing.Point(12, 226);
            this.m_btnThem.Margin = new System.Windows.Forms.Padding(5);
            this.m_btnThem.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.m_btnThem.Name = "m_btnThem";
            this.m_btnThem.SaveChanged = false;
            this.m_btnThem.ShadownDistance = 6;
            this.m_btnThem.Size = new System.Drawing.Size(136, 82);
            this.m_btnThem.TabIndex = 19;
            this.m_btnThem.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Bot;
            this.m_btnThem.TextColor = System.Drawing.Color.White;
            this.m_btnThem.TextOrigin = new System.Drawing.Point(0, 0);
            this.m_btnThem.TransparentBackColor = System.Drawing.Color.Empty;
            this.m_btnThem.Type = QuanLyHocSinh.ButtonFlat.Types.FlatNormal;
            this.m_btnThem.Click += new System.EventHandler(this.m_btnThem_Click);
            // 
            // m_btHide
            // 
            this.m_btHide.AlphaGlow = 40F;
            this.m_btHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(99)))));
            this.m_btHide.ButtonImage = global::QuanLyHocSinh.Properties.Resources.iconminmize;
            this.m_btHide.ButtonText = "";
            this.m_btHide.DeltaAlphaGlow = 8F;
            this.m_btHide.DeltaDistance = 2F;
            this.m_btHide.HaveEffects = true;
            this.m_btHide.ImageOrigin = new System.Drawing.Point(0, 0);
            this.m_btHide.ImageSize = new System.Drawing.Size(20, 20);
            this.m_btHide.Location = new System.Drawing.Point(917, 4);
            this.m_btHide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_btHide.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.m_btHide.Name = "m_btHide";
            this.m_btHide.SaveChanged = false;
            this.m_btHide.ShadownDistance = 0;
            this.m_btHide.Size = new System.Drawing.Size(61, 34);
            this.m_btHide.TabIndex = 17;
            this.m_btHide.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Bot;
            this.m_btHide.TextColor = System.Drawing.Color.White;
            this.m_btHide.TextOrigin = new System.Drawing.Point(0, 0);
            this.m_btHide.TransparentBackColor = System.Drawing.Color.Empty;
            this.m_btHide.Type = QuanLyHocSinh.ButtonFlat.Types.FlatNormal;
            // 
            // m_btclose
            // 
            this.m_btclose.AlphaGlow = 80F;
            this.m_btclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(99)))));
            this.m_btclose.ButtonImage = global::QuanLyHocSinh.Properties.Resources.iconClose;
            this.m_btclose.ButtonText = "";
            this.m_btclose.DeltaAlphaGlow = 8F;
            this.m_btclose.DeltaDistance = 2F;
            this.m_btclose.HaveEffects = true;
            this.m_btclose.ImageOrigin = new System.Drawing.Point(0, 0);
            this.m_btclose.ImageSize = new System.Drawing.Size(30, 30);
            this.m_btclose.Location = new System.Drawing.Point(984, 4);
            this.m_btclose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_btclose.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.m_btclose.Name = "m_btclose";
            this.m_btclose.SaveChanged = false;
            this.m_btclose.ShadownDistance = 0;
            this.m_btclose.Size = new System.Drawing.Size(57, 34);
            this.m_btclose.TabIndex = 18;
            this.m_btclose.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Bot;
            this.m_btclose.TextColor = System.Drawing.Color.White;
            this.m_btclose.TextOrigin = new System.Drawing.Point(0, 0);
            this.m_btclose.TransparentBackColor = System.Drawing.Color.Empty;
            this.m_btclose.Type = QuanLyHocSinh.ButtonFlat.Types.FlatNormal;
            this.m_btclose.Click += new System.EventHandler(this.m_btclose_Click);
            // 
            // m_btnTaoTK
            // 
            this.m_btnTaoTK.AlphaGlow = 60F;
            this.m_btnTaoTK.BackColor = System.Drawing.Color.Maroon;
            this.m_btnTaoTK.ButtonImage = null;
            this.m_btnTaoTK.ButtonText = "Sữa tài khoản";
            this.m_btnTaoTK.DeltaAlphaGlow = 8F;
            this.m_btnTaoTK.DeltaDistance = 2F;
            this.m_btnTaoTK.Enabled = false;
            this.m_btnTaoTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btnTaoTK.HaveEffects = false;
            this.m_btnTaoTK.ImageOrigin = new System.Drawing.Point(0, -12);
            this.m_btnTaoTK.ImageSize = new System.Drawing.Size(30, 30);
            this.m_btnTaoTK.Location = new System.Drawing.Point(145, 175);
            this.m_btnTaoTK.Margin = new System.Windows.Forms.Padding(5);
            this.m_btnTaoTK.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.m_btnTaoTK.Name = "m_btnTaoTK";
            this.m_btnTaoTK.SaveChanged = false;
            this.m_btnTaoTK.ShadownDistance = 6;
            this.m_btnTaoTK.Size = new System.Drawing.Size(184, 49);
            this.m_btnTaoTK.TabIndex = 23;
            this.m_btnTaoTK.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Center;
            this.m_btnTaoTK.TextColor = System.Drawing.Color.White;
            this.m_btnTaoTK.TextOrigin = new System.Drawing.Point(0, 0);
            this.m_btnTaoTK.TransparentBackColor = System.Drawing.Color.Empty;
            this.m_btnTaoTK.Type = QuanLyHocSinh.ButtonFlat.Types.FlatNormal;
            this.m_btnTaoTK.Click += new System.EventHandler(this.m_btnTaoTK_Click);
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1047, 588);
            this.Controls.Add(this.m_btnXoa);
            this.Controls.Add(this.m_btnSua);
            this.Controls.Add(this.m_btnLuu);
            this.Controls.Add(this.m_btnThem);
            this.Controls.Add(this.m_btHide);
            this.Controls.Add(this.m_btclose);
            this.Controls.Add(this.m_cbbGioitinh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.m_dtpNgaysinh);
            this.Controls.Add(this.m_txtHoten);
            this.Controls.Add(this.m_txtEmail);
            this.Controls.Add(this.m_txtSoDT);
            this.Controls.Add(this.m_txtMaGV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_dgvGV);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmGiaoVien";
            this.Text = "Quản lý Giáo Viên";
            this.Load += new System.EventHandler(this.frmGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView m_dgvGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox m_txtMaGV;
        private System.Windows.Forms.TextBox m_txtHoten;
        private System.Windows.Forms.TextBox m_txtSoDT;
        private System.Windows.Forms.DateTimePicker m_dtpNgaysinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox m_txtPass;
        private System.Windows.Forms.TextBox m_txtDangnhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox m_txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox m_cbbPhanquyen;
        private System.Windows.Forms.ComboBox m_cbbGioitinh;
        private ButtonFlat m_btHide;
        private ButtonFlat m_btclose;
        private ButtonFlat m_btnThem;
        private ButtonFlat m_btnLuu;
        private ButtonFlat m_btnSua;
        private ButtonFlat m_btnXoa;
        private ButtonFlat m_btnTaoTK;
    }
}