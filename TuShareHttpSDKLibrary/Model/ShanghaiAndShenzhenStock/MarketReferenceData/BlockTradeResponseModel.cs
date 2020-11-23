using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketReferenceData
  {
  /// <summary>
  /// 接口：block_trade<br/>描述：大宗交易<br/>限量：单次最大1000条，总量不限制<br/>积分：300积分可调取，每分钟内限制次数，超过5000积分无限制，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  public class BlockTradeResponseModel
  {
      /// <summary>
      /// TS代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 交易日历
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// 成交价
      /// <summary>
      [TuShareProperty("price")]
      public float Price { get; set; }
      /// <summary>
      /// 成交量（万股）
      /// <summary>
      [TuShareProperty("vol")]
      public float Vol { get; set; }
      /// <summary>
      /// 成交金额
      /// <summary>
      [TuShareProperty("amount")]
      public float Amount { get; set; }
      /// <summary>
      /// 买方营业部
      /// <summary>
      [TuShareProperty("buyer")]
      public string Buyer { get; set; }
      /// <summary>
      /// 卖方营业部
      /// <summary>
      [TuShareProperty("seller")]
      public string Seller { get; set; }
  }
}
