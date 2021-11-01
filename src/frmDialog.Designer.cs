namespace SKCT
{
    partial class frmDialog
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
            this.BtnYes = new SKCT.Controls.IconRoundedButton();
            this.LblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RboxMessage = new System.Windows.Forms.RichTextBox();
            this.BtnNo = new SKCT.Controls.IconRoundedButton();
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
            this.BtnClose.Location = new System.Drawing.Point(997, 2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(30, 30);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnYes
            // 
            this.BtnYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.BtnYes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.BtnYes.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnYes.BorderRadius = 5;
            this.BtnYes.BorderSize = 0;
            this.BtnYes.FlatAppearance.BorderSize = 0;
            this.BtnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnYes.ForeColor = System.Drawing.Color.White;
            this.BtnYes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnYes.IconColor = System.Drawing.Color.White;
            this.BtnYes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnYes.IconSize = 35;
            this.BtnYes.Location = new System.Drawing.Point(941, 342);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.Size = new System.Drawing.Size(50, 50);
            this.BtnYes.TabIndex = 3;
            this.BtnYes.Text = "Yes";
            this.BtnYes.TextColor = System.Drawing.Color.White;
            this.BtnYes.UseVisualStyleBackColor = false;
            this.BtnYes.Click += new System.EventHandler(this.BtnYes_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.LblTitle.Location = new System.Drawing.Point(2, 14);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(164, 24);
            this.LblTitle.TabIndex = 22;
            this.LblTitle.Text = "Thêm Hàng Hóa";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.RboxMessage);
            this.panel2.Controls.Add(this.LblTitle);
            this.panel2.Controls.Add(this.BtnNo);
            this.panel2.Controls.Add(this.BtnYes);
            this.panel2.Location = new System.Drawing.Point(9, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1007, 405);
            this.panel2.TabIndex = 23;
            // 
            // RboxMessage
            // 
            this.RboxMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.RboxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RboxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RboxMessage.ForeColor = System.Drawing.Color.White;
            this.RboxMessage.Location = new System.Drawing.Point(14, 47);
            this.RboxMessage.Name = "RboxMessage";
            this.RboxMessage.ReadOnly = true;
            this.RboxMessage.Size = new System.Drawing.Size(977, 289);
            this.RboxMessage.TabIndex = 23;
            this.RboxMessage.Text = "";
            // 
            // BtnNo
            // 
            this.BtnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(103)))), ((int)(((byte)(183)))));
            this.BtnNo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(103)))), ((int)(((byte)(183)))));
            this.BtnNo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnNo.BorderRadius = 5;
            this.BtnNo.BorderSize = 0;
            this.BtnNo.FlatAppearance.BorderSize = 0;
            this.BtnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnNo.ForeColor = System.Drawing.Color.White;
            this.BtnNo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnNo.IconColor = System.Drawing.Color.White;
            this.BtnNo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnNo.IconSize = 35;
            this.BtnNo.Location = new System.Drawing.Point(863, 342);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.Size = new System.Drawing.Size(50, 50);
            this.BtnNo.TabIndex = 3;
            this.BtnNo.Text = "No";
            this.BtnNo.TextColor = System.Drawing.Color.White;
            this.BtnNo.UseVisualStyleBackColor = false;
            this.BtnNo.Click += new System.EventHandler(this.BtnNo_Click);
            // 
            // frmDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1028, 453);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmDialog";
            this.Text = "frmModifyCustomsDeclare";
            this.Load += new System.EventHandler(this.frmDialog_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton BtnClose;
        private Controls.IconRoundedButton BtnYes;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Panel panel2;
        private Controls.IconRoundedButton BtnNo;
        private System.Windows.Forms.RichTextBox RboxMessage;
    }
}