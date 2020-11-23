using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.USStockDailyMarket
  {
  /// <summary>
  /// 接口：us_daily<br/>描述：获取美股行情，包括全部股票全历史行情，以及重要的市场和估值指标<br/>限量：单次最大6000行数据，可根据日期参数循环提取，开通正式权限后也可支持分页提取全部历史<br/>要求：120积分可以试用查看数据，开通正式权限请在QQ群联系群主或积分管理员。
  /// </summary>
  [TuShareApi("us_daily")]
  public class UsDailyRequestModel:IApiModel<UsDailyResponseModel>
  {
      /// <summary>
      /// 股票代码（e.g. AAPL）
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 交易日期（YYYYMMDD）
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// 开始日期（YYYYMMDD）
      /// <summary>
      [TuShareProperty("start_date")]
      public string StartDate { get; set; }
      /// <summary>
      /// 结束日期（YYYYMMDD）
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
  }
}
