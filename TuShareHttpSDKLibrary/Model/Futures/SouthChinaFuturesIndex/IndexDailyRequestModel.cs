using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.SouthChinaFuturesIndex
  {
  /// <summary>
  /// 接口：index_daily<br/>描述：获取南华指数每日行情，指数行情也可以通过<a href="https://tushare.pro/document/2?doc_id=109"><strong>通用行情接口</strong></a>获取数据．<br/>权限：用户需要累积200积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  [TuShareApi("index_daily")]
  public class IndexDailyRequestModel:IApiModel<IndexDailyResponseModel>
  {
      /// <summary>
      /// 指数代码（南华期货指数以 .NH 结尾，具体请参考本文最下方）
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 交易日期 （日期格式：YYYYMMDD，下同）
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
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
  }
}
