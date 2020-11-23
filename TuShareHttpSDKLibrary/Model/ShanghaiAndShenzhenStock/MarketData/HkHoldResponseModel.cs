using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketData
  {
  /// <summary>
  /// 接口：hk_hold<br/>描述：获取沪深港股通持股明细，数据来源港交所。<br/>限量：单次最多提取3800条记录，可循环调取，总量不限制<br/>积分：用户积120积分可调取试用，2000积分可正常使用，单位分钟有流控，积分越高流量越大，请自行提高积分，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  public class HkHoldResponseModel
  {
      /// <summary>
      /// 原始代码
      /// <summary>
      [TuShareProperty("code")]
      public string Code { get; set; }
      /// <summary>
      /// 交易日期
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// TS代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 股票名称
      /// <summary>
      [TuShareProperty("name")]
      public string Name { get; set; }
      /// <summary>
      /// 持股数量(股)
      /// <summary>
      [TuShareProperty("vol")]
      public int Vol { get; set; }
      /// <summary>
      /// 持股占比（%），占已发行股份百分比
      /// <summary>
      [TuShareProperty("ratio")]
      public float Ratio { get; set; }
      /// <summary>
      /// 类型：SH沪股通SZ深股通HK港股通
      /// <summary>
      [TuShareProperty("exchange")]
      public string Exchange { get; set; }
  }
}
