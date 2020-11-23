using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.OptionsDailyMarket
  {
  /// <summary>
  /// 接口：opt_daily<br/>描述：获取期权日线行情<br/>限量：单次最大1000，总量不限制<br/>积分：用户需要至少200积分才可以调取，但有流量控制，请自行提高积分，积分越多权限越大，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  public class OptDailyResponseModel
  {
      /// <summary>
      /// TS代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 交易日期
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// 交易市场
      /// <summary>
      [TuShareProperty("exchange")]
      public string Exchange { get; set; }
      /// <summary>
      /// 昨结算价
      /// <summary>
      [TuShareProperty("pre_settle")]
      public float PreSettle { get; set; }
      /// <summary>
      /// 前收盘价
      /// <summary>
      [TuShareProperty("pre_close")]
      public float PreClose { get; set; }
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
      /// 结算价
      /// <summary>
      [TuShareProperty("settle")]
      public float Settle { get; set; }
      /// <summary>
      /// 成交量(万手)
      /// <summary>
      [TuShareProperty("vol")]
      public float Vol { get; set; }
      /// <summary>
      /// 成交金额(元)
      /// <summary>
      [TuShareProperty("amount")]
      public float Amount { get; set; }
      /// <summary>
      /// 持仓量(手)
      /// <summary>
      [TuShareProperty("oi")]
      public float Oi { get; set; }
  }
}
