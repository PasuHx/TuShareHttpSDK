using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketData
  {
  /// <summary>
  /// 接口：limit_list<br/>描述：获取每日涨跌停股票统计，包括封闭时间和打开次数等数据，帮助用户快速定位近期强（弱）势股，以及研究超短线策略。<br/>限量：单次最大1000，总量不限制<br/>积分：用户积2000积分可调取，5000积分以上可高频使用，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  public class LimitListResponseModel
  {
      /// <summary>
      /// 交易日期
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// 股票代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 股票名称
      /// <summary>
      [TuShareProperty("name")]
      public string Name { get; set; }
      /// <summary>
      /// 收盘价
      /// <summary>
      [TuShareProperty("close")]
      public float Close { get; set; }
      /// <summary>
      /// 涨跌幅
      /// <summary>
      [TuShareProperty("pct_chg")]
      public float PctChg { get; set; }
      /// <summary>
      /// 振幅
      /// <summary>
      [TuShareProperty("amp")]
      public float Amp { get; set; }
      /// <summary>
      /// 封单金额/日成交金额
      /// <summary>
      [TuShareProperty("fc_ratio")]
      public float FcRatio { get; set; }
      /// <summary>
      /// 封单手数/流通股本
      /// <summary>
      [TuShareProperty("fl_ratio")]
      public float FlRatio { get; set; }
      /// <summary>
      /// 封单金额
      /// <summary>
      [TuShareProperty("fd_amount")]
      public float FdAmount { get; set; }
      /// <summary>
      /// 首次涨停时间
      /// <summary>
      [TuShareProperty("first_time")]
      public string FirstTime { get; set; }
      /// <summary>
      /// 最后封板时间
      /// <summary>
      [TuShareProperty("last_time")]
      public string LastTime { get; set; }
      /// <summary>
      /// 打开次数
      /// <summary>
      [TuShareProperty("open_times")]
      public int OpenTimes { get; set; }
      /// <summary>
      /// 涨跌停强度
      /// <summary>
      [TuShareProperty("strth")]
      public float Strth { get; set; }
      /// <summary>
      /// D跌停U涨停
      /// <summary>
      [TuShareProperty("limit")]
      public string Limit { get; set; }
  }
}
