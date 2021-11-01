using SKCT.Dto;
using SKCT.Entity;
using SKCT.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKCT
{
    public partial class frmModifyCustomsDeclare : Form
    {
        public frmModifyCustomsDeclare()
        {
            InitializeComponent();
        }

        private List<Product> _products;
        private List<EnterpriseDto> _enterprise;

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            using var frmCreateProduct_vb = new frmCreateProduct();

            if (CboxProduct.SelectedIndex < 0)
            {
                frmCreateProduct_vb.ProductNameInit = CboxProduct.Text;
            }
            var result = frmCreateProduct_vb.ShowDialog();
            if (result == DialogResult.OK)
            {
                _products.Add(frmCreateProduct_vb.NewProduct);
                RefreshCboxProduct();

                CboxProduct.SelectedIndex = CboxProduct.FindStringExact(frmCreateProduct_vb.NewProduct.Name);
            }
        }

        private void frmModifyCustomsDeclare_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using var db = new DbContext();
            _products = db.Products.Get().ToList();

            _enterprise = db.Enterprises.Get().Select(e => new EnterpriseDto(e)).ToList();

            var hsCode = db.CustomsDeclarations.Get(r => new { r.HarmonizedSystemCode }).Select(x => x.HarmonizedSystemCode).ToList();
            RefreshCboxHSCode(hsCode);

            var typeLH = db.CustomsDeclarations.Get(r => new { r.TypeLH }).Select(x => x.TypeLH).ToList();
            RefreshCboxTypeLH(typeLH);

            var loadUnit = db.CustomsDeclarations.Get(r => new { r.Unit }).Select(x => x.Unit).ToList();
            RefreshCboxUnit(loadUnit);

            RefreshCboxEnterprise();

            RefreshCboxProduct();
        }

        private void RefreshCboxProduct()
        {
            CboxProduct.DataSource = null;
            CboxProduct.DataSource = _products;
            CboxProduct.DisplayMember = "Name";
            CboxProduct.ValueMember = "Id";

            CboxProduct.AutoCompleteMode = AutoCompleteMode.Suggest;
            CboxProduct.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void RefreshCboxEnterprise()
        {
            CboxEnterprise.DataSource = null;
            CboxEnterprise.DataSource = _enterprise;
            CboxEnterprise.DisplayMember = "FullName";
            CboxEnterprise.ValueMember = "Id";

            CboxEnterprise.AutoCompleteMode = AutoCompleteMode.Suggest;
            CboxEnterprise.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void RefreshCboxHSCode(IEnumerable<string> data)
        {
            CboxHSCode.DataSource = null;
            CboxHSCode.DataSource = data;

            CboxHSCode.AutoCompleteMode = AutoCompleteMode.Suggest;
            CboxHSCode.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void RefreshCboxTypeLH(IEnumerable<string> data)
        {
            CboxTypeLH.DataSource = null;
            CboxTypeLH.DataSource = data;

            CboxTypeLH.AutoCompleteMode = AutoCompleteMode.Suggest;
            CboxTypeLH.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void RefreshCboxUnit(IEnumerable<string> data)
        {
            CboxUnit.DataSource = null;
            CboxUnit.DataSource = data;

            CboxUnit.AutoCompleteMode = AutoCompleteMode.Suggest;
            CboxUnit.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void BtnAddEnterprise_Click(object sender, EventArgs e)
        {
            using var frmCreateEnterprise_vb = new frmCreateEnterprise();

            if (CboxEnterprise.SelectedIndex < 0)
            {
                frmCreateEnterprise_vb.NameInit = CboxEnterprise.Text;
            }
            var result = frmCreateEnterprise_vb.ShowDialog();
            if (result == DialogResult.OK)
            {
                var newEnterpriseDto = new EnterpriseDto(frmCreateEnterprise_vb.NewEnterprise);
                _enterprise.Add(newEnterpriseDto);
                RefreshCboxEnterprise();

                CboxEnterprise.SelectedIndex = CboxEnterprise.FindStringExact(newEnterpriseDto.FullName);
            }
        }

        private bool CheckInvalid()
        {
            if (string.IsNullOrWhiteSpace(TboxNoDeclare.Text))
            {
                MessageBox.Show("Vui lòng nhập số tờ khai.");
                return true;
            }
            if (string.IsNullOrWhiteSpace(DatePickerDateRegister.Text))
            {
                MessageBox.Show("Vui lòng nhập ngày đăng ký.");
                return true;
            }
            if (string.IsNullOrWhiteSpace(TboxQuantity.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng.");
                return true;
            }
            if (string.IsNullOrWhiteSpace(CboxEnterprise.SelectedValue?.ToString()))
            {
                MessageBox.Show("Vui lòng nhập doanh nghiệp.");
                return true;
            }
            if (string.IsNullOrWhiteSpace(CboxProduct.SelectedValue?.ToString()))
            {
                MessageBox.Show("Vui lòng nhập hàng hóa.");
                return true;
            }

            if (string.IsNullOrWhiteSpace(CboxTypeLH.Text))
            {
                MessageBox.Show("Vui lòng nhập mã LH.");
                return true;
            }
            if (string.IsNullOrWhiteSpace(CboxHSCode.Text))
            {
                MessageBox.Show("Vui lòng nhập mã HS.");
                return true;
            }

            if (string.IsNullOrWhiteSpace(CboxUnit.Text))
            {
                MessageBox.Show("Vui lòng nhập mã HS.");
                return true;
            }
            return false;
        }

        private void CleanControl()
        {
            TboxNoDeclare.Text = "";
            DatePickerDateRegister.Text = "";
            TboxQuantity.Text = "";
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                BtnOk.Enabled = false;
                if (CheckInvalid())
                {
                    return;
                }
                if (!int.TryParse(CboxEnterprise.SelectedValue?.ToString(), out int enterpriseId))
                {
                    MessageBox.Show("Vui lòng nhập doanh nghiệp.");
                    return;
                }
                if (!int.TryParse(CboxProduct.SelectedValue?.ToString(), out int productId))
                {
                    MessageBox.Show("Vui lòng nhập hàng hóa.");
                    return;
                }
                if (!float.TryParse(TboxQuantity.Text, out float quantity))
                {
                    MessageBox.Show("Vui lòng nhập số lượng.");
                    return;
                }

                var (day, month, year) = DateHelper.CookDate(DatePickerDateRegister.Text);
                if (day == 0 || month == 0 || year == 0)
                {
                    MessageBox.Show("Vui lòng nhập ngày đăng ký đúng định dạng 25/10/2021 hoặc 25-10-2021.");
                    return;
                }

                var entity = new CustomsDeclaration
                {
                    NoDeclare = TboxNoDeclare.Text.Trim(),
                    DayRegister = day,
                    MonthRegister = month,
                    YearRegister = year,
                    ProductId = productId,
                    EnterpriseId = enterpriseId,
                    TypeLH = CboxTypeLH.Text,
                    Quantity = quantity,
                    Unit = CboxUnit.Text,
                    HarmonizedSystemCode = CboxHSCode.Text,
                };

                using var db = new DbContext();
                db.CustomsDeclarations.Add(entity, false);
                db.SaveChange();
                CleanControl();
            }
            catch 
            {
                MessageBox.Show("Thêm tờ khai lỗi. Vui lòng liên hệ lập trình viên.");
            }
            finally
            {
                BtnOk.Enabled = true;
            }
        }

        private void PnelWrapper_Paint(object sender, PaintEventArgs e)
        {
            var color = Color.FromArgb(31, 45, 72);
            //ControlPaint.DrawBorder(e.Graphics, PnelWrapper.ClientRectangle,
            //color, 1, ButtonBorderStyle.Dotted, // left
            //color, 1, ButtonBorderStyle.Dotted, // top
            //color, 1, ButtonBorderStyle.Dotted, // right
            //color, 1, ButtonBorderStyle.Dotted);// bottom


            Panel panel = (Panel)sender;
            float width = (float)4.0;
            Pen pen = new Pen(color, width);
            pen.DashStyle = DashStyle.Dot;
            e.Graphics.DrawLine(pen, 0, 0, 0, panel.Height - 0);
            e.Graphics.DrawLine(pen, 0, 0, panel.Width - 0, 0);
            e.Graphics.DrawLine(pen, panel.Width - 1, panel.Height - 1, 0, panel.Height - 1);
            e.Graphics.DrawLine(pen, panel.Width - 1, panel.Height - 1, panel.Width - 1, 0);
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            using var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    MessageBox.Show("Vui lòng chọn Folder để save file!");
                    return;
                }

                using var db = new DbContext();
                var entities = db.CustomsDeclarationViews.Get();

                (string message, bool hasError) = entities.ExportToExcel(fbd.SelectedPath);

                if (hasError)
                {
                    MessageBox.Show(message);
                    return;
                }
                else
                {
                    MessageBox.Show($"Export file :{message} xong!");
                    return;
                }
            }
        }

        private void BtnImportFromExcel_Click(object sender, EventArgs e)
        {
            using var fbd = new OpenFileDialog();
            fbd.DefaultExt = "xlsx";
            fbd.Filter = "excel files (*.xlsx)|*.xlsx";
            fbd.CheckFileExists = true;
            fbd.CheckPathExists = true;

            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (string.IsNullOrWhiteSpace(fbd.FileName))
                {
                    MessageBox.Show("Vui lòng chọn Folder để save file!");
                    return;
                }
                (string message, bool hasError, var entities) = ExcelHelper.GetDataFromExcel(fbd.FileName);

                if (hasError)
                {
                    MessageBox.Show(message);
                    return;
                }

                if (!entities.Any())
                {
                    MessageBox.Show("File excel rỗng. Hoặc liên hệ lập trình viên!");
                    return;
                }


                #region [Validation Data]
                var hasInvalidData = entities.Any(e => !e.ValidToImport());
                if (hasInvalidData)
                {
                    var errors = entities.Where(e => !e.ValidToImport()).Select(e => e.ValidationErrorMessage()).ToArray();
                    if (errors.Any())
                    {
                        using var frmValidation = new frmDialog();

                        frmValidation.Title = "Thông Báo! chọn OK sẽ tiếp tục import và bỏ ra những dòng lỗi sau:";
                        frmValidation.Message = string.Join(Environment.NewLine, errors);

                        var frmValidationResult = frmValidation.ShowDialog();
                        if (frmValidationResult == DialogResult.No)
                        {
                            return;
                        }

                        entities = entities.Where(e => e.ValidToImport()).ToArray();
                    }
                }
                
                #endregion


                try
                {
                    using var db = new DbContext();
                    var products = db.Products.Get().GroupBy(x => x.Name.ToUpper()).Select(g => g.First()).ToDictionary(x => x.Name.ToUpper(), x => x.Id);
                    var enterprises = db.Enterprises.Get().GroupBy(x => x.MST.ToUpper()).Select(g => g.First()).ToDictionary(x => x.MST.ToUpper(), x => x.Id);

                    var newCustomsDeclares = new List<CustomsDeclaration>();
                    var newProducts = new List<Product>();
                    var newEnterprises = new List<Enterprise>();

                    foreach (var item in entities)
                    {
                        item.ProductName = item.ProductName.ToUpper();
                        item.EnterpriseMST = item.EnterpriseMST.ToUpper();
                        if (!products.ContainsKey(item.ProductName))
                        {
                            newProducts.Add(new Product
                            {
                                Name = item.ProductName,
                                //Description = item.ProductDescription
                            });
                        }

                        if (!enterprises.ContainsKey(item.EnterpriseMST))
                        {
                            newEnterprises.Add(new Enterprise
                            {
                                Name = item.EnterpriseName,
                                MST = item.EnterpriseMST
                            });
                        }
                    }

                    if (newProducts.Any())
                    {
                        db.Products.AddRange(newProducts);
                        db.SaveChange();

                        products = db.Products.Get().GroupBy(x => x.Name.ToUpper()).Select(g => g.First()).ToDictionary(x => x.Name.ToUpper(), x => x.Id);
                    }

                    if (newEnterprises.Any())
                    {
                        db.Enterprises.AddRange(newEnterprises);
                        db.SaveChange();

                        enterprises = db.Enterprises.Get().GroupBy(x => x.MST.ToUpper()).Select(g => g.First()).ToDictionary(x => x.MST.ToUpper(), x => x.Id);
                    }

                    var declarInDb = db.CustomsDeclarations.Get(d =>new { d.Id, d.NoDeclare })
                        .Select(x => { x.NoDeclare = x.NoDeclare.ToUpper(); return x; })
                        .GroupBy(x => x.NoDeclare)
                        .Select(g => g.First())
                        .ToDictionary(x => x.NoDeclare, x => x.Id);

                    foreach (var item in entities)
                    {
                        var noDeclare = item.NoDeclare.ToUpper();
                        var id = declarInDb.ContainsKey(noDeclare) ? declarInDb[noDeclare] : 0;
                        newCustomsDeclares.Add(new CustomsDeclaration
                        {
                            Id = id,
                            NoDeclare = item.NoDeclare,
                            DayRegister = item.DayRegister,
                            MonthRegister = item.MonthRegister,
                            YearRegister = item.YearRegister,
                            EnterpriseId = enterprises[item.EnterpriseMST],
                            TypeLH = item.TypeLH,
                            HarmonizedSystemCode = item.HarmonizedSystemCode,
                            ProductId = products[item.ProductName],
                            Quantity = item.Quantity,
                            Unit = item.Unit,
                        });
                    }

                    var importPaging = 50;


                    var updatedCustomsDeclares = newCustomsDeclares.Where(x => x.Id > 0).ToList();
                    while (updatedCustomsDeclares.Any())
                    {
                        var updatedCustomsDeclaresDoing = updatedCustomsDeclares.Splice(0, importPaging);

                        db.CustomsDeclarations.UpdateRange(updatedCustomsDeclaresDoing);
                        db.SaveChange();
                    }

                    newCustomsDeclares = newCustomsDeclares.Where(x => x.Id <= 0).ToList();
                    while (newCustomsDeclares.Any())
                    {
                        var newCustomsDeclaresAdding = newCustomsDeclares.Splice(0, importPaging);

                        db.CustomsDeclarations.AddRange(newCustomsDeclaresAdding);
                        db.SaveChange();
                    }


                }
                catch //(Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra, vui lòng liên hệ lập trình viên!");
                    return;
                }


                
                    MessageBox.Show($"Imports file :{message} xong!");
                    return;
            }
        }
    }
}
