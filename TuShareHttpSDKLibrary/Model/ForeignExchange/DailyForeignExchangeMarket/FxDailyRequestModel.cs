using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.DailyForeignExchangeMarket
  {
  /// <summary>
  /// 接口：fx_daily<br/>描述：获取外汇日线行情<br/>限量：单次最大提取1000行记录，可多次提取，总量不限制<br/>积分：用户需要至少2000积分才可以调取，但有流量控制，5000积分以上无限制，积分越多权限越大，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  [TuShareApi("fx_daily")]
  public class FxDailyRequestModel:IApiModel<FxDailyResponseModel>
  {
      /// <summary>
      /// TS代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 交易日期（GMT，日期是格林尼治时间，比北京时间晚一天）
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// 开始日期（GMT）
      /// <summary>
      [TuShareProperty("start_date")]
      public string StartDate { get; set; }
      /// <summary>
      /// 结束日期（GMT）
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
      /// <summary>
      /// 交易商，目前只有FXCM
      /// <summary>
      [TuShareProperty("exchange")]
      public string Exchange { get; set; }
  }
}
