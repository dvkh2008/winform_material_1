namespace SKCT
{
    partial class frmCreateProduct
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
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.BtnOk = new FontAwesome.Sharp.IconButton();
            this.PanlWrapperTextbox = new System.Windows.Forms.Panel();
            this.TboxProductName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TboxDescription = new System.Windows.Forms.TextBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanlWrapperTextbox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.BtnClose.IconColor = System.Drawing.Color.White;
            this.BtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClose.IconSize = 25;
            this.BtnClose.Location = new System.Drawing.Point(428, 2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(30, 30);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(103)))), ((int)(((byte)(183)))));
            this.BtnOk.FlatAppearance.BorderSize = 0;
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnOk.ForeColor = System.Drawing.Color.White;
            this.BtnOk.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnOk.IconColor = System.Drawing.Color.White;
            this.BtnOk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnOk.IconSize = 35;
            this.BtnOk.Location = new System.Drawing.Point(388, 348);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(50, 50);
            this.BtnOk.TabIndex = 3;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // PanlWrapperTextbox
            // 
            this.PanlWrapperTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.PanlWrapperTextbox.Controls.Add(this.TboxProductName);
            this.PanlWrapperTextbox.Location = new System.Drawing.Point(4, 59);
            this.PanlWrapperTextbox.Name = "PanlWrapperTextbox";
            this.PanlWrapperTextbox.Size = new System.Drawing.Size(434, 36);
            this.PanlWrapperTextbox.TabIndex = 20;
            // 
            // TboxProductName
            // 
            this.TboxProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.TboxProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TboxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TboxProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.TboxProductName.Location = new System.Drawing.Point(10, 8);
            this.TboxProductName.Margin = new System.Windows.Forms.Padding(0);
            this.TboxProductName.Name = "TboxProductName";
            this.TboxProductName.PlaceholderText = "Nhập tên hàng hóa";
            this.TboxProductName.Size = new System.Drawing.Size(414, 19);
            this.TboxProductName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.TboxDescription);
            this.panel1.Location = new System.Drawing.Point(4, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 228);
            this.panel1.TabIndex = 21;
            // 
            // TboxDescription
            // 
            this.TboxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.TboxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TboxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TboxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.TboxDescription.Location = new System.Drawing.Point(10, 8);
            this.TboxDescription.Margin = new System.Windows.Forms.Padding(0);
            this.TboxDescription.Multiline = true;
            this.TboxDescription.Name = "TboxDescription";
            this.TboxDescription.PlaceholderText = "Nhập mô tả hàng hóa";
            this.TboxDescription.Size = new System.Drawing.Size(414, 208);
            this.TboxDescription.TabIndex = 2;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbltitle.Location = new System.Drawing.Point(2, 14);
            this.lbltitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(233, 32);
            this.lbltitle.TabIndex = 22;
            this.lbltitle.Text = "Thêm Hàng Hóa";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.lbltitle);
            this.panel2.Controls.Add(this.BtnOk);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.PanlWrapperTextbox);
            this.panel2.Location = new System.Drawing.Point(9, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 405);
            this.panel2.TabIndex = 23;
            // 
            // frmCreateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(459, 447);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmCreateProduct";
            this.Text = "frmModifyCustomsDeclare";
            this.Load += new System.EventHandler(this.frmCreateProduct_Load);
            this.PanlWrapperTextbox.ResumeLayout(false);
            this.PanlWrapperTextbox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton BtnClose;
        private FontAwesome.Sharp.IconButton BtnOk;
        private System.Windows.Forms.Panel PanlWrapperTextbox;
        private System.Windows.Forms.TextBox TboxProductName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TboxDescription;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel panel2;
    }
}