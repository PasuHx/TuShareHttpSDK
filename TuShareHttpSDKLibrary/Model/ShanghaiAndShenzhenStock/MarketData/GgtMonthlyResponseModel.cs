using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketData
  {
  /// <summary>
  /// 接口：ggt_monthly<br/>描述：港股通每月成交信息，数据从2014年开始<br/>限量：单次最大1000<br/>积分：用户积5000积分可调取，请自行提高积分，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  public class GgtMonthlyResponseModel
  {
      /// <summary>
      /// 交易日期
      /// <summary>
      [TuShareProperty("month")]
      public string Month { get; set; }
      /// <summary>
      /// 当月日均买入成交金额（亿元）
      /// <summary>
      [TuShareProperty("day_buy_amt")]
      public float DayBuyAmt { get; set; }
      /// <summary>
      /// 当月日均买入成交笔数（万笔）
      /// <summary>
      [TuShareProperty("day_buy_vol")]
      public float DayBuyVol { get; set; }
      /// <summary>
      /// 当月日均卖出成交金额（亿元）
      /// <summary>
      [TuShareProperty("day_sell_amt")]
      public float DaySellAmt { get; set; }
      /// <summary>
      /// 当月日均卖出成交笔数（万笔）
      /// <summary>
      [TuShareProperty("day_sell_vol")]
      public float DaySellVol { get; set; }
      /// <summary>
      /// 总买入成交金额（亿元）
      /// <summary>
      [TuShareProperty("total_buy_amt")]
      public float TotalBuyAmt { get; set; }
      /// <summary>
      /// 总买入成交笔数（万笔）
      /// <summary>
      [TuShareProperty("total_buy_vol")]
      public float TotalBuyVol { get; set; }
      /// <summary>
      /// 总卖出成交金额（亿元）
      /// <summary>
      [TuShareProperty("total_sell_amt")]
      public float TotalSellAmt { get; set; }
      /// <summary>
      /// 总卖出成交笔数（万笔）
      /// <summary>
      [TuShareProperty("total_sell_vol")]
      public float TotalSellVol { get; set; }
  }
}
