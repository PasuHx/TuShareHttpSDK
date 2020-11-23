using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.DailyMarketOfHongKongStocks
  {
  /// <summary>
  /// 接口：hk_daily<br/>描述：获取港股每日增量和历史行情<br/>限量：单次最大提取3000行记录，可多次提取，总量不限制<br/>积分：用户需要至少2000积分才可以调取，但有流量控制，5000积分以上无限制，积分越多权限越大，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  public class HkDailyResponseModel
  {
      /// <summary>
      /// 股票代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 交易日期
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// 开盘价
      /// <summary>
      [TuShareProperty("open")]
      public float Open { get; set; }
      /// <summary>
      /// 最高价
      /// <summary>
      [TuShareProperty("high")]
      public float High { get; set; }
      /// <summary>
      /// 最低价
      /// <summary>
      [TuShareProperty("low")]
      public float Low { get; set; }
      /// <summary>
      /// 收盘价
      /// <summary>
      [TuShareProperty("close")]
      public float Close { get; set; }
      /// <summary>
      /// 昨收价
      /// <summary>
      [TuShareProperty("pre_close")]
      public float PreClose { get; set; }
      /// <summary>
      /// 涨跌额
      /// <summary>
      [TuShareProperty("change")]
      public float Change { get; set; }
      /// <summary>
      /// 涨跌幅(%)
      /// <summary>
      [TuShareProperty("pct_chg")]
      public float PctChg { get; set; }
      /// <summary>
      /// 成交量(股)
      /// <summary>
      [TuShareProperty("vol")]
      public float Vol { get; set; }
      /// <summary>
      /// 成交额(元)
      /// <summary>
      [TuShareProperty("amount")]
      public float Amount { get; set; }
  }
}
