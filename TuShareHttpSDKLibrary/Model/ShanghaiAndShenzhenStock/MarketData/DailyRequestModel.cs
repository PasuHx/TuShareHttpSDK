using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketData
  {
  /// <summary>
  /// 接口：daily<br/>数据说明：交易日每天15点～16点之间。本接口是未复权行情，停牌期间不提供数据。<br/>调取说明：基础积分每分钟内最多调取500次，每次5000条数据，相当于23年历史，用户获得超过5000积分<strong>正常调取</strong>无频次限制。<br/>描述：获取股票行情数据，或通过<a href="https://tushare.pro/document/2?doc_id=109"><strong>通用行情接口</strong></a>获取数据，包含了前后复权数据。
  /// </summary>
  [TuShareApi("daily")]
  public class DailyRequestModel:IApiModel<DailyResponseModel>
  {
      /// <summary>
      /// 股票代码（支持多个股票同时提取，逗号分隔）
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 交易日期（YYYYMMDD）
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
