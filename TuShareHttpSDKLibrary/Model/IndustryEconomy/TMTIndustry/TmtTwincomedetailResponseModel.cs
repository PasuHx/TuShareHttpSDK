using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.TMTIndustry
  {
  /// <summary>
  /// 接口：tmt_twincomedetail<br/>描述：获取台湾TMT行业上市公司各类产品月度营收情况。
  /// </summary>
  public class TmtTwincomedetailResponseModel
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
      /// 月度营收
      /// <summary>
      [TuShareProperty("op_income")]
      public string OpIncome { get; set; }
      /// <summary>
      /// 合并月度营收（默认不展示）
      /// <summary>
      [TuShareProperty("consop_income")]
      public string ConsopIncome { get; set; }
  }
}
