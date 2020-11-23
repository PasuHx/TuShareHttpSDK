using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketData
  {
  /// <summary>
  /// 接口：stk_limit<br/>描述：获取全市场（包含A/B股和基金）每日涨跌停价格，包括涨停价格，跌停价格等，每个交易日8点40左右更新当日股票涨跌停价格。<br/>限量：单次最多提取4800条记录，可循环调取，总量不限制<br/>积分：用户积600积分可调取，单位分钟有流控，积分越高流量越大，请自行提高积分，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  [TuShareApi("stk_limit")]
  public class StkLimitRequestModel:IApiModel<StkLimitResponseModel>
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
  }
}
