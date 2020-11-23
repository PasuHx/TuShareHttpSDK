using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.TMTIndustry
  {
  /// <summary>
  /// 接口：bo_monthly<br/>描述：获取电影月度票房数据<br/>数据更新：本月更新上一月数据<br/>数据历史： 数据从2008年1月1日开始，超过10年历史数据。<br/>数据权限：用户需要至少500积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  public class BoMonthlyResponseModel
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
      /// 上映日期
      /// <summary>
      [TuShareProperty("list_date")]
      public string ListDate { get; set; }
      /// <summary>
      /// 平均票价
      /// <summary>
      [TuShareProperty("avg_price")]
      public float AvgPrice { get; set; }
      /// <summary>
      /// 当月票房（万）
      /// <summary>
      [TuShareProperty("month_amount")]
      public float MonthAmount { get; set; }
      /// <summary>
      /// 月内天数
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
      /// 月度占比（%）
      /// <summary>
      [TuShareProperty("m_ratio")]
      public float MRatio { get; set; }
      /// <summary>
      /// 排名
      /// <summary>
      [TuShareProperty("rank")]
      public int Rank { get; set; }
  }
}
