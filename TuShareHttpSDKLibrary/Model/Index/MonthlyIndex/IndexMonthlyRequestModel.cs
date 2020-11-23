using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MonthlyIndex
  {
  /// <summary>
  /// 接口：index_monthly<br/>描述：获取指数月线行情,每月更新一次<br/>限量：单次最大1000行记录,可多次获取,总量不限制<br/>积分：用户需要至少600积分才可以调取，积分越多频次越高，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>
  /// </summary>
  [TuShareApi("index_monthly")]
  public class IndexMonthlyRequestModel:IApiModel<IndexMonthlyResponseModel>
  {
      /// <summary>
      /// TS代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 交易日期
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
