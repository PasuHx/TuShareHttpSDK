using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TuShareHttpSDKLibrary.Model
{
    public class RequestModel
    {
        [JsonProperty(propertyName: "api_name")]
        public string ApiName { get; set; }
        [JsonProperty(propertyName: "token")]
        public string Token { get; set; }
        [JsonProperty(propertyName: "params")]
        public Dictionary<string,string> Params { get; set; }
        [JsonProperty(propertyName: "fields")]
        public string Fields { get; set; }
    }
}
