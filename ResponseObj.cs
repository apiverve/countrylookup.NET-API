using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class eng
{
    [JsonProperty("official")]
    public string official { get; set; }

    [JsonProperty("common")]
    public string common { get; set; }

}

public class native
{
    [JsonProperty("eng")]
    public eng eng { get; set; }

}

public class name
{
    [JsonProperty("common")]
    public string common { get; set; }

    [JsonProperty("official")]
    public string official { get; set; }

    [JsonProperty("native")]
    public native native { get; set; }

}

public class uSD
{
    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("symbol")]
    public string symbol { get; set; }

}

public class currencies
{
    [JsonProperty("USD")]
    public uSD uSD { get; set; }

}

public class languages
{
    [JsonProperty("eng")]
    public string eng { get; set; }

}

public class countries
{
    [JsonProperty("name")]
    public name name { get; set; }

    [JsonProperty("tld")]
    public string[] tld { get; set; }

    [JsonProperty("cca2")]
    public string cca2 { get; set; }

    [JsonProperty("ccn3")]
    public string ccn3 { get; set; }

    [JsonProperty("cca3")]
    public string cca3 { get; set; }

    [JsonProperty("cioc")]
    public string cioc { get; set; }

    [JsonProperty("independent")]
    public bool independent { get; set; }

    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("currencies")]
    public currencies currencies { get; set; }

    [JsonProperty("capital")]
    public string[] capital { get; set; }

    [JsonProperty("altSpellings")]
    public string[] altSpellings { get; set; }

    [JsonProperty("region")]
    public string region { get; set; }

    [JsonProperty("subregion")]
    public string subregion { get; set; }

    [JsonProperty("languages")]
    public languages languages { get; set; }

    [JsonProperty("latlng")]
    public int[] latlng { get; set; }

    [JsonProperty("landlocked")]
    public bool landlocked { get; set; }

    [JsonProperty("borders")]
    public string[] borders { get; set; }

    [JsonProperty("area")]
    public int area { get; set; }

    [JsonProperty("flag")]
    public string flag { get; set; }

    [JsonProperty("majorCities")]
    public string[] majorCities { get; set; }

}

public class data
{
    [JsonProperty("search")]
    public string search { get; set; }

    [JsonProperty("countries")]
    public countries[] countries { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
