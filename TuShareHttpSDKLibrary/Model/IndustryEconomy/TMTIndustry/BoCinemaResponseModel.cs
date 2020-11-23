using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.TMTIndustry
  {
  /// <summary>
  /// 接口：bo_cinema<br/>描述：获取每日各影院的票房数据<br/>数据历史： 数据从2018年9月开始，更多历史数据正在补充<br/>数据权限：用户需要至少500积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  public class BoCinemaResponseModel
  {
      /// <summary>
      /// 日期
      /// <summary>
      [TuShareProperty("date")]
      public string Date { get; set; }
      /// <summary>
      /// 影院名称
      /// <summary>
      [TuShareProperty("c_name")]
      public string CName { get; set; }
      /// <summary>
      /// 观众人数
      /// <summary>
      [TuShareProperty("aud_count")]
      public int AudCount { get; set; }
      /// <summary>
      /// 上座率
      /// <summary>
      [TuShareProperty("att_ratio")]
      public float AttRatio { get; set; }
      /// <summary>
      /// 当日票房
      /// <summary>
      [TuShareProperty("day_amount")]
      public float DayAmount { get; set; }
      /// <summary>
      /// 当日场次
      /// <summary>
      [TuShareProperty("day_showcount")]
      public float DayShowcount { get; set; }
      /// <summary>
      /// 场均票价（元）
      /// <summary>
      [TuShareProperty("avg_price")]
      public float AvgPrice { get; set; }
      /// <summary>
      /// 场均人次
      /// <summary>
      [TuShareProperty("p_pc")]
      public float PPc { get; set; }
      /// <summary>
      /// 排名
      /// <summary>
      [TuShareProperty("rank")]
      public int Rank { get; set; }
  }
}
