using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketData
  {
  /// <summary>
  /// 接口：moneyflow_hsgt<br/>描述：获取沪股通、深股通、港股通每日资金流向数据，每次最多返回300条记录，总量不限制。
  /// </summary>
  public class MoneyflowHsgtResponseModel
  {
      /// <summary>
      /// 交易日期
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// 港股通（上海）
      /// <summary>
      [TuShareProperty("ggt_ss")]
      public float GgtSs { get; set; }
      /// <summary>
      /// 港股通（深圳）
      /// <summary>
      [TuShareProperty("ggt_sz")]
      public float GgtSz { get; set; }
      /// <summary>
      /// 沪股通（百万元）
      /// <summary>
      [TuShareProperty("hgt")]
      public float Hgt { get; set; }
      /// <summary>
      /// 深股通（百万元）
      /// <summary>
      [TuShareProperty("sgt")]
      public float Sgt { get; set; }
      /// <summary>
      /// 北向资金（百万元）
      /// <summary>
      [TuShareProperty("north_money")]
      public float NorthMoney { get; set; }
      /// <summary>
      /// 南向资金（百万元）
      /// <summary>
      [TuShareProperty("south_money")]
      public float SouthMoney { get; set; }
  }
}
