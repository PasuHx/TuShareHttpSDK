using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.IssueOfConvertibleBonds
  {
  /// <summary>
  /// 接口：cb_issue<br/>描述：获取可转债发行数据<br/>限量：单次最大2000，可多次提取，总量不限制<br/>积分：用户需要至少2000积分才可以调取，5000积分以上无限制，积分越多权限越大，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  [TuShareApi("cb_issue")]
  public class CbIssueRequestModel:IApiModel<CbIssueResponseModel>
  {
      /// <summary>
      /// TS代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 发行公告日
      /// <summary>
      [TuShareProperty("ann_date")]
      public string AnnDate { get; set; }
      /// <summary>
      /// 公告开始日期
      /// <summary>
      [TuShareProperty("start_date")]
      public string StartDate { get; set; }
      /// <summary>
      /// 公告结束日期
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
  }
}
