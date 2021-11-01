using SKCT.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKCT
{
    public partial class frmCreateEnterprise : Form
    {
        public frmCreateEnterprise()
        {
            InitializeComponent();

            #region [Move & resize]
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            #endregion
        }

        #region [Move & resize]
        private const int cCaption = 32;   // Caption bar height;

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            using SolidBrush brush = new SolidBrush(Color.FromArgb(24, 30, 54));
            e.Graphics.FillRectangle(brush, rc);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
            }
            base.WndProc(ref m);
        }
        #endregion

        public string NameInit { get; set; }
        public Enterprise NewEnterprise { get; set; }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TboxName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên doanh nghiệp");
                this.TboxName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(TboxMST.Text))
            {
                MessageBox.Show("Vui lòng nhập MST");
                this.TboxMST.Focus();
                return;
            }
            NewEnterprise = new Enterprise
            {
                Name = TboxName.Text,
                MST = TboxMST.Text
            };
            using var db = new DbContext();
            db.Enterprises.Add(NewEnterprise);
            db.SaveChange();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmCreateEnterprise_Load(object sender, EventArgs e)
        {
            TboxName.Text = NameInit;
            this.ActiveControl = TboxName;
        }
    }
}
