namespace SKCT
{
    partial class frmModifyCustomsDeclare
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
            this.TboxNoDeclare = new System.Windows.Forms.TextBox();
            this.CboxProduct = new System.Windows.Forms.ComboBox();
            this.BtnAddProduct = new FontAwesome.Sharp.IconButton();
            this.label16 = new System.Windows.Forms.Label();
            this.CboxEnterprise = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAddEnterprise = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CboxTypeLH = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CboxHSCode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CboxUnit = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnOk = new FontAwesome.Sharp.IconButton();
            this.TboxQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnExport = new SKCT.Controls.IconRoundedButton();
            this.PnelWrapper = new System.Windows.Forms.Panel();
            this.DatePickerDateRegister = new System.Windows.Forms.DateTimePicker();
            this.PnelWrapperControl = new System.Windows.Forms.Panel();
            this.BtnImportFromExcel = new SKCT.Controls.IconRoundedButton();
            this.label8 = new System.Windows.Forms.Label();
            this.PnelWrapper.SuspendLayout();
            this.PnelWrapperControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // TboxNoDeclare
            // 
            this.TboxNoDeclare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.TboxNoDeclare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TboxNoDeclare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TboxNoDeclare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.TboxNoDeclare.Location = new System.Drawing.Point(20, 56);
            this.TboxNoDeclare.Name = "TboxNoDeclare";
            this.TboxNoDeclare.PlaceholderText = "Nhập số tờ khai";
            this.TboxNoDeclare.Size = new System.Drawing.Size(345, 29);
            this.TboxNoDeclare.TabIndex = 0;
            // 
            // CboxProduct
            // 
            this.CboxProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.CboxProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CboxProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.CboxProduct.FormattingEnabled = true;
            this.CboxProduct.Location = new System.Drawing.Point(411, 126);
            this.CboxProduct.Name = "CboxProduct";
            this.CboxProduct.Size = new System.Drawing.Size(304, 32);
            this.CboxProduct.TabIndex = 4;
            this.CboxProduct.TabStop = false;
            // 
            // BtnAddProduct
            // 
            this.BtnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.BtnAddProduct.FlatAppearance.BorderSize = 0;
            this.BtnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddProduct.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnAddProduct.IconColor = System.Drawing.Color.White;
            this.BtnAddProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddProduct.IconSize = 25;
            this.BtnAddProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAddProduct.Location = new System.Drawing.Point(716, 126);
            this.BtnAddProduct.Name = "BtnAddProduct";
            this.BtnAddProduct.Size = new System.Drawing.Size(32, 32);
            this.BtnAddProduct.TabIndex = 5;
            this.BtnAddProduct.UseVisualStyleBackColor = false;
            this.BtnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(145)))), ((int)(((byte)(166)))));
            this.label16.Location = new System.Drawing.Point(411, 98);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(141, 24);
            this.label16.TabIndex = 4;
            this.label16.Text = "Chọn hàng hóa";
            // 
            // CboxEnterprise
            // 
            this.CboxEnterprise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.CboxEnterprise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboxEnterprise.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CboxEnterprise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.CboxEnterprise.FormattingEnabled = true;
            this.CboxEnterprise.Location = new System.Drawing.Point(21, 126);
            this.CboxEnterprise.Name = "CboxEnterprise";
            this.CboxEnterprise.Size = new System.Drawing.Size(311, 32);
            this.CboxEnterprise.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(145)))), ((int)(((byte)(166)))));
            this.label1.Location = new System.Drawing.Point(20, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chọn doanh nghiệp";
            // 
            // BtnAddEnterprise
            // 
            this.BtnAddEnterprise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.BtnAddEnterprise.FlatAppearance.BorderSize = 0;
            this.BtnAddEnterprise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddEnterprise.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnAddEnterprise.IconColor = System.Drawing.Color.White;
            this.BtnAddEnterprise.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddEnterprise.IconSize = 25;
            this.BtnAddEnterprise.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAddEnterprise.Location = new System.Drawing.Point(333, 126);
            this.BtnAddEnterprise.Name = "BtnAddEnterprise";
            this.BtnAddEnterprise.Size = new System.Drawing.Size(32, 32);
            this.BtnAddEnterprise.TabIndex = 3;
            this.BtnAddEnterprise.UseVisualStyleBackColor = false;
            this.BtnAddEnterprise.Click += new System.EventHandler(this.BtnAddEnterprise_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(145)))), ((int)(((byte)(166)))));
            this.label2.Location = new System.Drawing.Point(20, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập số tờ khai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(145)))), ((int)(((byte)(166)))));
            this.label3.Location = new System.Drawing.Point(411, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhập ngày đăng ký";
            // 
            // CboxTypeLH
            // 
            this.CboxTypeLH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.CboxTypeLH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboxTypeLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CboxTypeLH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.CboxTypeLH.FormattingEnabled = true;
            this.CboxTypeLH.Location = new System.Drawing.Point(21, 203);
            this.CboxTypeLH.Name = "CboxTypeLH";
            this.CboxTypeLH.Size = new System.Drawing.Size(344, 32);
            this.CboxTypeLH.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(145)))), ((int)(((byte)(166)))));
            this.label4.Location = new System.Drawing.Point(21, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã LH";
            // 
            // CboxHSCode
            // 
            this.CboxHSCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.CboxHSCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboxHSCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CboxHSCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.CboxHSCode.FormattingEnabled = true;
            this.CboxHSCode.Location = new System.Drawing.Point(411, 203);
            this.CboxHSCode.Name = "CboxHSCode";
            this.CboxHSCode.Size = new System.Drawing.Size(337, 32);
            this.CboxHSCode.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(145)))), ((int)(((byte)(166)))));
            this.label5.Location = new System.Drawing.Point(411, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã HS";
            // 
            // CboxUnit
            // 
            this.CboxUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.CboxUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboxUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CboxUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.CboxUnit.FormattingEnabled = true;
            this.CboxUnit.Location = new System.Drawing.Point(411, 281);
            this.CboxUnit.Name = "CboxUnit";
            this.CboxUnit.Size = new System.Drawing.Size(337, 32);
            this.CboxUnit.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(145)))), ((int)(((byte)(166)))));
            this.label7.Location = new System.Drawing.Point(411, 253);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Đơn vị tính";
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
            this.BtnOk.Location = new System.Drawing.Point(698, 335);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(50, 50);
            this.BtnOk.TabIndex = 6;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // TboxQuantity
            // 
            this.TboxQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.TboxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TboxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TboxQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.TboxQuantity.Location = new System.Drawing.Point(21, 280);
            this.TboxQuantity.Name = "TboxQuantity";
            this.TboxQuantity.PlaceholderText = "Nhập số tờ khai";
            this.TboxQuantity.Size = new System.Drawing.Size(344, 29);
            this.TboxQuantity.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(145)))), ((int)(((byte)(166)))));
            this.label6.Location = new System.Drawing.Point(21, 253);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nhập số lượng";
            // 
            // BtnExport
            // 
            this.BtnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.BtnExport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.BtnExport.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnExport.BorderRadius = 5;
            this.BtnExport.BorderSize = 0;
            this.BtnExport.FlatAppearance.BorderSize = 0;
            this.BtnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnExport.ForeColor = System.Drawing.Color.White;
            this.BtnExport.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.BtnExport.IconColor = System.Drawing.Color.White;
            this.BtnExport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExport.IconSize = 25;
            this.BtnExport.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.BtnExport.Location = new System.Drawing.Point(58, 16);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnExport.Size = new System.Drawing.Size(177, 40);
            this.BtnExport.TabIndex = 10;
            this.BtnExport.Text = "Export to Excel";
            this.BtnExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExport.TextColor = System.Drawing.Color.White;
            this.BtnExport.UseVisualStyleBackColor = false;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // PnelWrapper
            // 
            this.PnelWrapper.Controls.Add(this.DatePickerDateRegister);
            this.PnelWrapper.Controls.Add(this.label2);
            this.PnelWrapper.Controls.Add(this.BtnOk);
            this.PnelWrapper.Controls.Add(this.label6);
            this.PnelWrapper.Controls.Add(this.TboxNoDeclare);
            this.PnelWrapper.Controls.Add(this.TboxQuantity);
            this.PnelWrapper.Controls.Add(this.CboxUnit);
            this.PnelWrapper.Controls.Add(this.BtnAddProduct);
            this.PnelWrapper.Controls.Add(this.CboxHSCode);
            this.PnelWrapper.Controls.Add(this.label16);
            this.PnelWrapper.Controls.Add(this.label7);
            this.PnelWrapper.Controls.Add(this.label3);
            this.PnelWrapper.Controls.Add(this.CboxTypeLH);
            this.PnelWrapper.Controls.Add(this.BtnAddEnterprise);
            this.PnelWrapper.Controls.Add(this.label5);
            this.PnelWrapper.Controls.Add(this.label1);
            this.PnelWrapper.Controls.Add(this.CboxEnterprise);
            this.PnelWrapper.Controls.Add(this.CboxProduct);
            this.PnelWrapper.Controls.Add(this.label4);
            this.PnelWrapper.Location = new System.Drawing.Point(21, 131);
            this.PnelWrapper.Name = "PnelWrapper";
            this.PnelWrapper.Size = new System.Drawing.Size(780, 407);
            this.PnelWrapper.TabIndex = 11;
            this.PnelWrapper.Paint += new System.Windows.Forms.PaintEventHandler(this.PnelWrapper_Paint);
            // 
            // DatePickerDateRegister
            // 
            this.DatePickerDateRegister.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.DatePickerDateRegister.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.DatePickerDateRegister.CustomFormat = "dd/MM/yyyy";
            this.DatePickerDateRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DatePickerDateRegister.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePickerDateRegister.Location = new System.Drawing.Point(411, 56);
            this.DatePickerDateRegister.Name = "DatePickerDateRegister";
            this.DatePickerDateRegister.Size = new System.Drawing.Size(337, 29);
            this.DatePickerDateRegister.TabIndex = 10;
            // 
            // PnelWrapperControl
            // 
            this.PnelWrapperControl.Controls.Add(this.BtnImportFromExcel);
            this.PnelWrapperControl.Controls.Add(this.BtnExport);
            this.PnelWrapperControl.Location = new System.Drawing.Point(21, 16);
            this.PnelWrapperControl.Name = "PnelWrapperControl";
            this.PnelWrapperControl.Size = new System.Drawing.Size(780, 72);
            this.PnelWrapperControl.TabIndex = 12;
            this.PnelWrapperControl.Paint += new System.Windows.Forms.PaintEventHandler(this.PnelWrapper_Paint);
            // 
            // BtnImportFromExcel
            // 
            this.BtnImportFromExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.BtnImportFromExcel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.BtnImportFromExcel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnImportFromExcel.BorderRadius = 5;
            this.BtnImportFromExcel.BorderSize = 0;
            this.BtnImportFromExcel.FlatAppearance.BorderSize = 0;
            this.BtnImportFromExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImportFromExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnImportFromExcel.ForeColor = System.Drawing.Color.White;
            this.BtnImportFromExcel.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            this.BtnImportFromExcel.IconColor = System.Drawing.Color.White;
            this.BtnImportFromExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnImportFromExcel.IconSize = 25;
            this.BtnImportFromExcel.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.BtnImportFromExcel.Location = new System.Drawing.Point(275, 16);
            this.BtnImportFromExcel.Name = "BtnImportFromExcel";
            this.BtnImportFromExcel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnImportFromExcel.Size = new System.Drawing.Size(177, 40);
            this.BtnImportFromExcel.TabIndex = 10;
            this.BtnImportFromExcel.Text = "Import file Excel";
            this.BtnImportFromExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImportFromExcel.TextColor = System.Drawing.Color.White;
            this.BtnImportFromExcel.UseVisualStyleBackColor = false;
            this.BtnImportFromExcel.Click += new System.EventHandler(this.BtnImportFromExcel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(145)))), ((int)(((byte)(166)))));
            this.label8.Location = new System.Drawing.Point(30, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Form thêm data";
            // 
            // frmModifyCustomsDeclare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(855, 550);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PnelWrapperControl);
            this.Controls.Add(this.PnelWrapper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmModifyCustomsDeclare";
            this.Text = "frmModifyCustomsDeclare";
            this.Load += new System.EventHandler(this.frmModifyCustomsDeclare_Load);
            this.PnelWrapper.ResumeLayout(false);
            this.PnelWrapper.PerformLayout();
            this.PnelWrapperControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TboxNoDeclare;
        private System.Windows.Forms.ComboBox CboxProduct;
        private FontAwesome.Sharp.IconButton BtnAddProduct;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox CboxEnterprise;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnAddEnterprise;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboxTypeLH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CboxHSCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CboxUnit;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton BtnOk;
        private System.Windows.Forms.TextBox TboxQuantity;
        private System.Windows.Forms.Label label6;
        private Controls.IconRoundedButton BtnExport;
        private System.Windows.Forms.Panel PnelWrapper;
        private System.Windows.Forms.Panel PnelWrapperControl;
        private System.Windows.Forms.Label label8;
        private Controls.IconRoundedButton BtnImportFromExcel;
        private System.Windows.Forms.DateTimePicker DatePickerDateRegister;
    }
}