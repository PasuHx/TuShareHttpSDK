using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.IndexDailyIndex
  {
  /// <summary>
  /// 接口：index_dailybasic<br/>描述：目前只提供上证综指，深证成指，上证50，中证500，中小板指，创业板指的每日指标数据<br/>数据来源：Tushare社区统计计算<br/>数据历史：从2004年1月开始提供<br/>数据权限：用户需要至少400积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  public class IndexDailybasicResponseModel
  {
      /// <summary>
      /// TS代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 交易日期
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// 当日总市值（元）
      /// <summary>
      [TuShareProperty("total_mv")]
      public float TotalMv { get; set; }
      /// <summary>
      /// 当日流通市值（元）
      /// <summary>
      [TuShareProperty("float_mv")]
      public float FloatMv { get; set; }
      /// <summary>
      /// 当日总股本（股）
      /// <summary>
      [TuShareProperty("total_share")]
      public float TotalShare { get; set; }
      /// <summary>
      /// 当日流通股本（股）
      /// <summary>
      [TuShareProperty("float_share")]
      public float FloatShare { get; set; }
      /// <summary>
      /// 当日自由流通股本（股）
      /// <summary>
      [TuShareProperty("free_share")]
      public float FreeShare { get; set; }
      /// <summary>
      /// 换手率
      /// <summary>
      [TuShareProperty("turnover_rate")]
      public float TurnoverRate { get; set; }
      /// <summary>
      /// 换手率(基于自由流通股本)
      /// <summary>
      [TuShareProperty("turnover_rate_f")]
      public float TurnoverRateF { get; set; }
      /// <summary>
      /// 市盈率
      /// <summary>
      [TuShareProperty("pe")]
      public float Pe { get; set; }
      /// <summary>
      /// 市盈率TTM
      /// <summary>
      [TuShareProperty("pe_ttm")]
      public float PeTtm { get; set; }
      /// <summary>
      /// 市净率
      /// <summary>
      [TuShareProperty("pb")]
      public float Pb { get; set; }
  }
}
