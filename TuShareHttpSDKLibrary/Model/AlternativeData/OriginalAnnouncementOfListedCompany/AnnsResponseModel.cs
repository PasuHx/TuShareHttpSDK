using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.OriginalAnnouncementOfListedCompany
  {
  /// <summary>
  /// 接口：anns<br/>描述：获取上市公司公告数据及原文文本，数据从2000年开始，内容很大，请注意数据调取节奏。<br/>提示：单次最大50行记录，可设置开始和结束时间分阶段获取数据，数据总量不限制<br/>积分：用户需要至少5000积分才可以调取。基础积分有流量控制，积分越多权限越大，请自行提高积分，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  public class AnnsResponseModel
  {
      /// <summary>
      /// 股票代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 公告日期
      /// <summary>
      [TuShareProperty("ann_date")]
      public string AnnDate { get; set; }
      /// <summary>
      /// 公告类型
      /// <summary>
      [TuShareProperty("ann_type")]
      public string AnnType { get; set; }
      /// <summary>
      /// 公告标题
      /// <summary>
      [TuShareProperty("title")]
      public string Title { get; set; }
      /// <summary>
      /// 公告内容
      /// <summary>
      [TuShareProperty("content")]
      public string Content { get; set; }
      /// <summary>
      /// 公告发布时间
      /// <summary>
      [TuShareProperty("pub_time")]
      public string PubTime { get; set; }
  }
}
