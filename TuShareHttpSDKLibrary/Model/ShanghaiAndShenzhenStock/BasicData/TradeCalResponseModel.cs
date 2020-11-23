using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.BasicData
  {
  /// <summary>
  /// 接口：trade_cal<br/>描述：获取各大交易所交易日历数据,默认提取的是上交所
  /// </summary>
  public class TradeCalResponseModel
  {
      /// <summary>
      /// 交易所 SSE上交所 SZSE深交所
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
      public string IsOpen { get; set; }
      /// <summary>
      /// 上一个交易日
      /// <summary>
      [TuShareProperty("pretrade_date")]
      public string PretradeDate { get; set; }
  }
}
