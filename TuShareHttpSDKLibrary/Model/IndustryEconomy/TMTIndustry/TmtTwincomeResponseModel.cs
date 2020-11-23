using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.TMTIndustry
  {
  /// <summary>
  /// 接口：tmt_twincome<br/>描述：获取台湾TMT电子产业领域各类产品月度营收数据。
  /// </summary>
  public class TmtTwincomeResponseModel
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
      /// 月度收入
      /// <summary>
      [TuShareProperty("op_income")]
      public string OpIncome { get; set; }
  }
}
