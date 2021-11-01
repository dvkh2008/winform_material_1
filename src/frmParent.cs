using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Forms.VisualStyles;

namespace SKCT
{
    public partial class frmParent : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse

         );

        public frmParent()
        {
            InitializeComponent();
            var a = CreateRoundRectRgn(0, 0, Width, Height, 10, 10);
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 500, 200, 10, 10));
            pnlNav.Height = btnDashbord.Height;
            pnlNav.Top = btnDashbord.Top;
            pnlNav.Left = btnDashbord.Left;

            lbltitle.Text = "Dashboard";
            frmDashboard frmDashboard_vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            SetSizeToForm(frmDashboard_vrb);
            this.pnlFormLoader.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
            ActiveButton(btnDashbord, true);

            var db = new Entity.DbContext();
            db.SeedDbContext();

            #region [Move & resize]
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            #endregion
        }

        #region [Move & resize]
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);

            using SolidBrush brush = new SolidBrush(Color.FromArgb(40, 58, 88));
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
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }
        #endregion

        private void VisibleControlSearchDb(bool value)
        {
            this.TxtInputSearchDb.Text = "";
            this.TxtInputSearchDb.Visible = value;
            this.BtnSearchOnDB.Visible = value;
            this.PanlWrapperTextbox.Visible = value;
        }

        private void ActiveButton(FontAwesome.Sharp.IconButton btn, bool isActive)
        {
            if (isActive)
            {
                InActiveButton();
                btn.BackColor = Color.FromArgb(40, 58, 88);
                btn.ForeColor = Color.White;
                btn.IconColor = Color.White;
                btn.Tag = "active";
            }
            else
            {
                btn.BackColor = Color.FromArgb(31, 45, 72);
                btn.ForeColor = Color.FromArgb(139, 145, 166);
                btn.IconColor = Color.FromArgb(139, 145, 166);
                btn.Tag = "";
            }
        }

        private void InActiveButton()
        {
            if (btnDashbord.Tag?.ToString() == "active")
            {
                ActiveButton(btnDashbord, false);
            }
            if (BtnCorporation.Tag?.ToString() == "active")
            {
                ActiveButton(BtnCorporation, false);
            }
            if (BtnSearch.Tag?.ToString() == "active")
            {
                ActiveButton(BtnSearch, false);
            }
            if (BtnStatistical.Tag?.ToString() == "active")
            {
                ActiveButton(BtnStatistical, false);
            }
            if (BtnModifyCustomsDeclare.Tag?.ToString() == "active")
            {
                ActiveButton(BtnModifyCustomsDeclare, false);
            }
            if (btnsettings.Tag?.ToString() == "active")
            {
                ActiveButton(btnsettings, false);
            }
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            VisibleControlSearchDb(false);
            pnlNav.Height = btnDashbord.Height;
            pnlNav.Top = btnDashbord.Top;
            pnlNav.Left = btnDashbord.Left;
            ActiveButton(btnDashbord, true);

            lbltitle.Text = "Dashboard";
            this.pnlFormLoader.Controls.Clear();
            frmDashboard frmDashboard_vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, Anchor = AnchorStyles.Top };
            frmDashboard_vrb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            SetSizeToForm(frmDashboard_vrb);

            this.pnlFormLoader.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();

        }

        private void BtnCorporation_Click(object sender, EventArgs e)
        {
            VisibleControlSearchDb(false);

            pnlNav.Height = BtnCorporation.Height;
            pnlNav.Top = BtnCorporation.Top;
            ActiveButton(BtnCorporation, true);

            lbltitle.Text = "Corporation";
            this.pnlFormLoader.Controls.Clear();
            frmCorporation frmAnalytics_vrb = new frmCorporation() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAnalytics_vrb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            frmAnalytics_vrb.FormBorderStyle = FormBorderStyle.None;
            SetSizeToForm(frmAnalytics_vrb);

            this.pnlFormLoader.Controls.Add(frmAnalytics_vrb);
            frmAnalytics_vrb.Show();
        }

        private void BtnStatistical_Click(object sender, EventArgs e)
        {
            VisibleControlSearchDb(true);
            pnlNav.Height = BtnStatistical.Height;
            pnlNav.Top = BtnStatistical.Top;
            ActiveButton(BtnStatistical, true);

            this.pnlFormLoader.Controls.Clear();
            frmStatistical frmStatistical_vrb = new frmStatistical() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmStatistical_vrb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            frmStatistical_vrb.FormBorderStyle = FormBorderStyle.None;
            SetSizeToForm(frmStatistical_vrb);

            this.pnlFormLoader.Controls.Add(frmStatistical_vrb);
            frmStatistical_vrb.Show();
            lbltitle.Text = "Statistical";
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnsettings.Height;
            pnlNav.Top = btnsettings.Top;
            ActiveButton(btnsettings, true);

            this.pnlFormLoader.Controls.Clear();
            frmSettings frmSettings_vrb = new frmSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmSettings_vrb.FormBorderStyle = FormBorderStyle.None;
            SetSizeToForm(frmSettings_vrb);
            this.pnlFormLoader.Controls.Add(frmSettings_vrb);
            frmSettings_vrb.Show();
            lbltitle.Text = "Settings";
        }

        private void SetSizeToForm(Form frm)
        {
            frm.Width = this.pnlFormLoader.Width;
            frm.Height = this.pnlFormLoader.Height;
        }

        private void BtnFullScreen_Click(object sender, EventArgs e)
        {
            var childForm = (Form)this.pnlFormLoader.Controls[0];
            if (this.WindowState == FormWindowState.Minimized || this.WindowState == FormWindowState.Normal)
            {
                childForm.WindowState = this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                childForm.WindowState = this.WindowState = FormWindowState.Normal;
            }
        }

        private void BtnMaxOrRestore_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized || this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.BtnMaxOrRestore.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.BtnMaxOrRestore.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            VisibleControlSearchDb(true);

            pnlNav.Height = BtnSearch.Height;
            pnlNav.Top = BtnSearch.Top;
            ActiveButton(BtnSearch, true);

            this.pnlFormLoader.Controls.Clear();
            frmSearch frmSearch_vrb = new frmSearch() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmSearch_vrb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            frmSearch_vrb.FormBorderStyle = FormBorderStyle.None;
            SetSizeToForm(frmSearch_vrb);

            this.pnlFormLoader.Controls.Add(frmSearch_vrb);
            frmSearch_vrb.Show();
            lbltitle.Text = "Search";
        }

        private void BtnModifyCustomsDeclare_Click(object sender, EventArgs e)
        {
            VisibleControlSearchDb(false);
            pnlNav.Height = BtnModifyCustomsDeclare.Height;
            pnlNav.Top = BtnModifyCustomsDeclare.Top;
            ActiveButton(BtnModifyCustomsDeclare, true);

            this.pnlFormLoader.Controls.Clear();
            frmModifyCustomsDeclare frmModifyCustomsDeclare_vrb = new frmModifyCustomsDeclare() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmModifyCustomsDeclare_vrb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            frmModifyCustomsDeclare_vrb.FormBorderStyle = FormBorderStyle.None;
            SetSizeToForm(frmModifyCustomsDeclare_vrb);

            this.pnlFormLoader.Controls.Add(frmModifyCustomsDeclare_vrb);
            frmModifyCustomsDeclare_vrb.Show();
            lbltitle.Text = "Modify data";
        }

        private void SearchInDB()
        {
            var searchText = TxtInputSearchDb.Text.Trim();
            if (pnlFormLoader.Controls.Count == 0)
            {
                return;
            }
            var frm = pnlFormLoader.Controls[0];
            if (frm is frmStatistical frm1)
            {
                frm1.searchText = searchText;
                frm1.ReloadDataToGird();
            }
            else if (frm is frmSearch frm2)
            {
                frm2.searchText = searchText;
                frm2.ReloadDataToGird();
            }
        }

        private void BtnSearchOnDB_Click(object sender, EventArgs e)
        {
            SearchInDB();
        }

        private void TxtInputSearchDb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SearchInDB();
                return;
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                TxtInputSearchDb.Text = "";
            }
        }
    }
}
