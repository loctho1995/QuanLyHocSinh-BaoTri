namespace QuanLyHocSinh.Data
{
    partial class frmData
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
            this.m_btHide = new QuanLyHocSinh.ButtonFlat();
            this.m_btClose = new QuanLyHocSinh.ButtonFlat();
            this.m_btnBackup = new QuanLyHocSinh.ButtonFlat();
            this.m_btnRestore = new QuanLyHocSinh.ButtonFlat();
            this.SuspendLayout();
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
            this.m_btHide.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btHide.HaveEffects = false;
            this.m_btHide.ImageOrigin = new System.Drawing.Point(0, 0);
            this.m_btHide.ImageSize = new System.Drawing.Size(35, 35);
            this.m_btHide.Location = new System.Drawing.Point(363, 8);
            this.m_btHide.Margin = new System.Windows.Forms.Padding(5);
            this.m_btHide.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.m_btHide.Name = "m_btHide";
            this.m_btHide.SaveChanged = false;
            this.m_btHide.ShadownDistance = 6;
            this.m_btHide.Size = new System.Drawing.Size(60, 44);
            this.m_btHide.TabIndex = 17;
            this.m_btHide.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Center;
            this.m_btHide.TextColor = System.Drawing.Color.White;
            this.m_btHide.TextOrigin = new System.Drawing.Point(-8, 0);
            this.m_btHide.TransparentBackColor = System.Drawing.Color.Empty;
            this.m_btHide.Type = QuanLyHocSinh.ButtonFlat.Types.FlatNormal;
            this.m_btHide.Click += new System.EventHandler(this.m_btHide_Click);
            // 
            // m_btClose
            // 
            this.m_btClose.AlphaGlow = 40F;
            this.m_btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(99)))));
            this.m_btClose.ButtonImage = global::QuanLyHocSinh.Properties.Resources.iconClose;
            this.m_btClose.ButtonText = "";
            this.m_btClose.DeltaAlphaGlow = 8F;
            this.m_btClose.DeltaDistance = 2F;
            this.m_btClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btClose.HaveEffects = false;
            this.m_btClose.ImageOrigin = new System.Drawing.Point(0, 0);
            this.m_btClose.ImageSize = new System.Drawing.Size(35, 35);
            this.m_btClose.Location = new System.Drawing.Point(433, 8);
            this.m_btClose.Margin = new System.Windows.Forms.Padding(5);
            this.m_btClose.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.m_btClose.Name = "m_btClose";
            this.m_btClose.SaveChanged = false;
            this.m_btClose.ShadownDistance = 6;
            this.m_btClose.Size = new System.Drawing.Size(60, 44);
            this.m_btClose.TabIndex = 16;
            this.m_btClose.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Center;
            this.m_btClose.TextColor = System.Drawing.Color.White;
            this.m_btClose.TextOrigin = new System.Drawing.Point(-8, 0);
            this.m_btClose.TransparentBackColor = System.Drawing.Color.Empty;
            this.m_btClose.Type = QuanLyHocSinh.ButtonFlat.Types.FlatNormal;
            this.m_btClose.Click += new System.EventHandler(this.m_btClose_Click);
            // 
            // m_btnBackup
            // 
            this.m_btnBackup.AlphaGlow = 40F;
            this.m_btnBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(99)))));
            this.m_btnBackup.ButtonImage = null;
            this.m_btnBackup.ButtonText = "Backup Data";
            this.m_btnBackup.DeltaAlphaGlow = 8F;
            this.m_btnBackup.DeltaDistance = 2F;
            this.m_btnBackup.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btnBackup.HaveEffects = false;
            this.m_btnBackup.ImageOrigin = new System.Drawing.Point(35, 0);
            this.m_btnBackup.ImageSize = new System.Drawing.Size(20, 20);
            this.m_btnBackup.Location = new System.Drawing.Point(278, 130);
            this.m_btnBackup.Margin = new System.Windows.Forms.Padding(5);
            this.m_btnBackup.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.m_btnBackup.Name = "m_btnBackup";
            this.m_btnBackup.SaveChanged = false;
            this.m_btnBackup.ShadownDistance = 6;
            this.m_btnBackup.Size = new System.Drawing.Size(169, 95);
            this.m_btnBackup.TabIndex = 15;
            this.m_btnBackup.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Center;
            this.m_btnBackup.TextColor = System.Drawing.Color.White;
            this.m_btnBackup.TextOrigin = new System.Drawing.Point(-8, 0);
            this.m_btnBackup.TransparentBackColor = System.Drawing.Color.Empty;
            this.m_btnBackup.Type = QuanLyHocSinh.ButtonFlat.Types.FlatNormal;
            this.m_btnBackup.Click += new System.EventHandler(this.m_btnBackup_Click);
            // 
            // m_btnRestore
            // 
            this.m_btnRestore.AlphaGlow = 40F;
            this.m_btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(99)))));
            this.m_btnRestore.ButtonImage = null;
            this.m_btnRestore.ButtonText = "Restore Data";
            this.m_btnRestore.DeltaAlphaGlow = 8F;
            this.m_btnRestore.DeltaDistance = 2F;
            this.m_btnRestore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btnRestore.HaveEffects = false;
            this.m_btnRestore.ImageOrigin = new System.Drawing.Point(35, 0);
            this.m_btnRestore.ImageSize = new System.Drawing.Size(20, 20);
            this.m_btnRestore.Location = new System.Drawing.Point(51, 130);
            this.m_btnRestore.Margin = new System.Windows.Forms.Padding(5);
            this.m_btnRestore.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.m_btnRestore.Name = "m_btnRestore";
            this.m_btnRestore.SaveChanged = false;
            this.m_btnRestore.ShadownDistance = 6;
            this.m_btnRestore.Size = new System.Drawing.Size(169, 95);
            this.m_btnRestore.TabIndex = 14;
            this.m_btnRestore.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Center;
            this.m_btnRestore.TextColor = System.Drawing.Color.White;
            this.m_btnRestore.TextOrigin = new System.Drawing.Point(-8, 0);
            this.m_btnRestore.TransparentBackColor = System.Drawing.Color.Empty;
            this.m_btnRestore.Type = QuanLyHocSinh.ButtonFlat.Types.FlatNormal;
            this.m_btnRestore.Click += new System.EventHandler(this.m_btnRestore_Click);
            // 
            // frmData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 268);
            this.Controls.Add(this.m_btHide);
            this.Controls.Add(this.m_btClose);
            this.Controls.Add(this.m_btnBackup);
            this.Controls.Add(this.m_btnRestore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmData";
            this.Text = "Data";
            this.ResumeLayout(false);

        }

        #endregion

        private ButtonFlat m_btnRestore;
        private ButtonFlat m_btnBackup;
        private ButtonFlat m_btClose;
        private ButtonFlat m_btHide;
    }
}