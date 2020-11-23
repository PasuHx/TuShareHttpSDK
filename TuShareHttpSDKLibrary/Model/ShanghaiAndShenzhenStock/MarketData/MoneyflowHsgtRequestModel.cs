using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketData
  {
  /// <summary>
  /// 接口：moneyflow_hsgt<br/>描述：获取沪股通、深股通、港股通每日资金流向数据，每次最多返回300条记录，总量不限制。
  /// </summary>
  [TuShareApi("moneyflow_hsgt")]
  public class MoneyflowHsgtRequestModel:IApiModel<MoneyflowHsgtResponseModel>
  {
      /// <summary>
      /// 交易日期 (二选一)
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// 开始日期 (二选一)
      /// <summary>
      [TuShareProperty("start_date")]
      public string StartDate { get; set; }
      /// <summary>
      /// 结束日期
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
  }
}
