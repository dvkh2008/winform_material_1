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
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void BtnDeleteDatabase_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Anh/Chị chắc chắn muốn xóa Database?", "Confirm", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                using var db = new DbContext();
                db.CleanDatabase();
            }
        }
    }
}
