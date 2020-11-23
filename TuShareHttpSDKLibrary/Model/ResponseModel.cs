using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TuShareHttpSDKLibrary.Model
{
    public class ResponseModel
    {
        [JsonProperty(propertyName: "code")]
        public int Code { get; set; }
        [JsonProperty(propertyName: "msg")]
        public string Msg { get; set; }
        [JsonProperty(propertyName: "data")]
        public ResponseDataModel Data { get; set; }
    }
}
