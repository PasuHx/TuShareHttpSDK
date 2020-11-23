using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.DailyPositionRanking
  {
  /// <summary>
  /// 接口：fut_holding<br/>描述：获取每日成交持仓排名数据<br/>限量：单次最大2000，总量不限制<br/>积分：用户需要至少600积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  public class FutHoldingResponseModel
  {
      /// <summary>
      /// 交易日期
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// 合约代码或类型
      /// <summary>
      [TuShareProperty("symbol")]
      public string Symbol { get; set; }
      /// <summary>
      /// 期货公司会员简称
      /// <summary>
      [TuShareProperty("broker")]
      public string Broker { get; set; }
      /// <summary>
      /// 成交量
      /// <summary>
      [TuShareProperty("vol")]
      public int Vol { get; set; }
      /// <summary>
      /// 成交量变化
      /// <summary>
      [TuShareProperty("vol_chg")]
      public int VolChg { get; set; }
      /// <summary>
      /// 持买仓量
      /// <summary>
      [TuShareProperty("long_hld")]
      public int LongHld { get; set; }
      /// <summary>
      /// 持买仓量变化
      /// <summary>
      [TuShareProperty("long_chg")]
      public int LongChg { get; set; }
      /// <summary>
      /// 持卖仓量
      /// <summary>
      [TuShareProperty("short_hld")]
      public int ShortHld { get; set; }
      /// <summary>
      /// 持卖仓量变化
      /// <summary>
      [TuShareProperty("short_chg")]
      public int ShortChg { get; set; }
      /// <summary>
      /// 交易所
      /// <summary>
      [TuShareProperty("exchange")]
      public string Exchange { get; set; }
  }
}
