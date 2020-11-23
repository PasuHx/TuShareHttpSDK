using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.IndexDailyMarket
  {
  /// <summary>
  /// 接口：index_daily<br/>描述：获取指数每日行情，还可以通过bar接口获取。由于服务器压力，目前规则是单次调取最多取8000行记录，可以设置start和end日期补全。指数行情也可以通过<a href="https://tushare.pro/document/2?doc_id=109"><strong>通用行情接口</strong></a>获取数据．<br/>权限：常规指数需累积200积分可低频调取，5000积分以上正常调取无限制。本接口不包括申万行情数据，申万等行业指数行情请在QQ群联系群主，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  public class IndexDailyResponseModel
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
      /// 涨跌点
      /// <summary>
      [TuShareProperty("change")]
      public float Change { get; set; }
      /// <summary>
      /// 涨跌幅（%）
      /// <summary>
      [TuShareProperty("pct_chg")]
      public float PctChg { get; set; }
      /// <summary>
      /// 成交量（手）
      /// <summary>
      [TuShareProperty("vol")]
      public float Vol { get; set; }
      /// <summary>
      /// 成交额（千元）
      /// <summary>
      [TuShareProperty("amount")]
      public float Amount { get; set; }
  }
}
