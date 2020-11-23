using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketReferenceData
  {
  /// <summary>
  /// 接口：pledge_stat<br/>描述：获取股票质押统计数据<br/>限量：单次最大1000<br/>积分：用户需要至少500积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  public class PledgeStatResponseModel
  {
      /// <summary>
      /// TS代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 截止日期
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
      /// <summary>
      /// 质押次数
      /// <summary>
      [TuShareProperty("pledge_count")]
      public int PledgeCount { get; set; }
      /// <summary>
      /// 无限售股质押数量（万）
      /// <summary>
      [TuShareProperty("unrest_pledge")]
      public float UnrestPledge { get; set; }
      /// <summary>
      /// 限售股份质押数量（万）
      /// <summary>
      [TuShareProperty("rest_pledge")]
      public float RestPledge { get; set; }
      /// <summary>
      /// 总股本
      /// <summary>
      [TuShareProperty("total_share")]
      public float TotalShare { get; set; }
      /// <summary>
      /// 质押比例
      /// <summary>
      [TuShareProperty("pledge_ratio")]
      public float PledgeRatio { get; set; }
  }
}
