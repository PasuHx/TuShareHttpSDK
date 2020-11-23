using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.OptionsDailyMarket
  {
  /// <summary>
  /// 接口：opt_daily<br/>描述：获取期权日线行情<br/>限量：单次最大1000，总量不限制<br/>积分：用户需要至少200积分才可以调取，但有流量控制，请自行提高积分，积分越多权限越大，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  [TuShareApi("opt_daily")]
  public class OptDailyRequestModel:IApiModel<OptDailyResponseModel>
  {
      /// <summary>
      /// TS合约代码（输入代码或时间至少任意一个参数）
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
      /// <summary>
      /// 交易所
      /// <summary>
      [TuShareProperty("exchange")]
      public string Exchange { get; set; }
  }
}
