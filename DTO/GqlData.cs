using System.Text.Json.Serialization;
using CricketStats_Frontend.Models;

namespace CricketStats_Frontend.DTO {

    public partial class GqlData
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

    public partial class Data
    {
        [JsonPropertyName("country")]
        public Country[] Countries { get; set; }
    }

}