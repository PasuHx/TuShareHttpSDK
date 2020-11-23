using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.DailyFuturesMarket
  {
  /// <summary>
  /// 接口：fut_daily<br/>描述：期货日线行情数据<br/>限量：单次最大2000条，总量不限制<br/>积分：用户需要至少200积分才可以调取，未来可能调整积分，请尽量多的积累积分。具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  [TuShareApi("fut_daily")]
  public class FutDailyRequestModel:IApiModel<FutDailyResponseModel>
  {
      /// <summary>
      /// 交易日期
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// 合约代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 交易所代码
      /// <summary>
      [TuShareProperty("exchange")]
      public string Exchange { get; set; }
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
