using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.ListOfFunds
  {
  /// <summary>
  /// 接口：fund_basic<br/>描述：获取公募基金数据列表，包括场内和场外基金<br/>积分：用户需要1500积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  [TuShareApi("fund_basic")]
  public class FundBasicRequestModel:IApiModel<FundBasicResponseModel>
  {
      /// <summary>
      /// 交易市场: E场内 O场外（默认E）
      /// <summary>
      [TuShareProperty("market")]
      public string Market { get; set; }
      /// <summary>
      /// 存续状态 D摘牌 I发行 L上市中
      /// <summary>
      [TuShareProperty("status")]
      public string Status { get; set; }
  }
}
