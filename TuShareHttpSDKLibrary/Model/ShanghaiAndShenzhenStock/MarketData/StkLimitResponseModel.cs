using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketData
  {
  /// <summary>
  /// 接口：stk_limit<br/>描述：获取全市场（包含A/B股和基金）每日涨跌停价格，包括涨停价格，跌停价格等，每个交易日8点40左右更新当日股票涨跌停价格。<br/>限量：单次最多提取4800条记录，可循环调取，总量不限制<br/>积分：用户积600积分可调取，单位分钟有流控，积分越高流量越大，请自行提高积分，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  public class StkLimitResponseModel
  {
      /// <summary>
      /// 交易日期
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// TS股票代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 昨日收盘价
      /// <summary>
      [TuShareProperty("pre_close")]
      public float PreClose { get; set; }
      /// <summary>
      /// 涨停价
      /// <summary>
      [TuShareProperty("up_limit")]
      public float UpLimit { get; set; }
      /// <summary>
      /// 跌停价
      /// <summary>
      [TuShareProperty("down_limit")]
      public float DownLimit { get; set; }
  }
}
