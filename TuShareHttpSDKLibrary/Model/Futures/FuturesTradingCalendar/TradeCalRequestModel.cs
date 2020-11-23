using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.FuturesTradingCalendar
  {
  /// <summary>
  /// 接口：trade_cal<br/>描述：获取各大期货交易所交易日历数据<br/>积分：注册用户即可获取，无积分要求
  /// </summary>
  [TuShareApi("trade_cal")]
  public class TradeCalRequestModel:IApiModel<TradeCalResponseModel>
  {
      /// <summary>
      /// 交易所 SHFE 上期所 DCE 大商所 CFFEX中金所  CZCE郑商所 INE上海国际能源交易所
      /// <summary>
      [TuShareProperty("exchange")]
      public string Exchange { get; set; }
      /// <summary>
      /// 开始日期
      /// <summary>
      [TuShareProperty("start_date")]
      public string StartDate { get; set; }
      /// <summary>
      /// 结束日期
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
      /// <summary>
      /// 是否交易 0休市 1交易
      /// <summary>
      [TuShareProperty("is_open")]
      public int IsOpen { get; set; }
  }
}
