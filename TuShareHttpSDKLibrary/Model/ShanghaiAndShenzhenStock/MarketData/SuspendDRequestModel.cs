using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketData
  {
  /// <summary>
  /// 接口：suspend_d<br/>更新时间：不定期<br/>描述：按日期方式获取股票每日停复牌信息
  /// </summary>
  [TuShareApi("suspend_d")]
  public class SuspendDRequestModel:IApiModel<SuspendDResponseModel>
  {
      /// <summary>
      /// 股票代码(可输入多值)
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 交易日日期
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// 停复牌查询开始日期
      /// <summary>
      [TuShareProperty("start_date")]
      public string StartDate { get; set; }
      /// <summary>
      /// 停复牌查询结束日期
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
      /// <summary>
      /// 停复牌类型：S-停牌,R-复牌
      /// <summary>
      [TuShareProperty("suspend_type")]
      public string SuspendType { get; set; }
  }
}
