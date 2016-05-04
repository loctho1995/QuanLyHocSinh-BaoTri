namespace QuanLyHocSinh
{
    partial class frmCaiDat
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
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Lớp 10A1");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Lớp 10A2");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Lớp10A3");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Lớp10A4");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Khối 10", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Lớp 11A1");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Lớp 11A2");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Lớp 11A3");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Khối 11", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Lớp 12A1");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Lớp 12A2");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Khối 12", new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Khối", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode22,
            treeNode25});
            this.m_panel = new System.Windows.Forms.Panel();
            this.m_btdangXuat = new System.Windows.Forms.Button();
            this.m_dgvMain = new System.Windows.Forms.DataGridView();
            this.m_btCaiDat = new System.Windows.Forms.Button();
            this.m_btGiaoVien = new System.Windows.Forms.Button();
            this.m_lblName = new System.Windows.Forms.Label();
            this.m_lblLopBoMon = new System.Windows.Forms.Label();
            this.m_lblLopCN = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_scMain = new QuanLyHocSinh.SearchControl();
            this.m_treeViewKhoi = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.m_tcMain = new QuanLyHocSinh.CustomTabControl();
            this.m_tbHoSo = new System.Windows.Forms.TabPage();
            this.m_tbHocTap = new System.Windows.Forms.TabPage();
            this.m_cbbNamHoc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.m_cbbBoMon = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.m_ccbPhanQuyen = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.m_tbBaoCao = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.m_cbbBaoCaonamhoc = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.m_cbbBaoCaoLoai = new System.Windows.Forms.ComboBox();
            this.m_cbbBaoCaohocky = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.m_cbbBaoCaomonhoc = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonFlat1 = new System.Windows.Forms.Button();
            this.m_btformBackColor = new System.Windows.Forms.Button();
            this.bt_tabButtonsColor = new System.Windows.Forms.Button();
            this.m_bttopButtonsColor = new System.Windows.Forms.Button();
            this.m_bttabPageColor = new System.Windows.Forms.Button();
            this.m_btsearchColor = new System.Windows.Forms.Button();
            this.m_btSave = new System.Windows.Forms.Button();
            this.buttonFlat2 = new QuanLyHocSinh.ButtonFlat();
            this.m_btXemThongTin = new System.Windows.Forms.Button();
            this.m_btSuaHS = new System.Windows.Forms.Button();
            this.m_btXoaHS = new System.Windows.Forms.Button();
            this.m_btThemHS = new System.Windows.Forms.Button();
            this.m_btXemDiem = new System.Windows.Forms.Button();
            this.m_btSuaDiem = new System.Windows.Forms.Button();
            this.m_btBaoCao = new System.Windows.Forms.Button();
            this.m_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvMain)).BeginInit();
            this.m_tcMain.SuspendLayout();
            this.m_tbHoSo.SuspendLayout();
            this.m_tbHocTap.SuspendLayout();
            this.m_tbBaoCao.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_panel
            // 
            this.m_panel.Controls.Add(this.m_btdangXuat);
            this.m_panel.Controls.Add(this.m_dgvMain);
            this.m_panel.Controls.Add(this.m_btCaiDat);
            this.m_panel.Controls.Add(this.m_btGiaoVien);
            this.m_panel.Controls.Add(this.m_lblName);
            this.m_panel.Controls.Add(this.m_lblLopBoMon);
            this.m_panel.Controls.Add(this.m_lblLopCN);
            this.m_panel.Controls.Add(this.label4);
            this.m_panel.Controls.Add(this.label2);
            this.m_panel.Controls.Add(this.label3);
            this.m_panel.Controls.Add(this.m_lblID);
            this.m_panel.Controls.Add(this.label1);
            this.m_panel.Controls.Add(this.m_scMain);
            this.m_panel.Controls.Add(this.m_treeViewKhoi);
            this.m_panel.Controls.Add(this.m_tcMain);
            this.m_panel.Location = new System.Drawing.Point(5, 12);
            this.m_panel.Name = "m_panel";
            this.m_panel.Size = new System.Drawing.Size(758, 422);
            this.m_panel.TabIndex = 0;
            // 
            // m_btdangXuat
            // 
            this.m_btdangXuat.Location = new System.Drawing.Point(647, 4);
            this.m_btdangXuat.Name = "m_btdangXuat";
            this.m_btdangXuat.Size = new System.Drawing.Size(101, 37);
            this.m_btdangXuat.TabIndex = 16;
            this.m_btdangXuat.Text = "Đăng xuất";
            this.m_btdangXuat.UseVisualStyleBackColor = true;
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
            this.m_dgvMain.GridColor = System.Drawing.Color.SandyBrown;
            this.m_dgvMain.Location = new System.Drawing.Point(142, 131);
            this.m_dgvMain.Name = "m_dgvMain";
            this.m_dgvMain.ReadOnly = true;
            this.m_dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_dgvMain.Size = new System.Drawing.Size(612, 265);
            this.m_dgvMain.TabIndex = 72;
            // 
            // m_btCaiDat
            // 
            this.m_btCaiDat.Location = new System.Drawing.Point(540, 4);
            this.m_btCaiDat.Name = "m_btCaiDat";
            this.m_btCaiDat.Size = new System.Drawing.Size(101, 37);
            this.m_btCaiDat.TabIndex = 16;
            this.m_btCaiDat.Text = "Cài đặt";
            this.m_btCaiDat.UseVisualStyleBackColor = true;
            // 
            // m_btGiaoVien
            // 
            this.m_btGiaoVien.Location = new System.Drawing.Point(431, 4);
            this.m_btGiaoVien.Name = "m_btGiaoVien";
            this.m_btGiaoVien.Size = new System.Drawing.Size(101, 37);
            this.m_btGiaoVien.TabIndex = 16;
            this.m_btGiaoVien.Text = "Giáo viên";
            this.m_btGiaoVien.UseVisualStyleBackColor = true;
            // 
            // m_lblName
            // 
            this.m_lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_lblName.AutoSize = true;
            this.m_lblName.ForeColor = System.Drawing.Color.Snow;
            this.m_lblName.Location = new System.Drawing.Point(129, 404);
            this.m_lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_lblName.Name = "m_lblName";
            this.m_lblName.Size = new System.Drawing.Size(0, 13);
            this.m_lblName.TabIndex = 61;
            // 
            // m_lblLopBoMon
            // 
            this.m_lblLopBoMon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_lblLopBoMon.AutoSize = true;
            this.m_lblLopBoMon.ForeColor = System.Drawing.Color.Snow;
            this.m_lblLopBoMon.Location = new System.Drawing.Point(416, 404);
            this.m_lblLopBoMon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_lblLopBoMon.Name = "m_lblLopBoMon";
            this.m_lblLopBoMon.Size = new System.Drawing.Size(0, 13);
            this.m_lblLopBoMon.TabIndex = 62;
            // 
            // m_lblLopCN
            // 
            this.m_lblLopCN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_lblLopCN.AutoSize = true;
            this.m_lblLopCN.ForeColor = System.Drawing.Color.Snow;
            this.m_lblLopCN.Location = new System.Drawing.Point(316, 404);
            this.m_lblLopCN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_lblLopCN.Name = "m_lblLopCN";
            this.m_lblLopCN.Size = new System.Drawing.Size(21, 13);
            this.m_lblLopCN.TabIndex = 63;
            this.m_lblLopCN.Text = "lớp";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(372, 404);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Lớp BM:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(267, 404);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Lớp CN:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(86, 404);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Họ tên:";
            // 
            // m_lblID
            // 
            this.m_lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_lblID.AutoSize = true;
            this.m_lblID.ForeColor = System.Drawing.Color.Snow;
            this.m_lblID.Location = new System.Drawing.Point(23, 404);
            this.m_lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_lblID.Name = "m_lblID";
            this.m_lblID.Size = new System.Drawing.Size(0, 13);
            this.m_lblID.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(0, 404);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "ID:";
            // 
            // m_scMain
            // 
            this.m_scMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_scMain.BackColor = System.Drawing.Color.GhostWhite;
            this.m_scMain.DeltaSpeed = 20;
            this.m_scMain.HideSize = new System.Drawing.Size(25, 80);
            this.m_scMain.Location = new System.Drawing.Point(729, 50);
            this.m_scMain.Margin = new System.Windows.Forms.Padding(4);
            this.m_scMain.Name = "m_scMain";
            this.m_scMain.Opacity = 1F;
            this.m_scMain.ShadowColor = System.Drawing.Color.Empty;
            this.m_scMain.ShowSize = new System.Drawing.Size(230, 80);
            this.m_scMain.Size = new System.Drawing.Size(25, 79);
            this.m_scMain.Speed = 1;
            this.m_scMain.State = QuanLyHocSinh.SearchControl.States.Hide;
            this.m_scMain.TabIndex = 57;
            // 
            // m_treeViewKhoi
            // 
            this.m_treeViewKhoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_treeViewKhoi.BackColor = System.Drawing.Color.GhostWhite;
            this.m_treeViewKhoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_treeViewKhoi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_treeViewKhoi.ImageIndex = 0;
            this.m_treeViewKhoi.ImageList = this.imageList1;
            this.m_treeViewKhoi.Location = new System.Drawing.Point(2, 131);
            this.m_treeViewKhoi.Name = "m_treeViewKhoi";
            treeNode14.Name = "m_node10A1";
            treeNode14.Text = "Lớp 10A1";
            treeNode15.Name = "m_node10A2";
            treeNode15.Text = "Lớp 10A2";
            treeNode16.Name = "m_node10A3";
            treeNode16.Text = "Lớp10A3";
            treeNode17.Name = "m_node10A4";
            treeNode17.Text = "Lớp10A4";
            treeNode18.ImageIndex = 2;
            treeNode18.Name = "m_nodeKhoi10";
            treeNode18.Text = "Khối 10";
            treeNode19.Name = "m_node11A1";
            treeNode19.Text = "Lớp 11A1";
            treeNode20.Name = "m_node11A2";
            treeNode20.Text = "Lớp 11A2";
            treeNode21.Name = "m_node11A3";
            treeNode21.Text = "Lớp 11A3";
            treeNode22.ImageIndex = 2;
            treeNode22.Name = "m_nodeKhoi11";
            treeNode22.Text = "Khối 11";
            treeNode23.Name = "m_node12A1";
            treeNode23.Text = "Lớp 12A1";
            treeNode24.Name = "m_node12A2";
            treeNode24.Text = "Lớp 12A2";
            treeNode25.ImageIndex = 2;
            treeNode25.Name = "m_nodeKhoi12";
            treeNode25.Text = "Khối 12";
            treeNode26.Checked = true;
            treeNode26.ImageIndex = 1;
            treeNode26.Name = "m_nodeKhoi";
            treeNode26.Text = "Khối";
            this.m_treeViewKhoi.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode26});
            this.m_treeViewKhoi.SelectedImageIndex = 0;
            this.m_treeViewKhoi.Size = new System.Drawing.Size(138, 265);
            this.m_treeViewKhoi.TabIndex = 55;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // m_tcMain
            // 
            this.m_tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_tcMain.Controls.Add(this.m_tbHoSo);
            this.m_tcMain.Controls.Add(this.m_tbHocTap);
            this.m_tcMain.Controls.Add(this.m_tbBaoCao);
            this.m_tcMain.Location = new System.Drawing.Point(2, 30);
            this.m_tcMain.Name = "m_tcMain";
            this.m_tcMain.SelectedIndex = 0;
            this.m_tcMain.Size = new System.Drawing.Size(728, 99);
            this.m_tcMain.TabIndex = 53;
            // 
            // m_tbHoSo
            // 
            this.m_tbHoSo.Controls.Add(this.m_btThemHS);
            this.m_tbHoSo.Controls.Add(this.m_btXemThongTin);
            this.m_tbHoSo.Controls.Add(this.m_btXoaHS);
            this.m_tbHoSo.Controls.Add(this.m_btSuaHS);
            this.m_tbHoSo.Location = new System.Drawing.Point(1, 20);
            this.m_tbHoSo.Name = "m_tbHoSo";
            this.m_tbHoSo.Padding = new System.Windows.Forms.Padding(3);
            this.m_tbHoSo.Size = new System.Drawing.Size(726, 79);
            this.m_tbHoSo.TabIndex = 0;
            this.m_tbHoSo.Text = "Hồ Sơ";
            this.m_tbHoSo.UseVisualStyleBackColor = true;
            // 
            // m_tbHocTap
            // 
            this.m_tbHocTap.Controls.Add(this.m_btSuaDiem);
            this.m_tbHocTap.Controls.Add(this.m_cbbNamHoc);
            this.m_tbHocTap.Controls.Add(this.m_btXemDiem);
            this.m_tbHocTap.Controls.Add(this.label7);
            this.m_tbHocTap.Controls.Add(this.m_cbbBoMon);
            this.m_tbHocTap.Controls.Add(this.label6);
            this.m_tbHocTap.Controls.Add(this.m_ccbPhanQuyen);
            this.m_tbHocTap.Controls.Add(this.label5);
            this.m_tbHocTap.Location = new System.Drawing.Point(1, 20);
            this.m_tbHocTap.Name = "m_tbHocTap";
            this.m_tbHocTap.Padding = new System.Windows.Forms.Padding(3);
            this.m_tbHocTap.Size = new System.Drawing.Size(726, 79);
            this.m_tbHocTap.TabIndex = 1;
            this.m_tbHocTap.Text = "Học Tập";
            this.m_tbHocTap.UseVisualStyleBackColor = true;
            // 
            // m_cbbNamHoc
            // 
            this.m_cbbNamHoc.FormattingEnabled = true;
            this.m_cbbNamHoc.Location = new System.Drawing.Point(385, 50);
            this.m_cbbNamHoc.Name = "m_cbbNamHoc";
            this.m_cbbNamHoc.Size = new System.Drawing.Size(121, 21);
            this.m_cbbNamHoc.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(328, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Năm học:";
            // 
            // m_cbbBoMon
            // 
            this.m_cbbBoMon.FormattingEnabled = true;
            this.m_cbbBoMon.Location = new System.Drawing.Point(559, 16);
            this.m_cbbBoMon.Name = "m_cbbBoMon";
            this.m_cbbBoMon.Size = new System.Drawing.Size(121, 21);
            this.m_cbbBoMon.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(521, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Môn:";
            // 
            // m_ccbPhanQuyen
            // 
            this.m_ccbPhanQuyen.FormattingEnabled = true;
            this.m_ccbPhanQuyen.Location = new System.Drawing.Point(385, 16);
            this.m_ccbPhanQuyen.Name = "m_ccbPhanQuyen";
            this.m_ccbPhanQuyen.Size = new System.Drawing.Size(121, 21);
            this.m_ccbPhanQuyen.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(294, 20);
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
            this.m_tbBaoCao.Size = new System.Drawing.Size(726, 79);
            this.m_tbBaoCao.TabIndex = 2;
            this.m_tbBaoCao.Text = "Báo Cáo";
            this.m_tbBaoCao.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(438, 20);
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
            this.label9.Location = new System.Drawing.Point(200, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Loại báo cáo:";
            // 
            // m_cbbBaoCaonamhoc
            // 
            this.m_cbbBaoCaonamhoc.FormattingEnabled = true;
            this.m_cbbBaoCaonamhoc.Location = new System.Drawing.Point(499, 17);
            this.m_cbbBaoCaonamhoc.Margin = new System.Windows.Forms.Padding(2);
            this.m_cbbBaoCaonamhoc.Name = "m_cbbBaoCaonamhoc";
            this.m_cbbBaoCaonamhoc.Size = new System.Drawing.Size(144, 21);
            this.m_cbbBaoCaonamhoc.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(449, 56);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Học kỳ:";
            // 
            // m_cbbBaoCaoLoai
            // 
            this.m_cbbBaoCaoLoai.FormattingEnabled = true;
            this.m_cbbBaoCaoLoai.Location = new System.Drawing.Point(275, 17);
            this.m_cbbBaoCaoLoai.Margin = new System.Windows.Forms.Padding(2);
            this.m_cbbBaoCaoLoai.Name = "m_cbbBaoCaoLoai";
            this.m_cbbBaoCaoLoai.Size = new System.Drawing.Size(144, 21);
            this.m_cbbBaoCaoLoai.TabIndex = 9;
            // 
            // m_cbbBaoCaohocky
            // 
            this.m_cbbBaoCaohocky.FormattingEnabled = true;
            this.m_cbbBaoCaohocky.Location = new System.Drawing.Point(499, 54);
            this.m_cbbBaoCaohocky.Margin = new System.Windows.Forms.Padding(2);
            this.m_cbbBaoCaohocky.Name = "m_cbbBaoCaohocky";
            this.m_cbbBaoCaohocky.Size = new System.Drawing.Size(144, 21);
            this.m_cbbBaoCaohocky.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(220, 56);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Môn học:";
            // 
            // m_cbbBaoCaomonhoc
            // 
            this.m_cbbBaoCaomonhoc.FormattingEnabled = true;
            this.m_cbbBaoCaomonhoc.Location = new System.Drawing.Point(275, 54);
            this.m_cbbBaoCaomonhoc.Margin = new System.Windows.Forms.Padding(2);
            this.m_cbbBaoCaomonhoc.Name = "m_cbbBaoCaomonhoc";
            this.m_cbbBaoCaomonhoc.Size = new System.Drawing.Size(144, 21);
            this.m_cbbBaoCaomonhoc.TabIndex = 9;
            // 
            // buttonFlat1
            // 
            this.buttonFlat1.Location = new System.Drawing.Point(774, 354);
            this.buttonFlat1.Name = "buttonFlat1";
            this.buttonFlat1.Size = new System.Drawing.Size(157, 37);
            this.buttonFlat1.TabIndex = 16;
            this.buttonFlat1.Text = "Mặc định";
            this.buttonFlat1.UseVisualStyleBackColor = true;
            this.buttonFlat1.Click += new System.EventHandler(this.buttonFlat1_Click);
            // 
            // m_btformBackColor
            // 
            this.m_btformBackColor.Location = new System.Drawing.Point(774, 39);
            this.m_btformBackColor.Name = "m_btformBackColor";
            this.m_btformBackColor.Size = new System.Drawing.Size(157, 36);
            this.m_btformBackColor.TabIndex = 16;
            this.m_btformBackColor.Text = "Màu nền Form";
            this.m_btformBackColor.UseVisualStyleBackColor = true;
            this.m_btformBackColor.Click += new System.EventHandler(this.m_btformBackColor_Click);
            // 
            // bt_tabButtonsColor
            // 
            this.bt_tabButtonsColor.Location = new System.Drawing.Point(774, 81);
            this.bt_tabButtonsColor.Name = "bt_tabButtonsColor";
            this.bt_tabButtonsColor.Size = new System.Drawing.Size(157, 37);
            this.bt_tabButtonsColor.TabIndex = 16;
            this.bt_tabButtonsColor.Text = "Màu nút bấm bảng";
            this.bt_tabButtonsColor.UseVisualStyleBackColor = true;
            this.bt_tabButtonsColor.Click += new System.EventHandler(this.bt_tabButtonsColor_Click);
            // 
            // m_bttopButtonsColor
            // 
            this.m_bttopButtonsColor.Location = new System.Drawing.Point(774, 124);
            this.m_bttopButtonsColor.Name = "m_bttopButtonsColor";
            this.m_bttopButtonsColor.Size = new System.Drawing.Size(157, 36);
            this.m_bttopButtonsColor.TabIndex = 16;
            this.m_bttopButtonsColor.Text = "Màu nút bấm trên";
            this.m_bttopButtonsColor.UseVisualStyleBackColor = true;
            this.m_bttopButtonsColor.Click += new System.EventHandler(this.m_bttopButtonsColor_Click);
            // 
            // m_bttabPageColor
            // 
            this.m_bttabPageColor.Location = new System.Drawing.Point(774, 166);
            this.m_bttabPageColor.Name = "m_bttabPageColor";
            this.m_bttabPageColor.Size = new System.Drawing.Size(157, 36);
            this.m_bttabPageColor.TabIndex = 16;
            this.m_bttabPageColor.Text = "Màu nền trang tabs";
            this.m_bttabPageColor.UseVisualStyleBackColor = true;
            this.m_bttabPageColor.Click += new System.EventHandler(this.m_bttabPageColor_Click);
            // 
            // m_btsearchColor
            // 
            this.m_btsearchColor.Location = new System.Drawing.Point(774, 208);
            this.m_btsearchColor.Name = "m_btsearchColor";
            this.m_btsearchColor.Size = new System.Drawing.Size(157, 36);
            this.m_btsearchColor.TabIndex = 16;
            this.m_btsearchColor.Text = "Màu nền bảng tìm kiếm";
            this.m_btsearchColor.UseVisualStyleBackColor = true;
            this.m_btsearchColor.Click += new System.EventHandler(this.m_btsearchColor_Click);
            // 
            // m_btSave
            // 
            this.m_btSave.Location = new System.Drawing.Point(774, 397);
            this.m_btSave.Name = "m_btSave";
            this.m_btSave.Size = new System.Drawing.Size(157, 36);
            this.m_btSave.TabIndex = 16;
            this.m_btSave.Text = "Lưu lại";
            this.m_btSave.UseVisualStyleBackColor = true;
            this.m_btSave.Click += new System.EventHandler(this.m_btSave_Click);
            // 
            // buttonFlat2
            // 
            this.buttonFlat2.AlphaGlow = 40F;
            this.buttonFlat2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFlat2.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonFlat2.ButtonImage = global::QuanLyHocSinh.Properties.Resources.iconClose;
            this.buttonFlat2.ButtonText = "";
            this.buttonFlat2.DeltaAlphaGlow = 8F;
            this.buttonFlat2.DeltaDistance = 2F;
            this.buttonFlat2.HaveEffects = false;
            this.buttonFlat2.ImageOrigin = new System.Drawing.Point(0, 0);
            this.buttonFlat2.ImageSize = new System.Drawing.Size(25, 20);
            this.buttonFlat2.Location = new System.Drawing.Point(1548, 2);
            this.buttonFlat2.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFlat2.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.buttonFlat2.Name = "buttonFlat2";
            this.buttonFlat2.SaveChanged = false;
            this.buttonFlat2.ShadownDistance = 6;
            this.buttonFlat2.Size = new System.Drawing.Size(28, 23);
            this.buttonFlat2.TabIndex = 52;
            this.buttonFlat2.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Bot;
            this.buttonFlat2.TextColor = System.Drawing.Color.White;
            this.buttonFlat2.TextOrigin = new System.Drawing.Point(0, 0);
            this.buttonFlat2.TransparentBackColor = System.Drawing.Color.Empty;
            this.buttonFlat2.Type = QuanLyHocSinh.ButtonFlat.Types.FlatNormal;
            this.buttonFlat2.Click += new System.EventHandler(this.buttonFlat2_Click);
            // 
            // m_btXemThongTin
            // 
            this.m_btXemThongTin.Location = new System.Drawing.Point(5, 6);
            this.m_btXemThongTin.Name = "m_btXemThongTin";
            this.m_btXemThongTin.Size = new System.Drawing.Size(120, 67);
            this.m_btXemThongTin.TabIndex = 73;
            this.m_btXemThongTin.Text = "Xem Thông Tin";
            this.m_btXemThongTin.UseVisualStyleBackColor = true;
            // 
            // m_btSuaHS
            // 
            this.m_btSuaHS.Location = new System.Drawing.Point(131, 6);
            this.m_btSuaHS.Name = "m_btSuaHS";
            this.m_btSuaHS.Size = new System.Drawing.Size(120, 67);
            this.m_btSuaHS.TabIndex = 73;
            this.m_btSuaHS.Text = "Sửa thông tin";
            this.m_btSuaHS.UseVisualStyleBackColor = true;
            // 
            // m_btXoaHS
            // 
            this.m_btXoaHS.Location = new System.Drawing.Point(257, 6);
            this.m_btXoaHS.Name = "m_btXoaHS";
            this.m_btXoaHS.Size = new System.Drawing.Size(120, 67);
            this.m_btXoaHS.TabIndex = 73;
            this.m_btXoaHS.Text = "Xóa học sinh";
            this.m_btXoaHS.UseVisualStyleBackColor = true;
            // 
            // m_btThemHS
            // 
            this.m_btThemHS.Location = new System.Drawing.Point(383, 6);
            this.m_btThemHS.Name = "m_btThemHS";
            this.m_btThemHS.Size = new System.Drawing.Size(120, 67);
            this.m_btThemHS.TabIndex = 73;
            this.m_btThemHS.Text = "Thêm học sinh";
            this.m_btThemHS.UseVisualStyleBackColor = true;
            // 
            // m_btXemDiem
            // 
            this.m_btXemDiem.Location = new System.Drawing.Point(6, 7);
            this.m_btXemDiem.Name = "m_btXemDiem";
            this.m_btXemDiem.Size = new System.Drawing.Size(120, 65);
            this.m_btXemDiem.TabIndex = 73;
            this.m_btXemDiem.Text = "Xem điểm";
            this.m_btXemDiem.UseVisualStyleBackColor = true;
            // 
            // m_btSuaDiem
            // 
            this.m_btSuaDiem.Location = new System.Drawing.Point(132, 7);
            this.m_btSuaDiem.Name = "m_btSuaDiem";
            this.m_btSuaDiem.Size = new System.Drawing.Size(120, 65);
            this.m_btSuaDiem.TabIndex = 73;
            this.m_btSuaDiem.Text = "Sửa điểm";
            this.m_btSuaDiem.UseVisualStyleBackColor = true;
            // 
            // m_btBaoCao
            // 
            this.m_btBaoCao.Location = new System.Drawing.Point(5, 7);
            this.m_btBaoCao.Name = "m_btBaoCao";
            this.m_btBaoCao.Size = new System.Drawing.Size(156, 65);
            this.m_btBaoCao.TabIndex = 73;
            this.m_btBaoCao.Text = "Báo cáo";
            this.m_btBaoCao.UseVisualStyleBackColor = true;
            // 
            // frmCaiDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(949, 445);
            this.Controls.Add(this.m_btSave);
            this.Controls.Add(this.buttonFlat1);
            this.Controls.Add(this.m_btsearchColor);
            this.Controls.Add(this.m_bttabPageColor);
            this.Controls.Add(this.m_bttopButtonsColor);
            this.Controls.Add(this.bt_tabButtonsColor);
            this.Controls.Add(this.m_btformBackColor);
            this.Controls.Add(this.buttonFlat2);
            this.Controls.Add(this.m_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCaiDat";
            this.Text = "frmSetting";
            this.m_panel.ResumeLayout(false);
            this.m_panel.PerformLayout();
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

        private System.Windows.Forms.Panel m_panel;
        private System.Windows.Forms.ImageList imageList1;
        private ButtonFlat buttonFlat2;
        private CustomTabControl m_tcMain;
        private System.Windows.Forms.TabPage m_tbHoSo;
        private System.Windows.Forms.TabPage m_tbHocTap;
        private System.Windows.Forms.ComboBox m_cbbNamHoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox m_cbbBoMon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox m_ccbPhanQuyen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage m_tbBaoCao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox m_cbbBaoCaonamhoc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox m_cbbBaoCaoLoai;
        private System.Windows.Forms.ComboBox m_cbbBaoCaohocky;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox m_cbbBaoCaomonhoc;
        private System.Windows.Forms.TreeView m_treeViewKhoi;
        private SearchControl m_scMain;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label m_lblName;
        private System.Windows.Forms.Label m_lblLopBoMon;
        private System.Windows.Forms.Label m_lblLopCN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label m_lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView m_dgvMain;
        private System.Windows.Forms.Button buttonFlat1;
        private System.Windows.Forms.Button m_btdangXuat;
        private System.Windows.Forms.Button m_btGiaoVien;
        private System.Windows.Forms.Button m_btformBackColor;
        private System.Windows.Forms.Button bt_tabButtonsColor;
        private System.Windows.Forms.Button m_bttopButtonsColor;
        private System.Windows.Forms.Button m_bttabPageColor;
        private System.Windows.Forms.Button m_btsearchColor;
        private System.Windows.Forms.Button m_btSave;
        private System.Windows.Forms.Button m_btCaiDat;
        private System.Windows.Forms.Button m_btThemHS;
        private System.Windows.Forms.Button m_btXemThongTin;
        private System.Windows.Forms.Button m_btXoaHS;
        private System.Windows.Forms.Button m_btSuaHS;
        private System.Windows.Forms.Button m_btSuaDiem;
        private System.Windows.Forms.Button m_btXemDiem;
        private System.Windows.Forms.Button m_btBaoCao;
    }
}