using ClosedXML.Excel;
using SKCT.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace SKCT.Helper
{
    public static class ExcelHelper
    {
        public static DataTable loadFileToDatatable(string excelFilePath, string fromCellToCell)
        {
            using (var oConn = new OdbcConnection())
            {
                oConn.ConnectionString = $"Driver={{Microsoft Excel Driver (*.xls)}};DBQ={excelFilePath}";
                using (var oComm = new OdbcCommand())
                {
                    oComm.Connection = oConn;
                    oComm.CommandText = $"Select * From [{fromCellToCell}]";

                    var dt = new DataTable();
                    OdbcDataAdapter oAdapter = new OdbcDataAdapter(oComm);
                    oConn.Open();
                    oAdapter.Fill(dt);
                    return dt;
                }
            }
        }

        public static (string message, bool hasError, IEnumerable<CustomsDeclarationView> entities) GetDataFromExcel(string fileName)
        {
            string newFileName = "";
            try
            {
                newFileName = Path.Combine(Path.GetDirectoryName(fileName), Guid.NewGuid() + Path.GetExtension(fileName));
                File.Copy(fileName, newFileName);

                using var workbook = new XLWorkbook(newFileName);

                var workSheet = workbook.Worksheet(1);
                workSheet.Column("A").Unhide();


                var rows = workSheet.RowsUsed((r) => r.RowNumber() != 1);

                var result = new List<CustomsDeclarationView>();

                foreach (var item in rows)
                {
                    float.TryParse(item.Cell(8).Value.ToString(), out float quantity);

                    var (day, month, year) = DateHelper.CookDate(item.Cell(2).Value.ToString());

                    result.Add(new CustomsDeclarationView
                    {
                        NoDeclare = item.Cell(1).Value.ToString(),
                        DayRegister = day,
                        MonthRegister = month,
                        YearRegister = year,
                        EnterpriseMST = item.Cell(3).Value.ToString(),
                        EnterpriseName = item.Cell(4).Value.ToString(),
                        TypeLH = item.Cell(5).Value.ToString(),
                        HarmonizedSystemCode = item.Cell(6).Value.ToString(),
                        ProductName = item.Cell(7).Value.ToString(),
                        //ProductDescription = item.Cell(9).Value.ToString(),
                        Quantity = quantity,
                        Unit = item.Cell(9).Value.ToString(),
                        RowIndex = item.RowNumber()
                    });
                }

                //result = result.Where(r => r.Quantity > 0 && !string.IsNullOrEmpty(r.NoDeclare) && r.HasDate()
                //&& !string.IsNullOrWhiteSpace(r.EnterpriseMST) && !string.IsNullOrWhiteSpace(r.EnterpriseName) && !string.IsNullOrWhiteSpace(r.TypeLH) && !string.IsNullOrWhiteSpace(r.HarmonizedSystemCode) && !string.IsNullOrWhiteSpace(r.ProductDescription) && !string.IsNullOrWhiteSpace(r.Unit)).ToList();

                return ("", false, result);
            }
            catch// (Exception ex)
            {
                return ("Có lỗi xảy ra, vui lòng liên hệ lập trình viên!", true, null);
            }
            finally
            {
                if (File.Exists(newFileName))
                {
                    File.Delete(newFileName);
                }
            }
        }

        public static (string message, bool hasError) ExportToExcel(this IEnumerable<CustomsDeclarationView> entities, string saveToFolder)
        {

            try
            {
                int rowcount = 1;
                var cellIndex = 1;
                using var workbook = new XLWorkbook();

                IXLWorksheet worksheet = workbook.Worksheets.Add("SKCT");

                #region [render Header]
                //worksheet.Cell(rowcount, cellIndex++).Value = "Id";
                worksheet.Cell(rowcount, cellIndex++).Value = "Số tờ khai";
                worksheet.Cell(rowcount, cellIndex++).Value = "Ngày đăng ký";
                worksheet.Cell(rowcount, cellIndex++).Value = "MST";
                worksheet.Cell(rowcount, cellIndex++).Value = "Tên doanh nghiệp";
                worksheet.Cell(rowcount, cellIndex++).Value = "Mã LH";
                worksheet.Cell(rowcount, cellIndex++).Value = "Mã HS";
                //worksheet.Cell(rowcount, cellIndex++).Value = "Hàng hóa";
                worksheet.Cell(rowcount, cellIndex++).Value = "Mô tả hàng hóa";
                worksheet.Cell(rowcount, cellIndex++).Value = "Số lượng";
                worksheet.Cell(rowcount, cellIndex++).Value = "ĐVT";

                worksheet.Range(rowcount, 1, rowcount, cellIndex - 1).Style.Font.FontColor = XLColor.Blue;
                #endregion

                foreach (var item in entities)
                {
                    rowcount += 1;
                    cellIndex = 1;

                    #region [render Header]
                    //worksheet.Cell(rowcount, cellIndex++).Value = item.Id;
                    worksheet.Cell(rowcount, cellIndex++).Value = item.NoDeclare;
                    worksheet.Cell(rowcount, cellIndex++).Value = item.DateRegister;
                    worksheet.Cell(rowcount, cellIndex++).Value = item.EnterpriseMST;
                    worksheet.Cell(rowcount, cellIndex++).Value = item.EnterpriseName;
                    worksheet.Cell(rowcount, cellIndex++).Value = item.TypeLH;
                    worksheet.Cell(rowcount, cellIndex++).Value = item.HarmonizedSystemCode;
                    worksheet.Cell(rowcount, cellIndex++).Value = item.ProductName;
                    //worksheet.Cell(rowcount, cellIndex++).Value = item.ProductDescription;
                    worksheet.Cell(rowcount, cellIndex++).Value = item.Quantity;
                    worksheet.Cell(rowcount, cellIndex++).Value = item.Unit;

                    worksheet.Range(rowcount, 1, rowcount, cellIndex - 1).Style.Font.FontColor = XLColor.Black;
                    #endregion
                }

                //worksheet.Column(1).Hide();

                #region [Set Column Type]
                worksheet.Columns("A", "K").Style.NumberFormat.Format = "@";
                #endregion

                worksheet.Columns("A", "K").AdjustToContents();

                string fileName = $"skct_export_on_{DateTime.Now:yyyyMMddHHmmss}.xlsx";

                var fullFileName = Path.Combine(saveToFolder, fileName);
                workbook.SaveAs(fullFileName);

                Process.Start("explorer.exe", saveToFolder);

                return (fileName, false);
            }
            catch //(Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return ("Có lỗi xảy ra, vui lòng liên hệ lập trình viên!", true);
            }
        }

    }
}
