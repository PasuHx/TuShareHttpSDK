using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.FundMarket
  {
  /// <summary>
  /// 接口：fund_daily<br/>描述：获取场内基金日线行情，类似股票日行情<br/>更新：每日收盘后2小时内<br/>限量：单次最大800行记录，总量不限制<br/>积分：用户需要至少500积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  [TuShareApi("fund_daily")]
  public class FundDailyRequestModel:IApiModel<FundDailyResponseModel>
  {
      /// <summary>
      /// 基金代码（二选一）
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
  }
}
