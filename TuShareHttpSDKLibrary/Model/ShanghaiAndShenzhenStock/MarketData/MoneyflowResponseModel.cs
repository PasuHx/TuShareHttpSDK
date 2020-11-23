using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketData
  {
  /// <summary>
  /// 接口：moneyflow<br/>描述：获取沪深A股票资金流向数据，分析大单小单成交情况，用于判别资金动向<br/>限量：单次最大提取4500行记录，总量不限制<br/>积分：用户需要至少2000积分才可以调取，基础积分有流量控制，积分越多权限越大，请自行提高积分，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  public class MoneyflowResponseModel
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
      /// 小单买入量（手）
      /// <summary>
      [TuShareProperty("buy_sm_vol")]
      public int BuySmVol { get; set; }
      /// <summary>
      /// 小单买入金额（万元）
      /// <summary>
      [TuShareProperty("buy_sm_amount")]
      public float BuySmAmount { get; set; }
      /// <summary>
      /// 小单卖出量（手）
      /// <summary>
      [TuShareProperty("sell_sm_vol")]
      public int SellSmVol { get; set; }
      /// <summary>
      /// 小单卖出金额（万元）
      /// <summary>
      [TuShareProperty("sell_sm_amount")]
      public float SellSmAmount { get; set; }
      /// <summary>
      /// 中单买入量（手）
      /// <summary>
      [TuShareProperty("buy_md_vol")]
      public int BuyMdVol { get; set; }
      /// <summary>
      /// 中单买入金额（万元）
      /// <summary>
      [TuShareProperty("buy_md_amount")]
      public float BuyMdAmount { get; set; }
      /// <summary>
      /// 中单卖出量（手）
      /// <summary>
      [TuShareProperty("sell_md_vol")]
      public int SellMdVol { get; set; }
      /// <summary>
      /// 中单卖出金额（万元）
      /// <summary>
      [TuShareProperty("sell_md_amount")]
      public float SellMdAmount { get; set; }
      /// <summary>
      /// 大单买入量（手）
      /// <summary>
      [TuShareProperty("buy_lg_vol")]
      public int BuyLgVol { get; set; }
      /// <summary>
      /// 大单买入金额（万元）
      /// <summary>
      [TuShareProperty("buy_lg_amount")]
      public float BuyLgAmount { get; set; }
      /// <summary>
      /// 大单卖出量（手）
      /// <summary>
      [TuShareProperty("sell_lg_vol")]
      public int SellLgVol { get; set; }
      /// <summary>
      /// 大单卖出金额（万元）
      /// <summary>
      [TuShareProperty("sell_lg_amount")]
      public float SellLgAmount { get; set; }
      /// <summary>
      /// 特大单买入量（手）
      /// <summary>
      [TuShareProperty("buy_elg_vol")]
      public int BuyElgVol { get; set; }
      /// <summary>
      /// 特大单买入金额（万元）
      /// <summary>
      [TuShareProperty("buy_elg_amount")]
      public float BuyElgAmount { get; set; }
      /// <summary>
      /// 特大单卖出量（手）
      /// <summary>
      [TuShareProperty("sell_elg_vol")]
      public int SellElgVol { get; set; }
      /// <summary>
      /// 特大单卖出金额（万元）
      /// <summary>
      [TuShareProperty("sell_elg_amount")]
      public float SellElgAmount { get; set; }
      /// <summary>
      /// 净流入量（手）
      /// <summary>
      [TuShareProperty("net_mf_vol")]
      public int NetMfVol { get; set; }
      /// <summary>
      /// 净流入额（万元）
      /// <summary>
      [TuShareProperty("net_mf_amount")]
      public float NetMfAmount { get; set; }
  }
}
