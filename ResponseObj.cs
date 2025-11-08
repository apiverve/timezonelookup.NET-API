using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("timezone_offset")]
        public int Timezoneoffset { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("time24")]
        public string Time24 { get; set; }

        [JsonProperty("time12")]
        public string Time12 { get; set; }

        [JsonProperty("day")]
        public string Day { get; set; }

        [JsonProperty("month")]
        public string Month { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("unix")]
        public string Unix { get; set; }

        [JsonProperty("dst")]
        public bool Dst { get; set; }

        [JsonProperty("dst_start")]
        public string Dststart { get; set; }

        [JsonProperty("dst_end")]
        public string Dstend { get; set; }

        [JsonProperty("dst_name")]
        public string Dstname { get; set; }

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
