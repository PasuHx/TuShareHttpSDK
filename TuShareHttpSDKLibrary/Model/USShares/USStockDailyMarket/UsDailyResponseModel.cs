using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.USStockDailyMarket
  {
  /// <summary>
  /// 接口：us_daily<br/>描述：获取美股行情，包括全部股票全历史行情，以及重要的市场和估值指标<br/>限量：单次最大6000行数据，可根据日期参数循环提取，开通正式权限后也可支持分页提取全部历史<br/>要求：120积分可以试用查看数据，开通正式权限请在QQ群联系群主或积分管理员。
  /// </summary>
  public class UsDailyResponseModel
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
      /// 收盘价
      /// <summary>
      [TuShareProperty("close")]
      public float Close { get; set; }
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
      /// 涨跌额
      /// <summary>
      [TuShareProperty("change")]
      public float Change { get; set; }
      /// <summary>
      /// 涨跌幅
      /// <summary>
      [TuShareProperty("pct_change")]
      public float PctChange { get; set; }
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
      /// 平均价
      /// <summary>
      [TuShareProperty("vwap")]
      public float Vwap { get; set; }
      /// <summary>
      /// 换手率
      /// <summary>
      [TuShareProperty("turnover_ratio")]
      public float TurnoverRatio { get; set; }
      /// <summary>
      /// 总市值
      /// <summary>
      [TuShareProperty("total_mv")]
      public float TotalMv { get; set; }
      /// <summary>
      /// PE
      /// <summary>
      [TuShareProperty("pe")]
      public float Pe { get; set; }
      /// <summary>
      /// PB
      /// <summary>
      [TuShareProperty("pb")]
      public float Pb { get; set; }
  }
}
