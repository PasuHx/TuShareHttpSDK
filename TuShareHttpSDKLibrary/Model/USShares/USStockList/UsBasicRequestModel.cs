using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;

namespace TuShareHttpSDKLibrary.Model.USStockList
{
    /// <summary>
    /// 接口：us_basic<br/>描述：获取美股列表信息<br/>限量：单次最大6000，可分页提取<br/>积分：120积分可以试用，5000积分有正式权限
    /// </summary>
    [TuShareApi("us_basic")]
    public class UsBasicRequestModel : IApiModel<UsBasicResponseModel>
    {
        /// <summary>
        /// 股票代码: AAPL（苹果）
        /// <summary>
        [TuShareProperty("ts_code")]
        public string TsCode { get; set; }
        /// <summary>
        /// 股票分类: ADR/GDR/EQ
        /// <summary>
        [TuShareProperty("classify")]
        public string Classify { get; set; }
        /// <summary>
        /// 开始行数: 1：第一行
        /// <summary>
        [TuShareProperty("offset")]
        public string Offset { get; set; }
        /// <summary>
        /// 每页最大行数: 500：每页500行
        /// <summary>
        [TuShareProperty("limit")]
        public string Limit { get; set; }
    }
}
