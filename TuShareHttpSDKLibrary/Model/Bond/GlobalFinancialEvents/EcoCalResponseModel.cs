using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.GlobalFinancialEvents
  {
  /// <summary>
  /// 接口：eco_cal<br/>描述：获取全球财经日历、包括经济事件数据更新<br/>限量：单次最大获取100行数据<br/>积分：2000积分可调取
  /// </summary>
  public class EcoCalResponseModel
  {
      /// <summary>
      /// 日期
      /// <summary>
      [TuShareProperty("date")]
      public string Date { get; set; }
      /// <summary>
      /// 时间
      /// <summary>
      [TuShareProperty("time")]
      public string Time { get; set; }
      /// <summary>
      /// 货币代码
      /// <summary>
      [TuShareProperty("currency")]
      public string Currency { get; set; }
      /// <summary>
      /// 国家
      /// <summary>
      [TuShareProperty("country")]
      public string Country { get; set; }
      /// <summary>
      /// 经济事件
      /// <summary>
      [TuShareProperty("event")]
      public string Event { get; set; }
      /// <summary>
      /// 今值
      /// <summary>
      [TuShareProperty("value")]
      public string Value { get; set; }
      /// <summary>
      /// 前值
      /// <summary>
      [TuShareProperty("pre_value")]
      public string PreValue { get; set; }
      /// <summary>
      /// 预测值
      /// <summary>
      [TuShareProperty("fore_value")]
      public string ForeValue { get; set; }
  }
}
