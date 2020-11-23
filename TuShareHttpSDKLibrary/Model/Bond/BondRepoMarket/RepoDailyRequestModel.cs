using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.BondRepoMarket
  {
  /// <summary>
  /// 接口：repo_daily<br/>描述：债券回购日行情<br/>限量：单次最大2000条，可多次提取，总量不限制<br/>权限：用户需要累积200积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>
  /// </summary>
  [TuShareApi("repo_daily")]
  public class RepoDailyRequestModel:IApiModel<RepoDailyResponseModel>
  {
      /// <summary>
      /// TS代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 交易日期(YYYYMMDD格式，下同)
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
