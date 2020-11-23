using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketData
  {
  /// <summary>
  /// 接口：suspend_d<br/>更新时间：不定期<br/>描述：按日期方式获取股票每日停复牌信息
  /// </summary>
  public class SuspendDResponseModel
  {
      /// <summary>
      /// TS代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 停复牌日期
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// 日内停牌时间段
      /// <summary>
      [TuShareProperty("suspend_timing")]
      public string SuspendTiming { get; set; }
      /// <summary>
      /// 停复牌类型：S-停牌，R-复牌
      /// <summary>
      [TuShareProperty("suspend_type")]
      public string SuspendType { get; set; }
  }
}
