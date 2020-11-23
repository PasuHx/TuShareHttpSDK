using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.NewsFlash
  {
  /// <summary>
  /// 接口：news<br/>描述：获取主流新闻网站的快讯新闻数据<br/>限量：单次最大1000条新闻<br/>积分：用户积累1500积分可以调取，超过5000无限制，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  [TuShareApi("news")]
  public class NewsRequestModel:IApiModel<NewsResponseModel>
  {
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
      /// <summary>
      /// 新闻来源 见下表
      /// <summary>
      [TuShareProperty("src")]
      public string Src { get; set; }
  }
}
