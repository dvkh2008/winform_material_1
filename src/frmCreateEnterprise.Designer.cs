namespace SKCT
{
    partial class frmCreateEnterprise
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
            this.TboxName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TboxMST = new System.Windows.Forms.TextBox();
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
            this.BtnOk.Location = new System.Drawing.Point(388, 167);
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
            this.PanlWrapperTextbox.Controls.Add(this.TboxName);
            this.PanlWrapperTextbox.Location = new System.Drawing.Point(4, 59);
            this.PanlWrapperTextbox.Name = "PanlWrapperTextbox";
            this.PanlWrapperTextbox.Size = new System.Drawing.Size(434, 36);
            this.PanlWrapperTextbox.TabIndex = 20;
            // 
            // TboxName
            // 
            this.TboxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.TboxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TboxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TboxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.TboxName.Location = new System.Drawing.Point(10, 8);
            this.TboxName.Margin = new System.Windows.Forms.Padding(0);
            this.TboxName.Name = "TboxName";
            this.TboxName.PlaceholderText = "Nhập tên doanh nghiệp";
            this.TboxName.Size = new System.Drawing.Size(414, 19);
            this.TboxName.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.TboxMST);
            this.panel1.Location = new System.Drawing.Point(4, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 36);
            this.panel1.TabIndex = 21;
            // 
            // TboxMST
            // 
            this.TboxMST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.TboxMST.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TboxMST.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TboxMST.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.TboxMST.Location = new System.Drawing.Point(10, 8);
            this.TboxMST.Margin = new System.Windows.Forms.Padding(0);
            this.TboxMST.Name = "TboxMST";
            this.TboxMST.PlaceholderText = "Nhập mã số thuế";
            this.TboxMST.Size = new System.Drawing.Size(414, 19);
            this.TboxMST.TabIndex = 2;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbltitle.Location = new System.Drawing.Point(2, 14);
            this.lbltitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(292, 32);
            this.lbltitle.TabIndex = 22;
            this.lbltitle.Text = "Thêm Doanh Nghiệp";
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
            this.panel2.Size = new System.Drawing.Size(443, 230);
            this.panel2.TabIndex = 23;
            // 
            // frmCreateEnterprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(459, 270);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmCreateEnterprise";
            this.Text = "frmModifyCustomsDeclare";
            this.Load += new System.EventHandler(this.frmCreateEnterprise_Load);
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
        private System.Windows.Forms.TextBox TboxName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TboxMST;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel panel2;
    }
}