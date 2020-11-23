using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketData
  {
  /// <summary>
  /// 接口：hsgt_top10<br/>描述：获取沪股通、深股通每日前十大成交详细数据
  /// </summary>
  public class HsgtTop10ResponseModel
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
      /// 涨跌额
      /// <summary>
      [TuShareProperty("change")]
      public float Change { get; set; }
      /// <summary>
      /// 资金排名
      /// <summary>
      [TuShareProperty("rank")]
      public int Rank { get; set; }
      /// <summary>
      /// 市场类型（1：沪市 3：深市）
      /// <summary>
      [TuShareProperty("market_type")]
      public string MarketType { get; set; }
      /// <summary>
      /// 成交金额（元）
      /// <summary>
      [TuShareProperty("amount")]
      public float Amount { get; set; }
      /// <summary>
      /// 净成交金额（元）
      /// <summary>
      [TuShareProperty("net_amount")]
      public float NetAmount { get; set; }
      /// <summary>
      /// 买入金额（元）
      /// <summary>
      [TuShareProperty("buy")]
      public float Buy { get; set; }
      /// <summary>
      /// 卖出金额（元）
      /// <summary>
      [TuShareProperty("sell")]
      public float Sell { get; set; }
  }
}
