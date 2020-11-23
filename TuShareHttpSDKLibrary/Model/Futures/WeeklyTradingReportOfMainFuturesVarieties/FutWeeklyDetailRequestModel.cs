using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.WeeklyTradingReportOfMainFuturesVarieties
  {
  /// <summary>
  /// 接口：fut_weekly_detail<br/>描述：获取期货交易所主要品种每周交易统计信息，数据从2010年3月开始<br/>权限：600积分可调取，单次最大获取4000行数据，积分越高频次越高，5000积分以上正常调取不受限制<br/>数据来源：中国证监会，本数据由Tushare社区成员CE完成规划和采集
  /// </summary>
  [TuShareApi("fut_weekly_detail")]
  public class FutWeeklyDetailRequestModel:IApiModel<FutWeeklyDetailResponseModel>
  {
      /// <summary>
      /// 周期（每年第几周，e.g. 202001 表示2020第1周）
      /// <summary>
      [TuShareProperty("week")]
      public string Week { get; set; }
      /// <summary>
      /// 期货品种（支持多品种输入，逗号分隔）
      /// <summary>
      [TuShareProperty("prd")]
      public string Prd { get; set; }
      /// <summary>
      /// 开始周期
      /// <summary>
      [TuShareProperty("start_week")]
      public string StartWeek { get; set; }
      /// <summary>
      /// 结束周期
      /// <summary>
      [TuShareProperty("end_week")]
      public string EndWeek { get; set; }
      /// <summary>
      /// 交易所（请参考交易所说明）
      /// <summary>
      [TuShareProperty("exchange")]
      public string Exchange { get; set; }
      /// <summary>
      /// 提取的字段，e.g. fields=&#39;prd,name,vol&#39;
      /// <summary>
      [TuShareProperty("fields")]
      public string Fields { get; set; }
  }
}
