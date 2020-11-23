using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketData
  {
  /// <summary>
  /// 接口：suspend<br/>更新时间：不定期<br/>描述：获取股票每日停复牌信息
  /// </summary>
  public class SuspendResponseModel
  {
      /// <summary>
      /// 股票代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 停牌日期
      /// <summary>
      [TuShareProperty("suspend_date")]
      public string SuspendDate { get; set; }
      /// <summary>
      /// 复牌日期
      /// <summary>
      [TuShareProperty("resume_date")]
      public string ResumeDate { get; set; }
      /// <summary>
      /// 公告日期
      /// <summary>
      [TuShareProperty("ann_date")]
      public string AnnDate { get; set; }
      /// <summary>
      /// 停牌原因
      /// <summary>
      [TuShareProperty("suspend_reason")]
      public string SuspendReason { get; set; }
      /// <summary>
      /// 停牌原因类别
      /// <summary>
      [TuShareProperty("reason_type")]
      public string ReasonType { get; set; }
  }
}
