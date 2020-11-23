using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.TMTIndustry
  {
  /// <summary>
  /// 接口：film_record<br/>描述：获取全国电影剧本备案的公示数据<br/>限量：单次最大500，总量不限制<br/>数据权限：用户需要至少120积分才可以调取，积分越多调取频次越高，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  [TuShareApi("film_record")]
  public class FilmRecordRequestModel:IApiModel<FilmRecordResponseModel>
  {
      /// <summary>
      /// 公布日期 （至少输入一个参数，格式：YYYYMMDD，日期不连续，定期公布）
      /// <summary>
      [TuShareProperty("ann_date")]
      public string AnnDate { get; set; }
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
