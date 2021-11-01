namespace SKCT
{
    partial class frmSettings
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
            this.BtnDeleteDatabase = new SKCT.Controls.IconRoundedButton();
            this.SuspendLayout();
            // 
            // BtnDeleteDatabase
            // 
            this.BtnDeleteDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDeleteDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.BtnDeleteDatabase.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.BtnDeleteDatabase.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnDeleteDatabase.BorderRadius = 5;
            this.BtnDeleteDatabase.BorderSize = 0;
            this.BtnDeleteDatabase.FlatAppearance.BorderSize = 0;
            this.BtnDeleteDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDeleteDatabase.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteDatabase.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.BtnDeleteDatabase.IconColor = System.Drawing.Color.White;
            this.BtnDeleteDatabase.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDeleteDatabase.IconSize = 25;
            this.BtnDeleteDatabase.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.BtnDeleteDatabase.Location = new System.Drawing.Point(294, 258);
            this.BtnDeleteDatabase.Name = "BtnDeleteDatabase";
            this.BtnDeleteDatabase.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnDeleteDatabase.Size = new System.Drawing.Size(202, 40);
            this.BtnDeleteDatabase.TabIndex = 9;
            this.BtnDeleteDatabase.Text = "Xóa cơ sở dữ liệu";
            this.BtnDeleteDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDeleteDatabase.TextColor = System.Drawing.Color.White;
            this.BtnDeleteDatabase.UseVisualStyleBackColor = false;
            this.BtnDeleteDatabase.Click += new System.EventHandler(this.BtnDeleteDatabase_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(855, 556);
            this.Controls.Add(this.BtnDeleteDatabase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.IconRoundedButton BtnDeleteDatabase;
    }
}