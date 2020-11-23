using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.WeeklyIndex
  {
  /// <summary>
  /// 接口：index_weekly<br/>描述：获取指数周线行情<br/>限量：单次最大1000行记录，可分批获取，总量不限制<br/>积分：用户需要至少600积分才可以调取，积分越多频次越高，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>
  /// </summary>
  public class IndexWeeklyResponseModel
  {
      /// <summary>
      /// TS指数代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 交易日
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// 收盘点位
      /// <summary>
      [TuShareProperty("close")]
      public float Close { get; set; }
      /// <summary>
      /// 开盘点位
      /// <summary>
      [TuShareProperty("open")]
      public float Open { get; set; }
      /// <summary>
      /// 最高点位
      /// <summary>
      [TuShareProperty("high")]
      public float High { get; set; }
      /// <summary>
      /// 最低点位
      /// <summary>
      [TuShareProperty("low")]
      public float Low { get; set; }
      /// <summary>
      /// 昨日收盘点
      /// <summary>
      [TuShareProperty("pre_close")]
      public float PreClose { get; set; }
      /// <summary>
      /// 涨跌点位
      /// <summary>
      [TuShareProperty("change")]
      public float Change { get; set; }
      /// <summary>
      /// 涨跌幅
      /// <summary>
      [TuShareProperty("pct_chg")]
      public float PctChg { get; set; }
      /// <summary>
      /// 成交量
      /// <summary>
      [TuShareProperty("vol")]
      public float Vol { get; set; }
      /// <summary>
      /// 成交额
      /// <summary>
      [TuShareProperty("amount")]
      public float Amount { get; set; }
  }
}
