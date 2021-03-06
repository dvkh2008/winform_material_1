using SKCT.Entity;
using SKCT.Helper;
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
    public partial class frmSearch : Form
    {
        public string searchText { get; set; }
        private bool _frmLoadDone { get; set; }
        private List<int> _pageNos { get; set; }
        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            SytleDGridView();
            LoadData();
            _frmLoadDone = true;
            LoadDataToGird();
        }

        public void SytleDGridView()
        {
            DGridView.Columns[0].Width = 150;
            DGridView.Columns[1].Width = 120;
            DGridView.Columns[2].Width = 150;
            DGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGridView.Columns[4].Width = 50;
            DGridView.Columns[5].Width = 120;
            DGridView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGridView.Columns[7].Width = 60;
            DGridView.Columns[8].Width = 70;
            foreach (DataGridViewColumn col in DGridView.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                col.HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
            }
            DGridView.AutoGenerateColumns = false;
        }

        #region [Code for Paging]
        private void LoadData()
        {
            var pageSize = new List<int> { 10, 20, 50, 100, 200, 500, 1000 };
            CboxPageSize.DataSource = pageSize;
            CboxPageSize.SelectedIndex = 2;

            RefreshPaging();
        }

        private void RefreshPaging()
        {
            var pageSize = (int)CboxPageSize.SelectedValue;
            using var db = new DbContext();

            var total = db.TotalOfCustomsDeclarationView(searchText);
            LblInfo.Text = $"{total} records";
            _pageNos = ArrayHelper.GetPageSize(total, pageSize);

            CboxPageNo.DataSource = null;
            CboxPageNo.DataSource = _pageNos;
            if (_pageNos.Any())
            {
                CboxPageNo.SelectedIndex = 0;
            }
        }

        private void LoadDataToGird()
        {
            if (!_frmLoadDone)
            {
                return;
            }
            var pageSize = (int)CboxPageSize.SelectedValue;
            var pageNo = (int)(CboxPageNo.SelectedValue ?? 0);

            using var db = new DbContext();
            var data = string.IsNullOrEmpty(searchText) ? db.CustomsDeclarationViews.Get(pageSize, pageNo - 1) : db.CustomsDeclarationViews.SearchWithEnterprise(searchText, false, pageSize, pageNo - 1);

            DGridView.DataSource = data;

            ManageControl();
        }

        private int OffsetPaging()
        {
            var pageSize = (int)CboxPageSize.SelectedValue;
            var pageNo = (int)CboxPageNo.SelectedValue;

            return pageSize * (pageNo - 1);
        }

        private void ManageControl()
        {
            if (DGridView.Rows.Count == 0)
            {
                BtnTrangDau.Enabled = false;
                BtnLui1Trang.Enabled = false;
                BtnToi1Trang.Enabled = false;
                BtnTrangCuoi.Enabled = false;
                CboxPageNo.Enabled = false;
                CboxPageSize.Enabled = false;
                return;
            }

            if (_pageNos.Count == 1)
            {
                BtnTrangDau.Enabled = false;
                BtnLui1Trang.Enabled = false;
                BtnToi1Trang.Enabled = false;
                BtnTrangCuoi.Enabled = false;
                CboxPageNo.Enabled = true;
                CboxPageSize.Enabled = true;
                return;
            }

            var currentPaginIndex = CboxPageNo.SelectedIndex;
            if (currentPaginIndex == 0)
            {
                BtnTrangDau.Enabled = false;
                BtnLui1Trang.Enabled = false;
                BtnToi1Trang.Enabled = true;
                BtnTrangCuoi.Enabled = true;
            }
            else if (currentPaginIndex == _pageNos.Count - 1)
            {
                BtnTrangDau.Enabled = true;
                BtnLui1Trang.Enabled = true;
                BtnToi1Trang.Enabled = false;
                BtnTrangCuoi.Enabled = false;
            }
            else
            {
                BtnTrangDau.Enabled = true;
                BtnLui1Trang.Enabled = true;
                BtnToi1Trang.Enabled = true;
                BtnTrangCuoi.Enabled = true;
            }
        }

        public void ReloadDataToGird()
        {
            if (_frmLoadDone)
            {
                _frmLoadDone = false;
                RefreshPaging();
                _frmLoadDone = true;
            }
            LoadDataToGird();
        }
        #endregion

        private void DGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using SolidBrush b = new SolidBrush(DGridView.RowHeadersDefaultCellStyle.ForeColor);
            var serialNumber = OffsetPaging() + e.RowIndex + 1;
            e.Graphics.DrawString((serialNumber).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
        }

        private void CboxPageNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataToGird();
        }

        private void CboxPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadDataToGird();
        }

        private void BtnToi1Trang_Click(object sender, EventArgs e)
        {
            CboxPageNo.SelectedIndex += 1;
        }

        private void BtnTrangCuoi_Click(object sender, EventArgs e)
        {
            CboxPageNo.SelectedIndex = _pageNos.Count - 1;
        }

        private void BtnLui1Trang_Click(object sender, EventArgs e)
        {
            CboxPageNo.SelectedIndex -= 1;
        }

        private void BtnTrangDau_Click(object sender, EventArgs e)
        {
            CboxPageNo.SelectedIndex = 0;
        }
    }
}
