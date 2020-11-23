using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketDailyTransactionStatistics
  {
  /// <summary>
  /// 接口：daily_info<br/>描述：获取交易所股票交易统计，包括各板块明细<br/>限量：单次最大4000，可循环获取，总量不限制<br/>权限：用户积600积分可调取， 频次有限制，积分越高每分钟调取频次越高，5000积分以上正常调取无限制，积分获取方法请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  [TuShareApi("daily_info")]
  public class DailyInfoRequestModel:IApiModel<DailyInfoResponseModel>
  {
      /// <summary>
      /// 交易日期（YYYYMMDD格式，下同）
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// 板块代码（请参阅下方列表）
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 股票市场（SH上交所 SZ深交所）
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
      /// 指定提取字段
      /// <summary>
      [TuShareProperty("fields")]
      public string Fields { get; set; }
  }
}
