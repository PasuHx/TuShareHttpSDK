using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;

namespace TuShareHttpSDKLibrary.Model.Base
{
    /// <summary>
    /// 说明：旧版上的PE/PB/股本等字段，请在行情接口“每日指标”中获取。
    /// </summary>
    public class StoreBasicResponseModel
    {
        [TuShareProperty("ts_code")]
        public string TsCode { get; set; }

        [TuShareProperty("symbol")]
        public string Symbol { get; set; }

        [TuShareProperty("name")]
        public string Name { get; set; }

        [TuShareProperty("area")]
        public string Area { get; set; }

        [TuShareProperty("industry")]
        public string Industry { get; set; }

        [TuShareProperty("fullname")]
        public string FullName { get; set; }

        [TuShareProperty("enname")]
        public string EnName { get; set; }

        [TuShareProperty("market")]
        public string Market { get; set; }

        [TuShareProperty("exchange")]
        public string Exchange { get; set; }

        [TuShareProperty("curr_type")]
        public string CurrType { get; set; }

        [TuShareProperty("list_status")]
        public string ListStatus { get; set; }

        [TuShareProperty("list_date")]
        public string ListDate { get; set; }

        [TuShareProperty("delist_date")]
        public string DelistDate { get; set; }

        [TuShareProperty("is_hs")]
        public string IsHS { get; set; }
    }
}
