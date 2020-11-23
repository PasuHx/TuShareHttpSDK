using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketData
  {
  /// <summary>
  /// 接口：suspend<br/>更新时间：不定期<br/>描述：获取股票每日停复牌信息
  /// </summary>
  [TuShareApi("suspend")]
  public class SuspendRequestModel:IApiModel<SuspendResponseModel>
  {
      /// <summary>
      /// 股票代码(三选一)
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 停牌日期(三选一)
      /// <summary>
      [TuShareProperty("suspend_date")]
      public string SuspendDate { get; set; }
      /// <summary>
      /// 复牌日期(三选一)
      /// <summary>
      [TuShareProperty("resume_date")]
      public string ResumeDate { get; set; }
  }
}
