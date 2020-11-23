using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketReferenceData
  {
  /// <summary>
  /// 接口：top_list<br/>描述：龙虎榜每日交易明细<br/>数据历史： 2005年至今<br/>限量：单次最大10000<br/>积分：用户需要至少300积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  public class TopListResponseModel
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
      /// 名称
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
      [TuShareProperty("pct_change")]
      public float PctChange { get; set; }
      /// <summary>
      /// 换手率
      /// <summary>
      [TuShareProperty("turnover_rate")]
      public float TurnoverRate { get; set; }
      /// <summary>
      /// 总成交额
      /// <summary>
      [TuShareProperty("amount")]
      public float Amount { get; set; }
      /// <summary>
      /// 龙虎榜卖出额
      /// <summary>
      [TuShareProperty("l_sell")]
      public float LSell { get; set; }
      /// <summary>
      /// 龙虎榜买入额
      /// <summary>
      [TuShareProperty("l_buy")]
      public float LBuy { get; set; }
      /// <summary>
      /// 龙虎榜成交额
      /// <summary>
      [TuShareProperty("l_amount")]
      public float LAmount { get; set; }
      /// <summary>
      /// 龙虎榜净买入额
      /// <summary>
      [TuShareProperty("net_amount")]
      public float NetAmount { get; set; }
      /// <summary>
      /// 龙虎榜净买额占比
      /// <summary>
      [TuShareProperty("net_rate")]
      public float NetRate { get; set; }
      /// <summary>
      /// 龙虎榜成交额占比
      /// <summary>
      [TuShareProperty("amount_rate")]
      public float AmountRate { get; set; }
      /// <summary>
      /// 当日流通市值
      /// <summary>
      [TuShareProperty("float_values")]
      public float FloatValues { get; set; }
      /// <summary>
      /// 上榜理由
      /// <summary>
      [TuShareProperty("reason")]
      public string Reason { get; set; }
  }
}
