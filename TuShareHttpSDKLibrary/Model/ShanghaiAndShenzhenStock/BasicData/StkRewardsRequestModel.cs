using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.BasicData
  {
  /// <summary>
  /// 接口：stk_rewards<br/>描述：获取上市公司管理层薪酬和持股<br/>积分：用户需要2000积分才可以调取，5000积分以上无限制，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  [TuShareApi("stk_rewards")]
  public class StkRewardsRequestModel:IApiModel<StkRewardsResponseModel>
  {
      /// <summary>
      /// TS股票代码，支持单个或多个代码输入
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 报告期
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
  }
}
