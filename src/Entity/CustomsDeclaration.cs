using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace SKCT.Entity
{
    public class CustomsDeclaration
    {
        public int Id { get; set; }

        [JsonPropertyName("no_declare")]
        public string NoDeclare { get; set; }
        public int ProductId { get; set; }
        public int EnterpriseId { get; set; }

        public string DateRegister()
        {
            return $"{DayRegister}/{MonthRegister}/{YearRegister}";
        }

        public int DayRegister { get; set; }
        public int MonthRegister { get; set; }
        public int YearRegister { get; set; }

        [JsonPropertyName("type_lh")]
        public string TypeLH { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }

        [JsonPropertyName("hsc")]
        public string HarmonizedSystemCode { get; set; }
    }
}
