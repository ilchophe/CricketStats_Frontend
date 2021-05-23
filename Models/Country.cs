using System;
using System.Reflection.Metadata;
using System.Text.Json.Serialization;


namespace CricketStats_Frontend.Models
{

    public partial class Country
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("countrycode")]
        public string CountryCode { get; set; }

        [JsonPropertyName("countrydesc")]
        public string CountryDesc { get; set; }

        [JsonPropertyName("lastupdated")]
        public DateTimeOffset LastUpdated { get; set; }
    }
}
