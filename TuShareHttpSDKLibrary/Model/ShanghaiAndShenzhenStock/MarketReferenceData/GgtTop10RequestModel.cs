using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketReferenceData
  {
  /// <summary>
  /// 接口：ggt_top10<br/>描述：获取港股通每日成交数据，其中包括沪市、深市详细数据
  /// </summary>
  [TuShareApi("ggt_top10")]
  public class GgtTop10RequestModel:IApiModel<GgtTop10ResponseModel>
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
      /// 市场类型 2：港股通（沪） 4：港股通（深）
      /// <summary>
      [TuShareProperty("market_type")]
      public string MarketType { get; set; }
  }
}
