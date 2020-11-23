using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.DailyFuturesMarket
  {
  /// <summary>
  /// 接口：fut_daily<br/>描述：期货日线行情数据<br/>限量：单次最大2000条，总量不限制<br/>积分：用户需要至少200积分才可以调取，未来可能调整积分，请尽量多的积累积分。具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  public class FutDailyResponseModel
  {
      /// <summary>
      /// TS合约代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 交易日期
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// 昨收盘价
      /// <summary>
      [TuShareProperty("pre_close")]
      public float PreClose { get; set; }
      /// <summary>
      /// 昨结算价
      /// <summary>
      [TuShareProperty("pre_settle")]
      public float PreSettle { get; set; }
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
      /// 涨跌1 收盘价-昨结算价
      /// <summary>
      [TuShareProperty("change1")]
      public float Change1 { get; set; }
      /// <summary>
      /// 涨跌2 结算价-昨结算价
      /// <summary>
      [TuShareProperty("change2")]
      public float Change2 { get; set; }
      /// <summary>
      /// 成交量(手)
      /// <summary>
      [TuShareProperty("vol")]
      public float Vol { get; set; }
      /// <summary>
      /// 成交金额(万元)
      /// <summary>
      [TuShareProperty("amount")]
      public float Amount { get; set; }
      /// <summary>
      /// 持仓量(手)
      /// <summary>
      [TuShareProperty("oi")]
      public float Oi { get; set; }
      /// <summary>
      /// 持仓量变化
      /// <summary>
      [TuShareProperty("oi_chg")]
      public float OiChg { get; set; }
      /// <summary>
      /// 交割结算价
      /// <summary>
      [TuShareProperty("delv_settle")]
      public float DelvSettle { get; set; }
  }
}
