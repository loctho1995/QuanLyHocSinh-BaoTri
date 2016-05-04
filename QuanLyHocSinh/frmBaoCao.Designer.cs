namespace QuanLyHocSinh
{
    partial class frmBaoCao
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
            this.m_tableName = new System.Windows.Forms.Label();
            this.m_lableLop = new System.Windows.Forms.Label();
            this.m_dgvData = new System.Windows.Forms.DataGridView();
            this.m_ButtonPreview = new System.Windows.Forms.Button();
            this.m_ButtonPrint = new System.Windows.Forms.Button();
            this.m_ButtonExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // m_tableName
            // 
            this.m_tableName.BackColor = System.Drawing.Color.Transparent;
            this.m_tableName.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.m_tableName.ForeColor = System.Drawing.Color.Black;
            this.m_tableName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.m_tableName.Location = new System.Drawing.Point(339, 34);
            this.m_tableName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_tableName.Name = "m_tableName";
            this.m_tableName.Size = new System.Drawing.Size(267, 43);
            this.m_tableName.TabIndex = 5;
            this.m_tableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_lableLop
            // 
            this.m_lableLop.BackColor = System.Drawing.Color.Transparent;
            this.m_lableLop.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.m_lableLop.ForeColor = System.Drawing.Color.Black;
            this.m_lableLop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.m_lableLop.Location = new System.Drawing.Point(40, 34);
            this.m_lableLop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_lableLop.Name = "m_lableLop";
            this.m_lableLop.Size = new System.Drawing.Size(267, 43);
            this.m_lableLop.TabIndex = 1;
            this.m_lableLop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_dgvData
            // 
            this.m_dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_dgvData.BackgroundColor = System.Drawing.Color.White;
            this.m_dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dgvData.Location = new System.Drawing.Point(1, 79);
            this.m_dgvData.Margin = new System.Windows.Forms.Padding(2);
            this.m_dgvData.Name = "m_dgvData";
            this.m_dgvData.ReadOnly = true;
            this.m_dgvData.RowTemplate.Height = 24;
            this.m_dgvData.Size = new System.Drawing.Size(750, 325);
            this.m_dgvData.TabIndex = 2;
            // 
            // m_ButtonPreview
            // 
            this.m_ButtonPreview.Location = new System.Drawing.Point(441, 411);
            this.m_ButtonPreview.Name = "m_ButtonPreview";
            this.m_ButtonPreview.Size = new System.Drawing.Size(95, 28);
            this.m_ButtonPreview.TabIndex = 18;
            this.m_ButtonPreview.Text = "Preview";
            this.m_ButtonPreview.UseVisualStyleBackColor = true;
            this.m_ButtonPreview.Click += new System.EventHandler(this.m_ButtonPreview_Click);
            // 
            // m_ButtonPrint
            // 
            this.m_ButtonPrint.Location = new System.Drawing.Point(542, 411);
            this.m_ButtonPrint.Name = "m_ButtonPrint";
            this.m_ButtonPrint.Size = new System.Drawing.Size(95, 28);
            this.m_ButtonPrint.TabIndex = 18;
            this.m_ButtonPrint.Text = "Print";
            this.m_ButtonPrint.UseVisualStyleBackColor = true;
            this.m_ButtonPrint.Click += new System.EventHandler(this.m_ButtonPrint_Click);
            // 
            // m_ButtonExport
            // 
            this.m_ButtonExport.Location = new System.Drawing.Point(643, 411);
            this.m_ButtonExport.Name = "m_ButtonExport";
            this.m_ButtonExport.Size = new System.Drawing.Size(95, 28);
            this.m_ButtonExport.TabIndex = 18;
            this.m_ButtonExport.Text = "Export";
            this.m_ButtonExport.UseVisualStyleBackColor = true;
            this.m_ButtonExport.Click += new System.EventHandler(this.m_ButtonExport_Click);
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 483);
            this.Controls.Add(this.m_ButtonExport);
            this.Controls.Add(this.m_ButtonPrint);
            this.Controls.Add(this.m_ButtonPreview);
            this.Controls.Add(this.m_tableName);
            this.Controls.Add(this.m_dgvData);
            this.Controls.Add(this.m_lableLop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBaoCao";
            this.Text = "frmBaoCao";
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label m_lableLop;
        private System.Windows.Forms.Label m_tableName;
        private System.Windows.Forms.DataGridView m_dgvData;
        private System.Windows.Forms.Button m_ButtonPreview;
        private System.Windows.Forms.Button m_ButtonPrint;
        private System.Windows.Forms.Button m_ButtonExport;
    }
}