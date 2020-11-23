using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.BasicData
  {
  /// <summary>
  /// 接口：trade_cal<br/>描述：获取各大交易所交易日历数据,默认提取的是上交所
  /// </summary>
  [TuShareApi("trade_cal")]
  public class TradeCalRequestModel:IApiModel<TradeCalResponseModel>
  {
      /// <summary>
      /// 交易所 SSE上交所,SZSE深交所,CFFEX 中金所,SHFE 上期所,CZCE 郑商所,DCE 大商所,INE 上能源,IB 银行间,XHKG  港交所
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
      /// 是否交易 &#39;0&#39;休市 &#39;1&#39;交易
      /// <summary>
      [TuShareProperty("is_open")]
      public string IsOpen { get; set; }
  }
}
