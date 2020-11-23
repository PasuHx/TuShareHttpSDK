using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketData
  {
  /// <summary>
  /// 接口：hsgt_top10<br/>描述：获取沪股通、深股通每日前十大成交详细数据
  /// </summary>
  [TuShareApi("hsgt_top10")]
  public class HsgtTop10RequestModel:IApiModel<HsgtTop10ResponseModel>
  {
      /// <summary>
      /// 股票代码（二选一）
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 交易日期（二选一）
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// 开始日期
      /// <summary>
      [TuShareProperty("start_date")]
      public string StartDate { get; set; }
      /// <summary>
      /// 结束日期
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
      /// <summary>
      /// 市场类型（1：沪市 3：深市）
      /// <summary>
      [TuShareProperty("market_type")]
      public string MarketType { get; set; }
  }
}
