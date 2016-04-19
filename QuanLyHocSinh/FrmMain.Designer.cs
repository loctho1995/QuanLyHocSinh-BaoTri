namespace QuanLyHocSinh
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Lớp 10A1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Lớp 10A2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Lớp 10A3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Lớp 10A4");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Khối 10", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Lớp 11A1");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Lớp 11A2");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Lớp 11A3");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Khối 11", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Lớp 12A1");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Lớp 12A2");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Khối 12", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Khối", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode9,
            treeNode12});
            this.m_treeViewKhoi = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.m_dgwMain = new System.Windows.Forms.DataGridView();
            this.m_dgvMain = new System.Windows.Forms.DataGridView();
            this.m_btnDuLieu = new System.Windows.Forms.Button();
            this.m_btnGiaoVien = new System.Windows.Forms.Button();
            this.m_btdangXuat = new System.Windows.Forms.Button();
            this.m_tcMain = new QuanLyHocSinh.CustomTabControl();
            this.m_tbHoSo = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.m_btXoaHS = new System.Windows.Forms.Button();
            this.m_btSuaHS = new System.Windows.Forms.Button();
            this.m_btXemThongTin = new System.Windows.Forms.Button();
            this.m_tbHocTap = new System.Windows.Forms.TabPage();
            this.m_btSuaDiem = new System.Windows.Forms.Button();
            this.m_btXemDiem = new System.Windows.Forms.Button();
            this.m_cbbNamHoc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.m_cbbBoMon = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.m_ccbPhanQuyen = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.m_tbBaoCao = new System.Windows.Forms.TabPage();
            this.m_btBaoCao = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.m_cbbBaoCaonamhoc = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.m_cbbBaoCaoLoai = new System.Windows.Forms.ComboBox();
            this.m_cbbBaoCaohocky = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.m_cbbBaoCaomonhoc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgwMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvMain)).BeginInit();
            this.m_tcMain.SuspendLayout();
            this.m_tbHoSo.SuspendLayout();
            this.m_tbHocTap.SuspendLayout();
            this.m_tbBaoCao.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_treeViewKhoi
            // 
            this.m_treeViewKhoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_treeViewKhoi.BackColor = System.Drawing.Color.GhostWhite;
            this.m_treeViewKhoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_treeViewKhoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_treeViewKhoi.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.m_treeViewKhoi.ImageIndex = 0;
            this.m_treeViewKhoi.ImageList = this.imageList1;
            this.m_treeViewKhoi.Location = new System.Drawing.Point(2, 124);
            this.m_treeViewKhoi.Name = "m_treeViewKhoi";
            treeNode1.Name = "m_node10A1";
            treeNode1.Text = "Lớp 10A1";
            treeNode2.Name = "m_node10A2";
            treeNode2.Text = "Lớp 10A2";
            treeNode3.Name = "m_node10A3";
            treeNode3.Text = "Lớp 10A3";
            treeNode4.Name = "m_node10A4";
            treeNode4.Text = "Lớp 10A4";
            treeNode5.ImageIndex = 2;
            treeNode5.Name = "m_nodeKhoi10";
            treeNode5.Text = "Khối 10";
            treeNode6.Name = "m_node11A1";
            treeNode6.Text = "Lớp 11A1";
            treeNode7.Name = "m_node11A2";
            treeNode7.Text = "Lớp 11A2";
            treeNode8.Name = "m_node11A3";
            treeNode8.Text = "Lớp 11A3";
            treeNode9.ImageIndex = 2;
            treeNode9.Name = "m_nodeKhoi11";
            treeNode9.Text = "Khối 11";
            treeNode10.Name = "m_node12A1";
            treeNode10.Text = "Lớp 12A1";
            treeNode11.Name = "m_node12A2";
            treeNode11.Text = "Lớp 12A2";
            treeNode12.ImageIndex = 2;
            treeNode12.Name = "m_nodeKhoi12";
            treeNode12.Text = "Khối 12";
            treeNode13.Checked = true;
            treeNode13.ImageIndex = 1;
            treeNode13.Name = "m_nodeKhoi";
            treeNode13.Text = "Khối";
            this.m_treeViewKhoi.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13});
            this.m_treeViewKhoi.SelectedImageIndex = 0;
            this.m_treeViewKhoi.Size = new System.Drawing.Size(187, 396);
            this.m_treeViewKhoi.TabIndex = 0;
            this.m_treeViewKhoi.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.m_treeViewKhoi_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // m_dgwMain
            // 
            this.m_dgwMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dgwMain.Location = new System.Drawing.Point(0, 0);
            this.m_dgwMain.Name = "m_dgwMain";
            this.m_dgwMain.Size = new System.Drawing.Size(715, 346);
            this.m_dgwMain.TabIndex = 0;
            // 
            // m_dgvMain
            // 
            this.m_dgvMain.AllowUserToAddRows = false;
            this.m_dgvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_dgvMain.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.m_dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dgvMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.m_dgvMain.GridColor = System.Drawing.Color.SandyBrown;
            this.m_dgvMain.Location = new System.Drawing.Point(191, 124);
            this.m_dgvMain.Name = "m_dgvMain";
            this.m_dgvMain.ReadOnly = true;
            this.m_dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_dgvMain.Size = new System.Drawing.Size(717, 396);
            this.m_dgvMain.TabIndex = 5;
            this.m_dgvMain.DoubleClick += new System.EventHandler(this.m_dgvMain_DoubleClick);
            // 
            // m_btnDuLieu
            // 
            this.m_btnDuLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnDuLieu.Location = new System.Drawing.Point(631, 6);
            this.m_btnDuLieu.Name = "m_btnDuLieu";
            this.m_btnDuLieu.Size = new System.Drawing.Size(88, 30);
            this.m_btnDuLieu.TabIndex = 18;
            this.m_btnDuLieu.Text = "Data";
            this.m_btnDuLieu.UseVisualStyleBackColor = true;
            this.m_btnDuLieu.Click += new System.EventHandler(this.m_btnDuLieu_Click);
            // 
            // m_btnGiaoVien
            // 
            this.m_btnGiaoVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnGiaoVien.Location = new System.Drawing.Point(725, 6);
            this.m_btnGiaoVien.Name = "m_btnGiaoVien";
            this.m_btnGiaoVien.Size = new System.Drawing.Size(88, 30);
            this.m_btnGiaoVien.TabIndex = 19;
            this.m_btnGiaoVien.Text = "Giáo viên";
            this.m_btnGiaoVien.UseVisualStyleBackColor = true;
            this.m_btnGiaoVien.Click += new System.EventHandler(this.m_btnGiaoVien_Click);
            // 
            // m_btdangXuat
            // 
            this.m_btdangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btdangXuat.Location = new System.Drawing.Point(819, 6);
            this.m_btdangXuat.Name = "m_btdangXuat";
            this.m_btdangXuat.Size = new System.Drawing.Size(88, 30);
            this.m_btdangXuat.TabIndex = 20;
            this.m_btdangXuat.Text = "Đăng xuất";
            this.m_btdangXuat.UseVisualStyleBackColor = true;
            this.m_btdangXuat.Click += new System.EventHandler(this.m_btdangXuat_Click_1);
            // 
            // m_tcMain
            // 
            this.m_tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_tcMain.Controls.Add(this.m_tbHoSo);
            this.m_tcMain.Controls.Add(this.m_tbHocTap);
            this.m_tcMain.Controls.Add(this.m_tbBaoCao);
            this.m_tcMain.Location = new System.Drawing.Point(2, 24);
            this.m_tcMain.Name = "m_tcMain";
            this.m_tcMain.SelectedIndex = 0;
            this.m_tcMain.Size = new System.Drawing.Size(906, 99);
            this.m_tcMain.TabIndex = 4;
            this.m_tcMain.SelectedIndexChanged += new System.EventHandler(this.m_tcMain_SelectedIndexChanged_1);
            // 
            // m_tbHoSo
            // 
            this.m_tbHoSo.Controls.Add(this.button1);
            this.m_tbHoSo.Controls.Add(this.m_btXoaHS);
            this.m_tbHoSo.Controls.Add(this.m_btSuaHS);
            this.m_tbHoSo.Controls.Add(this.m_btXemThongTin);
            this.m_tbHoSo.Location = new System.Drawing.Point(1, 20);
            this.m_tbHoSo.Name = "m_tbHoSo";
            this.m_tbHoSo.Padding = new System.Windows.Forms.Padding(3);
            this.m_tbHoSo.Size = new System.Drawing.Size(904, 79);
            this.m_tbHoSo.TabIndex = 0;
            this.m_tbHoSo.Text = "Hồ Sơ";
            this.m_tbHoSo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 70);
            this.button1.TabIndex = 24;
            this.button1.Text = "Thêm học sinh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // m_btXoaHS
            // 
            this.m_btXoaHS.Location = new System.Drawing.Point(279, 6);
            this.m_btXoaHS.Name = "m_btXoaHS";
            this.m_btXoaHS.Size = new System.Drawing.Size(132, 70);
            this.m_btXoaHS.TabIndex = 23;
            this.m_btXoaHS.Text = "Xóa học sinh";
            this.m_btXoaHS.UseVisualStyleBackColor = true;
            this.m_btXoaHS.Click += new System.EventHandler(this.m_btXoaHS_Click);
            // 
            // m_btSuaHS
            // 
            this.m_btSuaHS.Location = new System.Drawing.Point(141, 6);
            this.m_btSuaHS.Name = "m_btSuaHS";
            this.m_btSuaHS.Size = new System.Drawing.Size(132, 70);
            this.m_btSuaHS.TabIndex = 22;
            this.m_btSuaHS.Text = "Sửa thông tin";
            this.m_btSuaHS.UseVisualStyleBackColor = true;
            this.m_btSuaHS.Click += new System.EventHandler(this.m_btSuaHS_Click);
            // 
            // m_btXemThongTin
            // 
            this.m_btXemThongTin.Location = new System.Drawing.Point(3, 6);
            this.m_btXemThongTin.Name = "m_btXemThongTin";
            this.m_btXemThongTin.Size = new System.Drawing.Size(132, 70);
            this.m_btXemThongTin.TabIndex = 21;
            this.m_btXemThongTin.Text = "Xem Thông tin";
            this.m_btXemThongTin.UseVisualStyleBackColor = true;
            this.m_btXemThongTin.Click += new System.EventHandler(this.m_btXemThongTin_Click);
            // 
            // m_tbHocTap
            // 
            this.m_tbHocTap.Controls.Add(this.m_btSuaDiem);
            this.m_tbHocTap.Controls.Add(this.m_btXemDiem);
            this.m_tbHocTap.Controls.Add(this.m_cbbNamHoc);
            this.m_tbHocTap.Controls.Add(this.label7);
            this.m_tbHocTap.Controls.Add(this.m_cbbBoMon);
            this.m_tbHocTap.Controls.Add(this.label6);
            this.m_tbHocTap.Controls.Add(this.m_ccbPhanQuyen);
            this.m_tbHocTap.Controls.Add(this.label5);
            this.m_tbHocTap.Location = new System.Drawing.Point(1, 20);
            this.m_tbHocTap.Name = "m_tbHocTap";
            this.m_tbHocTap.Padding = new System.Windows.Forms.Padding(3);
            this.m_tbHocTap.Size = new System.Drawing.Size(904, 79);
            this.m_tbHocTap.TabIndex = 1;
            this.m_tbHocTap.Text = "Học Tập";
            this.m_tbHocTap.UseVisualStyleBackColor = true;
            // 
            // m_btSuaDiem
            // 
            this.m_btSuaDiem.Location = new System.Drawing.Point(170, 3);
            this.m_btSuaDiem.Name = "m_btSuaDiem";
            this.m_btSuaDiem.Size = new System.Drawing.Size(158, 70);
            this.m_btSuaDiem.TabIndex = 23;
            this.m_btSuaDiem.Text = "Sửa điểm";
            this.m_btSuaDiem.UseVisualStyleBackColor = true;
            this.m_btSuaDiem.Click += new System.EventHandler(this.m_btSuaDiem_Click);
            // 
            // m_btXemDiem
            // 
            this.m_btXemDiem.Location = new System.Drawing.Point(6, 3);
            this.m_btXemDiem.Name = "m_btXemDiem";
            this.m_btXemDiem.Size = new System.Drawing.Size(158, 70);
            this.m_btXemDiem.TabIndex = 22;
            this.m_btXemDiem.Text = "Xem điểm";
            this.m_btXemDiem.UseVisualStyleBackColor = true;
            this.m_btXemDiem.Click += new System.EventHandler(this.m_btXemDiem_Click);
            // 
            // m_cbbNamHoc
            // 
            this.m_cbbNamHoc.FormattingEnabled = true;
            this.m_cbbNamHoc.Location = new System.Drawing.Point(471, 40);
            this.m_cbbNamHoc.Name = "m_cbbNamHoc";
            this.m_cbbNamHoc.Size = new System.Drawing.Size(121, 21);
            this.m_cbbNamHoc.TabIndex = 13;
            this.m_cbbNamHoc.SelectedIndexChanged += new System.EventHandler(this.m_cbbNamHoc_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(403, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Năm học:";
            // 
            // m_cbbBoMon
            // 
            this.m_cbbBoMon.FormattingEnabled = true;
            this.m_cbbBoMon.Location = new System.Drawing.Point(641, 12);
            this.m_cbbBoMon.Name = "m_cbbBoMon";
            this.m_cbbBoMon.Size = new System.Drawing.Size(121, 21);
            this.m_cbbBoMon.TabIndex = 11;
            this.m_cbbBoMon.SelectedIndexChanged += new System.EventHandler(this.m_cbbBoMon_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(604, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Môn:";
            // 
            // m_ccbPhanQuyen
            // 
            this.m_ccbPhanQuyen.FormattingEnabled = true;
            this.m_ccbPhanQuyen.Location = new System.Drawing.Point(471, 12);
            this.m_ccbPhanQuyen.Name = "m_ccbPhanQuyen";
            this.m_ccbPhanQuyen.Size = new System.Drawing.Size(121, 21);
            this.m_ccbPhanQuyen.TabIndex = 9;
            this.m_ccbPhanQuyen.SelectedIndexChanged += new System.EventHandler(this.m_ccbPhanQuyen_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(378, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Xem theo quyền:";
            // 
            // m_tbBaoCao
            // 
            this.m_tbBaoCao.Controls.Add(this.m_btBaoCao);
            this.m_tbBaoCao.Controls.Add(this.label11);
            this.m_tbBaoCao.Controls.Add(this.label9);
            this.m_tbBaoCao.Controls.Add(this.m_cbbBaoCaonamhoc);
            this.m_tbBaoCao.Controls.Add(this.label10);
            this.m_tbBaoCao.Controls.Add(this.m_cbbBaoCaoLoai);
            this.m_tbBaoCao.Controls.Add(this.m_cbbBaoCaohocky);
            this.m_tbBaoCao.Controls.Add(this.label8);
            this.m_tbBaoCao.Controls.Add(this.m_cbbBaoCaomonhoc);
            this.m_tbBaoCao.Location = new System.Drawing.Point(1, 20);
            this.m_tbBaoCao.Name = "m_tbBaoCao";
            this.m_tbBaoCao.Size = new System.Drawing.Size(904, 79);
            this.m_tbBaoCao.TabIndex = 2;
            this.m_tbBaoCao.Text = "Báo Cáo";
            this.m_tbBaoCao.UseVisualStyleBackColor = true;
            // 
            // m_btBaoCao
            // 
            this.m_btBaoCao.Location = new System.Drawing.Point(3, 6);
            this.m_btBaoCao.Name = "m_btBaoCao";
            this.m_btBaoCao.Size = new System.Drawing.Size(183, 70);
            this.m_btBaoCao.TabIndex = 23;
            this.m_btBaoCao.Text = "Báo cáo";
            this.m_btBaoCao.UseVisualStyleBackColor = true;
            this.m_btBaoCao.Click += new System.EventHandler(this.m_btBaoCao_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(440, 11);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Năm học:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(216, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Loại báo cáo:";
            // 
            // m_cbbBaoCaonamhoc
            // 
            this.m_cbbBaoCaonamhoc.FormattingEnabled = true;
            this.m_cbbBaoCaonamhoc.Location = new System.Drawing.Point(497, 11);
            this.m_cbbBaoCaonamhoc.Margin = new System.Windows.Forms.Padding(2);
            this.m_cbbBaoCaonamhoc.Name = "m_cbbBaoCaonamhoc";
            this.m_cbbBaoCaonamhoc.Size = new System.Drawing.Size(144, 21);
            this.m_cbbBaoCaonamhoc.TabIndex = 9;
            this.m_cbbBaoCaonamhoc.SelectedIndexChanged += new System.EventHandler(this.m_cbbBaoCaonamhoc_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(448, 40);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Học kỳ:";
            // 
            // m_cbbBaoCaoLoai
            // 
            this.m_cbbBaoCaoLoai.FormattingEnabled = true;
            this.m_cbbBaoCaoLoai.Location = new System.Drawing.Point(292, 11);
            this.m_cbbBaoCaoLoai.Margin = new System.Windows.Forms.Padding(2);
            this.m_cbbBaoCaoLoai.Name = "m_cbbBaoCaoLoai";
            this.m_cbbBaoCaoLoai.Size = new System.Drawing.Size(144, 21);
            this.m_cbbBaoCaoLoai.TabIndex = 9;
            this.m_cbbBaoCaoLoai.SelectedIndexChanged += new System.EventHandler(this.m_cbbBaoCaoLoai_SelectedIndexChanged);
            // 
            // m_cbbBaoCaohocky
            // 
            this.m_cbbBaoCaohocky.FormattingEnabled = true;
            this.m_cbbBaoCaohocky.Location = new System.Drawing.Point(497, 41);
            this.m_cbbBaoCaohocky.Margin = new System.Windows.Forms.Padding(2);
            this.m_cbbBaoCaohocky.Name = "m_cbbBaoCaohocky";
            this.m_cbbBaoCaohocky.Size = new System.Drawing.Size(144, 21);
            this.m_cbbBaoCaohocky.TabIndex = 9;
            this.m_cbbBaoCaohocky.SelectedIndexChanged += new System.EventHandler(this.m_cbbBaoCaohocky_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(231, 40);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Môn học:";
            // 
            // m_cbbBaoCaomonhoc
            // 
            this.m_cbbBaoCaomonhoc.FormattingEnabled = true;
            this.m_cbbBaoCaomonhoc.Location = new System.Drawing.Point(292, 41);
            this.m_cbbBaoCaomonhoc.Margin = new System.Windows.Forms.Padding(2);
            this.m_cbbBaoCaomonhoc.Name = "m_cbbBaoCaomonhoc";
            this.m_cbbBaoCaomonhoc.Size = new System.Drawing.Size(144, 21);
            this.m_cbbBaoCaomonhoc.TabIndex = 9;
            this.m_cbbBaoCaomonhoc.SelectedIndexChanged += new System.EventHandler(this.m_cbbBaoCaomonhoc_SelectedIndexChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(910, 524);
            this.Controls.Add(this.m_btdangXuat);
            this.Controls.Add(this.m_btnGiaoVien);
            this.Controls.Add(this.m_btnDuLieu);
            this.Controls.Add(this.m_dgvMain);
            this.Controls.Add(this.m_treeViewKhoi);
            this.Controls.Add(this.m_tcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMain";
            this.Text = "Quản lý học sinh";
            ((System.ComponentModel.ISupportInitialize)(this.m_dgwMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvMain)).EndInit();
            this.m_tcMain.ResumeLayout(false);
            this.m_tbHoSo.ResumeLayout(false);
            this.m_tbHocTap.ResumeLayout(false);
            this.m_tbHocTap.PerformLayout();
            this.m_tbBaoCao.ResumeLayout(false);
            this.m_tbBaoCao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView m_treeViewKhoi;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView m_dgwMain;
        private System.Windows.Forms.DataGridView m_dgvMain;
        private System.Windows.Forms.TabPage m_tbBaoCao;
        //private System.Windows.Forms.Button m_btBaoCao;
        private System.Windows.Forms.ComboBox m_ccbPhanQuyen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox m_cbbBoMon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox m_cbbNamHoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage m_tbHocTap;
        private System.Windows.Forms.TabPage m_tbHoSo;
        private CustomTabControl m_tcMain;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox m_cbbBaoCaomonhoc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox m_cbbBaoCaonamhoc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox m_cbbBaoCaoLoai;
        private System.Windows.Forms.ComboBox m_cbbBaoCaohocky;
        private System.Windows.Forms.Button m_btnDuLieu;
        private System.Windows.Forms.Button m_btnGiaoVien;
        private System.Windows.Forms.Button m_btdangXuat;
        private System.Windows.Forms.Button m_btXemThongTin;
        private System.Windows.Forms.Button m_btSuaHS;
        private System.Windows.Forms.Button m_btXoaHS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button m_btSuaDiem;
        private System.Windows.Forms.Button m_btXemDiem;
        private System.Windows.Forms.Button m_btBaoCao;
    }
}

