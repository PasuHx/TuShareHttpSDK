using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.FuturesTradingCalendar
  {
  /// <summary>
  /// 接口：trade_cal<br/>描述：获取各大期货交易所交易日历数据<br/>积分：注册用户即可获取，无积分要求
  /// </summary>
  public class TradeCalResponseModel
  {
      /// <summary>
      /// 交易所 同参数部分描述
      /// <summary>
      [TuShareProperty("exchange")]
      public string Exchange { get; set; }
      /// <summary>
      /// 日历日期
      /// <summary>
      [TuShareProperty("cal_date")]
      public string CalDate { get; set; }
      /// <summary>
      /// 是否交易 0休市 1交易
      /// <summary>
      [TuShareProperty("is_open")]
      public int IsOpen { get; set; }
      /// <summary>
      /// 上一个交易日
      /// <summary>
      [TuShareProperty("pretrade_date")]
      public string PretradeDate { get; set; }
  }
}
