using System;
using System.Reflection.Metadata;
using System.Text.Json.Serialization;


namespace CricketStats_Frontend.Models
{

    public partial class Country
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("countryCode")]
        public string CountryCode { get; set; }

        [JsonPropertyName("countryDesc")]
        public string CountryDesc { get; set; }

        [JsonPropertyName("lastUpdated")]
        public DateTimeOffset LastUpdated { get; set; }
    }
}
