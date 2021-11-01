using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace SKCT.Entity
{
    public class CustomsDeclarationView
    {
        public int Id { get; set; }

        [JsonPropertyName("no_declare")]
        public string NoDeclare { get; set; }
        public string ProductName { get; set; }
        //public string ProductDescription { get; set; }
        public string EnterpriseName { get; set; }
        public string EnterpriseMST { get; set; }
        public int DayRegister { get; set; }
        public int MonthRegister { get; set; }
        public int YearRegister { get; set; }

        [JsonPropertyName("type_lh")]
        public string TypeLH { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }

        [JsonPropertyName("hsc")]
        public string HarmonizedSystemCode { get; set; }

        [NotMapped]
        public string DateRegister => $"{DayRegister}/{MonthRegister}/{YearRegister}";

        [NotMapped]
        public int RowIndex { get; set; }

        public bool HasDate()
        {
            return DayRegister > 0 && MonthRegister > 0 && YearRegister > 0;
        }

        public bool ValidToImport()
        {
            return CheckValidQuantity()
                && CheckValidNoDeclare()
                && HasDate()
                && CheckValidEnterpriseMST()
                && CheckValidEnterpriseName()
                && CheckValidTypeLH()
                && CheckValidHarmonizedSystemCode()
                && CheckValidProductName()
                && CheckValidUnit();
        }

        public string ValidationErrorMessage()
        {
            var errors = new List<string>();

            if (!CheckValidNoDeclare())
            {
                errors.Add("Số tờ khai");
            }
            
            if (!HasDate())
            {
                errors.Add("Ngày đăng ký");
            }

            if (!CheckValidEnterpriseMST())
            {
                errors.Add("MST");
            }

            if (!CheckValidEnterpriseName())
            {
                errors.Add("Tên doanh nghiệp");
            }

            if (!CheckValidTypeLH())
            {
                errors.Add("Mã LH");
            }

            if (!CheckValidHarmonizedSystemCode())
            {
                errors.Add("Mã HS");
            }
            
            if (!CheckValidProductName())
            {
                errors.Add("Mô tả hàng hóa");
            }

            if (!CheckValidQuantity())
            {
                errors.Add("Số lượng");
            }

            if (!CheckValidUnit())
            {
                errors.Add("ĐVT");
            }

            return $"Dòng {RowIndex} - Số tờ khai {NoDeclare} có những cột sai data là: {string.Join("; ", errors)}";
        }

        #region [Validation Data]
        private bool CheckValidQuantity() => Quantity > 0;
        private bool CheckValidNoDeclare() => !string.IsNullOrEmpty(NoDeclare);
        private bool CheckValidEnterpriseMST() => !string.IsNullOrEmpty(EnterpriseMST);
        private bool CheckValidEnterpriseName() => !string.IsNullOrEmpty(EnterpriseName);
        private bool CheckValidTypeLH() => !string.IsNullOrEmpty(TypeLH);
        private bool CheckValidHarmonizedSystemCode() => !string.IsNullOrEmpty(HarmonizedSystemCode);
        private bool CheckValidProductName() => !string.IsNullOrEmpty(ProductName);
        private bool CheckValidUnit() => !string.IsNullOrEmpty(Unit);
        #endregion
    }
}
