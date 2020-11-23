using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketData
  {
  /// <summary>
  /// 接口：daily_basic<br/>更新时间：交易日每日15点～17点之间<br/>描述：获取全部股票每日重要的基本面指标，可用于选股分析、报表展示等。<br/>积分：用户需要至少600积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  public class DailyBasicResponseModel
  {
      /// <summary>
      /// TS股票代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 交易日期
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// 当日收盘价
      /// <summary>
      [TuShareProperty("close")]
      public float Close { get; set; }
      /// <summary>
      /// 换手率（%）
      /// <summary>
      [TuShareProperty("turnover_rate")]
      public float TurnoverRate { get; set; }
      /// <summary>
      /// 换手率（自由流通股）
      /// <summary>
      [TuShareProperty("turnover_rate_f")]
      public float TurnoverRateF { get; set; }
      /// <summary>
      /// 量比
      /// <summary>
      [TuShareProperty("volume_ratio")]
      public float VolumeRatio { get; set; }
      /// <summary>
      /// 市盈率（总市值/净利润， 亏损的PE为空）
      /// <summary>
      [TuShareProperty("pe")]
      public float Pe { get; set; }
      /// <summary>
      /// 市盈率（TTM，亏损的PE为空）
      /// <summary>
      [TuShareProperty("pe_ttm")]
      public float PeTtm { get; set; }
      /// <summary>
      /// 市净率（总市值/净资产）
      /// <summary>
      [TuShareProperty("pb")]
      public float Pb { get; set; }
      /// <summary>
      /// 市销率
      /// <summary>
      [TuShareProperty("ps")]
      public float Ps { get; set; }
      /// <summary>
      /// 市销率（TTM）
      /// <summary>
      [TuShareProperty("ps_ttm")]
      public float PsTtm { get; set; }
      /// <summary>
      /// 股息率 （%）
      /// <summary>
      [TuShareProperty("dv_ratio")]
      public float DvRatio { get; set; }
      /// <summary>
      /// 股息率（TTM）（%）
      /// <summary>
      [TuShareProperty("dv_ttm")]
      public float DvTtm { get; set; }
      /// <summary>
      /// 总股本 （万股）
      /// <summary>
      [TuShareProperty("total_share")]
      public float TotalShare { get; set; }
      /// <summary>
      /// 流通股本 （万股）
      /// <summary>
      [TuShareProperty("float_share")]
      public float FloatShare { get; set; }
      /// <summary>
      /// 自由流通股本 （万）
      /// <summary>
      [TuShareProperty("free_share")]
      public float FreeShare { get; set; }
      /// <summary>
      /// 总市值 （万元）
      /// <summary>
      [TuShareProperty("total_mv")]
      public float TotalMv { get; set; }
      /// <summary>
      /// 流通市值（万元）
      /// <summary>
      [TuShareProperty("circ_mv")]
      public float CircMv { get; set; }
  }
}
