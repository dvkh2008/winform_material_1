using System.Text.Json.Serialization;

namespace SKCT.Entity
{
    public class MainScreenView
    {
        public int NoDeclare { get; set; }
        public string EnterpriseName { get; set; }
        public string EnterpriseMST { get; set; }


        [JsonPropertyName("hsc")]
        public string HarmonizedSystemCode { get; set; }
    }
}
