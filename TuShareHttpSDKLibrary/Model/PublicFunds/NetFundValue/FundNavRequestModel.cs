using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.NetFundValue
  {
  /// <summary>
  /// 接口：fund_nav<br/>描述：获取公募基金净值数据<br/>积分：用户需要至少2000积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  [TuShareApi("fund_nav")]
  public class FundNavRequestModel:IApiModel<FundNavResponseModel>
  {
      /// <summary>
      /// TS基金代码 （二选一）
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 净值日期 （二选一）
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
      /// <summary>
      /// E场内 O场外
      /// <summary>
      [TuShareProperty("market")]
      public string Market { get; set; }
  }
}
