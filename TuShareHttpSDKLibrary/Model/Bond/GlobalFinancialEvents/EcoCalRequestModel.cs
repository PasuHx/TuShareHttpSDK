using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.GlobalFinancialEvents
  {
  /// <summary>
  /// 接口：eco_cal<br/>描述：获取全球财经日历、包括经济事件数据更新<br/>限量：单次最大获取100行数据<br/>积分：2000积分可调取
  /// </summary>
  [TuShareApi("eco_cal")]
  public class EcoCalRequestModel:IApiModel<EcoCalResponseModel>
  {
      /// <summary>
      /// 日期（YYYYMMDD格式）
      /// <summary>
      [TuShareProperty("date")]
      public string Date { get; set; }
      /// <summary>
      /// 开始日期
      /// <summary>
      [TuShareProperty("start_date")]
      public string StartDate { get; set; }
      /// <summary>
      /// 结束日期
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
      /// <summary>
      /// 货币代码
      /// <summary>
      [TuShareProperty("currency")]
      public string Currency { get; set; }
      /// <summary>
      /// 国家（比如：中国、美国）
      /// <summary>
      [TuShareProperty("country")]
      public string Country { get; set; }
      /// <summary>
      /// 事件 （支持模糊匹配： *非农*）
      /// <summary>
      [TuShareProperty("event")]
      public string Event { get; set; }
  }
}
