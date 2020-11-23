using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;

namespace TuShareHttpSDKLibrary.Model.MarketDailyTransactionStatistics
{
    /// <summary>
    /// 接口：daily_info<br/>描述：获取交易所股票交易统计，包括各板块明细<br/>限量：单次最大4000，可循环获取，总量不限制<br/>权限：用户积600积分可调取， 频次有限制，积分越高每分钟调取频次越高，5000积分以上正常调取无限制，积分获取方法请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
    /// </summary>
    public class DailyInfoResponseModel
    {
        /// <summary>
        /// 交易日期
        /// <summary>
        [TuShareProperty("trade_date")]
        public string TradeDate { get; set; }
        /// <summary>
        /// 市场代码
        /// <summary>
        [TuShareProperty("ts_code")]
        public string TsCode { get; set; }
        /// <summary>
        /// 市场名称
        /// <summary>
        [TuShareProperty("ts_name")]
        public string TsName { get; set; }
        /// <summary>
        /// 挂牌数
        /// <summary>
        [TuShareProperty("com_count")]
        public string ComCount { get; set; }
        /// <summary>
        /// 总股本（亿股）
        /// <summary>
        [TuShareProperty("total_share")]
        public string TotalShare { get; set; }
        /// <summary>
        /// 流通股本（亿股）
        /// <summary>
        [TuShareProperty("float_share")]
        public string FloatShare { get; set; }
        /// <summary>
        /// 总市值（亿元）
        /// <summary>
        [TuShareProperty("total_mv")]
        public string TotalMv { get; set; }
        /// <summary>
        /// 流通市值（亿元）
        /// <summary>
        [TuShareProperty("float_mv")]
        public string FloatMv { get; set; }
        /// <summary>
        /// 交易金额（亿元）
        /// <summary>
        [TuShareProperty("amount")]
        public string Amount { get; set; }
        /// <summary>
        /// 成交量（亿股）
        /// <summary>
        [TuShareProperty("vol")]
        public string Vol { get; set; }
        /// <summary>
        /// 成交笔数（万笔）
        /// <summary>
        [TuShareProperty("trans_count")]
        public string TransCount { get; set; }
        /// <summary>
        /// 平均市盈率
        /// <summary>
        [TuShareProperty("pe")]
        public string Pe { get; set; }
        /// <summary>
        /// 换手率（％），注：深交所暂无此列
        /// <summary>
        [TuShareProperty("tr")]
        public string Tr { get; set; }
        /// <summary>
        /// 交易所（SH上交所 SZ深交所）
        /// <summary>
        [TuShareProperty("exchange")]
        public string Exchange { get; set; }

    }
}
