using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.WeeklyTradingReportOfMainFuturesVarieties
  {
  /// <summary>
  /// 接口：fut_weekly_detail<br/>描述：获取期货交易所主要品种每周交易统计信息，数据从2010年3月开始<br/>权限：600积分可调取，单次最大获取4000行数据，积分越高频次越高，5000积分以上正常调取不受限制<br/>数据来源：中国证监会，本数据由Tushare社区成员CE完成规划和采集
  /// </summary>
  public class FutWeeklyDetailResponseModel
  {
      /// <summary>
      /// 交易所代码
      /// <summary>
      [TuShareProperty("exchange")]
      public string Exchange { get; set; }
      /// <summary>
      /// 期货品种代码
      /// <summary>
      [TuShareProperty("prd")]
      public string Prd { get; set; }
      /// <summary>
      /// 品种名称
      /// <summary>
      [TuShareProperty("name")]
      public string Name { get; set; }
      /// <summary>
      /// 成交量（手）
      /// <summary>
      [TuShareProperty("vol")]
      public int Vol { get; set; }
      /// <summary>
      /// 同比增减（%）
      /// <summary>
      [TuShareProperty("vol_yoy")]
      public float VolYoy { get; set; }
      /// <summary>
      /// 成交金额（亿元）
      /// <summary>
      [TuShareProperty("amount")]
      public float Amount { get; set; }
      /// <summary>
      /// 同比增减（%）
      /// <summary>
      [TuShareProperty("amout_yoy")]
      public float AmoutYoy { get; set; }
      /// <summary>
      /// 年累计成交总量（手）
      /// <summary>
      [TuShareProperty("cumvol")]
      public int Cumvol { get; set; }
      /// <summary>
      /// 同比增减（%）
      /// <summary>
      [TuShareProperty("cumvol_yoy")]
      public float CumvolYoy { get; set; }
      /// <summary>
      /// 年累计成交金额（亿元）
      /// <summary>
      [TuShareProperty("cumamt")]
      public float Cumamt { get; set; }
      /// <summary>
      /// 同比增减（%）
      /// <summary>
      [TuShareProperty("cumamt_yoy")]
      public float CumamtYoy { get; set; }
      /// <summary>
      /// 持仓量（手）
      /// <summary>
      [TuShareProperty("open_interest")]
      public int OpenInterest { get; set; }
      /// <summary>
      /// 环比增减（%）
      /// <summary>
      [TuShareProperty("interest_wow")]
      public float InterestWow { get; set; }
      /// <summary>
      /// 本周主力合约收盘价
      /// <summary>
      [TuShareProperty("mc_close")]
      public float McClose { get; set; }
      /// <summary>
      /// 环比涨跌（%）
      /// <summary>
      [TuShareProperty("close_wow")]
      public float CloseWow { get; set; }
      /// <summary>
      /// 周期
      /// <summary>
      [TuShareProperty("week")]
      public string Week { get; set; }
      /// <summary>
      /// 周日期
      /// <summary>
      [TuShareProperty("week_date")]
      public string WeekDate { get; set; }
  }
}
