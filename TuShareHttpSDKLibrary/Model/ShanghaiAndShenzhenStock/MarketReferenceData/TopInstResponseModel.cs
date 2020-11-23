using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketReferenceData
  {
  /// <summary>
  /// 接口：top_inst<br/>描述：龙虎榜机构成交明细<br/>限量：单次最大10000<br/>积分：用户需要至少300积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  public class TopInstResponseModel
  {
      /// <summary>
      /// 交易日期
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// TS代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 营业部名称
      /// <summary>
      [TuShareProperty("exalter")]
      public string Exalter { get; set; }
      /// <summary>
      /// 买入额（万）
      /// <summary>
      [TuShareProperty("buy")]
      public float Buy { get; set; }
      /// <summary>
      /// 买入占总成交比例
      /// <summary>
      [TuShareProperty("buy_rate")]
      public float BuyRate { get; set; }
      /// <summary>
      /// 卖出额（万）
      /// <summary>
      [TuShareProperty("sell")]
      public float Sell { get; set; }
      /// <summary>
      /// 卖出占总成交比例
      /// <summary>
      [TuShareProperty("sell_rate")]
      public float SellRate { get; set; }
      /// <summary>
      /// 净成交额（万）
      /// <summary>
      [TuShareProperty("net_buy")]
      public float NetBuy { get; set; }
  }
}
