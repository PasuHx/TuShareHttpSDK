using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketData
  {
  /// <summary>
  /// 接口：bak_daily<br/>描述：获取备用行情，包括特定的行情指标<br/>限量：单次最大5000行数据，可以根据日期参数循环获取
  /// </summary>
  public class BakDailyResponseModel
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
      /// 股票名称
      /// <summary>
      [TuShareProperty("name")]
      public string Name { get; set; }
      /// <summary>
      /// 涨跌幅
      /// <summary>
      [TuShareProperty("pct_change")]
      public float PctChange { get; set; }
      /// <summary>
      /// 收盘价
      /// <summary>
      [TuShareProperty("close")]
      public float Close { get; set; }
      /// <summary>
      /// 涨跌额
      /// <summary>
      [TuShareProperty("change")]
      public float Change { get; set; }
      /// <summary>
      /// 开盘价
      /// <summary>
      [TuShareProperty("open")]
      public float Open { get; set; }
      /// <summary>
      /// 最高价
      /// <summary>
      [TuShareProperty("high")]
      public float High { get; set; }
      /// <summary>
      /// 最低价
      /// <summary>
      [TuShareProperty("low")]
      public float Low { get; set; }
      /// <summary>
      /// 昨收价
      /// <summary>
      [TuShareProperty("pre_close")]
      public float PreClose { get; set; }
      /// <summary>
      /// 量比
      /// <summary>
      [TuShareProperty("vol_ratio")]
      public float VolRatio { get; set; }
      /// <summary>
      /// 换手率
      /// <summary>
      [TuShareProperty("turn_over")]
      public float TurnOver { get; set; }
      /// <summary>
      /// 振幅
      /// <summary>
      [TuShareProperty("swing")]
      public float Swing { get; set; }
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
      /// <summary>
      /// 外盘（主动卖，手）
      /// <summary>
      [TuShareProperty("selling")]
      public float Selling { get; set; }
      /// <summary>
      /// 内盘（主动买， 手）
      /// <summary>
      [TuShareProperty("buying")]
      public float Buying { get; set; }
      /// <summary>
      /// 总股本(万)
      /// <summary>
      [TuShareProperty("total_share")]
      public float TotalShare { get; set; }
      /// <summary>
      /// 流通股本(万)
      /// <summary>
      [TuShareProperty("float_share")]
      public float FloatShare { get; set; }
      /// <summary>
      /// 市盈(动)
      /// <summary>
      [TuShareProperty("pe")]
      public float Pe { get; set; }
      /// <summary>
      /// 所属行业
      /// <summary>
      [TuShareProperty("industry")]
      public string Industry { get; set; }
      /// <summary>
      /// 所属地域
      /// <summary>
      [TuShareProperty("area")]
      public string Area { get; set; }
      /// <summary>
      /// 流通市值
      /// <summary>
      [TuShareProperty("float_mv")]
      public float FloatMv { get; set; }
      /// <summary>
      /// 总市值
      /// <summary>
      [TuShareProperty("total_mv")]
      public float TotalMv { get; set; }
      /// <summary>
      /// 平均价
      /// <summary>
      [TuShareProperty("avg_price")]
      public float AvgPrice { get; set; }
      /// <summary>
      /// 强弱度(%)
      /// <summary>
      [TuShareProperty("strength")]
      public float Strength { get; set; }
      /// <summary>
      /// 活跃度(%)
      /// <summary>
      [TuShareProperty("activity")]
      public float Activity { get; set; }
      /// <summary>
      /// 笔换手
      /// <summary>
      [TuShareProperty("avg_turnover")]
      public float AvgTurnover { get; set; }
      /// <summary>
      /// 攻击波(%)
      /// <summary>
      [TuShareProperty("attack")]
      public float Attack { get; set; }
      /// <summary>
      /// 近3月涨幅
      /// <summary>
      [TuShareProperty("interval_3")]
      public float Interval3 { get; set; }
      /// <summary>
      /// 近6月涨幅
      /// <summary>
      [TuShareProperty("interval_6")]
      public float Interval6 { get; set; }
  }
}
