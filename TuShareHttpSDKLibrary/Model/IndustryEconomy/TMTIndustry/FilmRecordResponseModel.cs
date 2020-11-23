using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.TMTIndustry
  {
  /// <summary>
  /// 接口：film_record<br/>描述：获取全国电影剧本备案的公示数据<br/>限量：单次最大500，总量不限制<br/>数据权限：用户需要至少120积分才可以调取，积分越多调取频次越高，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  public class FilmRecordResponseModel
  {
      /// <summary>
      /// 备案号
      /// <summary>
      [TuShareProperty("rec_no")]
      public string RecNo { get; set; }
      /// <summary>
      /// 影片名称
      /// <summary>
      [TuShareProperty("film_name")]
      public string FilmName { get; set; }
      /// <summary>
      /// 备案单位
      /// <summary>
      [TuShareProperty("rec_org")]
      public string RecOrg { get; set; }
      /// <summary>
      /// 编剧
      /// <summary>
      [TuShareProperty("script_writer")]
      public string ScriptWriter { get; set; }
      /// <summary>
      /// 备案结果
      /// <summary>
      [TuShareProperty("rec_result")]
      public string RecResult { get; set; }
      /// <summary>
      /// 备案地（备案时间）
      /// <summary>
      [TuShareProperty("rec_area")]
      public string RecArea { get; set; }
      /// <summary>
      /// 影片分类
      /// <summary>
      [TuShareProperty("classified")]
      public string Classified { get; set; }
      /// <summary>
      /// 备案日期区间
      /// <summary>
      [TuShareProperty("date_range")]
      public string DateRange { get; set; }
      /// <summary>
      /// 备案结果发布时间
      /// <summary>
      [TuShareProperty("ann_date")]
      public string AnnDate { get; set; }
  }
}
