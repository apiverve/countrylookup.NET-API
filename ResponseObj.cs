using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Eng data
    /// </summary>
    public class Eng
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }

    }
    /// <summary>
    /// Native data
    /// </summary>
    public class Native
    {
        [JsonProperty("eng")]
        public Eng Eng { get; set; }

    }
    /// <summary>
    /// Name data
    /// </summary>
    public class Name
    {
        [JsonProperty("common")]
        public string Common { get; set; }

        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("native")]
        public Native Native { get; set; }

    }
    /// <summary>
    /// USD data
    /// </summary>
    public class USD
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

    }
    /// <summary>
    /// Currencies data
    /// </summary>
    public class Currencies
    {
        [JsonProperty("USD")]
        public USD USD { get; set; }

    }
    /// <summary>
    /// Languages data
    /// </summary>
    public class Languages
    {
        [JsonProperty("eng")]
        public string Eng { get; set; }

    }
    /// <summary>
    /// Countries data
    /// </summary>
    public class Countries
    {
        [JsonProperty("name")]
        public Name Name { get; set; }

        [JsonProperty("tld")]
        public string[] Tld { get; set; }

        [JsonProperty("cca2")]
        public string Cca2 { get; set; }

        [JsonProperty("ccn3")]
        public string Ccn3 { get; set; }

        [JsonProperty("cca3")]
        public string Cca3 { get; set; }

        [JsonProperty("cioc")]
        public string Cioc { get; set; }

        [JsonProperty("independent")]
        public bool Independent { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("currencies")]
        public Currencies Currencies { get; set; }

        [JsonProperty("capital")]
        public string[] Capital { get; set; }

        [JsonProperty("altSpellings")]
        public string[] AltSpellings { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("subregion")]
        public string Subregion { get; set; }

        [JsonProperty("languages")]
        public Languages Languages { get; set; }

        [JsonProperty("latlng")]
        public int[] Latlng { get; set; }

        [JsonProperty("landlocked")]
        public bool Landlocked { get; set; }

        [JsonProperty("borders")]
        public string[] Borders { get; set; }

        [JsonProperty("area")]
        public int Area { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }

        [JsonProperty("majorCities")]
        public string[] MajorCities { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("search")]
        public string Search { get; set; }

        [JsonProperty("countries")]
        public Countries[] Countries { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
