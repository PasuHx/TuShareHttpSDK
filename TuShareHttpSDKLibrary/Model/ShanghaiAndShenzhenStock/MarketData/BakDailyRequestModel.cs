using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketData
  {
  /// <summary>
  /// 接口：bak_daily<br/>描述：获取备用行情，包括特定的行情指标<br/>限量：单次最大5000行数据，可以根据日期参数循环获取
  /// </summary>
  [TuShareApi("bak_daily")]
  public class BakDailyRequestModel:IApiModel<BakDailyResponseModel>
  {
      /// <summary>
      /// 股票代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 交易日期
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
      /// <summary>
      /// 开始行数
      /// <summary>
      [TuShareProperty("offset")]
      public string Offset { get; set; }
      /// <summary>
      /// 最大行数
      /// <summary>
      [TuShareProperty("limit")]
      public string Limit { get; set; }
  }
}
