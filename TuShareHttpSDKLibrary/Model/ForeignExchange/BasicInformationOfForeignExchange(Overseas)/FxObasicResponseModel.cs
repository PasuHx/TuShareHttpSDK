using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;

namespace TuShareHttpSDKLibrary.Model.BasicInformationOfForeignExchangeOverseas
{
    /// <summary>
    /// 接口：fx_obasic<br/>描述：获取海外外汇基础信息，目前只有FXCM交易商的数据<br/>数量：单次可提取全部数据<br/>积分：用户需要至少2000积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
    /// </summary>
    public class FxObasicResponseModel
    {
        /// <summary>
        /// 外汇代码
        /// <summary>
        [TuShareProperty("ts_code")]
        public string TsCode { get; set; }
        /// <summary>
        /// 名称
        /// <summary>
        [TuShareProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// 分类
        /// <summary>
        [TuShareProperty("classify")]
        public string Classify { get; set; }
        /// <summary>
        /// 交易商
        /// <summary>
        [TuShareProperty("exchange")]
        public string Exchange { get; set; }
        /// <summary>
        /// 最小交易单位
        /// <summary>
        [TuShareProperty("min_unit")]
        public float MinUnit { get; set; }
        /// <summary>
        /// 最大交易单位
        /// <summary>
        [TuShareProperty("max_unit")]
        public float MaxUnit { get; set; }
        /// <summary>
        /// 最大交易单位
        /// <summary>
        [TuShareProperty("pip")]
        public float Pip { get; set; }
        /// <summary>
        /// 点值
        /// <summary>
        [TuShareProperty("pip_cost")]
        public float PipCost { get; set; }
        /// <summary>
        /// 目标差价
        /// <summary>
        [TuShareProperty("traget_spread")]
        public float TragetSpread { get; set; }
        /// <summary>
        /// 最小止损距离（点子）
        /// <summary>
        [TuShareProperty("min_stop_distance")]
        public float MinStopDistance { get; set; }
        /// <summary>
        /// 交易时间
        /// <summary>
        [TuShareProperty("trading_hours")]
        public string TradingHours { get; set; }
        /// <summary>
        /// 休市时间
        /// <summary>
        [TuShareProperty("break_time")]
        public string BreakTime { get; set; }
    }
}
