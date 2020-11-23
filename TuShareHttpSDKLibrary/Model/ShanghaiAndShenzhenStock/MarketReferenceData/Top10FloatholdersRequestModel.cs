using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketReferenceData
  {
  /// <summary>
  /// 接口：top10_floatholders<br/>描述：获取上市公司前十大流通股东数据。
  /// </summary>
  [TuShareApi("top10_floatholders")]
  public class Top10FloatholdersRequestModel:IApiModel<Top10FloatholdersResponseModel>
  {
      /// <summary>
      /// TS代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 报告期
      /// <summary>
      [TuShareProperty("period")]
      public string Period { get; set; }
      /// <summary>
      /// 公告日期
      /// <summary>
      [TuShareProperty("ann_date")]
      public string AnnDate { get; set; }
      /// <summary>
      /// 报告期开始日期
      /// <summary>
      [TuShareProperty("start_date")]
      public string StartDate { get; set; }
      /// <summary>
      /// 报告期结束日期
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
  }
}
