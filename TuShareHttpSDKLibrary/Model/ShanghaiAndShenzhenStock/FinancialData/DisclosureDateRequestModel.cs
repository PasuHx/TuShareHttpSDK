using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.FinancialData
  {
  /// <summary>
  /// 接口：disclosure_date<br/>描述：获取财报披露计划日期<br/>限量：单次最大3000，总量不限制<br/>积分：用户需要至少500积分才可以调取，积分越多权限越大，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  [TuShareApi("disclosure_date")]
  public class DisclosureDateRequestModel:IApiModel<DisclosureDateResponseModel>
  {
      /// <summary>
      /// TS股票代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 财报周期（比如20181231表示2018年年报，20180630表示中报)
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
      /// <summary>
      /// 计划披露日期
      /// <summary>
      [TuShareProperty("pre_date")]
      public string PreDate { get; set; }
      /// <summary>
      /// 实际披露日期
      /// <summary>
      [TuShareProperty("actual_date")]
      public string ActualDate { get; set; }
  }
}
