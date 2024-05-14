using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("timezone")]
    public string timezone { get; set; }

    [JsonProperty("timezone_offset")]
    public int timezoneoffset { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("time")]
    public string time { get; set; }

    [JsonProperty("time24")]
    public string time24 { get; set; }

    [JsonProperty("time12")]
    public string time12 { get; set; }

    [JsonProperty("day")]
    public string day { get; set; }

    [JsonProperty("month")]
    public string month { get; set; }

    [JsonProperty("year")]
    public string year { get; set; }

    [JsonProperty("unix")]
    public string unix { get; set; }

    [JsonProperty("dst")]
    public bool dst { get; set; }

    [JsonProperty("dst_start")]
    public string dststart { get; set; }

    [JsonProperty("dst_end")]
    public string dstend { get; set; }

    [JsonProperty("dst_name")]
    public string dstname { get; set; }

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
