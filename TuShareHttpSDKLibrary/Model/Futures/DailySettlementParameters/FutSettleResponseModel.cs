using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.DailySettlementParameters
  {
  /// <summary>
  /// 接口：fut_settle<br/>描述：获取每日结算参数数据，包括交易和交割费率等<br/>限量：单次最大1000，总量不限制<br/>积分：用户需要至少600积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  public class FutSettleResponseModel
  {
      /// <summary>
      /// 合约代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 交易日期
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// 结算价
      /// <summary>
      [TuShareProperty("settle")]
      public float Settle { get; set; }
      /// <summary>
      /// 交易手续费率
      /// <summary>
      [TuShareProperty("trading_fee_rate")]
      public float TradingFeeRate { get; set; }
      /// <summary>
      /// 交易手续费
      /// <summary>
      [TuShareProperty("trading_fee")]
      public float TradingFee { get; set; }
      /// <summary>
      /// 交割手续费
      /// <summary>
      [TuShareProperty("delivery_fee")]
      public float DeliveryFee { get; set; }
      /// <summary>
      /// 买套保交易保证金率
      /// <summary>
      [TuShareProperty("b_hedging_margin_rate")]
      public float BHedgingMarginRate { get; set; }
      /// <summary>
      /// 卖套保交易保证金率
      /// <summary>
      [TuShareProperty("s_hedging_margin_rate")]
      public float SHedgingMarginRate { get; set; }
      /// <summary>
      /// 买投机交易保证金率
      /// <summary>
      [TuShareProperty("long_margin_rate")]
      public float LongMarginRate { get; set; }
      /// <summary>
      /// 卖投机交易保证金率
      /// <summary>
      [TuShareProperty("short_margin_rate")]
      public float ShortMarginRate { get; set; }
      /// <summary>
      /// 平今仓手续率
      /// <summary>
      [TuShareProperty("offset_today_fee")]
      public float OffsetTodayFee { get; set; }
      /// <summary>
      /// 交易所
      /// <summary>
      [TuShareProperty("exchange")]
      public string Exchange { get; set; }
  }
}
