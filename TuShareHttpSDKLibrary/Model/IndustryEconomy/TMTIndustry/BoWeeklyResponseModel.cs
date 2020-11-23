using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.TMTIndustry
  {
  /// <summary>
  /// 接口：bo_weekly<br/>描述：获取周度票房数据<br/>数据更新：本周更新上一周数据<br/>数据历史： 数据从2008年第一周开始，超过10年历史数据。<br/>数据权限：用户需要至少500积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  public class BoWeeklyResponseModel
  {
      /// <summary>
      /// 日期
      /// <summary>
      [TuShareProperty("date")]
      public string Date { get; set; }
      /// <summary>
      /// 影片名称
      /// <summary>
      [TuShareProperty("name")]
      public string Name { get; set; }
      /// <summary>
      /// 平均票价
      /// <summary>
      [TuShareProperty("avg_price")]
      public float AvgPrice { get; set; }
      /// <summary>
      /// 当周票房（万）
      /// <summary>
      [TuShareProperty("week_amount")]
      public float WeekAmount { get; set; }
      /// <summary>
      /// 累计票房（万）
      /// <summary>
      [TuShareProperty("total")]
      public float Total { get; set; }
      /// <summary>
      /// 上映天数
      /// <summary>
      [TuShareProperty("list_day")]
      public int ListDay { get; set; }
      /// <summary>
      /// 场均人次
      /// <summary>
      [TuShareProperty("p_pc")]
      public int PPc { get; set; }
      /// <summary>
      /// 口碑指数
      /// <summary>
      [TuShareProperty("wom_index")]
      public float WomIndex { get; set; }
      /// <summary>
      /// 环比变化 （%）
      /// <summary>
      [TuShareProperty("up_ratio")]
      public float UpRatio { get; set; }
      /// <summary>
      /// 排名
      /// <summary>
      [TuShareProperty("rank")]
      public int Rank { get; set; }
  }
}
