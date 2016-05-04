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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.m_ButtonThem = new System.Windows.Forms.Button();
            this.m_ButtonLuu = new System.Windows.Forms.Button();
            this.m_ButtonSua = new System.Windows.Forms.Button();
            this.m_ButtonXoa = new System.Windows.Forms.Button();
            this.m_ButtonSuaTaiKhoan = new System.Windows.Forms.Button();
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.m_dgvGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.m_dgvGV.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.m_dgvGV.Location = new System.Drawing.Point(0, 287);
            this.m_dgvGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_dgvGV.Name = "m_dgvGV";
            this.m_dgvGV.ReadOnly = true;
            this.m_dgvGV.RowTemplate.Height = 24;
            this.m_dgvGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_dgvGV.Size = new System.Drawing.Size(781, 191);
            this.m_dgvGV.TabIndex = 0;
            this.m_dgvGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.m_dgvGV_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(11, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã GV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(15, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(5, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(254, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(274, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày sinh:";
            // 
            // m_txtMaGV
            // 
            this.m_txtMaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txtMaGV.Location = new System.Drawing.Point(77, 47);
            this.m_txtMaGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_txtMaGV.Name = "m_txtMaGV";
            this.m_txtMaGV.Size = new System.Drawing.Size(167, 26);
            this.m_txtMaGV.TabIndex = 3;
            this.m_txtMaGV.TextChanged += new System.EventHandler(this.m_txtMaGV_TextChanged);
            // 
            // m_txtHoten
            // 
            this.m_txtHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txtHoten.Location = new System.Drawing.Point(76, 81);
            this.m_txtHoten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_txtHoten.Name = "m_txtHoten";
            this.m_txtHoten.Size = new System.Drawing.Size(168, 26);
            this.m_txtHoten.TabIndex = 3;
            // 
            // m_txtSoDT
            // 
            this.m_txtSoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txtSoDT.Location = new System.Drawing.Point(355, 82);
            this.m_txtSoDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_txtSoDT.Name = "m_txtSoDT";
            this.m_txtSoDT.Size = new System.Drawing.Size(139, 26);
            this.m_txtSoDT.TabIndex = 3;
            // 
            // m_dtpNgaysinh
            // 
            this.m_dtpNgaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_dtpNgaysinh.Location = new System.Drawing.Point(355, 47);
            this.m_dtpNgaysinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_dtpNgaysinh.Name = "m_dtpNgaysinh";
            this.m_dtpNgaysinh.Size = new System.Drawing.Size(139, 21);
            this.m_dtpNgaysinh.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_ButtonSuaTaiKhoan);
            this.groupBox1.Controls.Add(this.m_cbbPhanquyen);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.m_txtPass);
            this.groupBox1.Controls.Add(this.m_txtDangnhap);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(526, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(251, 188);
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
            this.m_cbbPhanquyen.Location = new System.Drawing.Point(108, 107);
            this.m_cbbPhanquyen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_cbbPhanquyen.Name = "m_cbbPhanquyen";
            this.m_cbbPhanquyen.Size = new System.Drawing.Size(139, 28);
            this.m_cbbPhanquyen.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(8, 113);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Phân quyền:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(8, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mật khẩu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(8, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Đăng nhập:";
            // 
            // m_txtPass
            // 
            this.m_txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txtPass.Location = new System.Drawing.Point(108, 69);
            this.m_txtPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_txtPass.Name = "m_txtPass";
            this.m_txtPass.Size = new System.Drawing.Size(139, 26);
            this.m_txtPass.TabIndex = 3;
            // 
            // m_txtDangnhap
            // 
            this.m_txtDangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txtDangnhap.Location = new System.Drawing.Point(109, 32);
            this.m_txtDangnhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_txtDangnhap.Name = "m_txtDangnhap";
            this.m_txtDangnhap.ReadOnly = true;
            this.m_txtDangnhap.Size = new System.Drawing.Size(139, 26);
            this.m_txtDangnhap.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(300, 121);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Email:";
            // 
            // m_txtEmail
            // 
            this.m_txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txtEmail.Location = new System.Drawing.Point(355, 117);
            this.m_txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_txtEmail.Name = "m_txtEmail";
            this.m_txtEmail.Size = new System.Drawing.Size(139, 26);
            this.m_txtEmail.TabIndex = 3;
            // 
            // m_cbbGioitinh
            // 
            this.m_cbbGioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cbbGioitinh.FormattingEnabled = true;
            this.m_cbbGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.m_cbbGioitinh.Location = new System.Drawing.Point(76, 118);
            this.m_cbbGioitinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_cbbGioitinh.Name = "m_cbbGioitinh";
            this.m_cbbGioitinh.Size = new System.Drawing.Size(168, 28);
            this.m_cbbGioitinh.TabIndex = 4;
            // 
            // m_ButtonThem
            // 
            this.m_ButtonThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.m_ButtonThem.Location = new System.Drawing.Point(9, 185);
            this.m_ButtonThem.Name = "m_ButtonThem";
            this.m_ButtonThem.Size = new System.Drawing.Size(102, 67);
            this.m_ButtonThem.TabIndex = 23;
            this.m_ButtonThem.Text = "Thêm";
            this.m_ButtonThem.UseVisualStyleBackColor = true;
            this.m_ButtonThem.Click += new System.EventHandler(this.m_ButtonThem_Click);
            // 
            // m_ButtonLuu
            // 
            this.m_ButtonLuu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.m_ButtonLuu.Location = new System.Drawing.Point(137, 185);
            this.m_ButtonLuu.Name = "m_ButtonLuu";
            this.m_ButtonLuu.Size = new System.Drawing.Size(102, 67);
            this.m_ButtonLuu.TabIndex = 23;
            this.m_ButtonLuu.Text = "Lưu";
            this.m_ButtonLuu.UseVisualStyleBackColor = true;
            this.m_ButtonLuu.Click += new System.EventHandler(this.m_ButtonLuu_Click);
            // 
            // m_ButtonSua
            // 
            this.m_ButtonSua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.m_ButtonSua.Location = new System.Drawing.Point(258, 184);
            this.m_ButtonSua.Name = "m_ButtonSua";
            this.m_ButtonSua.Size = new System.Drawing.Size(102, 67);
            this.m_ButtonSua.TabIndex = 23;
            this.m_ButtonSua.Text = "Sửa";
            this.m_ButtonSua.UseVisualStyleBackColor = true;
            this.m_ButtonSua.Click += new System.EventHandler(this.m_ButtonSua_Click);
            // 
            // m_ButtonXoa
            // 
            this.m_ButtonXoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.m_ButtonXoa.Location = new System.Drawing.Point(380, 184);
            this.m_ButtonXoa.Name = "m_ButtonXoa";
            this.m_ButtonXoa.Size = new System.Drawing.Size(102, 67);
            this.m_ButtonXoa.TabIndex = 23;
            this.m_ButtonXoa.Text = "Xóa";
            this.m_ButtonXoa.UseVisualStyleBackColor = true;
            this.m_ButtonXoa.Click += new System.EventHandler(this.m_ButtonXoa_Click);
            // 
            // m_ButtonSuaTaiKhoan
            // 
            this.m_ButtonSuaTaiKhoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.m_ButtonSuaTaiKhoan.Location = new System.Drawing.Point(108, 142);
            this.m_ButtonSuaTaiKhoan.Name = "m_ButtonSuaTaiKhoan";
            this.m_ButtonSuaTaiKhoan.Size = new System.Drawing.Size(140, 41);
            this.m_ButtonSuaTaiKhoan.TabIndex = 23;
            this.m_ButtonSuaTaiKhoan.Text = "Sửa Tài Khoản";
            this.m_ButtonSuaTaiKhoan.UseVisualStyleBackColor = true;
            this.m_ButtonSuaTaiKhoan.Click += new System.EventHandler(this.m_ButtonSuaTaiKhoan_Click);
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(785, 478);
            this.Controls.Add(this.m_ButtonXoa);
            this.Controls.Add(this.m_ButtonSua);
            this.Controls.Add(this.m_ButtonLuu);
            this.Controls.Add(this.m_ButtonThem);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button m_ButtonThem;
        private System.Windows.Forms.Button m_ButtonLuu;
        private System.Windows.Forms.Button m_ButtonSua;
        private System.Windows.Forms.Button m_ButtonXoa;
        private System.Windows.Forms.Button m_ButtonSuaTaiKhoan;
    }
}