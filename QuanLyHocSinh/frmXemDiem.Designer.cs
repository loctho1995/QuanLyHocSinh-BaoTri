namespace QuanLyHocSinh
{
    partial class frmXemDiem
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
            this.m_btminimize = new QuanLyHocSinh.ButtonFlat();
            this.m_btClose = new QuanLyHocSinh.ButtonFlat();
            this.m_lbLop = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.m_lbTenHS = new System.Windows.Forms.Label();
            this.m_lbMaHS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_cbbHocKi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_cbbNamHoc = new System.Windows.Forms.ComboBox();
            this.m_dgvMain = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.m_btminimize.Location = new System.Drawing.Point(588, 2);
            this.m_btminimize.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.m_btminimize.Name = "m_btminimize";
            this.m_btminimize.SaveChanged = false;
            this.m_btminimize.ShadownDistance = 6;
            this.m_btminimize.Size = new System.Drawing.Size(43, 27);
            this.m_btminimize.TabIndex = 55;
            this.m_btminimize.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Bot;
            this.m_btminimize.TextColor = System.Drawing.Color.White;
            this.m_btminimize.TextOrigin = new System.Drawing.Point(0, 0);
            this.m_btminimize.Click += new System.EventHandler(this.m_btminimize_Click);
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
            this.m_btClose.Location = new System.Drawing.Point(637, 2);
            this.m_btClose.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.m_btClose.Name = "m_btClose";
            this.m_btClose.SaveChanged = false;
            this.m_btClose.ShadownDistance = 6;
            this.m_btClose.Size = new System.Drawing.Size(43, 27);
            this.m_btClose.TabIndex = 54;
            this.m_btClose.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Bot;
            this.m_btClose.TextColor = System.Drawing.Color.White;
            this.m_btClose.TextOrigin = new System.Drawing.Point(0, 0);
            this.m_btClose.Click += new System.EventHandler(this.m_btClose_Click);
            // 
            // m_lbLop
            // 
            this.m_lbLop.AutoSize = true;
            this.m_lbLop.BackColor = System.Drawing.Color.Transparent;
            this.m_lbLop.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbLop.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.m_lbLop.Location = new System.Drawing.Point(209, 109);
            this.m_lbLop.Name = "m_lbLop";
            this.m_lbLop.Size = new System.Drawing.Size(0, 23);
            this.m_lbLop.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(153, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 52;
            this.label5.Text = "Lớp:";
            // 
            // m_lbTenHS
            // 
            this.m_lbTenHS.AutoSize = true;
            this.m_lbTenHS.BackColor = System.Drawing.Color.Transparent;
            this.m_lbTenHS.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbTenHS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.m_lbTenHS.Location = new System.Drawing.Point(257, 80);
            this.m_lbTenHS.Name = "m_lbTenHS";
            this.m_lbTenHS.Size = new System.Drawing.Size(0, 23);
            this.m_lbTenHS.TabIndex = 50;
            // 
            // m_lbMaHS
            // 
            this.m_lbMaHS.AutoSize = true;
            this.m_lbMaHS.BackColor = System.Drawing.Color.Transparent;
            this.m_lbMaHS.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbMaHS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.m_lbMaHS.Location = new System.Drawing.Point(283, 45);
            this.m_lbMaHS.Name = "m_lbMaHS";
            this.m_lbMaHS.Size = new System.Drawing.Size(0, 23);
            this.m_lbMaHS.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(562, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 26);
            this.label3.TabIndex = 46;
            this.label3.Text = "Học kì";
            // 
            // m_cbbHocKi
            // 
            this.m_cbbHocKi.FormattingEnabled = true;
            this.m_cbbHocKi.Location = new System.Drawing.Point(541, 163);
            this.m_cbbHocKi.Name = "m_cbbHocKi";
            this.m_cbbHocKi.Size = new System.Drawing.Size(121, 21);
            this.m_cbbHocKi.TabIndex = 45;
            this.m_cbbHocKi.SelectedIndexChanged += new System.EventHandler(this.m_cbbHocKi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(407, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 26);
            this.label2.TabIndex = 44;
            this.label2.Text = "Năm học";
            // 
            // m_cbbNamHoc
            // 
            this.m_cbbNamHoc.FormattingEnabled = true;
            this.m_cbbNamHoc.Location = new System.Drawing.Point(396, 163);
            this.m_cbbNamHoc.Name = "m_cbbNamHoc";
            this.m_cbbNamHoc.Size = new System.Drawing.Size(121, 21);
            this.m_cbbNamHoc.TabIndex = 43;
            this.m_cbbNamHoc.SelectedIndexChanged += new System.EventHandler(this.m_cbbNamHoc_SelectedIndexChanged);
            // 
            // m_dgvMain
            // 
            this.m_dgvMain.AllowUserToAddRows = false;
            this.m_dgvMain.AllowUserToDeleteRows = false;
            this.m_dgvMain.BackgroundColor = System.Drawing.Color.White;
            this.m_dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dgvMain.Location = new System.Drawing.Point(18, 205);
            this.m_dgvMain.Name = "m_dgvMain";
            this.m_dgvMain.ReadOnly = true;
            this.m_dgvMain.Size = new System.Drawing.Size(644, 257);
            this.m_dgvMain.TabIndex = 42;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(153, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 24);
            this.label15.TabIndex = 38;
            this.label15.Text = "Mã học sinh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(153, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "Họ và tên:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::QuanLyHocSinh.Properties.Resources.Hacker;
            this.pictureBox1.Location = new System.Drawing.Point(18, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // frmXemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(683, 501);
            this.Controls.Add(this.m_btminimize);
            this.Controls.Add(this.m_btClose);
            this.Controls.Add(this.m_lbLop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.m_lbTenHS);
            this.Controls.Add(this.m_lbMaHS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_cbbHocKi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_cbbNamHoc);
            this.Controls.Add(this.m_dgvMain);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmXemDiem";
            this.Text = "frmXemDiem";
            this.Load += new System.EventHandler(this.frmXemDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView m_dgvMain;
        private System.Windows.Forms.ComboBox m_cbbNamHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox m_cbbHocKi;
        private System.Windows.Forms.Label m_lbMaHS;
        private System.Windows.Forms.Label m_lbTenHS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label m_lbLop;
        private ButtonFlat m_btClose;
        private ButtonFlat m_btminimize;
    }
}