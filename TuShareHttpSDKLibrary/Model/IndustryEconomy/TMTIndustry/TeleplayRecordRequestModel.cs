using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.TMTIndustry
  {
  /// <summary>
  /// 接口：teleplay_record<br/>描述：获取2009年以来全国拍摄制作电视剧备案公示数据<br/>限量：单次最大1000，总量不限制<br/>数据权限：用户需要至少积分600才可以调取，积分越多调取频次越高，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  [TuShareApi("teleplay_record")]
  public class TeleplayRecordRequestModel:IApiModel<TeleplayRecordResponseModel>
  {
      /// <summary>
      /// 备案月份（YYYYMM）
      /// <summary>
      [TuShareProperty("report_date")]
      public string ReportDate { get; set; }
      /// <summary>
      /// 备案开始月份（YYYYMM）
      /// <summary>
      [TuShareProperty("start_date")]
      public string StartDate { get; set; }
      /// <summary>
      /// 备案结束月份（YYYYMM）
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
      /// <summary>
      /// 备案机构
      /// <summary>
      [TuShareProperty("org")]
      public string Org { get; set; }
      /// <summary>
      /// 电视剧名称
      /// <summary>
      [TuShareProperty("name")]
      public string Name { get; set; }
  }
}
