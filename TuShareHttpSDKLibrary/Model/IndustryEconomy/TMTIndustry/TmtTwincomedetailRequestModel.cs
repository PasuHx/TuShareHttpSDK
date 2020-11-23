using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.TMTIndustry
  {
  /// <summary>
  /// 接口：tmt_twincomedetail<br/>描述：获取台湾TMT行业上市公司各类产品月度营收情况。
  /// </summary>
  [TuShareApi("tmt_twincomedetail")]
  public class TmtTwincomedetailRequestModel:IApiModel<TmtTwincomedetailResponseModel>
  {
      /// <summary>
      /// 报告期
      /// <summary>
      [TuShareProperty("date")]
      public string Date { get; set; }
      /// <summary>
      /// 产品代码
      /// <summary>
      [TuShareProperty("item")]
      public string Item { get; set; }
      /// <summary>
      /// 公司代码
      /// <summary>
      [TuShareProperty("symbol")]
      public string Symbol { get; set; }
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
      /// <summary>
      /// None
      /// <summary>
      [TuShareProperty("source")]
      public string Source { get; set; }
  }
}
