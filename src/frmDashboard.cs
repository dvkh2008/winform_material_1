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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            using var db = new DbContext();

            LblCorporation.Text = $"{db.TotalOfEnterprise()}";
            LblDeclare.Text = $"{db.TotalOfCustomsDeclarationView("")}";

            var versionString = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            LblToday.Text = $"Today: {DateTime.Now.ToString("dd/MM/yyyy")}. The system is running on version {versionString}";
        }
    }
}
