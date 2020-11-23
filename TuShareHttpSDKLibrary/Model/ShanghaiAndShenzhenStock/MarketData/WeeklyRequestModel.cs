using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketData
  {
  /// <summary>
  /// 接口：weekly<br/>描述：获取A股周线行情<br/>限量：单次最大4500行，总量不限制<br/>积分：用户需要至少300积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>
  /// </summary>
  [TuShareApi("weekly")]
  public class WeeklyRequestModel:IApiModel<WeeklyResponseModel>
  {
      /// <summary>
      /// TS代码 （ts_code,trade_date两个参数任选一）
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 交易日期 （每周最后一个交易日期，YYYYMMDD格式）
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
  }
}
