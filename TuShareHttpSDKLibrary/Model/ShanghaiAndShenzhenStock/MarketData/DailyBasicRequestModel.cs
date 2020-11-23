using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketData
  {
  /// <summary>
  /// 接口：daily_basic<br/>更新时间：交易日每日15点～17点之间<br/>描述：获取全部股票每日重要的基本面指标，可用于选股分析、报表展示等。<br/>积分：用户需要至少600积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  [TuShareApi("daily_basic")]
  public class DailyBasicRequestModel:IApiModel<DailyBasicResponseModel>
  {
      /// <summary>
      /// 股票代码（二选一）
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 交易日期 （二选一）
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// 开始日期(YYYYMMDD)
      /// <summary>
      [TuShareProperty("start_date")]
      public string StartDate { get; set; }
      /// <summary>
      /// 结束日期(YYYYMMDD)
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
  }
}
