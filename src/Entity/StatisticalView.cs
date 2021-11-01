using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SKCT.Entity
{
    public class StatisticalView
    {
        public int NoDeclare { get; set; }

        [JsonPropertyName("hsc")]
        public string HarmonizedSystemCode { get; set; }
        public int MonthRegister { get; set; }
        public int YearRegister { get; set; }

        [NotMapped]
        public string DateRegister => $"Tháng {MonthRegister}/{YearRegister}";

        [NotMapped]
        public string NoDeclearUI => $"{NoDeclare} tờ khai nhập khẩu";

        public bool HasDate()
        {
            return MonthRegister > 0 && YearRegister > 0;
        }
    }
}
