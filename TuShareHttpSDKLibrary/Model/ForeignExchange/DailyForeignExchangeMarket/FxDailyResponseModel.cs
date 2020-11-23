using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.DailyForeignExchangeMarket
  {
  /// <summary>
  /// 接口：fx_daily<br/>描述：获取外汇日线行情<br/>限量：单次最大提取1000行记录，可多次提取，总量不限制<br/>积分：用户需要至少2000积分才可以调取，但有流量控制，5000积分以上无限制，积分越多权限越大，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  public class FxDailyResponseModel
  {
      /// <summary>
      /// 外汇代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 交易日期
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// 买入开盘价
      /// <summary>
      [TuShareProperty("bid_open")]
      public float BidOpen { get; set; }
      /// <summary>
      /// 买入收盘价
      /// <summary>
      [TuShareProperty("bid_close")]
      public float BidClose { get; set; }
      /// <summary>
      /// 买入最高价
      /// <summary>
      [TuShareProperty("bid_high")]
      public float BidHigh { get; set; }
      /// <summary>
      /// 买入最低价
      /// <summary>
      [TuShareProperty("bid_low")]
      public float BidLow { get; set; }
      /// <summary>
      /// 卖出开盘价
      /// <summary>
      [TuShareProperty("ask_open")]
      public float AskOpen { get; set; }
      /// <summary>
      /// 卖出收盘价
      /// <summary>
      [TuShareProperty("ask_close")]
      public float AskClose { get; set; }
      /// <summary>
      /// 卖出最高价
      /// <summary>
      [TuShareProperty("ask_high")]
      public float AskHigh { get; set; }
      /// <summary>
      /// 卖出最低价
      /// <summary>
      [TuShareProperty("ask_low")]
      public float AskLow { get; set; }
      /// <summary>
      /// 报价笔数
      /// <summary>
      [TuShareProperty("tick_qty")]
      public int TickQty { get; set; }
      /// <summary>
      /// 交易商
      /// <summary>
      [TuShareProperty("exchange")]
      public string Exchange { get; set; }
  }
}
