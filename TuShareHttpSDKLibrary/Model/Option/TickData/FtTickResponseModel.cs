using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.TickData
  {
  /// <summary>
  /// 接口：ft_tick<br/>描述：获取期权和期货的tick数据<br/>限量：单次最大10000条数据，可循环获取
  /// </summary>
  public class FtTickResponseModel
  {
      /// <summary>
      /// 交易代码
      /// <summary>
      [TuShareProperty("symbol")]
      public string Symbol { get; set; }
      /// <summary>
      /// 交易时间
      /// <summary>
      [TuShareProperty("trade_time")]
      public string TradeTime { get; set; }
      /// <summary>
      /// 交易毫秒数
      /// <summary>
      [TuShareProperty("trade_ms")]
      public string TradeMs { get; set; }
      /// <summary>
      /// 当前价
      /// <summary>
      [TuShareProperty("price")]
      public string Price { get; set; }
      /// <summary>
      /// 成交量
      /// <summary>
      [TuShareProperty("vol")]
      public string Vol { get; set; }
      /// <summary>
      /// 成交金额
      /// <summary>
      [TuShareProperty("amount")]
      public string Amount { get; set; }
      /// <summary>
      /// 申卖价一
      /// <summary>
      [TuShareProperty("ask_p1")]
      public string AskP1 { get; set; }
      /// <summary>
      /// 申卖量一
      /// <summary>
      [TuShareProperty("ask_v1")]
      public string AskV1 { get; set; }
      /// <summary>
      /// 申买价一
      /// <summary>
      [TuShareProperty("bid_p1")]
      public string BidP1 { get; set; }
      /// <summary>
      /// 申买量一
      /// <summary>
      [TuShareProperty("bid_v1")]
      public string BidV1 { get; set; }
      /// <summary>
      /// 持仓量
      /// <summary>
      [TuShareProperty("oi")]
      public string Oi { get; set; }
  }
}
