using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.NewsFlash
  {
  /// <summary>
  /// 接口：news<br/>描述：获取主流新闻网站的快讯新闻数据<br/>限量：单次最大1000条新闻<br/>积分：用户积累1500积分可以调取，超过5000无限制，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  public class NewsResponseModel
  {
      /// <summary>
      /// 获取新浪财经实时资讯
      /// <summary>
      [TuShareProperty("新浪财经")]
      public string 新浪财经 { get; set; }
      /// <summary>
      /// 华尔街见闻快讯
      /// <summary>
      [TuShareProperty("华尔街见闻")]
      public string 华尔街见闻 { get; set; }
      /// <summary>
      /// 同花顺财经新闻
      /// <summary>
      [TuShareProperty("同花顺")]
      public string 同花顺 { get; set; }
      /// <summary>
      /// 东方财富财经新闻
      /// <summary>
      [TuShareProperty("东方财富")]
      public string 东方财富 { get; set; }
      /// <summary>
      /// 云财经新闻
      /// <summary>
      [TuShareProperty("云财经")]
      public string 云财经 { get; set; }
  }
}
