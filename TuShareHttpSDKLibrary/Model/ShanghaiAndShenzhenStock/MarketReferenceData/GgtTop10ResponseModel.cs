using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketReferenceData
  {
  /// <summary>
  /// 接口：ggt_top10<br/>描述：获取港股通每日成交数据，其中包括沪市、深市详细数据
  /// </summary>
  public class GgtTop10ResponseModel
  {
      /// <summary>
      /// 交易日期
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// 股票代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 股票名称
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
      [TuShareProperty("p_change")]
      public float PChange { get; set; }
      /// <summary>
      /// 资金排名
      /// <summary>
      [TuShareProperty("rank")]
      public string Rank { get; set; }
      /// <summary>
      /// 市场类型 2：港股通（沪） 4：港股通（深）
      /// <summary>
      [TuShareProperty("market_type")]
      public string MarketType { get; set; }
      /// <summary>
      /// 累计成交金额（元）
      /// <summary>
      [TuShareProperty("amount")]
      public float Amount { get; set; }
      /// <summary>
      /// 净买入金额（元）
      /// <summary>
      [TuShareProperty("net_amount")]
      public float NetAmount { get; set; }
      /// <summary>
      /// 沪市成交金额（元）
      /// <summary>
      [TuShareProperty("sh_amount")]
      public float ShAmount { get; set; }
      /// <summary>
      /// 沪市净买入金额（元）
      /// <summary>
      [TuShareProperty("sh_net_amount")]
      public float ShNetAmount { get; set; }
      /// <summary>
      /// 沪市买入金额（元）
      /// <summary>
      [TuShareProperty("sh_buy")]
      public float ShBuy { get; set; }
      /// <summary>
      /// 沪市卖出金额
      /// <summary>
      [TuShareProperty("sh_sell")]
      public float ShSell { get; set; }
      /// <summary>
      /// 深市成交金额（元）
      /// <summary>
      [TuShareProperty("sz_amount")]
      public float SzAmount { get; set; }
      /// <summary>
      /// 深市净买入金额（元）
      /// <summary>
      [TuShareProperty("sz_net_amount")]
      public float SzNetAmount { get; set; }
      /// <summary>
      /// 深市买入金额（元）
      /// <summary>
      [TuShareProperty("sz_buy")]
      public float SzBuy { get; set; }
      /// <summary>
      /// 深市卖出金额（元）
      /// <summary>
      [TuShareProperty("sz_sell")]
      public float SzSell { get; set; }
  }
}
