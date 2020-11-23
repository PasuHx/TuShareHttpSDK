using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketData
  {
  /// <summary>
  /// 接口：ggt_daily<br/>描述：获取港股通每日成交信息，数据从2014年开始<br/>限量：单次最大1000，总量数据不限制<br/>积分：用户积2000积分可调取，5000积分无限制，请自行提高积分，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  public class GgtDailyResponseModel
  {
      /// <summary>
      /// 交易日期
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// 买入成交金额（亿元）
      /// <summary>
      [TuShareProperty("buy_amount")]
      public float BuyAmount { get; set; }
      /// <summary>
      /// 买入成交笔数（万笔）
      /// <summary>
      [TuShareProperty("buy_volume")]
      public float BuyVolume { get; set; }
      /// <summary>
      /// 卖出成交金额（亿元）
      /// <summary>
      [TuShareProperty("sell_amount")]
      public float SellAmount { get; set; }
      /// <summary>
      /// 卖出成交笔数（万笔）
      /// <summary>
      [TuShareProperty("sell_volume")]
      public float SellVolume { get; set; }
  }
}
