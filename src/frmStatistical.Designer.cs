namespace SKCT
{
    partial class frmStatistical
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
            this.CboxPageNo = new System.Windows.Forms.ComboBox();
            this.BtnToi1Trang = new SKCT.Controls.IconRoundedButton();
            this.BtnLui1Trang = new SKCT.Controls.IconRoundedButton();
            this.BtnTrangCuoi = new SKCT.Controls.IconRoundedButton();
            this.BtnTrangDau = new SKCT.Controls.IconRoundedButton();
            this.DGridView = new System.Windows.Forms.DataGridView();
            this.CboxPageSize = new System.Windows.Forms.ComboBox();
            this.LblInfo = new System.Windows.Forms.Label();
            this.ColumnMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNoDeclare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CboxPageNo
            // 
            this.CboxPageNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CboxPageNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.CboxPageNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxPageNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboxPageNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CboxPageNo.ForeColor = System.Drawing.Color.White;
            this.CboxPageNo.FormattingEnabled = true;
            this.CboxPageNo.ItemHeight = 29;
            this.CboxPageNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.CboxPageNo.Location = new System.Drawing.Point(327, 516);
            this.CboxPageNo.Name = "CboxPageNo";
            this.CboxPageNo.Size = new System.Drawing.Size(79, 37);
            this.CboxPageNo.TabIndex = 17;
            this.CboxPageNo.SelectedIndexChanged += new System.EventHandler(this.CboxPageNo_SelectedIndexChanged);
            // 
            // BtnToi1Trang
            // 
            this.BtnToi1Trang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnToi1Trang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.BtnToi1Trang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.BtnToi1Trang.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnToi1Trang.BorderRadius = 5;
            this.BtnToi1Trang.BorderSize = 0;
            this.BtnToi1Trang.FlatAppearance.BorderSize = 0;
            this.BtnToi1Trang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnToi1Trang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnToi1Trang.ForeColor = System.Drawing.Color.White;
            this.BtnToi1Trang.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.BtnToi1Trang.IconColor = System.Drawing.Color.White;
            this.BtnToi1Trang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnToi1Trang.IconSize = 25;
            this.BtnToi1Trang.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.BtnToi1Trang.Location = new System.Drawing.Point(421, 513);
            this.BtnToi1Trang.Name = "BtnToi1Trang";
            this.BtnToi1Trang.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnToi1Trang.Size = new System.Drawing.Size(134, 40);
            this.BtnToi1Trang.TabIndex = 16;
            this.BtnToi1Trang.Text = "Tới 1 trang";
            this.BtnToi1Trang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnToi1Trang.TextColor = System.Drawing.Color.White;
            this.BtnToi1Trang.UseVisualStyleBackColor = false;
            this.BtnToi1Trang.Click += new System.EventHandler(this.BtnToi1Trang_Click);
            // 
            // BtnLui1Trang
            // 
            this.BtnLui1Trang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnLui1Trang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.BtnLui1Trang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.BtnLui1Trang.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnLui1Trang.BorderRadius = 5;
            this.BtnLui1Trang.BorderSize = 0;
            this.BtnLui1Trang.FlatAppearance.BorderSize = 0;
            this.BtnLui1Trang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLui1Trang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnLui1Trang.ForeColor = System.Drawing.Color.White;
            this.BtnLui1Trang.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.BtnLui1Trang.IconColor = System.Drawing.Color.White;
            this.BtnLui1Trang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLui1Trang.IconSize = 25;
            this.BtnLui1Trang.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnLui1Trang.Location = new System.Drawing.Point(174, 513);
            this.BtnLui1Trang.Name = "BtnLui1Trang";
            this.BtnLui1Trang.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnLui1Trang.Size = new System.Drawing.Size(138, 40);
            this.BtnLui1Trang.TabIndex = 15;
            this.BtnLui1Trang.Text = "Lùi 1 trang";
            this.BtnLui1Trang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLui1Trang.TextColor = System.Drawing.Color.White;
            this.BtnLui1Trang.UseVisualStyleBackColor = false;
            this.BtnLui1Trang.Click += new System.EventHandler(this.BtnLui1Trang_Click);
            // 
            // BtnTrangCuoi
            // 
            this.BtnTrangCuoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnTrangCuoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.BtnTrangCuoi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.BtnTrangCuoi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnTrangCuoi.BorderRadius = 5;
            this.BtnTrangCuoi.BorderSize = 0;
            this.BtnTrangCuoi.FlatAppearance.BorderSize = 0;
            this.BtnTrangCuoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTrangCuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnTrangCuoi.ForeColor = System.Drawing.Color.White;
            this.BtnTrangCuoi.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.BtnTrangCuoi.IconColor = System.Drawing.Color.White;
            this.BtnTrangCuoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnTrangCuoi.IconSize = 25;
            this.BtnTrangCuoi.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.BtnTrangCuoi.Location = new System.Drawing.Point(561, 513);
            this.BtnTrangCuoi.Name = "BtnTrangCuoi";
            this.BtnTrangCuoi.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnTrangCuoi.Size = new System.Drawing.Size(150, 40);
            this.BtnTrangCuoi.TabIndex = 14;
            this.BtnTrangCuoi.Text = "Trang cuối";
            this.BtnTrangCuoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTrangCuoi.TextColor = System.Drawing.Color.White;
            this.BtnTrangCuoi.UseVisualStyleBackColor = false;
            this.BtnTrangCuoi.Click += new System.EventHandler(this.BtnTrangCuoi_Click);
            // 
            // BtnTrangDau
            // 
            this.BtnTrangDau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnTrangDau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.BtnTrangDau.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.BtnTrangDau.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnTrangDau.BorderRadius = 5;
            this.BtnTrangDau.BorderSize = 0;
            this.BtnTrangDau.FlatAppearance.BorderSize = 0;
            this.BtnTrangDau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTrangDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnTrangDau.ForeColor = System.Drawing.Color.White;
            this.BtnTrangDau.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            this.BtnTrangDau.IconColor = System.Drawing.Color.White;
            this.BtnTrangDau.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnTrangDau.IconSize = 25;
            this.BtnTrangDau.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnTrangDau.Location = new System.Drawing.Point(35, 513);
            this.BtnTrangDau.Name = "BtnTrangDau";
            this.BtnTrangDau.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnTrangDau.Size = new System.Drawing.Size(133, 40);
            this.BtnTrangDau.TabIndex = 13;
            this.BtnTrangDau.Text = "Trang đầu";
            this.BtnTrangDau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnTrangDau.TextColor = System.Drawing.Color.White;
            this.BtnTrangDau.UseVisualStyleBackColor = false;
            this.BtnTrangDau.Click += new System.EventHandler(this.BtnTrangDau_Click);
            // 
            // DGridView
            // 
            this.DGridView.AllowUserToAddRows = false;
            this.DGridView.AllowUserToDeleteRows = false;
            this.DGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(88)))));
            this.DGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMonth,
            this.ColumnNoDeclare,
            this.ColumnProductName});
            this.DGridView.Location = new System.Drawing.Point(0, 3);
            this.DGridView.Name = "DGridView";
            this.DGridView.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGridView.RowTemplate.Height = 25;
            this.DGridView.Size = new System.Drawing.Size(1010, 506);
            this.DGridView.TabIndex = 12;
            this.DGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DGridView_RowPostPaint);
            // 
            // CboxPageSize
            // 
            this.CboxPageSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CboxPageSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.CboxPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxPageSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboxPageSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CboxPageSize.ForeColor = System.Drawing.Color.White;
            this.CboxPageSize.FormattingEnabled = true;
            this.CboxPageSize.ItemHeight = 29;
            this.CboxPageSize.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.CboxPageSize.Location = new System.Drawing.Point(736, 516);
            this.CboxPageSize.Name = "CboxPageSize";
            this.CboxPageSize.Size = new System.Drawing.Size(79, 37);
            this.CboxPageSize.TabIndex = 17;
            this.CboxPageSize.SelectedIndexChanged += new System.EventHandler(this.CboxPageSize_SelectedIndexChanged);
            // 
            // LblInfo
            // 
            this.LblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblInfo.AutoSize = true;
            this.LblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblInfo.ForeColor = System.Drawing.Color.White;
            this.LblInfo.Location = new System.Drawing.Point(822, 533);
            this.LblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(118, 20);
            this.LblInfo.TabIndex = 18;
            this.LblInfo.Text = "Top declaration";
            // 
            // ColumnMonth
            // 
            this.ColumnMonth.DataPropertyName = "DateRegister";
            this.ColumnMonth.HeaderText = "Tháng";
            this.ColumnMonth.Name = "ColumnMonth";
            this.ColumnMonth.ReadOnly = true;
            this.ColumnMonth.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnMonth.Width = 135;
            // 
            // ColumnNoDeclare
            // 
            this.ColumnNoDeclare.DataPropertyName = "NoDeclearUI";
            this.ColumnNoDeclare.HeaderText = "Số tờ khai";
            this.ColumnNoDeclare.Name = "ColumnNoDeclare";
            this.ColumnNoDeclare.ReadOnly = true;
            this.ColumnNoDeclare.Width = 136;
            // 
            // ColumnProductName
            // 
            this.ColumnProductName.DataPropertyName = "HarmonizedSystemCode";
            this.ColumnProductName.HeaderText = "Mã HS";
            this.ColumnProductName.Name = "ColumnProductName";
            this.ColumnProductName.ReadOnly = true;
            this.ColumnProductName.Width = 135;
            // 
            // frmStatistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(1010, 556);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.CboxPageSize);
            this.Controls.Add(this.CboxPageNo);
            this.Controls.Add(this.BtnToi1Trang);
            this.Controls.Add(this.BtnLui1Trang);
            this.Controls.Add(this.BtnTrangCuoi);
            this.Controls.Add(this.BtnTrangDau);
            this.Controls.Add(this.DGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmStatistical";
            this.Text = "frmContactUs";
            this.Load += new System.EventHandler(this.frmStatistical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboxPageNo;
        private System.Windows.Forms.DataGridView DGridView;
        private Controls.IconRoundedButton BtnToi1Trang;
        private Controls.IconRoundedButton BtnLui1Trang;
        private Controls.IconRoundedButton BtnTrangCuoi;
        private Controls.IconRoundedButton BtnTrangDau;
        private System.Windows.Forms.ComboBox CboxPageSize;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNoDeclare;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductName;
    }
}